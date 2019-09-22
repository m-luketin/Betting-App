import React, { Component } from 'react';
import './PairList.css';

class PairList extends Component {
	constructor(props) {
		super(props);

		this.state = {};
	}

	render() {
		return (
			<div className='pair-list'>
				<div className='pair-list__header'>
					<span className='header__time'>Time</span>
					<span className='header__match'>Match</span>
					<div className='header__bet-types'>
						<span className='header__bet-type'>1</span>
						<span className='header__bet-type'>2</span>
						<span className='header__bet-type'>X</span>
						<span className='header__bet-type'>1X</span>
						<span className='header__bet-type'>2X</span>
						<span className='header__bet-type'>12</span>
					</div>
					<span className='header__sport'>Sport</span>
				</div>
				{this.props.pairs.map((item, firstKey) => {
					return (
						<div className='pair-list__pair'>
							<div className='pair__time'>
								<span>
									{item.startsAt.substring(5, 7)}/{item.startsAt.substring(8, 10)}
								</span>
								<span>{item.startsAt.substring(11, 16)}</span>
							</div>
							<div className='pair__teams'>
								<span>{item.homeTeam.name}</span>
								<span>{item.awayTeam.name}</span>
							</div>
							<div className='pair__quotas'>
								{item.betOffers.map((value, secondKey) => {
									return (
										<button
											className='quotas__quota'
											time={item.startsAt}
											hometeam={item.homeTeam.name}
											awayteam={item.awayTeam.name}
											bettype={value.betType.type}
											startsat={item.startsAt}
											onClick={() =>
												this.props.pairHandler(
													item.homeTeam.name,
													item.awayTeam.name,
													value.betType.type,
													value.matchId,
													value.quota,
													value.id,
													item.isTopOffer,
													item.startsAt,
													item.sport.name
												)
											}>
											{value.quota}
										</button>
									);
								})}
							</div>
							<span className='pair__sport'>{item.sport.name}</span>
						</div>
					);
				})}
			</div>
		);
	}
}

export default PairList;
