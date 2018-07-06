import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';

class IndicadorRegistro extends Component {

   

    render() {
        
        return <div>
            <button type="button" className="btn btn-info" data-toggle="modal" data-target="#myModalLabel6546A">
                Crear Indicador
            </button>

            <div className="modal fade" id="myModalLabel6546A" role="dialog" aria-labelledby="myModalLabel99" aria-hidden="true">
                <div className="modal-dialog modalBig" >
                    <div className="modal-content">
                        <div className="modal-header">
                            <button type="button" className="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span className="sr-only">Close</span></button>
                            <h3 className="modal-title" id="myModalLabel99">Crear Indicador</h3>
                        </div>
                        <div className="">
                            <div className="modal-body">
                                <div className="">


                                    <div className="row">
                                        <div className="col-md-12 ml-auto ">Nombre del indicador:</div>
                                    </div>
                                    <div className="row">
                                        <div className="col-md-12 ml-auto"> </div>
                                    </div>


                                    <div className="row">
                                        <div className="col-md-12 ml-auto ">Descripci&oacute;n:</div>
                                    </div>
                                    <div className="row">
                                        <div className="col-md-12 ml-auto"></div>
                                    </div>


                                    <div className="row paddno ">
                                        <div className="col-md-4 paddno">
                                            <div className="col-md-12 ml-auto ">Formula:</div>
                                            <div className="col-md-12 ml-auto "></div>
                                        </div>

                                        <div className="col-md-4 paddno">
                                            <div className="col-md-12 ml-auto ">Responsable:</div>
                                            <div className="col-md-12 ml-auto "></div>
                                        </div>

                                        <div className="col-md-4 paddno">
                                            <div className="col-md-12 ml-auto ">Correo:</div>
                                            <div className="col-md-12 ml-auto "></div>
                                        </div>

                                    </div>

                                    <div className="row ">

                                        
                                    </div>

                                    <div className="row">
                                        <div className="col-md-12 ml-auto minLetter">
                                           
                                        </div>
                                    </div>
                                    <br /><br />
                                </div>
                            </div>
                        </div>
                        <div className="modal-footer">
                            <button type="button" className="btn btn-default" data-dismiss="modal">Cerrar</button>

                        </div>
                    </div>
                </div>
            </div>

            
        </div>
    }
}

export default (IndicadorRegistro);
