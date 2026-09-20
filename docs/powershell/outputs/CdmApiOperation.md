### CdmApiOperation
A single CDM REST endpoint blocked while a TPR rule is in effect.

- method: System.String
  - The HTTP method the endpoint is served on.
- path: System.String
  - The CDM REST route path, excluding the /api/{version} prefix.
- versions: list of System.Strings
  - The CDM API version segments the endpoint is served under.
