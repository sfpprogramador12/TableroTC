import { _URLS } from './constantes.js';

const RequestDataOrganigramaAction = 'REQUEST_DATA_ORGANIGRAMA_ACTION';
const receiveWeatherForecastsType = 'RECEIVE_WEATHER_FORECASTS';
const initialState = { tacometros: [], isLoading: false };

export const actionCreators = {
    RequestDataOrganigramaAction: startDateIndex => async (dispatch, getState) => {    
    if (startDateIndex === getState().weatherForecasts.startDateIndex) {
      // Don't issue a duplicate request (we already have or are loading the requested data)
      return;
    }

        dispatch({ type: RequestDataOrganigramaAction, startDateIndex });
        const url = `${_URLS.api}/tableroAPI/Organigrama/GetTacometrosByID?id=${startDateIndex}`;
        const response = await fetch(url);
        const tacometros = await response.json();
        console.log( tacometros);
        dispatch({ type: receiveWeatherForecastsType, startDateIndex, tacometros });
    }
};

export const reducer = (state, action) => {
  state = state || initialState;

    if (action.type === RequestDataOrganigramaAction) {
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
        tacometros: action.tacometros,
      isLoading: false
    };
  }

  return state;
};
