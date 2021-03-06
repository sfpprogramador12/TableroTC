import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';

class PonderacionRegistro extends Component {

    render() {

        let buttonShow = "hidden";
        if (this.props.show == 1) {
            buttonShow = "showed";
        }


        return <div>
            <button type="button" className={"btn btn-info btn-xs " + buttonShow} data-toggle="modal" data-target="#myModalLabel6546AB">
                Modificar Ponderaci&oacute;n
            </button>

            <div className="modal fade modalseg" id="myModalLabel6546AB" role="dialog" aria-labelledby="myModalLabel59" aria-hidden="true">
                <div className="modal-dialog modalBig" >
                    <div className="modal-content">
                        <div className="modal-header">
                            <button type="button" className="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span className="sr-only">Close</span></button>
                            <h3 className="modal-title" id="myModalLabel59">Modificar  Ponderaci&oacute;n</h3>
                        </div>
                        <div className="">
                            <div className="modal-body">
                                <div className="">
                                    <div className="">
                                        <div className="checkbox">
                                            <label><input type="checkbox" value="" />Asignar Ponderaci&oacute;n de forma autom&aacute;tica</label>
                                        </div>
                                    </div>

                                    <div className="row">
                                        <div className="col-md-12 ml-auto">
                                            <table className="table table-striped">
                                                <thead>
                                                    <tr>
                                                        <th>Ponderaci&oacute;n</th>
                                                        <th>Nombre del Indicador</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr>
                                                        <td> <input type="text" name="" defaultValue="0" /></td>
                                                        <td> <input type="text" name="" placeholder="Nombre del indicador" /></td>
                                                    </tr>
                                                </tbody>
                                            </table>
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

export default (PonderacionRegistro);
