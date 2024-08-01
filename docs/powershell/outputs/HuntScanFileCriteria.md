### HuntScanFileCriteria
Hunt scan file criteria.

- fileSizeLimits: HuntScanFileSizeLimits
  - Specify the smallest and largest files to scan. This option is only
  compatible with Yara or Hash IOCs. Limits for Path IOC are
  ignored.
- fileTimeLimits: HuntScanFileTimeLimits
  - Specify limits around file creation and modification time.
- pathFilter: HuntScanPathFilters
  - Specify allow-list and deny-list of file paths. This option is only
  compatible with Yara or Hash IOCs. Filters for Path IOC are
  ignored.
