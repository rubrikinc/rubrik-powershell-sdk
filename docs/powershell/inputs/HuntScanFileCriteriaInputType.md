### HuntScanFileCriteriaInputType
Threat hunt scan file criteria.

- fileSizeLimits: HuntScanFileSizeLimitsInputType
  - Specify the smallest and largest files to scan. This option is only
compatible with YARA rule IOCs or Hash IOCs. Limits for Path IOCs are
ignored.
- fileTimeLimits: HuntScanFileTimeLimitsInputType
  - Specify limits around file creation and modification time.
- pathFilter: HuntScanPathFiltersInputType
  - Specify allow-list and deny-list of file paths. This option is only
compatible with YARA rule IOCs or Hash IOCs. Filters for Path IOCs are
ignored.
- shouldExpandArchiveFiles: System.Boolean
  - When true, zip and archive files are expanded during the threat hunt scan
so that inner files are scanned individually.
