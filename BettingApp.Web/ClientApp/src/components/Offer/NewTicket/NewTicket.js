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
		if (this.state.bet > 0)
			return Math.round(this.state.bet * this.calculateTotalQuota() * 95) / 100;
		else return 0;
	}

	confirmTicket() {
		if (this.props.selectedPairs.length < 1) {
			this.setState({ warning: 'Please select a pair' });
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
			pairIds: pairIds
		});

		// resetting
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
							<div className='pair__wrapper'>
								<span
									className='pair__delete'
									onClick={() =>
										this.props.pairRemover(
											value.startsAt,
											value.homeTeam,
											value.awayTeam
										)
									}>
									X
								</span>
								<div className='pairs__pair'>
									<div className='ticket-pair__time'>
										<span>
											{value.startsAt.substring(5, 7)}/
											{value.startsAt.substring(8, 10)}
										</span>
										<span>{value.startsAt.substring(11, 16)}</span>
									</div>
									<div className='ticket-pair__teams'>
										<span>{value.homeTeam}</span>
										<span>{value.awayTeam}</span>
									</div>
									<div className='ticket-pair__details'>
										<div className='ticket-pair__bettype'>
											<span>Bet type:</span>
											<span>{value.betType}</span>
										</div>
										<div className='ticket-pair__quota'>
											<span>Quota:</span>
											<span>{value.quota}</span>
										</div>
										<div className='ticket-pair__sport'>
											<span>Sport:</span>
											<span>{value.sport}</span>
										</div>
									</div>
								</div>
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
					<span className="new-ticket__disclaimer">* Your bet is deducted 5% for manipulative expenditures</span>
			</div>
		);
	}
}

export default NewTicket;
