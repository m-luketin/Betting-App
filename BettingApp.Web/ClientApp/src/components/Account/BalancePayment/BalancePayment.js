import React, { Component } from 'react';
import Axios from 'axios';
import './BalancePayment.css';

class BalancePayment extends Component {
	constructor(props) {
		super(props);
		this.state = {
			currentFunds: 0,
			balanceToAdd: 0
		};
	}

	componentDidMount() {
		Axios.post('api/user/balance').then(response => {
			this.setState({ currentFunds: response.data });
			console.log(response.data);
		});
	}

	editUserBalance() {
		let balanceToAdd = parseInt(document.getElementById("payment__input").value, 10);
		console.log(balanceToAdd);
		Axios.post('api/user/edit-balance',{balanceToAdd: balanceToAdd}).then(response => {
			this.setState({currentFunds: response.data})
			console.log(response.data);
		});
	}

	render() {
		return (
			<div className="balance-payment">
				<div className="balance-payment__funds">
					<span>Current funds:</span>
					<span>{this.state.currentFunds}</span>
				</div>
				<div className="balance-payment__payment">
					<span>Enter funds:</span>
					<input
						type='number'
						min='0.01'
						max='10000.00'
						step='0.01'
						placeholder='0.00'
						className='payment__input'
						id='payment__input'
					/>
				</div>
				<div className="balance-payment__button">
					<button onClick={() => {this.editUserBalance()}}>Confirm</button>
				</div>
			</div>
		);
	}
}

export default BalancePayment;
