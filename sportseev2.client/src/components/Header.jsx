import React from 'react'
import PropTypes from 'prop-types'

/**
 * Component that creates the header with the name of the user based on api data
 * 
 *@component
 * @example
 * const name = 'John;
 * return (
 *   <Header name={name}/>
 * )
 */

export default function Header(props) {
  return (
    <div className="header">
        <h1 className="header-intro">Hello <span className="header-intro--name">{props.name}</span></h1>
        <h4 className="header-goal">Congratulations! You reached yesterday's goal!</h4>
    </div>
  )
}

Header.propTypes = {
    name: PropTypes.string
};