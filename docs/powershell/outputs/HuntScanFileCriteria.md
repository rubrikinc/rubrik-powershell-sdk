### HuntScanFileCriteria
Threat hunt scan file criteria.

- fileSizeLimits: HuntScanFileSizeLimits
  - Specify the smallest and largest files to scan. This option is only
compatible with YARA rule IOCs or Hash IOCs. Limits for Path IOCs are
ignored.
- fileTimeLimits: HuntScanFileTimeLimits
  - Specify limits around file creation and modification time.
- pathFilter: HuntScanPathFilters
  - Specify allow-list and deny-list of file paths. This option is only
compatible with YARA rule IOCs or Hash IOCs. Filters for Path IOCs are
ignored.
- shouldExpandArchiveFiles: System.Boolean
  - When true, zip and archive files are expanded during the threat hunt scan
so that inner files are scanned individually.
- useExtensionWhitelist: System.Boolean
  - When true, the backend applies the extension whitelist during the scan.
Controlled by the extension whitelist checkbox in the Advance Hunt UI.
