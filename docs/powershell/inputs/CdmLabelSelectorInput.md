### CdmLabelSelectorInput
A Kubernetes-style label selector for entry-point workload filtering.

- matchExpressions: list of LabelSelectorRequirementInputs
  - List of label selector requirements. All requirements must be satisfied for a match.
- matchLabels: System.String
  - JSON-encoded map of label key-value pairs that must all match.
