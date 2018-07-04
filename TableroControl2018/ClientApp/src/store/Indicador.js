import { _URLS } from './constantes.js';

const RequestDataIndicadorAction = 'REQUEST_DATA_INDICADOR';
const receiveWeatherForecastsType = 'RECEIVE_WEATHER_FORECASTS';
const initialState = { indicadores: [], isLoading: false };

export const actionCreators = {
    RequestDataIndicadorAction: startDateIndex => async (dispatch, getState) => {    
    if (startDateIndex === getState().weatherForecasts.startDateIndex) {
      // Don't issue a duplicate request (we already have or are loading the requested data)
      return;
    }

        dispatch({ type: RequestDataIndicadorAction, startDateIndex });

        const url = `${_URLS.api}/tableroAPI/Indicador/GetIndicadoresByID?startDateIndex=${startDateIndex}`;
        const response = await fetch(url);
        const indicadores = await response.json();
        console.log("INDICAD:");
        console.log(indicadores);
        dispatch({ type: receiveWeatherForecastsType, startDateIndex, indicadores });
  }
};

export const reducer = (state, action) => {
  state = state || initialState;

    if (action.type === RequestDataIndicadorAction) {
    return {
      ...state,
      startDateIndex: action.startDateIndex,
      isLoading: true
    };
  }

  if (action.type === receiveWeatherForecastsType) {
    return {
      ...state,
      startDateIndex: action.startDateIndex,
      indicadores: action.indicadores,
      isLoading: false
    };
  }

  return state;
};
