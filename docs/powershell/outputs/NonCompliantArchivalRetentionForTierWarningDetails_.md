### NonCompliantArchivalRetentionForTierWarningDetails
 Warning details for an SLA Domain with archival retention that is not compatible with the minimum required retention for the selected tier.

- severity: WarningSeverityEnum
  - Severity of the warning.
- minArchivalRetentionDaysExpected: System.Int32
  - Minimum archival retention expected for the tier.
- minArchivalRetentionDaysFound: System.Int32
  - Minimum archival retention found for the tier.
- tier: System.String
  - Tier specifies hot, cool, or archive tier for archival location.
