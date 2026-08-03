### K8sResourceTypeCount
Object count for a single (apiGroup, resourceType) within a Kubernetes snapshot resource summary.

- apiGroup: System.String
  - API group of the resources. An empty string denotes the core group.
- resourceType: System.String
  - Resource type (plural of kind).
- count: System.Int32
  - Number of objects of this type.
