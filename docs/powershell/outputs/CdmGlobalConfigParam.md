### CdmGlobalConfigParam
A single CDM global (cluster-wide) configuration parameter.

- id: System.String
  - GraphQL `id: UUID!` -- backed by the RSC-internal UUID `fid`, not the
varchar CDM identifier.
- clusterUuid: System.String
  - Identifier of the cluster the parameter belongs to.
- name: System.String
  - Parameter name.
- description: System.String
  - Human-readable description of the parameter, if any.
- namespace: System.String
  - Namespace the parameter belongs to.
- state: CdmConfigParamState
  - State of the parameter relative to its shipped default.
- currentValue: System.String
  - Currently configured value.
- defaultValue: System.String
  - Shipped default value.
