### GetO365StorageStatsResp
Microsoft 365 detailed storage information.

- liveDataSizeInBytes: System.Int64
  - Logical size, in bytes, of all successfully ingested and synchronized data.
- physicalDataSizeInBytes: System.Int64
  - Size, in bytes, of all live data after compression and deduplication.
- storageEfficiencyPercent: System.Int64
  - Data storage efficiency, as a percentage.
- physicalDataSizeTimeSeries: list of O365PhysicalDataSizeTimeStamps
  - Time series consisting of the physical data size for the last 10 days.
- dailyGrowthInBytes: System.Int64
  - Total daily growth, in bytes, of physical data size.
- estimatedThirtyDaysStorageInBytes: System.Int64
  - Estimated physical data size after 30 days.
