### K8sClusterAddInput
Supported in v9.0+
Input to add a Kubernetes cluster.

- id: System.String
  - Supported in v9.1+
UUID of the to be added Kubernetes cluster.
- backupSubnetCidr: System.String
  - Comma-separated IPv4 CIDR(s) the per-node backup proxy binds its backup NIC within. Only used when dataPathTransport is pernodeproxy.
- name: System.String
  - Required. Supported in v9.0+
Name of the Kubernetes cluster to be added.
- kubeconfig: System.String
  - Supported in v9.0+
Kubeconfig is a YAML string to store Kubernetes cluster authentication information. You can get this config file directly from the cluster administrator or from a cloud platform if you are using managed Kubernetes cluster.
- registry: System.String
  - Supported in v9.0+
Container registry URL for storing Rubrik container images.
- serviceAccountName: System.String
  - Supported in v9.1+
The name of the RSC service account.
- eksConfig: EksConfigInput
  - The configuration for adding an EKS cluster.
- distribution: System.String
  - Supported in v9.1+
Distribution of the Kubernetes cluster to be added.
- kuprServerProxyConfig: KuprServerProxyConfigInput
  - Supported in v9.2+
The configuration for the kupr server proxy to be added.
- pullSecret: System.String
  - Supported in v9.1+
The pull secret required for pulling Rubrik container images.
- helmChartVersion: System.String
  - Supported in v9.6+
Helm chart version installed on the Kubernetes cluster. Set by the chart at install time. Empty for non-Helm onboarding.
- nadName: System.String
  - Supported in v9.4+
The name of the network attachment definition object.
- maxPvcsPerAgent: System.Int32
  - Supported in v9.6+
Maximum number of PVCs assigned to a single kupr backup agent. Required by the count grouping strategy and used as a per-group cap for the node_affinity strategy. Defaults to 30 when omitted. Set to 0 to disable the per-agent cap.
- transport: System.String
  - Supported in v9.1+
The transport type used for communication with the Kubernetes cluster.
- isAutoPsCreationEnabled: System.Boolean
  - Supported in v9.2+
Specifies whether to enable automatic protection set creation for the Kubernetes cluster.
- clientSecret: System.String
  - Supported in v9.1+
The client secret for the service account.
- nadNamespace: System.String
  - Supported in v9.4+
The namespace to which the network attachment definition object belongs.
- maxConcurrentAgents: System.Int32
  - Supported in v9.6+
Maximum number of kupr backup agents allowed to run concurrently against this Kubernetes cluster. Set to 0 (or omit) to leave the throttle unlimited.
- accessToken: System.String
  - Supported in v9.1+
The access token for the service account.
- helmMinCdmVersion: System.String
  - Supported in v9.6+
Minimum CDM version required by the Helm chart being installed. Empty for non-Helm onboarding.
- dataPathTransport: System.String
  - The transport type used for the RBA data movers. Defaults to the control-plane transport when unset. Set to pernodeproxy to route data movers through the per-node backup proxy.
- region: System.String
  - Supported in v9.1+
Region of the Kubernetes cluster to be added.
- onboardingType: System.String
  - Supported in v9.2+
The type of onboarding. It can be kubeconfig or manifest.
- clientId: System.String
  - Supported in v9.1+
The client ID for the service account.
- pvcGroupingStrategy: System.String
  - Supported in v9.6+
PVC grouping strategy used for multi-agent backup. Determines how PVCs are partitioned across kupr backup agents. One of: node_affinity, count, none. Defaults to node_affinity when omitted.
