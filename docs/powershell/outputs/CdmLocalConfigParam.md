### CdmLocalConfigParam
A single CDM local (per-node) configuration parameter, grouped with its
per-node values.

- id: System.String
  - GraphQL `id: UUID!` -- backed by the RSC-internal UUID `fid`, not the
varchar CDM identifier.
- name: System.String
  - Parameter name.
- description: System.String
  - Human-readable description of the parameter, if any.
- namespace: System.String
  - Namespace the parameter belongs to.
- nodeValues: list of CdmLocalConfigNodeValues
  - Per-node values for this parameter.
