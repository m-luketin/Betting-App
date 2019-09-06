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
			pairs: []
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
		Axios.get(`api/match/${sport}/${date}`)
			.then(response => {
				this.setState({ pairs: [...response.data] });
				console.log(this.state);
			})
			.catch(err => {
				console.log(err);
			});
	}

	handleCurrentSport = newSport => {
		this.setState({ currentSport: newSport });
		this.getNewPairs();
	};

	handleCurrentDay = newDay => {
		this.setState(
			{ currentDay: newDay, currentDate: this.getCurrentDate(newDay) },
			this.getNewPairs(this.state.currentSport, this.getCurrentDate(newDay))
		);
	};

	componentDidMount() {
		this.getNewPairs(this.state.currentSport, this.state.currentDate);
	}

	render() {
		return (
			<div>
				<Navbar />
				<main>
					<div className='left-column'>
						<WeekNav
							currentDate={this.state.currentDate}
							currentDay={this.state.currentDay}
							dayHandler={newDay => this.handleCurrentDay(newDay)}
						/>
						<Sports
							currentSport={this.state.currentSport}
							sportHandler={newSport => this.handleCurrentSport(newSport)}
						/>
					</div>
					<PairList pairs={this.state.pairs} />
					<div className='right-column'>
						<NewTicket />
					</div>
				</main>
			</div>
		);
	}
}

export default Offer;
