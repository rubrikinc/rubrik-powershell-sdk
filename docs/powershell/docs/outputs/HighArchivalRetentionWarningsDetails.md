### HighArchivalRetentionWarningsDetails
Warning details for an SLA Domain with a high archival retention value.

- id: System.String
  - Archival location ID.
- name: System.String
  - Archival location name.
- lockDurationDays: System.Int32
  - Immutability lock duration for the archival location, in days.
- frequencyType: RetentionUnit
  - Frequency configured in the SLA Domain for this archival location.
- archivalRetentionInDaysProvided: System.Int32
  - Archival retention configured in the SLA Domain for the archival location, in days.
- minLockDurationDaysRequired: System.Int32
  - Minimum immutability lock duration required for the archival location to be configured with an SLA Domain, in days.
- maxLockDurationDaysRequired: System.Int32
  - Maximum immutability lock duration required for the archival location to be configured with an SLA Domain, in days.
