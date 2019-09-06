import React, { Component } from 'react';
import '../WeekNav/WeekNav.css';

class WeekNav extends Component {
	constructor(props) {
		super(props);

		this.state = {};
	}

	setColor() {
		var days = document.getElementsByClassName('weekday-button');

		for (var i = 0; i < days.length; i++) {
			if (i === this.props.currentDay) {
				days[i].classList.add('weekday-button--selected');
			} else days[i].classList.remove('weekday-button--selected');
		}
	}

	getWeekday(daysToAdd) {
		let today = new Date();
		let day = (today.getDay() + daysToAdd) % 7;

		switch (day) {
			case 0:
				return 'SUN';
			case 1:
				return 'MON';
			case 2:
				return 'TUE';
			case 3:
				return 'WED';
			case 4:
				return 'THU';
			case 5:
				return 'FRI';
			case 6:
				return 'SAT';
			default:
				return '';
		}
	}

	render() {
		this.setColor();
		return (
			<div className='week-nav'>
				<div className='week-nav__row'>
					<button
						className='weekday-button'
						onClick={() => this.props.dayHandler(0)}>
						{this.getWeekday(0)}
					</button>
					<button className='weekday-button' onClick={() => this.props.dayHandler(1)}>
						{this.getWeekday(1)}
					</button>
					<button className='weekday-button' onClick={() => this.props.dayHandler(2)}>
						{this.getWeekday(2)}
					</button>
				</div>
				<div className='week-nav__row'>
					<button className='weekday-button' onClick={() => this.props.dayHandler(3)}>
						{this.getWeekday(3)}
					</button>
					<button className='weekday-button' onClick={() => this.props.dayHandler(4)}>
						{this.getWeekday(4)}
					</button>
					<button className='weekday-button' onClick={() => this.props.dayHandler(5)}>
						{this.getWeekday(5)}
					</button>
				</div>
				<div className='week-nav__row'>
					<button className='weekday-button' onClick={() => this.props.dayHandler(6)}>
						{this.getWeekday(6)}
					</button>
					<button
						className='weekday-button weekday-button--wide'
						onClick={() => this.props.dayHandler(7)}>
						THIS WEEK
					</button>
				</div>
			</div>
		);
	}
}

export default WeekNav;
