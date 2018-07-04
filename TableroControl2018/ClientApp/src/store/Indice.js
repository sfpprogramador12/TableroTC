import { _URLS } from './constantes.js';


const RequestDataIndiceAction = 'REQUEST_DATA_INDICE';
const receiveWeatherForecastsType = 'RECEIVE_WEATHER_FORECASTS';
const initialState = { indicadores: [], isLoading: false };

export const actionCreators = {
    RequestDataIndiceAction: startDateIndex => async (dispatch, getState) => {    
    if (startDateIndex === getState().weatherForecasts.startDateIndex) {
      // Don't issue a duplicate request (we already have or are loading the requested data)
      return;
    }

        dispatch({ type: RequestDataIndiceAction, startDateIndex });

        const url = `${_URLS.api}/tableroAPI/Indice/GetIndicesByID?startDateIndex=${startDateIndex}`;
        const response = await fetch(url);
        const indicadores = await response.json();
        console.log("INDICAD:");
        console.log(indicadores);
        dispatch({ type: receiveWeatherForecastsType, startDateIndex, indicadores });
  }
};

export const reducer = (state, action) => {
  state = state || initialState;

    if (action.type === RequestDataIndiceAction) {
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
