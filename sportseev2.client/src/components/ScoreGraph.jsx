import React from 'react'
import PropTypes from 'prop-types'
import { RadialBarChart, RadialBar, PolarAngleAxis, ResponsiveContainer } from 'recharts';

/**
 * Component displaying the user's today's score using a redial chart from 'recharts'
 *
 * @component
 * @example
 * const score = 0.12
 * return (
 *   <ScoreGraph score={score}/>
 * )
 */

export default function ScoreGraph(props) {
    const scoreValue = props.score * 100;

    const score = [{ "name": "score", "value": scoreValue }]

    return (
        <div className="scoreGraph">
            <ResponsiveContainer width="100%" height="100%">
                <RadialBarChart
                        innerRadius="72%"
                        outerRadius="85%"
                        data={score}
                        startAngle={90}
                        endAngle={450}
                    >
                        <svg style={{width: "inherit", height: "inherit"}}
                        viewBox="0 0 80 120"
                        >
                            <circle cx="40" cy="60" r="40" fill="white" />
                        </svg> 
                        <PolarAngleAxis
                            type="number"
                            domain={[0, 100]}
                            dataKey={'value'}
                            angleAxisId={0}
                            tick={false}
                        />
                        <RadialBar
                            minAngle={5}
                            fill="#E60000"
                            background={{ fill: "#FBFBFB" }}
                            position="center"
                            clockWise={true}
                            dataKey="value"
                            legendType="square"
                            data={score}
                            cornerRadius="50%"
                        />
                        <text fontSize="15px"
                                x="18%"
                                y="14%"
                                textAnchor="middle"
                                fill="black"
                            >
                            Score </text>
                            <text className="scoreGraph__value" x="50%" y="50%">
                                {scoreValue +"%"}
                            </text>
                            <text className="scoreGraph__text" x="50%" y="60%">
                                {"of your"}
                            </text>
                            <text className="scoreGraph__text" x="50%" y="70%">
                                {"goal"}
                            </text>
                </RadialBarChart>
            </ResponsiveContainer>
        </div>
    );
}

ScoreGraph.propTypes = {
    score: PropTypes.number,
}