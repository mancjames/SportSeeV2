import React from 'react'
import { useParams } from "react-router-dom";
import useFetch from '../utils/hooks/useFetch'
import Header from '../components/Header'
import StatsSection from '../components/StatsSection'
import Error from './Error';

  /**
 * Component displaying dashboard with all of users graphs
 *
 * @component
 * @example
 * return (
 *   <Dashboard />
 * )
 */
export default function Dashboard() {
    let { id } = useParams()
    const { response: user, loading, error } = useFetch(`https://localhost:7042/user/${id}`)
    const { response: activity, loading: loadingActivity } = useFetch(`https://localhost:7042/user/${id}/activity`)
    const { response: averageSessions, loading: loadingSessions } = useFetch(`https://localhost:7042/user/${id}/average-sessions`)
    const { response: performance, loading: loadingPerformance } = useFetch(`https://localhost:7042/user/${id}/performance`)

    if (error) return <Error />
    console.log('User:', user); // Debugging line
    console.log('Activity:', activity); // Debugging line
    console.log('Average Sessions:', averageSessions); // Debugging line
    console.log('Performance:', performance); // Debugging line
  return (
    <main className="dashboard__container">
      {(!loading && !loadingActivity && !loadingSessions && !loadingPerformance) ? (
        <div className="dashboard__main">
          <Header name={user.userInfos.firstName} />
          <StatsSection activity={activity} averageSessions={averageSessions} performance={performance} score={user.todayScore} nutrition={user.keyData}/>
        </div>
      ) : (
        'Loading...'
      )
      }
    </main>
  )
}
