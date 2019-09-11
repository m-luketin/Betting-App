import React, { Component } from 'react';
import './PairList.css';

class PairList extends Component {
	constructor(props) {
		super(props);

		this.state = {};
	}

	getHeaderBetTypes() {
		if (this.props.pairs[0] !== undefined) {
			return this.props.pairs[0].pairs.map(pair => {
				return <span>{pair.betType.type}</span>;
			});
		}
	}

	render() {
		return (
			<div className='pair-list'>
				<div className='pair-list__header'>
					<span>Time</span>
					<span>Match</span>
					<div className='bet-types'>{this.getHeaderBetTypes()}</div>
				</div>
				{this.props.pairs.map(item => {
					return (
						<div className='pair-list__pair'>
							<div>{item.startsAt.substring(11, 16)}</div>
							<div className='pair__teams'>
								<span>{item.teamMatches[0].team.name}</span>
								<span>{item.teamMatches[1].team.name}</span>
							</div>
							<div className='pair__quotas'>
								{item.pairs.map(value => {
									return (
										<button
											betType={value.betTypeId}
											className='quotas__quota'
											onClick={() =>
												this.props.pairHandler(
													item.teamMatches[0].team.name,
													item.teamMatches[1].team.name,
													value.betTypeId,
													value.matchId,
													value.quota,
													value.id
												)
											}>
											{value.quota}
										</button>
									);
								})}
							</div>
						</div>
					);
				})}
			</div>
		);
	}
}

export default PairList;
