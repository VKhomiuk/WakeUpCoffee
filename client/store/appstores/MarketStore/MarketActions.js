import store from "../../store";

const { dispatch } = store

export const marketActions = {
    setMarketData: (marketData) => {
        dispatch({
            type: 'SET_MARKET_DATA',
            marketData
        })
    }
}
