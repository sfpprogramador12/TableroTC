import { connect } from 'react-redux';
import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { actionCreators } from '../store/Home';

import { ButtonToolbar, Button, Image, Grid, Row, Col } from 'react-bootstrap';
import { Link, RouteComponentProps } from 'react-router-dom';
//import { ApplicationState } from '../store';
import Tacometro from './Tacometro'



class LineasOrg extends Component {


    divideDataSVG() {
        if (this.props.svgM) {
            return this.props.svgM.replace(" ", "").split(',');
        }
        else {
            return "";
        }
    }


    render() {
        let svgM = this.divideDataSVG();
        return (
            <div >
                <svg id="org6" className={svgM[0]} width="100%" height="700" margin-top="20" style={{ position: 'absolute', top: '-60px', right: '115px' }}>

                    <line x1="330" y1="445" x2="1120" y2="445" stroke="#000000" stroke-width="1" />
                    <line x1="690" y1="250" x2="690" y2="445" stroke="#000000" />


                    <line x1="650" y1="445" x2="650" y2="550" stroke="#000000"></line>
                    <line x1="330" y1="445" x2="330" y2="550" stroke="#000000"></line>
                    <line x1="490" y1="445" x2="490" y2="550" stroke="#000000" stroke-width="1" />


                    <line x1="790" y1="445" x2="790" y2="550" stroke="#000000" stroke-width="1" />
                    <line x1="960" y1="445" x2="960" y2="550" stroke="#000000" stroke-width="1" />

                    <line x1="1120" y1="445" x2="1120" y2="550" stroke="#000000" stroke-width="1" />

                </svg>


                <svg id="org5" className={svgM[1]} width="100%" height="700" margin-top="20" style={{ position: 'absolute', top: '-60px', }}>

                    <line x1="190" y1="445" x2="990" y2="445" stroke="#000000" stroke-width="1" />
                    <line x1="570" y1="250" x2="570" y2="550" stroke="#000000" stroke-width="1" />


                    <line x1="190" y1="445" x2="190" y2="550" stroke="#000000" stroke-width="1" />
                    <line x1="390" y1="445" x2="390" y2="550" stroke="#000000" stroke-width="1" />
                    <line x1="790" y1="445" x2="790" y2="550" stroke="#000000" stroke-width="1" />
                    <line x1="990" y1="445" x2="990" y2="550" stroke="#000000" stroke-width="1" />
                </svg>

                <svg id="org4" className={svgM[2]} width="100%" height="700" margin-top="20" style={{ position: 'absolute', top: '-60px', right: '-30px' }}>

                    <line x1="190" y1="445" x2="790" y2="445" stroke="#000000" stroke-width="1" />
                    <line x1="570" y1="445" x2="570" y2="550" stroke="#000000" stroke-width="1" />
                    <line x1="480" y1="250" x2="480" y2="445" stroke="#000000" stroke-width="1" />

                    <line x1="190" y1="445" x2="190" y2="550" stroke="#000000" stroke-width="1" />
                    <line x1="390" y1="445" x2="390" y2="550" stroke="#000000" stroke-width="1" />
                    <line x1="790" y1="445" x2="790" y2="550" stroke="#000000" stroke-width="1" />
                    <line x1="990" y1="445" x2="990" y2="550" stroke="#000000" stroke-width="1" />
                </svg>

                <svg id="org1" className={svgM[3]} width="100%" height="700" margin-top="20" style={{ position: 'absolute', top: '-60px', }}>
                    <line x1="570" y1="250" x2="570" y2="550" stroke="#000000" stroke-width="1" />
                </svg>
            </div>
        )

    }

}



export default (LineasOrg);

