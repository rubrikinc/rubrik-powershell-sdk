### ArchivalLocationForecast
ArchivalLocationForecast contains forecast data for a single archival location.

- locationId: System.String
  - Archival location ID.
- forecast: list of ArchivalForecastDataPoints
  - Forecasted storage time-series (one point per forecast horizon).
- runwayWeeks: System.Single
  - Estimated weeks until storage reaches entitlement capacity.
-1 if storage is not growing or entitlement is not set.
- currentBytes: System.Single
  - Current total storage in bytes for this location.
- weeklyGrowthPct: System.Single
  - Weekly growth rate as a percentage.
- confidence: ArchivalForecastConfidenceType
  - Confidence level of the forecast.
- lastRefreshedAt: DateTime
  - Timestamp of the most recent forecast refresh for this
archival location. Unset if no forecast data is available
yet.
