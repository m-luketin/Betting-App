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
		this.props.selectedPairs.forEach(value => {
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
			this.setState({ warning: 'Are you sure?' });
		}

		this.displayYesNo();
	}

	confirmPopup() {
		let pairIds = [];
		this.props.selectedPairs.forEach(pair => {
			pairIds.push(pair.id);
		});
		
		Axios.post('api/ticket/add', {
			moneyBet: this.state.bet,
			totalQuota: this.calculateTotalQuota(),
			pairIds: pairIds
		});

		// resetting
		this.props.pairRemover();
		this.displayConfirm();
		this.setState({ bet: 0 });
		document.getElementById('bet__input').value = '';
		this.setState({ warning: '' });
	}

	displayConfirm() {
		document.getElementById('new-ticket__button').classList.remove('display-none');
		document.getElementById('new-ticket__popup').classList.add('display-none');
		this.setState({ warning: '' });
	}

	displayYesNo() {
		document.getElementById('new-ticket__button').classList.add('display-none');
		document.getElementById('new-ticket__popup').classList.remove('display-none');
	}

	render() {
		return (
			<div className='new-ticket'>
				<span className='new-ticket__title'>Your ticket</span>
				<div className='new-ticket__pairs'>
					{this.props.selectedPairs.map((value, key) => {
						return (
							<div className='pairs__pair'>
								<div className='ticket-pair__time'>
									<span>{value.dateTime.substring(5, 10)}</span>
									<span>{value.dateTime.substring(11, 16)}</span>
								</div>
								<div className='ticket-pair__teams'>
									<span>{value.homeTeam}</span>
									<span>{value.awayTeam}</span>
								</div>
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
					<span
						className='new-ticket__button'
						id='new-ticket__button'
						onClick={() => this.confirmTicket()}>
						Confirm
					</span>
					<div className='new-ticket__popup  display-none' id='new-ticket__popup'>
						<span className='new-ticket__yes' onClick={() => this.confirmPopup()}>
							Yes
						</span>
						<span className='new-ticket__no' onClick={() => this.displayConfirm()}>
							No
						</span>
					</div>
				</div>
			</div>
		);
	}
}

export default NewTicket;
