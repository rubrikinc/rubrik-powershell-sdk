### NcdFrontEndCapacity
FrontEndCapacityReply is returned in response to a FrontEndCapacityReq and
holds the requested capacity.

- usageInBytes: System.Int64
  - The front-end capacity usage in bytes.
- backupFetb: System.Int64
  - The new front-end capacity backup usage in bytes.
- archiveFetb: System.Int64
  - The new front-end capacity archive usage in bytes.
