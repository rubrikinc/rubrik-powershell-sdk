### CreatePolicyInput
Policy representation containing only values supplied by the user for create and edit flows.

- id: System.String
  - Identifier of the policy. Empty when creating a policy.
- name: System.String
  - Name of the policy.
- description: System.String
  - Description of the policy.
- colorEnum: ClassificationPolicyColor
  - Color used to represent the policy in the user interface.
- mode: ClassificationPolicyMode
  - Mode the policy runs in.
- analyzerIds: list of System.Strings
  - Identifiers of the data types to classify with this policy.
- documentTypeIds: list of System.Strings
  - List of document type UUIDs to associate with the policy.
- updateName: System.Boolean
  - Flags for edit flow. When the frontend wants to update select parts
of a policy, it should include those fields in this proto and mark
the update_* flags so the backend knows what to update. Other fields
that are not marked for update will be ignored. These flags are not
relevant for the create workflow.

Numbering is 1xx where xx is the corresponding field to be updated.
Whether to apply the supplied name.
- updateDescription: System.Boolean
  - Whether to apply the supplied description.
- updateMode: System.Boolean
  - Whether to apply the supplied mode.
- updateAnalyzerIds: System.Boolean
  - Whether to apply the supplied data type identifiers.
