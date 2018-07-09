import { connect } from 'react-redux';
import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { actionCreators } from '../../store/Admin/Home';

import { ButtonToolbar, Button, Image, Grid, Row, Col } from 'react-bootstrap';
import { Link, RouteComponentProps } from 'react-router-dom';
import Tacometro from '../Tacometro'
import Tree from './Tree'
import IndicadorRegistro from './IndicadorRegistro'


// This only needs to be done once; probably during your application's bootstrapping process.
import 'react-sortable-tree/style.css';

// You can import the default tree with dnd context
import SortableTree from 'react-sortable-tree';



class Home extends Component {
    componentWillMount() {
        // This method runs when the component is first added to the page
        let startDateIndex = parseInt(this.props.match.params.startDateIndex, 10) || 0;
        this.props.RequestDataHomeAction(startDateIndex);
    }

    componentWillReceiveProps(nextProps) {
        // This method runs when incoming props (e.g., route params) change
        let startDateIndex = parseInt(nextProps.match.params.startDateIndex, 10) || 0;
        this.props.RequestDataHomeAction(startDateIndex);
    }

     render() {

        return (
            <div>
                <div>
                    <h3 style={{ position: 'absolute', color: 'lightgray', top: '1px', left: '18px' }}>M&oacute;dulo Administrador</h3>
                    <h3 style={{ position: 'absolute', color: 'black', top: '0px' }}>M&oacute;dulo Administrador</h3>
                </div>


                <div style={{ position: 'absolute', top: '0px', left: '900px' }}>
                    <img width="230px" src={require('../../images/logoSFP.png')} alt="Logo" />
                </div>

                <h4 style={{ marginTop: '60px' }} ></h4>

                <div className="container">
                    <div className="dropdown">
                        <button className="btn btn-default dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                            Seleccione el a&ntilde;o a administrar 
                        <span className="caret"></span>
                        </button>
                        <ul className="dropdown-menu" aria-labelledby="dropdownMenu1">
                            <li><a>2018</a></li>
                            <li><a>2017</a></li>
                            <li><a>2016</a></li>
                            <li><a>2015</a></li>
                            <li><a>2014</a></li>
                            <li><a>2013</a></li>
                            <li><a>2012</a></li>
                            <li><a>2012</a></li>
                            <li><a>2011</a></li>
                            <li><a>2010</a></li>
                            <li><a>2009</a></li>
                            <li><a>2008</a></li>
                            <li><a>2007</a></li>
                            <li><a>2006</a></li>
                            <li><a>2005</a></li>
                            <li><a>2004</a></li>
                        </ul>
                    </div>

                    <button className="btn btn-default bt-right" type="button"  aria-haspopup="true" aria-expanded="true">
                        C&aacute;lculo Autom&aacute;tico 
                    </button>
                </div>
                <br/>
              
                <Tree />
               
            </div>

        );
    }

}


export default connect(
    state => state.home,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(Home);

