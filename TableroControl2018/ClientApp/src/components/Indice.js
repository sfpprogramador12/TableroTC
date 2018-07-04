import { connect } from 'react-redux';
import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { actionCreators } from '../store/Indice';

import { ButtonToolbar, Button, Image, Grid, Row, Col } from 'react-bootstrap';
import { Link, RouteComponentProps } from 'react-router-dom';
//import { ApplicationState } from '../store';
import Tacometro from './Tacometro'
import LineasOrg from './LineasOrg'
import IndiceDetalle from './IndiceDetalle'



class Indice extends Component {
    componentWillMount() {
        // This method runs when the component is first added to the page
        let startDateIndex = parseInt(this.props.match.params.startDateIndex, 10) || 0;
        this.props.RequestDataIndiceAction(startDateIndex);
    }

    componentWillReceiveProps(nextProps) {
        // This method runs when incoming props (e.g., route params) change
        let startDateIndex = parseInt(nextProps.match.params.startDateIndex, 10) || 0;
        this.props.RequestDataIndiceAction(startDateIndex);
    }

    render() {

        let areaNombre;
        let tacometrosCalificacion;
        let areaDesc;
        let areaPres;
        let areaPers;
        let ponderacion;
        let indicador;
        let min;
        let sat;
        let sob;
        let actual;
        let avance;



        if (this.props.indicadores) {
            areaNombre = this.props.indicadores.map(
                (obj) => (<h2>{obj.nombreA} - 2018</h2>)
            );

            areaDesc = this.props.indicadores.map(
                (obj) => (<h4>{obj.descripcionA}</h4>)
            );
            areaPers = this.props.indicadores.map(
                (obj) => (<p className="person">{obj.personas} </p>)

            );
            areaPres = this.props.indicadores.map(
                (obj) => (<p>${obj.presupuesto}M</p>)
            );

            tacometrosCalificacion = this.props.indicadores.map(
                (obj) => (<Tacometro posX={1} posY={5} calificacion={obj.calificacion} />)
            );

            indicador = this.props.indicadores.map(
                (obj) => (<tr>
                    <th scope="row">p{obj.ponderacion}%</th>
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
                    <td>

                        {obj.indicador}

                        <a data-toggle="tooltip" title={`${obj.comentarios}`} className={`${obj.comentariosflag}`}>
                            <span className="glyphicon glyphicon-info-sign" aria-hidden="true"></span>
                        </a>
                    </td>
                    <td>{obj.min}</td>
                    <td>{obj.sat}</td>
                    <td>{obj.sob}</td>
                    <td>{obj.resultado}</td>

                    <td>{obj.avance}% </td>
                    <td> <div className={"" + obj.semaforo}></div> </td>
                </tr>)
            );

        } else {
            areaNombre = <p>No Data</p>
            indicador = <p>No Data</p>
            areaDesc = <p>No Data</p>
            areaPers = <p>No Data</p>
            areaPres = <p>No Data</p>
            tacometrosCalificacion = <p>No Data</p>

        }

        return <div className="container">

            <div className="headerInfo">
                <div>
                    <img width="230px" src={require('../images/logoSFP.png')} alt="Logo" />
                </div>

                <div className="headerInfoData">
                    <div className="dataTaco2">

                        <div className="tac">
                            <svg className="contTacometro">
                                {tacometrosCalificacion[0]}
                            </svg>
                        </div>

                        <div className="per">
                            <span className="iconPerson3 glyphicon glyphicon-user" aria-hidden="true"></span>
                        </div>

                        <div className="dataContPersMon">
                            {areaPers[0]}
                            {areaPres[0]}
                        </div>

                    </div>
                </div>

            </div>

            {areaNombre[0]}
            {areaDesc[0]}

            <br />

            <br />
            <table className="table">
                <thead className="thead-dark">


                    <tr>
                        <th scope="col"></th>
                        <th scope="col"></th>
                        <th scope="col"></th>
                        <th scope="col">Indicador</th>
                        <th scope="col">min</th>
                        <th scope="col">sat</th>
                        <th scope="col">sob</th>
                        <th scope="col">Actual</th>
                        <th scope="col">Avance</th>
                        <th scope="col">Sem&aacute;foro</th>
                    </tr>
                </thead>
                <tbody>
                    {indicador}
                </tbody>
                <tfoot>
                    <tr>
                        <th scope="col">GI: <div className="mundoBK" ></div> </th>
                        <th scope="col">PGCM: <div className="verdeBK" ></div> </th>
                        <th scope="col">MIR: <div className="agendaBK" ></div> </th>
                        <th scope="col">
                            <strong>p:</strong> <p>Porcentaje de ponderaci&oacute;n asignado al indicador </p>
                            <span className="glyphicon glyphicon-info-sign"></span> Comentario
                        </th>
                    </tr>
                </tfoot>
            </table>

        </div>;
    }


}


export default connect(
    state => state.indice,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(Indice);

