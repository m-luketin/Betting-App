import React, { Component } from 'react';
import Axios from 'axios';
import './PairList.css';

class PairList extends Component {
	constructor(props) {
		super(props);

		this.state = {
			pairs: []
		};
	}

	componentDidMount() {
		Axios.get(`api/match/date/${this.props.currentDate}`)
			.then(response => {
				console.log(...response.data);
				this.setState({ pairs: [...response.data] });
			})
			.catch(err => {
				console.log(err);
			});
	}

	render() {
		return (
			<div className='pair-list'>
				{this.state.pairs.map(item => {
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
