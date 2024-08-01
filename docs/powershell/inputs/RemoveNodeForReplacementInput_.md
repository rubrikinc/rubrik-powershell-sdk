### RemoveNodeForReplacementInput
Request parameters for removing a node on a Rubrik cluster for replacement.

- nodeIds: list of System.Strings
  - Node ID to be removed in list form.
- useQuickDrain: System.Boolean
  - Use quick drain instead of full data drain (not recommended).
- clusterUuid: System.String
  - Rubrik cluster UUID.
- nodeMetadata: list of NodeMetadataInputs
  - Metadata for the nodes.
