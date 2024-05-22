import React from 'react'
import PropTypes from 'prop-types'

/**
 * 
 * @param {string} str inputs a string
 * @returns the string with the first letter as a capital eg cardio to Cardio
 */
 export function capitalizeFirstLetter(str) {
    return str.charAt(0).toUpperCase() + str.slice(1);
  }

  capitalizeFirstLetter.propTypes = {
      str: PropTypes.string
  }

/**
* AverageSpeedCustomToolTip 
* @param {Boolean} active if bar is selected
* @param {array} payload provides array data from specific point in line chart
* @returns custom tool tip showing only the amount of minutes for session
*/
export const AverageSpeedCustomTooltip = ({ active, payload}) => {
    if (active && payload && payload.length) {
        return (
            <div className="averageSpeedGraph__tooltip">
                <p>{`${payload[0].value}min`}</p>
            </div>
        );
    }
    return null;
  };
    
  AverageSpeedCustomTooltip.propTypes = {
    active: PropTypes.bool,
    payload: PropTypes.array,
  }

/**
 * ActivityGraphCustomToolTip 
 * @param {Boolean} active if bar is selected
 * @param {array} payload provides array data from specific bar chart selected
 * @returns custom tool tip showing only the weight and calories
 */

export const ActivityGraphCustomTooltip = ({ active, payload}) => {
if (active && payload && payload.length) {
    return (
        <div className="dailyActivityGraph__tooltip">
        <p className="dailyActivityGraph__tooltip__text">{`${payload[0].value}kg`}</p>
        <p className="dailyActivityGraph__tooltip__text">{`${payload[1].value}kCal`}</p>
        </div>
    );
}
return null;
};

ActivityGraphCustomTooltip.propTypes = {
active: PropTypes.bool,
payload: PropTypes.array,
}

/**
 * getDayOfMonth
 * @param {string} input input date from JSON 
 * @returns the date reformated to only provide the day
 */
export function getDayOfMonth(input) {
    const date = new Date(input)
    const day = date.getDate()
    return day
}

getDayOfMonth.propTypes = {
    input: PropTypes.string
}

/**
 * numberedDayOfWeekToLetterDay
 * @param {integer} input input day number from JSON 
 * @returns the day of the week based on number of day in week - for example day 3 is W for Wednesday
 */
export function numberedDayOfWeekToLetterDay(input){
switch(input){
    case 1:
        input = 'M';
        break;
    case 2:
        input = 'T';
        break;
    case 3:
        input = 'W';
        break;
    case 4:
        input = 'T';
        break;
    case 5:
        input = 'F';
        break;
    case 6:
    case 7:
        input = 'S';
        break;
    default:
        input = 'unrecognised day'
    }
    return input
};

numberedDayOfWeekToLetterDay.propTypes = {
    input: PropTypes.number
}

/**
 * changeNumberToCategoryName
 * @param {object} name provides object with names of categories
 * @param {string} number takes number value in data as string
 * @returns changes the kind property in data from a number to a named category, eg 1 is changed to cardio
 */
export function changeNumberToCategoryName(name, number){
    for (let property in name)
    if (property === number) return capitalizeFirstLetter(name[property]);
return "category not found";
}

changeNumberToCategoryName.propTypes = {
    name: PropTypes.object,
    number: PropTypes.string
}