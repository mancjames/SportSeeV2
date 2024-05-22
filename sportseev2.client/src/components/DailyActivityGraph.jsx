import React from 'react'
import {
    BarChart,
    Bar,
    XAxis,
    YAxis,
    CartesianGrid,
    Tooltip,
    Legend,
    ResponsiveContainer
  } from "recharts";
  import variables from '../sass/base/_variables.module.scss'
  import PropTypes from 'prop-types'
  import { ActivityGraphCustomTooltip, getDayOfMonth } from '../utils/Utilities';

  /**
 * Component displaying the user's daily activity results with a bar chart from 'recharts'
 *
 * @component
 * @example
 * const activity = [{day: '2020-11-01', kilogram:70, calories:1920}, {day: '2020-11-02', kilogram:71, calories:1670}]
 * return (
 *   <DailyActivityGraph activity={props.activity}/>
 * )
 */

export default function DailyActivityGraph(props) {

    const data = props.activity.data.sessions.map((d) => ({
        day: getDayOfMonth(d.day),
        kilogram: d.kilogram,
        calories: d.calories
    }));

  return (
    <div className="dailyActivityGraph">
        <ResponsiveContainer
        width="100%"
        height="100%"
        >
        <BarChart
        data={data}
        fill="black"
        margin={{
            top: 20,
            right: 0,
            left: 40,
            bottom: 20
          }}
          barCategoryGap={54}
          barGap={8}
          barSize={7}
    >
        <text 
                    className="dailyActivityGraph__title"
                    x={85}
                    y={35}
                    textAnchor="middle"
                    fill="black"
                > Daily activity </text>
        <CartesianGrid strokeDasharray="2" vertical={false} />
        <XAxis tickLine={false} dataKey="day" dy={8} />
        <YAxis orientation="right" axisLine={false} tickLine={false} dx={8} />
        <Tooltip content={<ActivityGraphCustomTooltip />} />
        <Legend align='right' 
        verticalAlign='top' 
        iconType='circle' 
        iconSize={8} 
        height={90} 
        wrapperStyle={{paddingRight: '20px'}}
        className="dailyActivityGraph__legend" />
        <Bar name="Weight (kg)" dataKey="kilogram" barSize={5} radius={[10, 10, 0, 0]} fill={variables.colorGraphBlack} />
        <Bar name="Burned calories (kCal)" dataKey="calories" barSize={5} radius={[10, 10, 0, 0]} fill={variables.colorGraphRedDark} />
    </BarChart>
    </ResponsiveContainer>
    </div>
  )
}

DailyActivityGraph.propTypes = {
    day: PropTypes.string,
    kilogram: PropTypes.number,
    calories: PropTypes.number
};