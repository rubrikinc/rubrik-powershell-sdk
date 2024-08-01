### LicenseDetails
License details.

- entitlementId: System.String
  - Entitlement ID.
- licenseName: System.String
  - Name of a license.
- entitlementEdition: System.String
  - Entitlement edition.
- renewedEntitlementId: System.String
  - Renewed entitlement ID. This field will be empty if the license is not renewed.
- category: System.String
  - License product category.
- product: LicenseProduct
  - License Product.
- termStartDate: DateTime
  - Term start date of a license.
- termEndDate: DateTime
  - Term end date of a license.
- entitlementStatus: EntitlementStatus
  - Entitlement status.
- sharedProducts: list of LicenseProducts
  - Shared products.
- licenseParams: list of LicenseParamss
  - License parameters.
- expirySeverity: LicenseInsightsSeverity
  - Determines the severity level associated with the expiration of licenses.
