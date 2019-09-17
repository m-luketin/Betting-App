import React, { Component } from 'react';
import Axios from 'axios';
import Navbar from '../Navbar/Navbar';
import PairList from './PairList/PairList';
import WeekNav from './WeekNav/WeekNav.js';
import NewTicket from './NewTicket/NewTicket';
import Sports from './Sports/Sports';
import './Offer.css';

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
		if (date === null) {
			Axios.get(`api/match/top-offer/${sport}`).then(response => {
				this.setState({ pairs: [...response.data], currentDay: 7 });
			});
		} else {
			Axios.get(`api/match/${sport}/${date}`).then(response => {
				this.setState({ pairs: [...response.data] });
			});
		}
	}

	handleCurrentSport = newSport => {
		if (this.state.currentDay === 7) {
			this.setState({ currentSport: newSport }, this.getNewPairs(newSport, null));
		} else {
			this.setState(
				{ currentSport: newSport },
				this.getNewPairs(newSport, this.getCurrentDate(this.state.currentDay))
			);
		}
	};

	handleCurrentDay = newDay => {
		this.setState(
			{ currentDay: newDay, currentDate: this.getCurrentDate(newDay) },
			this.getNewPairs(this.state.currentSport, this.getCurrentDate(newDay))
		);
	};

	addPair = (homeTeam, awayTeam, betType, matchId, quota, id, isTopOffer, dateTime) => {
		let objectToAdd = {
			homeTeam: homeTeam,
			awayTeam: awayTeam,
			betType: betType,
			matchId: matchId,
			quota: quota,
			id: id,
			isTopOffer: isTopOffer,
			dateTime: dateTime
		};
		
		console.log(this.state);

		let identicalIndex = -1;
		let topOfferIndex = -1;
		console.log(identicalIndex, topOfferIndex);

		for (var i = 0; i < this.state.selectedPairs.length; i++) {
			if (
				this.state.selectedPairs[i].homeTeam === homeTeam &&
				this.state.selectedPairs[i].awayTeam === awayTeam &&
				this.state.selectedPairs[i].dateTime === dateTime
			) {
				identicalIndex = i;
			}

			if (this.state.selectedPairs[i].isTopOffer) {
				topOfferIndex = i;
			}
		}

		let newState = this.state.selectedPairs;
		if (identicalIndex > -1 && !(topOfferIndex > -1)) {
			newState.splice(identicalIndex, 1, objectToAdd);
			this.setState({
				selectedPairs: newState
			});
		}
		else if (topOfferIndex > -1 && !(identicalIndex > -1)) {
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
	};

	removePairs() {
		this.setState({ selectedPairs: [] });
	}

	handleTopOffers() {
		Axios.get(`api/match/top-offer/${this.state.currentSport}`).then(response => {
			this.setState({ pairs: [...response.data], currentDay: 7 });
		});
	}

	componentDidMount() {
		this.getNewPairs(this.state.currentSport, this.state.currentDate);

		Axios.get('api/user/balance/1').then(response => {
			this.setState({ balance: response.data});
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
							dateTime
						) =>
							this.addPair(
								homeTeam,
								awayTeam,
								betType,
								matchId,
								quota,
								id,
								isTopOffer,
								dateTime
							)
						}
					/>
					<div className='right-column'>
						<NewTicket
							selectedPairs={this.state.selectedPairs}
							totalQuota={this.state.totalQuota}
							balance={this.state.balance}
							pairRemover={() => this.removePairs()}
						/>
					</div>
				</main>
			</div>
		);
	}
}

export default Offer;
