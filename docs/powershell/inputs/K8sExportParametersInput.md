### K8sExportParametersInput
Supported in v9.0+
  Input to export Kubernetes resources from a resource set snapshot.

- filter: System.String
  - Supported in v9.0+
      The filter for selecting resources from the snapshot to export.
- shouldDeleteNamespaceIfExportFailed: System.Boolean
  - Specifies whether to delete exported namespace if the export failed. By default, this value is false.
- ignoreErrors: System.Boolean
  - Supported in v9.0+
      Specifies whether to ignore errors during the export operation. By default, this value is false.
- targetClusterId: System.String
  - Required. Supported in v9.0+
      The UUID of the target Kubernetes cluster to which the resources should be exported.
- targetNamespaceName: System.String
  - Required. Supported in v9.0+
      The name of the new Kubernetes namespace that will be created. The resources will be exported to the new namespace.
