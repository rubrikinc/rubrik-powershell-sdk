### CustomResourceDependency
Supported in v9.6+
A Custom Resource type to capture as a dependency of an Application Protection Set.

- group: System.String
  - Required. Supported in v9.6+
The CR API group, e.g. "poc.rubrik.com".
- selectionMode: System.String
  - Required. Supported in v9.6+
How CR instances are selected. One of: all, labelMatch, annotation.
- resource: System.String
  - Required. Supported in v9.6+
The plural resource name, e.g. "appconfigs".
