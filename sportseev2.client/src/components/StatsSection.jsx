import React from 'react'
import DailyActivityGraph from './DailyActivityGraph'
import AverageSpeedChart from './AverageSpeedChart'
import PerformanceRadarChart from './PerformanceRadarChart'
import ScoreGraph from './ScoreGraph'
import NutritionCard from './NutritionCard'
import PropTypes from 'prop-types'

/**
 * Component displaying the graph components in one section
 *
 * @component
 * @example
 * activity = [{day: '2020-11-01', kilogram:70, calories:1920}, {day: '2020-11-02', kilogram:71, calories:1670}]
 * averageSessions = [{day: 1, sessionLength:60}, {day: 2, sessionLength:85}]
 * performance = data{[{kind},{data}]}
 * score = 0.12
 * nutrition = {calorieCount: 1930, proteinCount: 155, carbohydrateCount: 290, lipidCount: 50}
 * return (
 *    <StatsSection activity={activity} averageSessions={averageSessions} performance={performance} score={user.data.todayScore || user.data.score} nutrition={user.data.keyData}/>
 * )
 */

export default function StatsSection(props) {
  return (
    <section className="statsSection">
      <div className="statsSection__activity">
       <DailyActivityGraph activity={props.activity} />
        <div className="statsSection__activity-detail">
        <AverageSpeedChart averageSessions={props.averageSessions.sessions} />
        <PerformanceRadarChart kind={props.performance.kind} data={props.performance.data} />
        <ScoreGraph score={props.score}/>
        </div>
      </div>
       <div className="statsSection__nutrition">
        <NutritionCard type="calories" value={props.nutrition.calorieCount}/>
        <NutritionCard type="proteins" value={props.nutrition.proteinCount}/>
        <NutritionCard type="carbs" value={props.nutrition.carbohydrateCount}/>
        <NutritionCard type="lipids" value={props.nutrition.lipidCount}/>
       </div>
    </section>
  )
}

StatsSection.propTypes = {
  activity: PropTypes.shape({
    day: PropTypes.string,
    kilogram: PropTypes.number,
    calories: PropTypes.number
  }),
  averageSessions: PropTypes.shape({
        day: PropTypes.number,
        sessionLength: PropTypes.number,
    }),
  performane: PropTypes.shape({
    kind: PropTypes.shape({
      "1": PropTypes.string,
      "2": PropTypes.string,
      "3": PropTypes.string,
      "4": PropTypes.string,
      "5": PropTypes.string,
      "6": PropTypes.string
    }),
    data: PropTypes.arrayOf(
      PropTypes.shape({
          value: PropTypes.number,
          kind: PropTypes.number
      })
    )
  }),
  score: PropTypes.number,
  nutrition: PropTypes.shape({
    type: PropTypes.string,
    value: PropTypes.number,
  })
}