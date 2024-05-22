import React from 'react';
import { ReactSVG } from 'react-svg';
import SitIcon from '@/assets/siticon.svg';
import SwimIcon from '@/assets/swimicon.svg';
import BikeIcon from '@/assets/bikeicon.svg';
import WeightIcon from '@/assets/weighticon.svg';

/**
 * Component returning verticle navigation bar
 * 
 * @component
 * @example
 * returns (
 * <NavigationVerticle />
 * )
 */

export default function NavigationVerticle() {
  return (
    <nav className="navverticle">
        <ul className="navverticle__list">
            <li>
                  <ReactSVG src={SitIcon} />
            </li>
            <li>
                  <ReactSVG src={SwimIcon} />
            </li>
            <li>
                  <ReactSVG src={BikeIcon} />
            </li>
            <li>
                  <ReactSVG src={WeightIcon} />
            </li>
        </ul>
        <div className="navverticle__footer">
            <p>Copyright, SportSee 2022</p>
        </div>
    </nav>
  )
}
