import React from 'react'
import { ReactSVG } from 'react-svg';
import Logo from '../assets/logo.svg'

/**
 * Component returning horizontal navigation bar
 * 
 * @component
 * @example
 * returns (
 * <NavigationHorizontal />
 * )
 */

export default function NavigationHorizontal() {
  return (
    <nav className="navhorizontal">
          <ReactSVG src={Logo} />
        <ul className="navhorizontal__list">
            <li>Home</li>
            <li>Profile</li>
            <li>Settings</li>
            <li>Community</li>
        </ul>
    </nav>
  )
}
