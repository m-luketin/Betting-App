import React, { Component } from 'react';
import Axios from 'axios';
import './BalancePayment.css';

class BalancePayment extends Component {
	constructor(props) {
		super(props);
		this.state = {
			currentFunds: 0,
			balanceToAdd: 0,
			warning: ''
		};
	}

	setPayment() {
		this.setState({ balanceToAdd: document.getElementById('payment__input').value });
	}

	displayConfirm() {
		document.getElementById('balance-payment__button').classList.remove('display-none');
		document.getElementById('balance-payment__popup').classList.add('display-none');
		this.setState({ warning: '' });
	}

	displayYesNo() {
		document.getElementById('balance-payment__button').classList.add('display-none');
		document.getElementById('balance-payment__popup').classList.remove('display-none');
	}

	editUserBalance() {
		if (!this.state.balanceToAdd) {
			this.setState({ warning: 'Please select money to add' });
			return;
		} else if (this.state.balanceToAdd < 0.01) {
			this.setState({ warning: 'Invalid amount' });
			return;
		} else if (this.state.balanceToAdd > 10000) {
			this.setState({ warning: 'Max payment is 10,000' });
			return;
		} else {
			this.setState({ warning: 'Are you sure?' });
		}

		this.displayYesNo();
	}

	confirmUserBalance() {
		Axios.post('api/user/edit-balance', { balanceToAdd: this.state.balanceToAdd })
			.then(response => {
				this.setState({ currentFunds: response.data });
			})
			.then(() => {
				this.props.transactionHandler();
			});

		document.getElementById('payment__input').value = '';
		this.setState({ warning: '', balanceToAdd: 0 });
		this.displayConfirm();
	}

	componentDidMount() {
		Axios.get('api/user/balance/1').then(response => {
			this.setState({ currentFunds: response.data });
		});
	}

	render() {
		return (
			<div className='balance-payment'>
				<div className='balance-payment__funds'>
					<span>Current funds:</span>
					<span>{this.state.currentFunds}</span>
				</div>
				<div className='balance-payment__payment'>
					<span>Enter funds:</span>
					<input
						type='number'
						min='0.01'
						max='10000.00'
						step='0.01'
						placeholder='0.00'
						className='payment__input'
						id='payment__input'
						onChange={() => this.setPayment()}
					/>
				</div>
				<div className='balance-payment__warning'>
					<span className='warning__message'>{this.state.warning}</span>
				</div>
				<div className='balance-payment__button'>
					<button
						id='balance-payment__button'
						onClick={() => {
							this.editUserBalance();
						}}>
						Confirm
					</button>
				</div>
				<div className='balance-payment__popup display-none' id='balance-payment__popup'>
					<span
						className='balance-payment__yes'
						onClick={() => this.confirmUserBalance()}>
						Yes
					</span>
					<span className='balance-payment__no' onClick={() => this.displayConfirm()}>
						No
					</span>
				</div>
			</div>
		);
	}
}

export default BalancePayment;
