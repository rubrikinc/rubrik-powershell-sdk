### CrawlObjErrorReason
Reason a crawl object failed to classify. Maps to a localized message in
the UI; the raw backend error is not part of this contract.

- UNSPECIFIED - Reason not determined or not applicable.
- GENERIC_ERROR - Crawl failed for a reason not covered by other values.
- SNAPSHOT_NOT_FOUND - No eligible snapshot was found for this workload.
- CONCURRENT_CRAWL_IN_PROGRESS - Another crawl is already in progress for this workload; only one
in-progress crawl is allowed per workload at a time.
