### RcvConversionType
Rubrik Cloud Vault (RCV) conversion.

- createdAt: DateTime
  - Time at which this conversion request was submitted.
- updatedAt: DateTime
  - Time at which RCV conversion request was last updated.
- status: RcvConversionStatus
  - Status for Rubrik Cloud Vault (RCV) conversion.
- destinationRedundancy: RcvRedundancy
  - Destination redundancy for RCV location.
- sourceRedundancy: RcvRedundancy
  - Source redundancy for RCV location.
- destinationTier: RcsTierEnumType
  - Destination tier for RCV location.
- sourceTier: RcsTierEnumType
  - Source tier for RCV location.
- conversionType: RcvConversionEnumType
  - Type of conversion for RCV location.
