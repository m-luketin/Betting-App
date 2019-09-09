import React, { Component } from 'react';
import './Transactions.css';

class Transactions extends Component {
	constructor(props) {
		super(props);
	}

	render() {
		return (
			<div className='account__transactions'>
				<div className='transactions__titles'>
					<span className='titles__title '>Date</span>
					<span className='titles__title titles__title--centerleft'>Time</span>
					<span className='titles__title titles__title--centerright'>Balance</span>
					<span className='titles__title'>Type</span>
				</div>
				<div className='transactions'>
					{this.props.transactions.map(transaction => {
						return (
							<div className='transaction'>
								<span className='transaction__date'>
									{transaction.time.substring(0, 10)}
								</span>
								<span className='transaction__time'>
									{transaction.time.substring(11, 16)}
								</span>
								<span className='transaction__balance'>
									{transaction.balanceChange}
								</span>
								<span className='transaction__type'>
									{transaction.transactionType}
								</span>
							</div>
						);
					})}
				</div>
			</div>
		);
	}
}

export default Transactions;
