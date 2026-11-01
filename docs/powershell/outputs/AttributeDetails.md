### AttributeDetails
Represents the attribute details of an Azure Ad Object attribute.

- attributeName: System.String
  - Name of the attribute.
- liveValue: list of System.Strings
  - Value of an attribute in the live Entra ID environment.
- snapshotValue: list of System.Strings
  - Value of an attribute in a snapshot.
- differenceType: AzureAdObjectAttributeDifferenceEnumType
  - Difference type in the values.
- isRecoverySupported: System.Boolean
  - Specifies if the attribute is supported for recovery.
