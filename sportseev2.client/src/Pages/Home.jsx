import React from 'react'
import { Link } from 'react-router-dom';

  /**
 * Component displaying Error page
 *
 * @component
 * @example
 * return (
 *   <Home />
 * )
 */

export default function Home() {
  return (
    <div className="home">
        <h1 className="home__header">Welcome</h1>
        <h2 className="home__paragraph">Please click on one of the following users to get started:</h2>
        <Link to={`/user/1`}>User 1</Link>
        <br></br>
        <Link to={`/user/2`}>User 2</Link>
    </div>
  )
}
