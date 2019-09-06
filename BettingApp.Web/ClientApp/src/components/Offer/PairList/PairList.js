import React, { Component } from 'react';
import './PairList.css';

class PairList extends Component {
	constructor(props) {
		super(props);

		this.state = {
		};
	}
	
	render() {
		return (
			<div className='pair-list'>
				{this.props.pairs.map(item => {
					return (
						<div className='pair-list__pair'>
							<div>{item.startsAt.substring(11, 16)}</div>
							<div>
								{item.teamMatches[0].team.name} - {item.teamMatches[1].team.name}
							</div>
							<div className='pair__quotas'>
								{item.pairs.map(value => {
									return <button className='quotas__quota'>{value.quota}</button>;
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
