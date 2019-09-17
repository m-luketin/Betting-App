import React, { Component } from 'react';
import './Tickets.css';

class Tickets extends Component {
	normalizeCurrency(currency) {
		return Math.round(currency * 100) / 100;
	}

	render() {
		return (
			<div className='tickets'>
				{this.props.tickets.map((ticket, key) => {
					return (
						<div key={key} className='tickets__ticket-view'>
							<div className='ticket-view__time'>
								<span className='time__title'>Issued at:</span>
								<span className='time__hours'>
									{ticket.issuedAt.substring(11, 16)}
								</span>
								<span className='time__date'>
									{ticket.issuedAt.substring(0, 10)}
								</span>
							</div>
							<div className='ticket-view__pairs-view'>
								{ticket.ticketPairs.map((ticketPair, key) => {
									return (
										<div key ={key} className='pairs-view__pair-view'>
											<div className='pair-view__teams'>
												{ticketPair.pair.match.teamMatches.map(
													(teamMatch, key) => {
														return <span key={key}>{teamMatch.team.name}</span>;
													}
												)}
											</div>
											<span className='pair-view__bet-type'>
												{ticketPair.pair.betType.type}
											</span>
											<span className='pair-view__quota'>
												{ticketPair.pair.quota}
											</span>
										</div>
									);
								})}
							</div>
							<div className='ticket__bet ticket__detail'>
								<span>Money bet:</span>
								<span>{ticket.moneyBet}</span>
							</div>
							<div className='ticket__quota ticket__detail'>
								<span>Full quota:</span>
								<span>{this.normalizeCurrency(ticket.totalQuota)}</span>
							</div>
							<div className='ticket__winnings ticket__detail'>
								<span>Winnings:</span>
								<span>
									{this.normalizeCurrency(
										ticket.moneyBet * ticket.totalQuota * 0.95
									)}
								</span>
							</div>
							<div className='ticket__status ticket__detail'>
								<span>Status:</span>
								<span>{ticket.status}</span>
							</div>
						</div>
					);
				})}
			</div>
		);
	}
}

export default Tickets;
