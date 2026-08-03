### ExposureTypeHits
ExposureTypeHits represents sensitive hit statistics for a particular
exposure category.

- type: ExposureType
  - Specifies the exposure type
(for example: public, organization-wide, external).
- hits: SensitiveHits
  - Detailed sensitive hits counts broken down by risk category
(high, medium, low, etc.).
- deltaHits: SensitiveFiles
  - Detailed delta sensitive hits counts broken down by risk category
(high, medium, low, etc.).
- policySummaryDetails: list of PolicySummaryDetailss
  - Detailed policy summary information for the sensitive hits.
