import React, { Component } from 'react';
import Navbar from '../Navbar/Navbar';
import PairList from '../Offer/PairList/PairList';

class Offer extends Component {
	constructor(props) {
		super(props);

		this.state = {};
	}

	render() {
		return (
			<div>
				<Navbar />
				<PairList />
			</div>
		);
	}
}

export default Offer;
