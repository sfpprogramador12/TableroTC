import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';

class AreaAccion extends Component {

   

    render() {

        let buttonShow = "hidden";
        if (this.props.show == 1) {
            buttonShow = "showed";
        }

        let nombre = this.props.nombre;

        return <div>
            <button type="button" className={"btn btn-info btn-xs " + buttonShow} data-toggle="modal" data-target="#myModalLabel6546AD">
                {nombre} &aacute;rea
            </button>

            <div className="modal fade modalseg" id="myModalLabel6546AD" role="dialog" aria-labelledby="myModalLabel48" aria-hidden="true">
                <div className="modal-dialog modalBig" >
                    <div className="modal-content">
                        <div className="modal-header">
                            <button type="button" className="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span className="sr-only">Close</span></button>
                            <h3 className="modal-title" id="myModalLabel48">Modificar &aacute;rea</h3>
                        </div>
                        <div className="">
                            <div className="modal-body">
                                <div className="">


                                    <div className="row">
                                        <div className="col-md-12 ml-auto ">
                                            <h3>{nombre} de &aacute;rea</h3>
                                        </div>
                                        </div>

                                    <div className="row">
                                        <div className="col-md-7 ml-auto">
                                            <table className="table table-striped">
                                                <thead>
                                                    <tr>
                                                        <th>Nombre</th>
                                                        
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr><td> Nombre      </td><td> <input type="text" name="" defaultValue="0" /></td><td> <input type="text" name="" defaultValue="0" /></td></tr>
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

export default (AreaAccion);
