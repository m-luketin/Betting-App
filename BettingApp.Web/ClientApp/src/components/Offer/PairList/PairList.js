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

	getCurrentDate() {
		let today = new Date();
		let day = today.getDate();
		let month = today.getMonth() + 1;
		let year = today.getFullYear();

		if (day < 10) day = '0' + day;
		if (month < 10) month = '0' + month;

		return year + '-' + month + '-' + day;
	}

	componentDidMount() {
		Axios.get(`api/match/date/${this.getCurrentDate()}`)
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
			<div className="pair-list">
				{this.state.pairs.map(item => {
					return (
						<div className="pair-list__pair">
							<div>
								{item.teamMatches[0].team.name} - {item.teamMatches[1].team.name}
							</div>
							<div>{item.startsAt.substring(11,16)}</div>
							<div className="pair__quotas">
								{item.pairs.map(value => {
									return <button className="quotas__quota">{value.quota}</button>;
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
