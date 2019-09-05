import React from 'react';
import './Sports.css';

const Sports = () => {
	return (
		<div className='sports'>
			<span className='sports__title'>Sports selection</span>
			<div className='sports__links'>
				<span className='links__link'>Football &rarr;</span>
				<span className='links__link'>Basketball &rarr;</span>
				<span className='links__link'>Handball &rarr;</span>
				<span className='links__link'>Baseball &rarr;</span>
				<span className='links__link'>UFC &rarr;</span>
				<span className='links__link'>Cricket &rarr;</span>
			</div>
		</div>
	);
};

export default Sports;
