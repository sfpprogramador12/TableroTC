import { _URLS } from './constantes.js';
const RequestDataHomeAction = 'REQUEST_DATA_HOME';
const receiveWeatherForecastsType = 'RECEIVE_WEATHER_FORECASTS';
const initialState = { tacometros: [], isLoading: false };


export const actionCreators = {
    RequestDataHomeAction: startDateIndex => async (dispatch, getState) => {    
    if (startDateIndex === getState().weatherForecasts.startDateIndex) {
      // Don't issue a duplicate request (we already have or are loading the requested data)
      return;
    }

        dispatch({ type: RequestDataHomeAction, startDateIndex });
        const url = `${_URLS.api}/tableroAPI/Organigrama/GetTacometrosHome?startDateIndex=${startDateIndex}`;
        const response = await fetch(url);
        const tacometros = await response.json();
        dispatch({ type: receiveWeatherForecastsType, startDateIndex, tacometros });
  }
};

export const reducer = (state, action) => {
  state = state || initialState;

    if (action.type === RequestDataHomeAction) {
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
