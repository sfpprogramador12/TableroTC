import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import { actionCreators } from '../store/WeatherForecasts';

class Tacometro extends Component {
    AsignarColor() {
        if (this.props.calificacion !== undefined) {
            if (this.props.calificacion < 6) {
                return "red";
            } else if (this.props.calificacion >= 6 && this.props.calificacion < 8) {
                return "yellow";
            } else {
                return "green";
            }
        }
        return "red";
    }

    AsignarColorFont() {
        if (this.props.calificacion !== undefined) {
            if (this.props.calificacion >= 6 && this.props.calificacion < 8) {
                return "black";
            } else {
                return "white";
            }
        }
        return "white";
    }

    AsignarGrados() {
        if (this.props.calificacion !== undefined) {
            if (this.props.calificacion > 10) {
                return 198;
            } else if (this.props.calificacion < 5)
                return 0;
            {
                return Math.ceil((this.props.calificacion - 4.5) * 36);
            }
        }
        return 0;
    }

    render() {
        let radioInt = 40 * 0.79;
        let radioPiv = 40 * 0.2;
        let color = "red";
        let posicion = "translate(" + this.props.posX + "," + this.props.posY + ")";
        let manecilla = "translate(24,45) rotate(" + this.AsignarGrados() + " 26 5)";

        const GradosLargo = [-198, -162, -126, -90, -54, -18, -342];
        const GradosCorto = [-180, -144, -108, -72, -36, 0];

        return <g transform={posicion} >

            <circle id="CirculoExt" cx="50" cy="50" r="40" stroke="lightgray" strokeWidth="1" fill="#F5F5F5" x="50" y="20" />
            <circle id="CirculoInt" cx="50" cy="50" r={radioInt} stroke="lightgray" strokeWidth="1" fill="#FFFFFF" x="0" y="0" />

            <g>
                <rect x="30" y="69" width="40" height="20" fill={this.AsignarColor()} rx="2" ry="2" stroke="gray" ></rect>
                <text x="40" y="84" fontSize="12" fill={this.AsignarColorFont()}>{this.props.calificacion}</text>
            </g>

            <g stroke="none" fill="yellow" transform="translate(50, 50)">
                <path d="M-27 9 L-27 9  L-27 -9       L-16 -23 L0 -28     L16 -23       L27 -9 L27 9  L19 6 L19 -6 L12 -16       L0 -20 L-12 -16 L-19 -6    L-19 6 Z" />
            </g>

            <g stroke="none" fill="red" transform="translate(50, 50)">
                <path d="M-27 9 L-27 9  L-27 -9       L-16 -23     L-12 -16 L-19 -6    L-19 6 Z" />
            </g>

            <g stroke="none" fill="green" transform="translate(50, 50)">
                <path d="M16 -23 L16 -23 L27 -9 L27 9   L19 6  L19 -6  L12 -16 Z" />
            </g>

            /*  MANECILLA   */
            <g transform={manecilla}>
                <polygon points="0 5, 40 0, 40 10, 0 5" stroke="gray" fill="#D5D5D5" />
            </g>
            <circle id="CirculoInt" cx="50" cy="50" r={radioPiv} stroke="gray" strokeWidth="1" fill="#F5F5F5" x="0" y="0" />

            /*  MARCAS   */
            <g transform="translate(50, 50)" >
                {GradosLargo.map((grados) =>
                    <line x1={Math.cos(grados * 2 * Math.PI / 360) * 28} y1={Math.sin(grados * 2 * Math.PI / 360) * 28}
                        x2={Math.cos(grados * 2 * Math.PI / 360) * 20} y2={Math.sin(grados * 2 * Math.PI / 360) * 20}
                        fill="black" stroke="black" strokeWidth="2" />
                )};

                {GradosCorto.map((grados) =>
                    <line x1={Math.cos(grados * 2 * Math.PI / 360) * 25} y1={Math.sin(grados * 2 * Math.PI / 360) * 25}
                        x2={Math.cos(grados * 2 * Math.PI / 360) * 20} y2={Math.sin(grados * 2 * Math.PI / 360) * 20}
                        fill="black" stroke="black" strokeWidth="2" />
                )};

            </g>
        </g>;
    } 
}

export default connect(
  state => state.weatherForecasts,
  dispatch => bindActionCreators(actionCreators, dispatch)
)(Tacometro);
