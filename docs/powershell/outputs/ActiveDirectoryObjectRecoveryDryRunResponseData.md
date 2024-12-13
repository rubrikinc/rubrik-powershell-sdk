### ActiveDirectoryObjectRecoveryDryRunResponseData
The changes in attribute values if the Active Directory object is restored.

- dnt: System.Int64
  - Required. Distinguished Name Tag of the object.
- isFailure: System.Boolean
  - Specifies if the operation succeeded or failed.
- operation: System.String
  - Represents how the object is recovered or modified.
- reason: System.String
  - Detailed error for failure scenarios for the given object.
- distinguishedName: System.String
  - Distinguished Name of the object.
- attributes: ActiveDirectoryObjectAttributesDiffResponseWithDetails
  - Attributes in difference format with detailed message.
- failedAttributes: ActiveDirectoryObjectRestoreFailedAttr
  - Attributes in difference format with detailed message.
