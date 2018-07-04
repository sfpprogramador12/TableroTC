import { connect } from 'react-redux';
import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { actionCreators } from '../store/Organigrama';

import { ButtonToolbar, Button, Image, Grid, Row, Col } from 'react-bootstrap';
import { Link, RouteComponentProps } from 'react-router-dom';
//import { ApplicationState } from '../store';
import Tacometro from './Tacometro'
import LineasOrg from './LineasOrg'



class Organigrama extends Component {
    componentWillMount() {
        // This method runs when the component is first added to the page
        let startDateIndex = parseInt(this.props.match.params.startDateIndex, 10) || 0;
        this.props.RequestDataOrganigramaAction(startDateIndex);
    }

    componentWillReceiveProps(nextProps) {
        // This method runs when incoming props (e.g., route params) change
        let startDateIndex = parseInt(nextProps.match.params.startDateIndex, 10) || 0;
        this.props.RequestDataOrganigramaAction(startDateIndex);
    }




    render() {
        let sigla;
        let personas;
        let presupuesto;
        let calificacion = 8;

        let tacometrosSigla;
        let tacometrosNombre;
        let title;
        let tacometrosPersonas;
        let tacometrosPresupuesto;
        let tacometrosCalificacion;
        let tacometrosUrl;
        let tablaDatos;
        let tp;
        let tp1;
        let svgLines;

        let ajust;
        let ajust1;
        let ajust2;
        let ajust0;
        let ajust4 = "";
        let ajust5 = "tablecontainer3";
        let ajust6 = "";
        let ajust7 = "";

        if (this.props.tacometros) {

            console.log(this.props.tacometros);

            ajust0 = this.props.tacometros[1].tp;
            ajust = this.props.tacometros[1].tp1;
            ajust1 = this.props.tacometros[1].tp2;
            ajust2 = this.props.tacometros[1].tp3;
            ajust4 = this.props.tacometros[1].tp4;
            ajust5 = this.props.tacometros[1].tp5;
            ajust6 = this.props.tacometros[1].tp6;
            ajust7 = this.props.tacometros[1].tp7;

            tacometrosSigla = this.props.tacometros.map(
                (obj) => (<p>{obj.siglas}</p>)
            );

            tacometrosNombre = this.props.tacometros.map(
                (obj) => (<p className="letterMin">{obj.descripcion}</p>)
            );

            title = this.props.tacometros.map(
                (obj) => (<h3>{obj.descripcion}</h3>)
            );

            tacometrosPersonas = this.props.tacometros.map(
                (obj) => (<p className="person">{obj.personas}</p>)
            );

            tacometrosPresupuesto = this.props.tacometros.map(
                (obj) => (<p className="money">${obj.presupuesto}</p>)
            );

            tacometrosUrl = this.props.tacometros.map(
                (obj) => (<Link className={`${obj.linkActive}`} to={`/Indice/${obj.indicador}`}>{obj.siglas}</Link>)
            );

            tacometrosCalificacion = this.props.tacometros.map(
                (obj) => (<Tacometro posX={1} posY={5} calificacion={obj.calificacion} />)
            );

            tp = this.props.tacometros.map(
                (obj) => (<div className={"divLined " + obj.tp}></div>)
            );

            tp1 = this.props.tacometros.map(
                (obj) => (<div className={"divLined " + obj.tp1}></div>)
            );

            svgLines = this.props.tacometros.map(
                (obj) => (<LineasOrg svgM={obj.svgM} />)
            );

            svgLines = this.props.tacometros.map(
                (obj) => (<LineasOrg svgM={obj.svgM} ajustmnt={obj.tp2} />)
            );
        }

        else {
            tacometrosSigla = <p>No Data</p>
            tacometrosPersonas = <p>No Data</p>
            tacometrosPresupuesto = <p>No Data</p>
            tacometrosCalificacion = <p>No Data</p>
            tacometrosUrl = <p>No Data</p>
            tacometrosNombre = <p>No Data</p>
            title = <p>No Data</p>
            tp = <p>No Data</p>
            tp1 = <p>No Data</p>
            svgLines = <p>No Data</p>
        }


        if (this.props.tacometros.length) {
            tablaDatos = this.props.tacometros.map(
                (obj) => (<tr><th>{obj.siglas}</th><td>{obj.presupuesto}</td><td></td><td>{obj.personas}</td><td></td></tr>)
            );
        } else {
            tablaDatos = <tr><td></td></tr>;
        }


        let descripcion = "SFP";
        let id = "408";
        //let svgM = this.props.tacometros[1].svgM.replace(" ", "").split(',');
        //console.log(this.props.tacometros[1].svgM);
        return (

            <div>

                <div>
                    <h1 style={{ position: 'absolute', color: 'black', top: '0px' }}>Tablero de control - 2018</h1>
                </div>

                <div style={{ position: 'absolute', top: '0px', left: '900px' }}>
                    <img width="230px" src={require('../images/logoSFP.png')} alt="Logo" />
                </div>


                {tp[0]}

                <div className="divLined">
                    <h2 className="subAreaT">{title[0]}</h2>

                    <div className="container organigramaS">
                        <div className="row">
                            <div className="col-md-4">
                                <div className="row">
                                    <div className="col-md-6">
                                    </div>
                                    <div className="col-md-6"></div>
                                </div>
                            </div>
                            <div className={"col-md-4" + ajust1}>
                                <div className="row">
                                    <div className="col-md-6 space1 ">
                                        <div className={"row cuadroMin " + ajust} style={{ margin: '-245px 0 0 -50px' }}>
                                            {tacometrosUrl[0]}
                                            <br />
                                            {tacometrosNombre[0]}
                                        </div>

                                        <div className={"row " + ajust7} style={{}}>
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
                                    <div className="col-md-6"></div>
                                </div>
                            </div>
                            <div className="col-md-4">
                                <div className="row">
                                    <div className="col-md-6"></div>
                                    <div className="col-md-6"></div>
                                </div>
                            </div>
                        </div>


                        <div className={"row " + ajust2}>
                            <div className="col-md-4">
                                <div className="row">
                                    <div className="col-md-6">
                                        <div className="row cuadroMin cuadroCenter">
                                            {tacometrosUrl[1]}
                                            <br />
                                            {tacometrosNombre[1]}
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
                                    <div className="col-md-6">
                                        <div className="row cuadroMin cuadroCenter">
                                            {tacometrosUrl[2]}
                                            <br />
                                            {tacometrosNombre[2]}
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

                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div className="col-md-4">
                                <div className="row">
                                    <div className="col-md-6"> <div className="row cuadroMin cuadroCenter" >
                                        {tacometrosUrl[3]}
                                        <br />
                                        {tacometrosNombre[3]}
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
                                    <div className="col-md-6"> <div className="row cuadroMin cuadroCenter">
                                        {tacometrosUrl[4]}
                                        <br />
                                        {tacometrosNombre[4]}
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
                                </div>
                            </div>
                            <div className="col-md-4" id="last">
                                <div className="row">
                                    <div className="col-md-6"> <div className="row cuadroMin cuadroCenter">
                                        {tacometrosUrl[5]}
                                        <br />
                                        {tacometrosNombre[5]}
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
                                    <div className={"col-md-6 " + ajust6 + " s"}>
                                        <div className="row cuadroMin cuadroCenter">
                                            {tacometrosUrl[6]}
                                            <br />
                                            {tacometrosNombre[6]}
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

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>


                    <div className={"col-md-6 " + ajust4 + " unike"}>
                        <div className="row cuadroMin cuadroCenter">
                            {tacometrosUrl[1]}
                            <br />
                            {tacometrosNombre[1]}
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


                    <div className={"tablecontainer2 table-responsive " + ajust5} >
                        <table className="table table-hover">
                            <thead>
                                <tr>
                                    <th scope="col">Area</th>
                                    <th scope="col">Presupuesto</th>
                                    <th scope="col">%</th>
                                    <th scope="col">Plazas</th>
                                    <th scope="col">%</th>
                                </tr>
                            </thead>
                            <tbody>
                                {tablaDatos}
                            </tbody>
                        </table>
                    </div>
                </div>

                {svgLines[0]}


                {/*
                <div className="cuadro cuadroPos1"></div>
                <div className="cuadro cuadroPos2"></div>
                <div className="cuadro cuadroPos3"></div>
                <div className="cuadro cuadroPos4"></div>
                <div className="cuadro cuadroPos5"></div>
                <div className="cuadro cuadroPos0"></div>
                */}



            </div>
        );
    }



}



export default connect(
    state => state.organigrama,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(Organigrama);

