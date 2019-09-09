import React, { Component } from 'react';
import Axios from 'axios';
import './NewTicket.css';

class NewTicket extends Component {
	constructor(props) {
		super(props);

		this.state = {
			bet: 0
		};
	}

	convertBetType(betId) {
		switch (betId) {
			case 1:
				return '1';
			case 2:
				return '2';
			case 3:
				return '1X';
			case 4:
				return '2X';
			case 5:
				return 'X';
			case 6:
				return '12';
			default:
				break;
		}
	}

	setBet() {
		this.setState({ bet: document.getElementById('bet__input').value });
	}

	calculateTotalQuota() {
		let totalQuota = 1;
		this.props.selectedPairs.map(value => {
			totalQuota *= value.quota;
		});

		return totalQuota;
	}

	calculateTotal() {
		return Math.round(this.state.bet * this.calculateTotalQuota() * 95) / 100;
	}

	confirmTicket() {
		let pairIds = [];
		this.props.selectedPairs.map(pair => {
			pairIds.push(pair.id);
		});
		console.log(this.calculateTotalQuota());
		Axios.post('api/ticket/add', {
			moneyBet: this.state.bet,
			totalQuota: this.calculateTotalQuota(),
			pairIds: pairIds
		}).then(response => {
			console.log(response);
		});
	}

	render() {
		return (
			<div className='new-ticket'>
				<span className='new-ticket__title'>Your ticket</span>
				<div className='new-ticket__pairs'>
					{this.props.selectedPairs.map((value, key) => {
						return (
							<div className='pairs__pair'>
								<span className='pair__teams'>
									{value.homeTeam} - {value.awayTeam}
								</span>
								<span className='pair__bettype'>
									{this.convertBetType(value.betType)}
								</span>
								<span className='pair__quota'>{value.quota}</span>
							</div>
						);
					})}
				</div>
				<div className='new-ticket__bottom'>
					<div className='new-ticket__bet'>
						<span>Bet:</span>
						<input
							type='number'
							min='0.01'
							max='10000.00'
							step='0.01'
							placeholder='Enter bet'
							className='bet__input'
							id='bet__input'
							onChange={() => this.setBet()}
						/>
					</div>
					<div className='new-ticket__total'>
						<span>Winnings:</span>
						<span className='total__number'>{this.calculateTotal()}</span>
					</div>
					<span className='new-ticket__button' onClick={() => this.confirmTicket()}>
						Confirm
					</span>
				</div>
			</div>
		);
	}
}

export default NewTicket;
