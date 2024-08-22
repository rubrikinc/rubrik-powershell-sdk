### K8sProtectionSetAddInput
Supported in v9.1+
  Input to add a Kubernetes protection set.

- creationType: System.String
  - Supported in v9.2+
      The type of method used to create a protection set. Possible values are: automatic, RSC, or CRD.
- kubernetesNamespace: System.String
  - Supported in v9.1+
      Kubernetes namespace to which the protection set to be added belongs.
- hookConfigs: list of System.Strings
  - Supported in v9.1+
- definition: System.String
  - Required. Supported in v9.1+
      Definition of the Kubernetes protection set to be added.
- kubernetesClusterId: System.String
  - Required. Supported in v9.1+
      ID of the Kubernetes cluster to which the protection set to be added belongs.
- name: System.String
  - Required. Supported in v9.1+
      Name of the Kubernetes protection set to be added.
- rsType: System.String
  - Required. Supported in v9.1+
      Type of the Kubernetes protection set to be added.
