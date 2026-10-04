### GcpCmk
Customer managed key ring and key information for a region.

- keyRingName: System.String
  - Name of the key ring where the crypto key resides (simple name, no slashes).
- keyName: System.String
  - Name of the customer managed crypto key (simple name, no slashes).
- region: GcpRegion
  - Region of the customer managed key.
- projectNativeId: System.String
  - GCP project native ID where the crypto key resides (for same-project or cross-project CMEK).
