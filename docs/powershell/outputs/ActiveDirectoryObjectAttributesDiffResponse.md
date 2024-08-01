### ActiveDirectoryObjectAttributesDiffResponse
The difference in attribute values between snapshots for the Active Directory (AD) object.

- name: System.String
  - Required. The display name of the Active Directory (AD) object.
- countLeft: System.Int32
  - Required. The count of the values in the left object.
- isTruncated: System.Boolean
  - Required. Specifies whether there are additional values.
- isChanged: System.Boolean
- countRight: System.Int32
  - Required. The count of the values in the right object.
- values: list of ActiveDirectoryObjectAttributeDiffValues
  - The value of the difference for the attribute.
