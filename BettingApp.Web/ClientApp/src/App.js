import React, { Component } from 'react';
import { Route, Switch } from 'react-router';
import Offer from './components/Offer/Offer';
import Account from './components/Account/Account';

export default class App extends Component {
	static displayName = App.name;

	render() {
		return (
				<Switch>
					<Route exact path='/' component={Offer} />
					<Route exact path='/offer' component={Offer} />
					<Route exact path='/account' component={Account} />
				</Switch>
		);
	}
}
