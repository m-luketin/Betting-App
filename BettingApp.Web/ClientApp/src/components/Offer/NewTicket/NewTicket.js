import React, { Component } from 'react';
import './NewTicket.css';

class NewTicket extends Component {
	constructor(props) {
		super(props);

		this.state = {
			currentPairs: [],
			total: 0,
			bet: 0
		};
	}

	render() {
		return (
			<div className='new-ticket'>
				<span className='new-ticket__title'>Your ticket</span>
				<div className='new-ticket__pairs'>
					{this.state.currentPairs.map(value => {
						return <div className='pairs__pair'>{value}</div>;
					})}
				</div>
				<div className="new-ticket__bottom">
					<div className='new-ticket__bet'>
						<span>Bet:</span>
						<input type="number" min="0.01" max="10000.00" step="0.01"  placeholder="Enter bet" className="bet__input"/>
					</div>
					<div className='new-ticket__total'>
						<span>Winnings:</span>
						<span className="total__number">{this.state.total}</span>
					</div>
					<span className='new-ticket__button'>Confirm</span>
				</div>
			</div>
		);
	}
}

export default NewTicket;
