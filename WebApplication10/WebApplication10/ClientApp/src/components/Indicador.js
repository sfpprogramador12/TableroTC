import { connect } from 'react-redux';
import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { actionCreators } from '../store/Indicador';

import { ButtonToolbar, Button, Image, Grid, Row, Col } from 'react-bootstrap';
import { Link, RouteComponentProps } from 'react-router-dom';
//import { ApplicationState } from '../store';
import Tacometro from './Tacometro'
import LineasOrg from './LineasOrg'
import IndiceDetalle from './IndiceDetalle'



class Indicador extends Component {
    componentWillMount() {
        // This method runs when the component is first added to the page
        let startDateIndex = parseInt(this.props.match.params.startDateIndex, 10) || 0;
        this.props.RequestDataIndicadorAction(startDateIndex);
    }

    componentWillReceiveProps(nextProps) {
        // This method runs when incoming props (e.g., route params) change
        let startDateIndex = parseInt(nextProps.match.params.startDateIndex, 10) || 0;
        this.props.RequestDataIndicadorAction(startDateIndex);
    }


    render() {
        let indicador;
        let title;

        if (this.props.indicadores) {

            indicador = this.props.indicadores.map(
                (obj) => (<tr>
                    <th>{obj.num}</th>
                    <td>
                        <IndiceDetalle
                            ID={obj.num}
                            nombre={obj.nombre}
                            descripcion={obj.descripcion}
                            formula={obj.formula}
                            responsable={obj.responsable}
                            correo={obj.correo}
                            proveedor={obj.proveedor}
                            periodicidad={obj.periodicidad}
                            ponderacion={obj.ponderacion}
                            project={obj.project}
                            tipoIndicador={obj.tipoIndicador}
                            reglamento={obj.reglamento}
                            min={obj.min}
                            sat={obj.sat}
                            sob={obj.sob}
                            uMedida={obj.uMedida}
                            valInicial={obj.valInicial}
                            seguimientoP={obj.seguimientoP}
                            seguimientoR={obj.seguimientoR}
                            comentario={obj.comentarios}
                        />
                    </td>
                    <td>
                        <div className={`${obj.tipoObjetivo}`} ></div>
                    </td>
                    <th scope="row">{obj.nombre}
                        <a data-toggle="tooltip" title={`${obj.comentarios}`} className={`${obj.comentariosflag}`}>
                            <span className="glyphicon glyphicon-info-sign" aria-hidden="true"></span>
                        </a>
                    </th>
                    <th>{obj.ua}</th>
                    <td>{obj.min}</td>
                    <td>{obj.sat}</td>
                    <td>{obj.sob}</td>

                    <td><div className={"" + obj.semaforo}></div></td>
                </tr>)
            );

            title = this.props.indicadores.map(
                (obj) => (<tr>
                    <h1>{obj.title}</h1>

                </tr>)
            );

        } else {
            indicador = <p>No Data</p>
            title = <p>No Data</p>
        }


        return (
            <div>
                <div>
                    {title[0]}
                </div>

                <div style={{ position: 'absolute', top: '0px', left: '900px' }}>
                    <img src={require('../images/logoSFP.png')} alt="Logo" />
                </div>

                <br /><br />
                <div className="container">

                    <div className="row">
                        <div className="col-md-12">
                            <table className="table">
                                <thead>

                                    <tr>
                                        <th>#</th>
                                        <th></th>
                                        <th></th>
                                        <th>Nombre</th>
                                        <th>U.A</th>
                                        <th>MIN</th>
                                        <th>SAT</th>
                                        <th>SOB</th>
                                        <th>Sem&aacute;foro</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    {indicador}



                                </tbody>

                                <tfoot>
                                    <tr>

                                        <th scope="col "></th>
                                        <th scope="col "></th>
                                        <th scope="col "></th>

                                        <th scope="col "></th>
                                        <th scope="col "></th>
                                        <th scope="col "></th>
                                        <th scope="col "></th>
                                        <th scope="col "></th>
                                    </tr>
                                </tfoot>
                            </table>
                            <div className="flex">
                                <span className="glyphicon glyphicon-info-sign"></span> <p className="clear"></p> <p>   Comentario</p>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        );
    }

}


export default connect(
    state => state.indice,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(Indicador);

