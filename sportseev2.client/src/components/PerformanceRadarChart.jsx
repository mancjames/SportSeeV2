import React from 'react'
import PropTypes from 'prop-types'
import { 
    Radar, 
    RadarChart, 
    PolarGrid, 
    PolarAngleAxis, 
    ResponsiveContainer
} from 'recharts';
import variables from '../sass/base/_variables.module.scss';
import { changeNumberToCategoryName } from '../utils/Utilities';

/**
 * Component displaying the user's performances using a radar chart from 'recharts'
 *
 * @component
 * @example
 * kind = {"1": 'cardio', "2": 'energy', "3": 'endurance'}
 * data = [{value: 200, kind:1}, {value: 240, kind:2}, {value: 80, kind:3}]
 * return (
 *   <RadarGraph kind={props.performance.data.kind} data={props.performance.data.data}/>
 * )
 */

export default function PerformanceRadarChart(props) {

    const data = props.data.map((obj) => ({
        value: obj.value,
        kind: changeNumberToCategoryName(props.kind, obj.kind.toString())
    }));

  return (
    <div className="performanceRadarGraph">
            <ResponsiveContainer width="100%" height="100%">
                <RadarChart
                        outerRadius="55%"
                        innerRadius="10%"
                        cx="50%"
                        cy="50%"
                        data={data}
                >
                    <PolarGrid radialLines={false}/>
                    <PolarAngleAxis 
                            dataKey="kind" 
                            stroke = "white"
                            axisLine= {false}
                            tickLine={false}
                            tickSize={12}
                    />
                        
                    <Radar
                        dataKey="value"
                        fill={variables.colorRed}
                        fillOpacity={0.7}
                    />
                </RadarChart>
            </ResponsiveContainer>
        </div>
  )
}

PerformanceRadarChart.propTypes = {
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
  }
