import React, { Component } from 'react';
import Axios from 'axios';
import Navbar from '../Navbar/Navbar';
import PairList from './PairList/PairList';
import WeekNav from './WeekNav/WeekNav.js';
import NewTicket from './NewTicket/NewTicket';
import Sports from './Sports/Sports';
import './Offer.css';
import { SSL_OP_SSLEAY_080_CLIENT_DH_BUG } from 'constants';

class Offer extends Component {
	constructor(props) {
		super(props);

		this.state = {
			currentSport: 'Football',
			currentDay: 0,
			currentDate: this.getCurrentDate(0),
			pairs: [],
			selectedPairs: [],
			balance: 0
		};
	}

	getCurrentDate(daysToAdd) {
		let today = new Date();

		let year = today.getFullYear();
		let month = today.getMonth() + 1;
		let day = today.getDate() + daysToAdd;

		if (month in [1, 3, 5, 7, 8, 10, 12] && day > 31) {
			month += 1;
			day = day % 31;
		} else if (month in [2, 4, 6, 9, 11] && day > 30) {
			month += 1;
			day = day % 30;
		}

		if (month > 12) {
			month = 1;
			year += 1;
		}

		if (day < 10) day = '0' + day;
		if (month < 10) month = '0' + month;

		return year + '-' + month + '-' + day;
	}

	getNewPairs(sport, date) {
		if (date === 'top') {
			Axios.get(`api/match/top-offer/${sport}`).then(response => {
				this.setState({ pairs: [...response.data], currentDay: 8 }, () =>
					this.handlePairChoiceColor()
				);
			});
		} else {
			Axios.get(`api/match/${sport}/${date}`).then(response => {
				this.setState({ pairs: [...response.data] }, () => this.handlePairChoiceColor());
			});
		}
	}

	handleCurrentSport = newSport => {
		if (this.state.currentDay === 7) {
			this.setState({ currentSport: newSport }, () => this.getNewPairs(newSport, 'all'));
		} else if (this.state.currentDay === 8) {
			this.setState({ currentSport: newSport }, () => this.getNewPairs(newSport, 'top'));
		} else {
			this.setState({ currentSport: newSport }, () =>
				this.getNewPairs(newSport, this.getCurrentDate(this.state.currentDay))
			);
		}
	};

	handleCurrentDay = newDay => {
		if (newDay === 8) {
			Axios.get(`api/match/top-offer/${this.state.currentSport}`).then(response => {
				this.setState({ pairs: [...response.data], currentDay: newDay });
			});
		} else if (newDay === 7) {
			this.setState({ currentDay: newDay, currentDate: this.getCurrentDate(newDay) }, () =>
				this.getNewPairs(this.state.currentSport, 'all')
			);
		} else {
			this.setState({ currentDay: newDay, currentDate: this.getCurrentDate(newDay) }, () =>
				this.getNewPairs(this.state.currentSport, this.getCurrentDate(newDay))
			);
		}
	};

	addPair = (homeTeam, awayTeam, betType, matchId, quota, id, isTopOffer, startsAt, sport) => {
		let objectToAdd = {
			homeTeam: homeTeam,
			awayTeam: awayTeam,
			betType: betType,
			matchId: matchId,
			quota: quota,
			id: id,
			isTopOffer: isTopOffer,
			startsAt: startsAt,
			sport: sport
		};

		let identicalIndex = -1;
		let topOfferIndex = -1;

		for (var i = 0; i < this.state.selectedPairs.length; i++) {
			if (
				this.state.selectedPairs[i].homeTeam === homeTeam &&
				this.state.selectedPairs[i].awayTeam === awayTeam &&
				this.state.selectedPairs[i].startsAt === startsAt
			) {
				identicalIndex = i;
			}

			if (this.state.selectedPairs[i].isTopOffer) {
				topOfferIndex = i;
			}
		}
		if (
			(isTopOffer && topOfferIndex === -1 && this.state.selectedPairs.length >= 6) ||
			(isTopOffer && topOfferIndex !== -1 && this.state.selectedPairs.length >= 7)
		) {
			this.state.selectedPairs.forEach(item => {
				if (item.quota <= 1.1) {
					alert(
						'A top offer can only be added when there are 6 pairs with quotas over 1.1 on the ticket!'
					);
					return;
				}
			});
		} else if (isTopOffer) {
			alert(
				'A top offer can only be added when there are 6 pairs with quotas over 1.1 on the ticket!'
			);
			return;
		}

		let newState = this.state.selectedPairs;
		if (identicalIndex > -1 && !(topOfferIndex > -1)) {
			newState.splice(identicalIndex, 1, objectToAdd);
			this.setState({
				selectedPairs: newState
			});
		} else if (topOfferIndex > -1 && !(identicalIndex > -1)) {
			newState.splice(topOfferIndex, 1, objectToAdd);
			this.setState({
				selectedPairs: newState
			});
		} else if (identicalIndex > -1 && topOfferIndex > -1) {
			newState.splice(topOfferIndex, 1, objectToAdd);
			this.setState({
				selectedPairs: newState
			});
		} else {
			this.setState({
				selectedPairs: [objectToAdd, ...this.state.selectedPairs]
			});
		}
		this.handlePairChoiceColor(objectToAdd, 'add');
	};

