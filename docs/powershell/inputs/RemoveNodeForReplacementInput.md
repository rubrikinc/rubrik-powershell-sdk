### RemoveNodeForReplacementInput
Request parameters for removing a node on a Rubrik cluster for replacement.

- clusterUuid: System.String
  - Rubrik cluster UUID.
- nodeIds: list of System.Strings
  - Node ID to be removed in list form.
- useQuickDrain: System.Boolean
  - Use quick drain instead of full data drain (not recommended).
- nodeMetadata: list of NodeMetadataInputs
  - Metadata for the nodes.
