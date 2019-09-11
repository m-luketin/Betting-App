import React, { Component } from 'react';
import Axios from 'axios';
import Navbar from '../Navbar/Navbar';
import Transactions from './Transactions/Transactions';
import Tickets from './Tickets/Tickets';
import BalancePayment from './BalancePayment/BalancePayment';
import './Account.css';

class Account extends Component {
	constructor(props) {
		super(props);
		this.state = {
			transactions: [],
			tickets: []
		};
	}

	componentDidMount() {
		Axios.post('api/transaction/get/1').then(response => {
			this.setState({ transactions: response.data });
			console.log(response.data);
		});
		Axios.get('api/ticket/get/1').then(response => {
			this.setState({ tickets: response.data });
		});
	}

	render() {
		return (
			<div className='account'>
				<Navbar />
				<main>
					<div className='account__column--left'>
						<Transactions transactions={this.state.transactions} />
					</div>
					<div className='account__tickets'>
						<Tickets tickets={this.state.tickets} />
					</div>
					<div className='account__column--right'>
						<BalancePayment />
					</div>
				</main>
			</div>
		);
	}
}

export default Account;
