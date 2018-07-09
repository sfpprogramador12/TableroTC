import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect }         from 'react-redux';
import { Link }            from 'react-router-dom';
import { actionCreators }  from '../../store/WeatherForecasts';
import IndicadorRegistro   from './IndicadorRegistro'
import SeguimientoRegistro from './SeguimientoRegistro'
import PonderacionRegistro from './PonderacionRegistro'
import AreaAccion from './AreaAccion'

import SortableTree, { changeNodeAtPath, addNodeUnderParent, removeNodeAtPath } from 'react-sortable-tree';

import 'react-sortable-tree/style.css'; // This only needs to be imported once in your app

class Tree extends Component {
    

    constructor(props) {
        super(props);

        this.state = {
            treeData: [{
                id: '1',
                title: 'Area',
                subtitle: 'Secretaria de la Funcion Publica',
                children: [
                    {
                        id: '2',
                        title: "Area",
                        subtitle: 'SCAGP',
                        children: [
                            {
                                id: '10',
                                title: 'Area',
                                subtitle: 'UCAOP',
                                children: [
                                    {
                                        id: "1334",
                                        subtitle: "Variación de medios remotos de comunicación electrónica, la información solic",
                                        title:"Indicador"
                                    },
                                    {
                                        id: "1334",
                                        subtitle: "Variación de auditorías y visitas a obra pública realizadas respecto de las programadas.",
                                        title:"Indicador"
                                    }
                                ]
                            },
                            {
                                id: '11',
                                title: 'Area',
                                subtitle: 'UAG'
                            },
                            {
                                id: '10',
                                title: 'Area',
                                subtitle: 'UCEGP'
                            }
                           
                        ]
                    },
                    { title: 'Area', id: '12', subtitle: 'UAJ' }, { title: 'Area', id: '13', subtitle: 'UAJ' }, { title: 'Area: ', id: '14', subtitle: 'UAJ' }]
            }],
        };
    }

    render() {
        const getNodeKey = ({ treeIndex }) => treeIndex;
        const getRandomName = () => "AJ";
        const TEAM_COLORS = ['Blue', 'Red', 'Black', 'Green'];
        const BUTTONS_TO_SHOW = [[0,0,0,1,1,1], [1,1,1,0,0,0]];  // de los 6 botones que existen, cuales fueron lo que se agregaron

        return (
            <div style={{ height: 900 }}>
                <SortableTree
                    treeData={this.state.treeData}
                    onChange={treeData => this.setState({ treeData })}


                    generateNodeProps={({ node, path }) => {
                        const rootLevelIndex =
                            this.state.treeData.reduce((acc, n, index) => {
                                if (acc !== null) {
                                    return acc;
                                }
                                if (path[0] === n.id) {
                                    return index;
                                }
                                return null;
                            }, null) || 0;
                        const playerColor = TEAM_COLORS[rootLevelIndex];

                        const rootLevelIndex2 =
                            this.state.treeData.map((acc, n, index) => {
                                console.log(acc);
                                if (acc.title === 'Area') {
                                    console.log("es " + acc.title);
                                    acc = acc.children;
                                    return 1;
                                    
                                }
                                else {
                                    console.log("es " + acc.title);
                                    acc = acc.children;
                                    return 0;
                                }
                                
                                return null;
                            }, null) || 0;
                        const show = BUTTONS_TO_SHOW[rootLevelIndex2];

                        return {
                            style: {
                                width : '500px',
                                boxShadow: `0 0 0 0px ${playerColor.toLowerCase()}`,
                                textShadow:
                                    path.length === 1
                                        ? `0px 0px px ${playerColor.toLowerCase()}`
                                        : 'none',
                            },

                            buttons: [
                                <SeguimientoRegistro show={show[0]} />,
                                <PonderacionRegistro show={show[1]} />,
                                <IndicadorRegistro   show={show[2]} />,

                                <AreaAccion show={show[3]} nombre="Agregar"/>,
                                <AreaAccion show={show[4]} nombre="Editar" />,
                                <AreaAccion show={show[5]} nombre="Calcular"/>
                               
                            ],


                            title: `${
                                path.length === 1 ? node.title : node.title
                                }`,
                            onClick: () => {
                                this.setState(state => ({
                                    treeData: changeNodeAtPath({
                                        treeData: state.treeData,
                                        path,
                                        getNodeKey,
                                        newNode: { ...node, expanded: !node.expanded },
                                    }),
                                }));
                            },
                        };
                    }}
                />
 
            </div>
        );
    }


}

export default (Tree);
