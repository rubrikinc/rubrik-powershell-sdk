### ProtectedAction
A TPR rule and the CDM REST endpoints it protects.

- actionName: System.String
  - The customer-facing name of the TPR rule (e.g. "Delete Snapshot").
- apiOperations: list of CdmApiOperations
  - The CDM REST endpoints blocked while this rule is in effect.
- rule: TprRule
  - The TPR rule this protected action corresponds to.
