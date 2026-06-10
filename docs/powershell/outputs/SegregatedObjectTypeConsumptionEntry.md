### SegregatedObjectTypeConsumptionEntry
An entry in the consumption breakdown by object type, state, and protection status.

- objectType: O365SnappableType
  - Office 365 application type (Exchange, OneDrive, SharePoint, Teams).
- objectState: ObjectState
  - State of the object (active or relic).
- protectionStatus: ProtectionStatusEnum
  - Protection status of the object (protected, do not protect, or no SLA Domain).
- bytes: System.Int64
  - Storage consumed in bytes.
