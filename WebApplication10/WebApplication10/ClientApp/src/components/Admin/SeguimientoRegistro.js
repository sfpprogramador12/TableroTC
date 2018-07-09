import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';

class SeguimientoRegistro extends Component {

   

    render() {
        let buttonShow = "hidden";
        if (this.props.show == 1) {
            buttonShow = "showed";
        }


        return <div>
            <button type="button" className={"btn btn-warning btn-xs " + buttonShow} data-toggle="modal" data-target="#myModalLabel6546AA">
                Modificar Seguimiento
            </button>

            <div className="modal fade modalseg" id="myModalLabel6546AA" role="dialog" aria-labelledby="myModalLabel49" aria-hidden="true">
                <div className="modal-dialog modalBig" >
                    <div className="modal-content">
                        <div className="modal-header">
                            <button type="button" className="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span className="sr-only">Close</span></button>
                            <h3 className="modal-title" id="myModalLabel49">Modificar Seguimiento</h3>
                        </div>
                        <div className="">
                            <div className="modal-body">
                                <div className="">


                                    <div className="row">
                                        <div className="col-md-12 ml-auto ">
                                            <h5>
                                                Promocio&oacute;n de las estrategias de contrataci&oacute;n p&uacute;blica (compras consolidadas, contratos marco y 
                                            </h5>
                                            <h5>
                                                ofertas subsecuentes de descuento) para fomentar el uso efiente y transparente de recursos p&uacute;blicos :
                                            </h5>
                                        </div>
                                        </div>

                                    <div className="row">
                                        <div className="col-md-7 ml-auto">
                                            <table className="table table-striped">
                                                <thead>
                                                    <tr>
                                                        <th>MES</th>
                                                        <th>PLAN</th>
                                                        <th>REAL</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr><td> Enero      </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                    <tr><td> Febrero    </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                    <tr><td> Marzo      </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                    <tr><td> Abril      </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                    <tr><td> Mayo       </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                    <tr><td> Junio      </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                    <tr><td> Julio      </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                    <tr><td> Agosto     </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                    <tr><td> Septiembre </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                    <tr><td> Octubre    </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                    <tr><td> Noviembre  </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                    <tr><td> Diciembre  </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
                                                </tbody>
                                            </table>
                                        </div>

                                        <div className="col-md-5 ml-auto">
                                            <div className="row">
                                                <label htmlFor="periodtext">Periodicidad:</label>
                                                <select className="form-control" id="periodtext">
                                                        <option>Anual</option>
                                                        <option>Semestral</option>
                                                        <option>Trimestral</option>
                                                    </select>
                                            </div>
                                            <br />
                                            <div className="row">
                                                <label htmlFor="tipoindicador">Tipo de Indicador:</label>
                                                <select className="form-control" id="tipoindicador">
                                                    <option>Porcentaje</option>
                                                    <option></option>
                                                    <option></option>
                                                </select>
                                            </div>
                                            <br/>
                                            <div className="row">
                                                <label htmlFor="comentstext">Comentarios:</label>
                                            </div>
                                            <div className="row">
                                                <textarea id="comentstext" placeholder="comentarios" className="textcoment"></textarea>
                                            </div>
                                        </div>
                                    </div>
                                   
                                </div>
                            </div>
                        </div>
                        <div className="modal-footer">
                            <button type="button" className="btn btn-default" data-dismiss="modal">Cerrar</button>
                            <button type="button" className="btn btn-info">Guardar Cambios</button>

                        </div>
                    </div>
                </div>
            </div>

            
        </div>
    }
}

export default (SeguimientoRegistro);
