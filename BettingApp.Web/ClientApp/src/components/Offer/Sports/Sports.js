import React, { Component } from 'react';
import './Sports.css';

class Sports extends Component {
	constructor(props) {
		super(props);

		this.state = {
		};
	}

	setColor() {
		var sports = document.getElementsByClassName('links__link');

		for (var i = 0; i < sports.length; i++) {
			if (sports[i].innerHTML === this.props.currentSport) {
				sports[i].classList.add('links__link--selected');
			} else sports[i].classList.remove('links__link--selected');
		}
	}

	render() {
		this.setColor();
		return (
			<div className='sports'>
				<span className='sports__title'>Sports selection</span>
				<div className='sports__links'>
					<span
						className='links__link links__link--selected'
						onClick={() => this.props.sportHandler('Football')}>
						Football
					</span>
					<span
						className='links__link'
						onClick={() => this.props.sportHandler('Basketball')}>
						Basketball
					</span>
					<span
						className='links__link'
						onClick={() => this.props.sportHandler('Handball')}>
						Handball
					</span>
					<span
						className='links__link'
						onClick={() => this.props.sportHandler('Baseball')}>
						Baseball
					</span>
					<span
						className='links__link'
						onClick={() => this.props.sportHandler('UFC')}>
						UFC
					</span>
					<span
						className='links__link'
						onClick={() => this.props.sportHandler('Cricket')}>
						Cricket
					</span>
					<span
						className='links__link'
						onClick={() => this.props.sportHandler('All')}>
						All
					</span>
				</div>
			</div>
		);
	}
}

export default Sports;
