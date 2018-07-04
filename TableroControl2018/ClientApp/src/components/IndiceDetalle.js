import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';

class IndiceDetalle extends Component {

    divideDataP() {
        if (this.props.seguimientoP) {
            console.log(this.props.seguimientoP);
            return this.props.seguimientoP.replace(" ", "").split(',');
        }
        else {
            return ""
        }
    }

    divideDataR() {
        if (this.props.seguimientoR) {
            return this.props.seguimientoR.replace(" ", "").split(',');
        }
        else {
            return ""
        }
    }

    render() {
        let ID = this.props.ID;
        let nombre = this.props.nombre;
        let descripcion = this.props.descripcion;
        let formula = this.props.formula;
        let responsable = this.props.responsable;
        let correo = this.props.correo;
        let proveedor = this.props.proveedor;
        let periodicidad = this.props.periodicidad;
        let ponderacion = this.props.ponderacion;
        let project = this.props.project;
        let tipoIndicador = this.props.tipoIndicador;
        let reglamento = this.props.reglamento;
        let min = this.props.min;
        let sat = this.props.sat;
        let sob = this.props.sob;
        let uMedida = this.props.uMedida;
        let valInicial = this.props.valInicial;
        let comentario = this.props.comentario;
        let seguimientoP = this.divideDataP();
        let seguimientoR = this.divideDataR();

        return <div>
            <button type="button" className="btn btn-info" data-toggle="modal" data-target={"#" + this.props.ID}>
                Info
            </button>

            <div className="modal fade" id={"" + this.props.ID} role="dialog" aria-labelledby={"myModalLabel" + ID} aria-hidden="true">
                <div className="modal-dialog modalBig" >
                    <div className="modal-content">
                        <div className="modal-header">
                            <button type="button" className="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span className="sr-only">Close</span></button>
                            <h3 className="modal-title" id={"myModalLabel" + this.props.ID}>Tablero de Control - Ficha T&eacute;cnica</h3>
                        </div>
                        <div className="">
                            <div className="modal-body">
                                <div className="">


                                    <div className="row">
                                        <div className="col-md-12 ml-auto backGray">Nombre del indicador:</div>
                                    </div>
                                    <div className="row">
                                        <div className="col-md-12 ml-auto"> {nombre}</div>
                                    </div>


                                    <div className="row">
                                        <div className="col-md-12 ml-auto backGray">Descripci&oacute;n:</div>
                                    </div>
                                    <div className="row">
                                        <div className="col-md-12 ml-auto">{descripcion}</div>
                                    </div>


                                    <div className="row paddno ">
                                        <div className="col-md-4 paddno">
                                            <div className="col-md-12 ml-auto backGray">Formula:</div>
                                            <div className="col-md-12 ml-auto ">{formula}</div>
                                        </div>

                                        <div className="col-md-4 paddno">
                                            <div className="col-md-12 ml-auto backGray">Responsable:</div>
                                            <div className="col-md-12 ml-auto ">{responsable}</div>
                                        </div>

                                        <div className="col-md-4 paddno">
                                            <div className="col-md-12 ml-auto backGray">Correo:</div>
                                            <div className="col-md-12 ml-auto ">{correo}</div>
                                        </div>

                                    </div>

                                    <div className="row ">

                                        <div className="col-md-12 paddno ">
                                            <div className="col-md-3 backGray">Proveedor:</div>
                                            <div className="col-md-1 backGray">Periodicidad:</div>
                                            <div className="col-md-1 backGray">Ponderacion:</div>
                                            <div className="col-md-2 backGray">Project Obligatorio:</div>
                                            <div className="col-md-2 backGray">Tipo Indcador:</div>
                                            <div className="col-md-2 last2 backGray">Reglamento Interno:</div>
                                        </div>
                                    </div>

                                    <div className="row">
                                        <div className="col-md-12 ml-auto minLetter">
                                            <div className="col-md-3 ">{proveedor}</div>
                                            <div className="col-md-1">{periodicidad}</div>
                                            <div className="col-md-1">{ponderacion}%</div>
                                            <div className="col-md-2">{project}</div>
                                            <div className="col-md-2">{tipoIndicador}</div>
                                            <div className="col-md-2 last2">{reglamento}</div>
                                        </div>
                                    </div>
                                    <br /><br />


                                    <div className="row table2Gray">
                                        <div className="col-md-4 ml-auto meta">
                                            <div className="row">
                                                <div className="col-md-11 ml-auto meta backSea2"><strong>META</strong></div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-4 ml-auto backSea ">Minimo  </div>
                                                <div className="col-md-3 ml-auto backSea ">Satisfact. </div>
                                                <div className="col-md-4 ml-auto backSea">Sobresaliente  </div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-4 ml-auto backSea "> {min} </div>
                                                <div className="col-md-3 ml-auto backSea "> {sat} </div>
                                                <div className="col-md-4 ml-auto backSea"> {sob} </div>
                                            </div>

                                            <div className="row">
                                                <div className="col-md-6 ml-auto backSea ">Unidad de Medida</div>
                                                <div className="col-md-5 ml-auto backSea">Valor inicial</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-6 ml-auto  ">{uMedida}</div>
                                                <div className="col-md-5 ml-auto ">{valInicial}</div>
                                            </div>

                                            <div className="row">
                                                <div className="col-md-4 ml-auto backSea">Presentaci&oacute;n ejec.</div>
                                                <div className="col-md-3 ml-auto backSea">Plan de Trabajo</div>
                                                <div className="col-md-4 ml-auto backSea">Evidencia de Resultados</div>
                                            </div>

                                            <div className="row">
                                                <div className="col-md-4 ml-auto ">Sin Documentos</div>
                                                <div className="col-md-3 ml-auto ">Sin Documentos</div>
                                                <div className="col-md-4 ml-auto ">Sin Documentos</div>
                                            </div>
                                            <br /><br />
                                            <div className="row">
                                                <div className="col-md-11 ml-auto backSea">Otros Documentos o Ligas:</div>
                                                <br />
                                                <div className="col-md-11 ml-auto backSea">
                                                    <select>
                                                        <option value="dc">Seleccione ...</option>
                                                    </select>
                                                </div>

                                            </div>

                                        </div>

                                        <div className="col-md-3 ml-auto calendario">
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea2">Mes</div>
                                                <div className="col-md-4 ml-auto backSea2">Program</div>
                                                <div className="col-md-4 ml-auto backSea2">Real</div>
                                            </div>

                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Enero</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[0]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[0]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Feb.</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[1]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[1]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Marzo</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[2]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[2]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Abril</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[3]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[3]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Mayo</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[4]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[4]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Junio</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[5]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[5]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Julio</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[6]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[6]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Ago.</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[7]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[7]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Sept</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[8]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[8]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Oct</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[9]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[9]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Nov</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[10]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[10]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">Dic</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[11]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[11]}</div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-3 ml-auto backSea">RES.</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoP[12]}</div>
                                                <div className="col-md-4 ml-auto backSea">{seguimientoR[12]}</div>
                                            </div>
                                        </div>

                                        <div className="col-md-4 ml-auto comentarios">
                                            <div className="row">
                                                <div className="col-md-12 ml-auto meta backSea2"><strong>Comentarios</strong></div>
                                            </div>
                                            <div className="row">
                                                <div className="col-md-12 ml-auto meta "><textarea disabled className="coments">{comentario}</textarea></div>
                                            </div>
                                        </div>
                                    </div>


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

export default (IndiceDetalle);