	removePairs(startsAt, homeTeam, awayTeam) {
		if (startsAt === undefined && homeTeam === undefined && awayTeam === undefined) {
			this.setState({ selectedPairs: [] });
		} else {
			var pairs = this.state.selectedPairs;
			for (let i = 0; i < pairs.length; i++)
				if (
					pairs[i].startsAt === startsAt &&
					pairs[i].homeTeam === homeTeam &&
					pairs[i].awayTeam === awayTeam
				) {
					this.handlePairChoiceColor(i, 'remove');
					pairs.splice(i, 1);
				}

			this.setState({ selectedPairs: [...pairs] });
		}
	}

	handlePairChoiceColor(pair, action) {
		var betTypeButtons = document.getElementsByClassName('quotas__quota');
		var pairs = [];

		if (action === 'add') {
			pairs = [...this.state.selectedPairs, pair];
		} else {
			pairs = this.state.selectedPairs;
			for (let j = 0; j < betTypeButtons.length; j++)
				betTypeButtons[j].classList.remove('quotas__quota--selected');
		}

		for (let i = 0; i < pairs.length; i++) {
			for (let j = 0; j < betTypeButtons.length; j++) {
				var buttonHomeTeam = betTypeButtons[j].attributes.hometeam.value;
				var buttonAwayTeam = betTypeButtons[j].attributes.awayteam.value;
				var buttonBetType = betTypeButtons[j].attributes.bettype.value;
				var buttonStartsAt = betTypeButtons[j].attributes.startsat.value;

				if (
					buttonHomeTeam === pairs[i].homeTeam &&
					buttonAwayTeam === pairs[i].awayTeam &&
					buttonStartsAt === pairs[i].startsAt
				) {
					if (action === 'remove' && pair === i) {
						betTypeButtons[j].classList.remove('quotas__quota--selected');
					} else if (buttonBetType === pairs[i].betType)
						betTypeButtons[j].classList.add('quotas__quota--selected');
					else betTypeButtons[j].classList.remove('quotas__quota--selected');
				}
			}
		}
	}

	handleTopOffers() {
		Axios.get(`api/match/top-offer/${this.state.currentSport}`).then(response => {
			this.setState({ pairs: [...response.data], currentDay: 7 });
		});
	}

	componentDidMount() {
		this.getNewPairs(this.state.currentSport, this.state.currentDate);

		Axios.get('api/user/balance/1').then(response => {
			this.setState({ balance: response.data });
		});
	}

	render() {
		return (
			<div className='offer'>
				<Navbar />
				<main>
					<div className='left-column'>
						<WeekNav
							currentDate={this.state.currentDate}
							currentDay={this.state.currentDay}
							dayHandler={newDay => this.handleCurrentDay(newDay)}
							topOfferHandler={() => this.handleTopOffers()}
						/>
						<Sports
							currentSport={this.state.currentSport}
							sportHandler={newSport => this.handleCurrentSport(newSport)}
						/>
					</div>
					<PairList
						pairs={this.state.pairs}
						pairHandler={(
							homeTeam,
							awayTeam,
							betType,
							matchId,
							quota,
							id,
							isTopOffer,
							startsAt,
							sport
						) =>
							this.addPair(
								homeTeam,
								awayTeam,
								betType,
								matchId,
								quota,
								id,
								isTopOffer,
								startsAt,
								sport
							)
						}
					/>
					<div className='right-column'>
						<NewTicket
							selectedPairs={this.state.selectedPairs}
							totalQuota={this.state.totalQuota}
							balance={this.state.balance}
							pairRemover={(time, homeTeam, awayTeam) =>
								this.removePairs(time, homeTeam, awayTeam)
							}
						/>
					</div>
				</main>
			</div>
		);
	}
}

export default Offer;
