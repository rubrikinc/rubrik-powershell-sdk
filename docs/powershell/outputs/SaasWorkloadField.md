### SaasWorkloadField
SaaS workload table field.

- name: System.String
  - Name of the SaaS workload field.
- type: System.String
  - Type of the SaaS workload field.
- label: System.String
  - Display name of the field.
- isDefault: System.Boolean
  - Indicates whether the field is a default field.
- distinctValues: list of System.Strings
  - Distinct values of the field, limited to a maximum of 100 values.
Currently, this is non-empty only in the case of a D365 Metadata type
field.
