### ThreatFeedScanStatus
Threat Monitoring scan status for a threat feed update.

- feedVersion: System.String
  - Version of the given Threat Feed.
- updatedAt: DateTime
  - Time at which the new IOCs came.
- newIocs: System.Int32
  - Count of the new IOCs.
- scannedObjects: System.Int64
  - Count of the object scanned till now with the new IOCs.
