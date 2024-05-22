import React from 'react'
import PropTypes from 'prop-types'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faFire } from '@fortawesome/free-solid-svg-icons'
import { faDrumstickBite } from '@fortawesome/free-solid-svg-icons'
import { faAppleWhole } from '@fortawesome/free-solid-svg-icons'
import { faBurger } from '@fortawesome/free-solid-svg-icons'

/**
 * Component displaying the user nutrition value by type
 *
 * @component
 * @example
 * const type = 'calories'
 * const value = 2500
 * return (
 *   <NutritionCard type={type} value={value}/>
 * )
 */

export default function NutritionCard(props) {
    const value = props.value;
    var unit = "";
    var desc = "";
    var colorClass ="";
    const icon = [];
    switch (props.type) {
        case "calories":
            unit="kCal";
            desc = "Calories";
            icon.push(<FontAwesomeIcon key="icon" icon={faFire} />);
            break;
        
        case "proteins":
            unit="g";
            desc = "Proteins";
            icon.push(<FontAwesomeIcon key="icon" icon={faDrumstickBite} />);
            colorClass ="nutritionCard__icon--protein";
            break;    

        case "carbs":
            unit="g";
            desc = "Carbs";
            colorClass ="nutritionCard__icon--carb";
            icon.push(<FontAwesomeIcon key="icon" icon={faAppleWhole} />);
            break;

        case "lipids":
            unit="g";
            desc = "Lipids";
            colorClass ="nutritionCard__icon--lipid";
            icon.push(<FontAwesomeIcon key="icon" icon={faBurger} />);
            break;
                
        default:
            unit="err";
            desc = "error";
            break;
    }

    return (
        <div className="nutritionCard">
            <div className={"nutritionCard__icon " + colorClass}>
                {icon}
            </div>
            <div className="nutritionCard__info">
                <p> 
                    <strong className="nutritionCard__info-value"> {value + unit} </strong>
                    <br/> 
                    {desc}
                </p>
            </div>
        </div>
    );
}

NutritionCard.propTypes = {
type: PropTypes.string,
value: PropTypes.number,
}
