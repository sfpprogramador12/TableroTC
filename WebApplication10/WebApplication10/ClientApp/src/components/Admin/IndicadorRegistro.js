import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';

class IndicadorRegistro extends Component {

    render() {
        let buttonShow = "hidden";
        if (this.props.show == 1) {
            buttonShow = "showed";
        }

        return <div>
            <button type="button" className={"btn btn-success btn-xs " + buttonShow} data-toggle="modal" data-target="#myModalLabel6546AC">
                Nuevo Indicador
            </button>

            <div className="modal fade in modalind" id="myModalLabel6546AC" role="dialog" aria-labelledby="myModalLabel69" aria-hidden="true">
                <div className="modal-dialog modalBig2" role="document">
                    <div className="modal-content">
                        <div className="modal-header">
                            <button type="button" className="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span className="sr-only">Close</span></button>
                            <h4 className="modal-title" id="myModalLabel69">Nuevo Indicador</h4>
                        </div>
                        <div className="">
                            <div className="modal-body">
                                <div className="">


                                    <div className="row">
                                        <div className="row">
                                            <div className="col-md-12 strong-t">
                                                A&ntilde;o:         <input type="text"/>
                                                Unidad:             <input type="text"/>
                                                ID:                 <input type="text"/>
                                                Ponderaci&oacute;n: <input type="text"/>
                                                
                                            </div>
                                        </div><br/>

                                        <div className="row">
                                            <div className="col-md-12 strong-t">
                                                Resultado:       <input type="text" />
                                                Nombre:          <input type="text" style={{width:'68%'}}/>
                                            </div>
                                        </div>
                                    </div>

                                    <div className="row objgrales">
                                            <div className="col-md-2 strong-t">
                                                    Objetivos Generales
                                            </div>
                                            <div className="col-md-10">
                                                <div className="row">
                                                    <div className="col-md-2"><div className="checkbox"><label><input type="checkbox" value="" />Pres Basado en Res</label></div></div>
                                                    <div className="col-md-2"><div className="checkbox"><label><input type="checkbox" value="" />Pres Basado en Res(</label></div></div>
                                                    <div className="col-md-2"><div className="checkbox"><label><input type="checkbox" value="" />PMG</label></div></div>
                                                    <div className="col-md-2"><div className="checkbox"><label><input type="checkbox" value="" />PNRCTCC</label></div></div>
                                                    <div className="col-md-2"><div className="checkbox"><label><input type="checkbox" value="" />Planeacion</label></div></div>
                                                </div>

                                            <div className="row">
                                                    <div className="col-md-2"><div className="checkbox"><label><input type="checkbox" value="" />Priorid OM</label></div></div>
                                                    <div className="col-md-2"><div className="checkbox"><label><input type="checkbox" value="" />PGCM</label></div></div>
                                                    <div className="col-md-2"><div className="checkbox"><label><input type="checkbox" value="" />ManualesGral(MAAG)</label></div></div>
                                                    <div className="col-md-2"><div className="checkbox"><label><input type="checkbox" value="" />Desemp. Met. Colc.</label></div></div>
                                                    <div className="col-md-2"><div className="checkbox"><label><input type="checkbox" value="" />Ofic. Secret.</label></div></div>
                                                </div>
                                            </div>
                                    </div>


                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">
                                            Objetivos ABG
                                            </div>
                                        <div className="col-md-10">
                                            <div className="row">
                                                <div className="col-md-3"><div className="checkbox"><label><input type="checkbox" value="" />Gobierno que cueste menos</label></div></div>
                                                <div className="col-md-3"><div className="checkbox"><label><input type="checkbox" value="" />Gobierno de calidad</label></div></div>
                                                <div className="col-md-3"><div className="checkbox"><label><input type="checkbox" value="" />Gobierno profesional</label></div></div>
                                            </div>

                                            <div className="row">
                                                <div className="col-md-3"><div className="checkbox"><label><input type="checkbox" value="" />Gobierno Digital</label></div></div>
                                                <div className="col-md-3"><div className="checkbox"><label><input type="checkbox" value="" />gobierno con mejopra regulatoria</label></div></div>
                                                <div className="col-md-3"><div className="checkbox"><label><input type="checkbox" value="" />Gobierno honesto y transparente</label></div></div>
                                            </div>
                                        </div>
                                    </div>


                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">
                                            Tipo de Avance
                                            </div>
                                        <div className="col-md-10">
                                            <div className="row">
                                                Avance proyecto: <input type="text" />
                                                <div className="col-md-4"><div className="checkbox"><label><input type="checkbox" value="" />Mostrar avance respecto al proyecto</label></div></div>
                                            </div>
                                            <div className="row">
                                                Avance Seguimiento: <input type="text" />
                                                <div className="col-md-4"><div className="checkbox"><label><input type="checkbox" value="" />Mostrar avance respecto a la meta</label></div></div>
                                            </div>
                                        </div>
                                    </div>

                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">
                                            Datos Iniciales
                                            </div>
                                        <div className="col-md-10">
                                            <div className="row">
                                                Valor inicial: <input type="text" />
                                                Min: <input type="text" />
                                                Sat: <input type="text" />
                                                Sob: <input type="text" />
                                            </div> <br/>
                                            <div className="row">
                                                Tipo de calculo: <input type="text" />
                                                Fecha de calculo: <input type="text" />
                                             </div>
                                        </div>
                                    </div>


                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">
                                            Descripci&oacute;n
                                            </div>
                                        <div className="col-md-10">
                                            <div className="row"><input style={{ width: '85%' }} type="text" /></div>
                                        </div>
                                    </div>

                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">
                                            F&oacute;rmula
                                            </div>
                                        <div className="col-md-10">
                                            <div className="row"><input type="text" style={{ width: '85%' }} /></div>
                                        </div>
                                    </div>


                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">
                                            Unidad
                                            </div>
                                        <div className="col-md-10">
                                            <input type="text" placeholder="unidad" />

                                            <div className="col-md-3"><div className="checkbox"><label><input type="checkbox" value="" />Proyecto Necesario</label></div></div>

                                            <label htmlFor="period">Periodicidad:</label>
                                            <select id="period">
                                            <option>Anual</option>
                                            <option>Trimestral</option>
                                            <option>Semestral</option>
                                            <option>Bimestral</option>
                                            </select>
                                        </div>
                                    </div>

                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">Proveedor</div>
                                        <div className="col-md-10"><div className="row"><input type="text" style={{ width: '85%' }} /></div></div>
                                    </div>

                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">Responsable</div>
                                        <div className="col-md-10"><div className="row"><input type="text" style={{ width: '85%' }} /></div></div>
                                    </div>

                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">Correo</div>
                                        <div className="col-md-10"><div className="row"><input type="text" style={{ width: '85%' }} /></div></div>
                                    </div>

                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">Reglamento Interior</div>
                                        <div className="col-md-10"><div className="row"><input type="text" style={{ width: '85%' }} /></div></div>
                                    </div>

                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">Excluir Indicador</div>
                                        <div className="col-md-10"><div className="row"><input type="text" style={{width:'85%'}} /></div></div>
                                    </div>


                                    <div className="row objgrales">
                                        <div className="col-md-2 strong-t">Documentos Anexos</div>
                                        <div className="col-md-10">
                                            <button className="btn btn-success btn-xs">Agregar</button>
                                            <button className="btn btn-danger btn-xs">Borrar</button>
                                        </div>
                                    </div>


                                    <div className="row objgrales">
                                            <div className="col-md-12 ml-auto">
                                                <table className="table table-striped">
                                                    <thead>
                                                        <tr>
                                                            <th>Clasificaci&oacute;n</th>
                                                            <th>Tipo</th>
                                                            <th>Ruta</th>
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
                            <div className="col-md-4"><div className="checkbox"><label><input type="checkbox" value="" />Finalizar Indicador</label></div></div>
                            <button type="button" className="btn btn-default" data-dismiss="modal">Cerrar</button>
                            <button type="button" className="btn btn-info">Guardar Cambios</button>

                        </div>
                    </div>
                </div>
            </div>


        </div>
    }
}

export default (IndicadorRegistro);
