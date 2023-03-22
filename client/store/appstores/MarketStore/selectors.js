import { createSelector } from 'reselect'

export const getMarketData = createSelector(
    [state => state.marketStore],
    (data => data.marketData)
)
