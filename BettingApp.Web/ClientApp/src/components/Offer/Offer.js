import React, { Component } from 'react';
import Navbar from '../Navbar/Navbar';
import PairList from './PairList/PairList';
import WeekNav from './WeekNav/WeekNav.js';
import NewTicket from './NewTicket/NewTicket';
import Sports from './Sports/Sports';
import './Offer.css';

class Offer extends Component {
	constructor(props) {
		super(props);

		this.state = {};
	}

	getCurrentDate() {
		let today = new Date();
		let day = today.getDate();
		let month = today.getMonth() + 1;
		let year = today.getFullYear();

		if (day < 10) day = '0' + day;
		if (month < 10) month = '0' + month;

		return year + '-' + month + '-' + day;
	}

	render() {
		return (
			<div>
				<Navbar />
				<main>
					<div className="left-column">
						<WeekNav currentDate={this.getCurrentDate()} />
						<Sports />
					</div>
					
						<PairList currentDate={this.getCurrentDate()} />
					<div className="right-column">
					<NewTicket />
						</div>
				</main>
			</div>
		);
	}
}

export default Offer;
