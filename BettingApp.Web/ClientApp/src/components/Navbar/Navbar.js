import React from 'react';
import { Link } from 'react-router-dom';
import './Navbar.css';

const Navbar = () => {
	return (
		<div className='navbar'>
			<Link to='/offer' className='navbar__element'>
				OFFER
			</Link>
			<Link to='/account' className='navbar__element navbar__element--right'>
				ACCOUNT
			</Link>
		</div>
	);
};

export default Navbar;
