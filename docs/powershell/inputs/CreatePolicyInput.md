### CreatePolicyInput
Policy representation containing only values supplied by the user for create and edit flows.

- id: System.String
  - 
- name: System.String
  - 
- description: System.String
  - 
- colorEnum: ClassificationPolicyColor
  - 
- mode: ClassificationPolicyMode
  - 
- analyzerIds: list of System.Strings
  - 
- documentTypeIds: list of System.Strings
  - List of document type UUIDs to associate with the policy.
- updateName: System.Boolean
  - Flags for edit flow. When the frontend wants to update select parts
of a policy, it should include those fields in this proto and mark
the update_* flags so the backend knows what to update. Other fields
that are not marked for update will be ignored. These flags are not
relevant for the create workflow.

Numbering is 1xx where xx is the corresponding field to be updated.
- updateDescription: System.Boolean
  - 
- updateMode: System.Boolean
  - 
- updateAnalyzerIds: System.Boolean
  - 
