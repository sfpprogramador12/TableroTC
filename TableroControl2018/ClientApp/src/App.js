import React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import Organigrama from './components/Organigrama';
import Indice from './components/Indice';
import Indicador from './components/Indicador';

export default () => (
  <Layout>
    <Route exact path='/' component={Home} />
    <Route path='/counter' component={Counter} />
    <Route path='/fetchdata/:startDateIndex?' component={FetchData} />
    <Route path='/Organigrama/:startDateIndex?' component={Organigrama} />
    <Route path='/Indice/:startDateIndex?' component={Indice} />
        <Route path='/Indicador/:startDateIndex?' component={Indicador} />

  </Layout>
);

/*

*/