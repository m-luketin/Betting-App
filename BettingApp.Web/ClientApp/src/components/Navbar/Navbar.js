import React from 'react';
import { Link } from 'react-router-dom';
import './Navbar.css';

const Navbar = () => {
	return (
		<div className='navbar'>
			<Link to='/offer' className='navbar__element'>
				Offer
			</Link>
			<Link to='/tickets' className='navbar__element'>
				Tickets
			</Link>
			<Link to='/account' className='navbar__element navbar__element--right'>
				Account
			</Link>
		</div>
	);
};

export default Navbar;
