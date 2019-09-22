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
		if (daysToAdd === 7) return 'ALL';
		else if (daysToAdd === 8) return 'TOP';

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
				{[0, 1, 2].map(firstIndex => {
					return (
						<div className='week-nav__row'>
							{[0, 1, 2].map(secondIndex => {
								return (
									<button
										className='weekday-button'
										onClick={() =>
											this.props.dayHandler((firstIndex * 3) + secondIndex)
										}>
										{this.getWeekday((firstIndex * 3) + secondIndex)}
									</button>
								);
							})}
						</div>
					);
				})}
			</div>
		);
	}
}

export default WeekNav;
