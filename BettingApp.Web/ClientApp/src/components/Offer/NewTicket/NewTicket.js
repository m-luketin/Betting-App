import React, { Component } from 'react';
import Axios from 'axios';
import './NewTicket.css';

class NewTicket extends Component {
	constructor(props) {
		super(props);

		this.state = {
			bet: 0,
			warning: ''
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
		if (this.props.selectedPairs.length < 3) {
			this.setState({ warning: 'Minimum number of pairs is 3' });
			return;
		} else if (!this.state.bet) {
			this.setState({ warning: 'Please select bet money' });
			return;
		} else if (this.state.bet > 1000) {
			this.setState({ warning: 'Max bet amount is 1000' });
			return;
		} else if (this.state.bet < 0.01) {
			this.setState({ warning: 'Invalid amount' });
			return;
		} else if (this.state.bet > this.props.balance) {
			this.setState({ warning: `Insufficient funds(${this.props.balance})` });
			return;
		} else {
			this.setState({ warning: '' });
		}

		let pairIds = [];
		this.props.selectedPairs.map(pair => {
			pairIds.push(pair.id);
		});
		Axios.post('api/ticket/add', {
			moneyBet: this.state.bet,
			totalQuota: this.calculateTotalQuota(),
			pairIds: pairIds
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
								<span className='ticket-pair__teams'>
									<span>{value.homeTeam}</span>
									<span>{value.awayTeam}</span>
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
					<div className='new-ticket__warning' id='new-ticket__warning'>
						{this.state.warning}
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
