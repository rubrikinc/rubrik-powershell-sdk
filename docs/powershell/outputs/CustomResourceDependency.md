### CustomResourceDependency
A Custom Resource type to capture as a dependency of an Application Protection Set.

- group: System.String
  - Required. The CR API group, e.g. "poc.rubrik.com".
- selectionMode: System.String
  - Required. How CR instances are selected. One of: all, labelMatch, annotation.
- resource: System.String
  - Required. The plural resource name, e.g. "appconfigs".
