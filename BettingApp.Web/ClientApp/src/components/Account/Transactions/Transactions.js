import React from 'react';
import './Transactions.css';

const Transactions = (props) => {
	return (
		<div className='account__transactions'>
			<div className='transactions__titles'>
				<span className='titles__title titles__title--left'>Date</span>
				<span className='titles__title titles__title--centerleft'>Time</span>
				<span className='titles__title titles__title--centerright'>Balance</span>
				<span className='titles__title titles__title--right'>Type</span>
			</div>
			<div className='transactions'>
				{props.transactions.map((transaction, key) => {
					return (
						<div key={key} className='transaction'>
							<span className='transaction__date'>
								{transaction.time.substring(0, 10)}
							</span>
							<span className='transaction__time'>
								{transaction.time.substring(11, 16)}
							</span>
							<span className='transaction__balance'>
								{transaction.balanceChange}
							</span>
							<span className='transaction__type'>{transaction.transactionType}</span>
						</div>
					);
				})}
			</div>
		</div>
	);
};

export default Transactions;
