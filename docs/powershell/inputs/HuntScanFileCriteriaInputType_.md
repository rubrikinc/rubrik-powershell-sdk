### HuntScanFileCriteriaInputType
Hunt scan file criteria.

- fileSizeLimits: HuntScanFileSizeLimitsInputType
  - Specify the smallest and largest files to scan. This option is only
  compatible with Yara or Hash IOCs. Limits for Path IOC are
  ignored.
- fileTimeLimits: HuntScanFileTimeLimitsInputType
  - Specify limits around file creation and modification time.
- pathFilter: HuntScanPathFiltersInputType
  - Specify allow-list and deny-list of file paths. This option is only
  compatible with Yara or Hash IOCs. Filters for Path IOC are
  ignored.
