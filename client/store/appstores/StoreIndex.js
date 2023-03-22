import { combineReducers } from 'redux'

import marketStoreReducer from './MarketStore/MarketStore'

export default combineReducers({
    marketStore: marketStoreReducer
})
