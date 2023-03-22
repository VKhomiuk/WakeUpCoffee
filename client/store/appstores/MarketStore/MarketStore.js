const INITIAL_STATE = {
    marketData: []
}

const marketStoreReducer = (state = INITIAL_STATE, action) => {
    switch (action.type) {
        case 'SET_MARKET_DATA':
            return {
                ...state,
                marketData: action.marketData
            }
        default:
            return state
    }
}

export default marketStoreReducer
