import { connect } from 'react-redux';
import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { actionCreators } from '../store/Home';

import { ButtonToolbar, Button, Image, Grid, Row, Col } from 'react-bootstrap';
import { Link, RouteComponentProps } from 'react-router-dom';
//import { ApplicationState } from '../store';
import Tacometro from './Tacometro'



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

        let tacometroGral;
        let obj1;
        let obj2;
        let obj3;
        let obj4;
         

         if (this.props.tacometros) {
             tacometroGral = this.props.tacometros.map(
                (obj) => (<Tacometro posX={1} posY={5} calificacion={obj.calificacionGral} />)
            );
        } else {
            tacometroGral = <p>No Data</p>
            obj1 = <p>No Data</p>
            obj2 = <p>No Data</p>
            obj3 = <p>No Data</p>
            obj4 = <p>No Data</p>
        }

        return (
            <div>
                <div>
                    <h3 style={{ position: 'absolute', color: 'lightgray', top: '1px', left: '18px' }}>Tablero de control - 2018</h3>
                    <h3 style={{ position: 'absolute', color: 'black', top: '0px' }}>Tablero de control - 2018</h3>
                </div>


                <div style={{ position: 'absolute', top: '0px', left: '900px' }}>
                    <img width="230px" src={require('../images/logoSFP.png')} alt="Logo" />
                </div>

                <h4 style={{ marginTop: '60px' }} >Objetivos Institucionales</h4>

                <svg width="1250" height="700" margin-top="20" style={{ position: 'absolute', top: '70px' }} xmlns="http://www.w3.org/2000/svg">

                    <g transform="translate(525, 215)">
                        {tacometroGral[0]}
                    </g>

                    <g transform="translate(0,20)">
                        <rect width="260" height="80" fill="#B40404" stroke="black" ></rect>
                        <text x="105" y="20" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Mejorar la efectividad de la </text>
                        <text x="105" y="40" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Administraci&oacute;n P&uacute;blica </text>
                        <text x="105" y="60" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Federal</text>
                    </g>

                    <g transform="translate(300,20)">
                        <rect width="260" height="80" fill="#B40404" stroke="black" ></rect>
                        <text x="105" y="20" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Reducir los niveles de  </text>
                        <text x="105" y="40" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Corrupci&oacute;n en la administraci&oacute;n  </text>
                        <text x="105" y="60" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">P&uacute;blica Federal</text>
                    </g>

                    <g transform="translate(600,20)">
                        <rect width="260" height="80" fill="#B40404" stroke="black" ></rect>
                        <text x="105" y="20" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Consolidar la transparencia </text>
                        <text x="105" y="40" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">rendici&oacute;n de cuentas en </text>
                        <text x="105" y="60" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">los asuntos p&uacute;blicos</text>
                    </g>

                    <g transform="translate(900,20)">
                        <rect width="260" height="80" fill="#B40404" stroke="black" ></rect>
                        <text x="105" y="20" alignmentBaseline="hanging" fontSize="14" fill="white" textAnchor="middle">Vigilar que la actualizaci&oacute;n de la </text>
                        <text x="105" y="40" alignmentBaseline="hanging" fontSize="14" fill="white" textAnchor="middle">Administraci&oacute;n P&uacute;blica Federal </text>
                        <text x="105" y="60" alignmentBaseline="hanging" fontSize="14" fill="white" textAnchor="middle">se apegue a la legalidad</text>
                    </g>


                    /*
                        T E X T O S
                    */
                    <text x="5" y="120" fontSize="14" fill="black" >Objetivos PCGM</text>
                    <text x="5" y="250" fontSize="14" fill="black" >Elementos Institucionales</text>
                    <text x="1020" y="250" fontSize="14" fill="black" >Estructura Org&aacute;nica</text>

                    /*
                        L I N E A S
                    */
                    <line x1="190" y1="245" x2="520" y2="245" stroke="#000000" strokeWidth="2" />
                    <line x1="630" y1="245" x2="990" y2="245" stroke="#000000" strokeWidth="2" />
                    <line x1="575" y1="320" x2="575" y2="650" stroke="#000000" strokeWidth="2" />



                    <g transform="translate(0,130)">
                        <rect width="220" height="80" fill="#FFC300" stroke="black" ></rect>
                        <text x="95" y="20" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Impulsar un gobierno </text>
                        <text x="95" y="40" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Abierto que fomente la </text>
                        <text x="95" y="60" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Rendici&oacute;n de Cuentas</text>
                    </g>

                    <g transform="translate(235,130)">
                        <rect width="220" height="80" fill="#FFC300" stroke="black" ></rect>
                        <text x="110" y="20" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Fortalecer el presupuesto basado</text>
                        <text x="80" y="40" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">en resultados de la APF, </text>
                        <text x="105" y="60" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">incluyendo el gasto federalizado</text>
                    </g>

                    <g transform="translate(470,130)">
                        <rect width="220" height="80" fill="#FFC300" stroke="black" ></rect>
                        <text x="105" y="30" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Optimizar el uso </text>
                        <text x="105" y="50" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">de los recursos de la APF</text>
                        <text x="35" y="70" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle"></text>
                    </g>

                    <g transform="translate(705,130)">
                        <rect width="220" height="80" fill="#FFC300" stroke="black" ></rect>
                        <text x="105" y="20" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Mejorar  la </text>
                        <text x="105" y="40" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Administraci&oacute;n P&uacute;blica </text>
                        <text x="105" y="60" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">gubernamental de la APF</text>
                    </g>

                    <g transform="translate(940,130)">
                        <rect width="220" height="80" fill="#FFC300" stroke="black" ></rect>
                        <text x="105" y="17" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Establecer una estrategia digital </text>
                        <text x="105" y="32" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">que acelere la inserci&oacute;n e M&eacute;xico</text>
                        <text x="105" y="47" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">en la sociedad de la informaci&oacute;n</text>
                        <text x="105" y="62" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">y del conocimiento</text>
                    </g>


                    /* 
                        ELEMENTOS INSTITUCIONALES
                        COLUMNA IZQUIERDA
                    */

                    <g transform="translate(0,280)">
                        <rect width="240" height="50" fill="#777777" rx="10" ry="10" stroke="black" ></rect>
                        <a href="documents/Funciones.pdf" target="_blank"><text x="105" y="30" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Funciones</text></a>
                    </g>

                    <g transform="translate(0,360)">
                        <rect width="240" height="50" fill="#777777" rx="10" ry="10" stroke="black" ></rect>
                        <a href="documents/GobModerno.pdf" target="_blank">
                            <text x="120" y="20" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Programa para un Gobierno </text>
                            <text x="105" y="40" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Cercano y Moderno</text>
                        </a>
                    </g>

                    <g transform="translate(0,440)">
                        <rect width="240" height="50" fill="#777777" rx="10" ry="10" stroke="black" ></rect>
                        <a href="documents/ProgPresupuestarios.pdf" target="_blank">
                            <text x="120" y="30" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Programas Presupuestarios</text>
                        </a>
                    </g>

                    <g transform="translate(0,520)">
                        <rect width="240" height="50" fill="#777777" rx="10" ry="10" stroke="black" ></rect>
                        <a href="documents/Matriz.pdf" target="_blank">
                            <text x="120" y="20" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Matriz para los indicadores </text>
                            <text x="120" y="40" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">de resultados</text>
                        </a>
                    </g>

                    <g transform="translate(0,590)">
                        <rect width="240" height="50" fill="#B43104" rx="10" ry="10" stroke="black" ></rect>
                        <a href="documents/Integral.pdf" target="_blank">
                            <text x="120" y="30" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Diagn&oacute;stico Integral de la APF</text>
                        </a>
                    </g>

                    /*  COLUMNA DERECHA*/

                    <g transform="translate(260,255)">
                        <polygon points="0 20, 200 20, 200 5, 240 40, 200 75, 200 60, 0 60, 0 20" fill="#777777" />
                        <a href="documents/Macroprocesos.pdf" target="_blank">
                            <text x="120" y="45" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Macroprocesos</text>
                        </a>
                    </g>

                    <g transform="translate(260,330)">
                        <polygon points="0 20, 200 20, 200 5, 240 40, 200 75, 200 60, 0 60, 0 20" fill="#777777" />
                        <a href="documents/Procesos.pdf" target="_blank">
                            <text x="120" y="45" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Procesos</text>
                        </a>
                    </g>

                    <g transform="translate(260, 410)">
                        <rect width="240" height="50" fill="#777777" rx="10" ry="10" stroke="black" ></rect>
                        <a href="documents/ProgEstrategico.pdf" target="_blank">
                            <text x="120" y="30" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Programa Estrat&eacute;gico Institucional</text>
                        </a>
                    </g>

                    <g transform="translate(260, 470)">
                        <rect width="240" height="50" fill="#B43104" rx="10" ry="10" stroke="black" ></rect>
                        <a href="documents/Resultados.pdf" target="_blank">
                            <text x="120" y="30" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">An&aacute;lisis de Resultados</text>
                        </a>
                    </g>

                    <g transform="translate(260,530)">
                        <rect width="240" height="50" fill="#B43104" rx="10" ry="10" stroke="black" ></rect>
                        <a href="documents/Riesgos.pdf" target="_blank">
                            <text x="120" y="30" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Administraci&oacute;n de Riesgos</text>
                        </a>
                    </g>

                    <g transform="translate(260,590)">
                        <rect width="240" height="50" fill="#B43104" rx="10" ry="10" stroke="black" ></rect>
                        <a href="documents/Acciones.pdf" target="_blank">
                            <text x="120" y="20" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Acciones de Disciplina</text>
                            <text x="120" y="40" alignmentBaseline="middle" fontSize="14" fill="white" textAnchor="middle">Presupuestaria</text>
                        </a>
                    </g>

                </svg>



                {this.renderOrganigrama(this.props)}

            </div>

        );
    }


    renderOrganigrama(props) {
        let sigla;
        let personas;
        let presupuesto;
        let calificacion = 8;
        let id;
        let descripcion;

        let tacometrosSigla;
        let tacometrosPersonas;
        let tacometrosPresupuesto;
        let tacometrosCalificacion;
        let tacometrosUrl;


        if (this.props.tacometros) {
            tacometrosSigla = props.tacometros.map(
                (obj) => (<p>{obj.siglas}</p>)
            );

            tacometrosPersonas = props.tacometros.map(
                (obj) => (<p className="person">{obj.personas}</p>)
            );

            tacometrosPresupuesto = props.tacometros.map(
                (obj) => (<p className="money">${obj.presupuesto}M</p>)
            );

            tacometrosUrl = props.tacometros.map(
                (obj) => (<Link to={obj.url}>{obj.siglas}</Link>)
            );

            tacometrosCalificacion = props.tacometros.map(
                (obj) => (<Tacometro posX={1} posY={5} calificacion={obj.calificacion} />)
            );

        } else {
            tacometrosSigla = <p>No Data</p>
            tacometrosPersonas = <p>No Data</p>
            tacometrosPresupuesto = <p>No Data</p>
            tacometrosCalificacion = <p>No Data</p>
            tacometrosUrl = <p>No Data</p>
        }


        return <div className="container organigramaP">
            <div className="tpH"></div>

            <svg width="100%" height="700" margin-top="20" style={{ position: 'absolute', top: '-111px', }}>
                <line x1="20" y1="485" x2="500" y2="485" stroke="#000000" ></line>
                <line x1="230" y1="440" x2="230" y2="530" stroke="#000000" ></line>

                {/* VERTICALES PRIMER BLOQUE */}
                <line x1="20" y1="485" x2="20" y2="530" stroke="#000000" ></line>
                <line x1="130" y1="485" x2="130" y2="530" stroke="#000000" ></line>
                <line x1="230" y1="435" x2="230" y2="530" stroke="#000000" ></line>
                <line x1="330" y1="485" x2="330" y2="530" stroke="#000000" ></line>
                <line x1="430" y1="485" x2="430" y2="530" stroke="#000000" ></line>
                {/* VERTICALES SEGUNDO BLOQUE */}
                <line x1="20" y1="685" x2="20" y2="700" stroke="#000000" ></line>
                <line x1="130" y1="685" x2="130" y2="700" stroke="#000000" ></line>
                <line x1="230" y1="685" x2="230" y2="700" stroke="#000000" ></line>
                <line x1="330" y1="685" x2="330" y2="700" stroke="#000000" ></line>
                <line x1="430" y1="685" x2="430" y2="700" stroke="#000000" ></line>




                <line x1="500" y1="485" x2="500" y2="685" stroke="#000000" ></line>
                <line x1="500" y1="685" x2="20" y2="685" stroke="#000000" ></line>

                {/*
                        <line x1="390" y1="445" x2="390" y2="550" stroke="#000000" data-reactid="167"></line>
                        <line x1="790" y1="445" x2="790" y2="550" stroke="#000000" data-reactid="168"></line>
                        <line x1="990" y1="445" x2="990" y2="550" stroke="#000000" data-reactid="169"></line>
                        */}
            </svg>

            <div className="row">
                <div className="col-md-2">
                    <div className="row">
                        <div className="col-md-6"></div>
                        <div className="col-md-6"></div>
                    </div>
                </div>
                <div className="col-md-2">
                    <div className="row">
                        <div className="col-md-6 space1" >
                            <div className="row cuadroMid">
                                SFP
                                </div>
                            <div className="dataTaco" style={{ position: 'inherit', margin: '-16px 0px 0px 110px' }}>
                                <span className="iconPerson glyphicon glyphicon-user" aria-hidden="true"></span>
                                {tacometrosPresupuesto[0]}
                                {tacometrosPersonas[0]}
                            </div>
                        </div>
                        <div className="col-md-6"></div>
                    </div>
                </div>
                <div className="col-md-2">
                    <div className="row">
                        <div className="col-md-6"></div>
                        <div className="col-md-6"></div>
                    </div>
                </div>
            </div>


            <div className="row">
                <div className="col-md-2">
                    <div className="row">
                        <div className="col-md-6">
                            <div className="row cuadroMid">
                                {tacometrosUrl[0]}
                            </div>
                            <div className="row">
                                <svg>
                                    {tacometrosCalificacion[0]}
                                </svg>
                                <div className="dataTaco">
                                    <span className="iconPerson glyphicon glyphicon-user" aria-hidden="true"></span>
                                    {tacometrosPresupuesto[0]}
                                    {tacometrosPersonas[0]}
                                </div>

                            </div>
                        </div>
                        <div className="col-md-6">
                            <div className="row cuadroMid">
                                {tacometrosUrl[1]}

                            </div>
                            <div className="row">
                                <svg>
                                    {tacometrosCalificacion[1]}
                                </svg>
                                <div className="dataTaco">
                                    <span className="iconPerson glyphicon glyphicon-user" aria-hidden="true"></span>
                                    {tacometrosPresupuesto[1]}
                                    {tacometrosPersonas[1]}
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
                <div className="col-md-2">
                    <div className="row">
                        <div className="col-md-6"> <div className="row cuadroMid">
                            {tacometrosUrl[2]}
                        </div>
                            <div className="row">
                                <svg>
                                    {tacometrosCalificacion[2]}
                                </svg>
                                <div className="dataTaco">
                                    <span className="iconPerson glyphicon glyphicon-user" aria-hidden="true"></span>
                                    {tacometrosPresupuesto[2]}
                                    {tacometrosPersonas[2]}
                                </div>
                            </div></div>
                        <div className="col-md-6"> <div className="row cuadroMid">
                            {tacometrosUrl[3]}
                        </div>
                            <div className="row">
                                <svg>
                                    {tacometrosCalificacion[3]}
                                </svg>
                                <div className="dataTaco">
                                    <span className="iconPerson glyphicon glyphicon-user" aria-hidden="true"></span>
                                    {tacometrosPresupuesto[3]}
                                    {tacometrosPersonas[3]}
                                </div>
                            </div></div>
                    </div>
                </div>
                <div className="col-md-2">
                    <div className="row">
                        <div className="col-md-6"> <div className="row cuadroMid">
                            {tacometrosUrl[4]}
                        </div>
                            <div className="row">
                                <svg>
                                    {tacometrosCalificacion[4]}
                                </svg>
                                <div className="dataTaco">
                                    <span className="iconPerson glyphicon glyphicon-user" aria-hidden="true"></span>
                                    {tacometrosPresupuesto[4]}
                                    {tacometrosPersonas[4]}
                                </div>
                            </div></div>
                        <div className="col-md-6"></div>
                    </div>
                </div>
            </div>


            <div className="row" style={{ margin: "12px 0 0 0" }}>
                <div className="col-md-2">
                    <div className="row">
                        <div className="col-md-6"> <div className="row cuadroMid">
                            {tacometrosUrl[5]}
                        </div>
                            <div className="row">
                                <svg>
                                    {tacometrosCalificacion[5]}
                                </svg>
                                <div className="dataTaco">
                                    <span className="iconPerson glyphicon glyphicon-user" aria-hidden="true"></span>
                                    {tacometrosPresupuesto[5]}
                                    {tacometrosPersonas[5]}
                                </div>
                            </div></div>
                        <div className="col-md-6"> <div className="row cuadroMid">
                            {tacometrosUrl[6]}
                        </div>
                            <div className="row">
                                <svg>
                                    {tacometrosCalificacion[6]}
                                </svg>
                                <div className="dataTaco">
                                    <span className="iconPerson glyphicon glyphicon-user" aria-hidden="true"></span>
                                    {tacometrosPresupuesto[6]}
                                    {tacometrosPersonas[6]}
                                </div>
                            </div></div>
                    </div>
                </div>
                <div className="col-md-2">
                    <div className="row">
                        <div className="col-md-6"> <div className="row cuadroMid">
                            {tacometrosUrl[7]}
                        </div>
                            <div className="row">
                                <svg>
                                    {tacometrosCalificacion[7]}
                                </svg>
                                <div className="dataTaco">
                                    <span className="iconPerson glyphicon glyphicon-user" aria-hidden="true"></span>
                                    {tacometrosPresupuesto[7]}
                                    {tacometrosPersonas[7]}
                                </div>
                            </div></div>
                        <div className="col-md-6"> <div className="row cuadroMid">
                            {tacometrosUrl[8]}
                        </div>
                            <div className="row">
                                <svg>
                                    {tacometrosCalificacion[8]}
                                </svg>
                                <div className="dataTaco">
                                    <span className="iconPerson glyphicon glyphicon-user" aria-hidden="true"></span>
                                    {tacometrosPresupuesto[8]}
                                    {tacometrosPersonas[8]}
                                </div>
                            </div></div>
                    </div>
                </div>
                <div className="col-md-2">
                    <div className="row">
                        <div className="col-md-6"> <div className="row cuadroMid">
                            {tacometrosUrl[9]}
                        </div>
                            <div className="row">
                                <svg>
                                    {tacometrosCalificacion[9]}
                                </svg>
                                <div className="dataTaco">
                                    <span className="iconPerson glyphicon glyphicon-user" aria-hidden="true"></span>
                                    {tacometrosPresupuesto[9]}
                                    {tacometrosPersonas[9]}
                                </div>
                            </div></div>
                        <div className="col-md-6"></div>
                    </div>
                </div>
            </div>
        </div>;

    }


}


export default connect(
    state => state.home,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(Home);

