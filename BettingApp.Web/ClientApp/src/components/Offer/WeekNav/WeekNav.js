import React, {Component} from 'react';
import '../WeekNav/WeekNav.css';

class WeekNav extends Component {
	constructor(props) {
        super(props);

		this.state = {
			currentWeekDay: 0,
			selectedButton: 0
		};
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
		return (
			<div className="week-nav">
				<div className="week-nav__row">
					<button className="weekday-button">{this.getWeekday(0)}</button>
					<button className="weekday-button">{this.getWeekday(1)}</button>
					<button className="weekday-button">{this.getWeekday(2)}</button>
				</div>
				<div className="week-nav__row">
					<button className="weekday-button">{this.getWeekday(3)}</button>
					<button className="weekday-button">{this.getWeekday(4)}</button>
					<button className="weekday-button">{this.getWeekday(5)}</button>
				</div>
				<div className="week-nav__row">
					<button className="weekday-button">{this.getWeekday(6)}</button>
					<button className="weekday-button weekday-button--wide">THIS WEEK</button>
				</div>
			</div>
		);
	}
}

export default WeekNav;
