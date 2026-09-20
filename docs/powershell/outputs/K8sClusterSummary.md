### K8sClusterSummary
Supported in v9.0+
Key properties of a Kubernetes cluster.

- id: System.String
  - Required. Supported in v9.0+
ID of the Kubernetes cluster.
- backupSubnetCidr: System.String
  - Comma-separated IPv4 CIDR(s) the per-node backup proxy binds its backup NIC within. Populated only when dataPathTransport is pernodeproxy.
- name: System.String
  - Required. Supported in v9.0+
Name of the Kubernetes cluster.
- port: System.Int32
  - NodePort or LoadBalancer port used to reach the kupr proxy service.
- kuprServerProxyPodMultusIp: System.String
  - IP address of the kupr proxy pod on the Multus secondary network. Populated only for Multus transport clusters.
- crdServiceAccountInfo: ServiceAccountInfo
  - Supported in v9.2+
The details of the RSC service account used for CRD operations.
- registry: System.String
  - Supported in v9.0+
Container registry URL for storing Rubrik container images.
- effectiveSlaType: System.String
  - Type of the effective SLA domain.
- numLabels: System.Int32
  - Number of K8s labels tracked by CDM for this cluster. Null on list responses.
- distribution: System.String
  - Supported in v9.1+
Distribution of the Kubernetes cluster.
- helmStatus: System.String
  - Helm chart status for manifest-onboarded clusters (e.g. synced, stale).
- kuprServerProxyConfig: KuprServerProxyConfig
  - Supported in v9.2+
The configuration for the kupr server proxy being used.
- isDbProtectionEnabled: System.Boolean
  - Specifies whether containerized database protection is enabled on the Rubrik cluster.
- nadName: System.String
  - Network Attachment Definition name for Multus transport clusters.
- maxPvcsPerAgent: System.Int32
  - Maximum number of PVCs assigned to a single kupr backup agent. Omitted when FF is off.
- transport: System.String
  - Supported in v9.1+
The transport type used for communication with the Kubernetes cluster.
- nadNamespace: System.String
  - Namespace of the Network Attachment Definition for Multus transport clusters.
- workloads: list of K8sWorkloadComponentSummarys
  - In-cluster Rubrik workload components (persistent and on-demand). Null on list responses; populated only by the single-cluster GET.
- maxConcurrentAgents: System.Int32
  - Maximum number of kupr backup agents allowed to run concurrently. Omitted when FF is off.
- dataPathTransport: System.String
  - Transport type used for RBA data movers. Set to pernodeproxy when the per-node backup proxy DaemonSet routes data traffic. Null for clusters without per-node-proxy configured.
- effectiveSlaSource: System.String
  - Source of the effective SLA (direct assignment or inherited hierarchy).
- kubevirtVersion: System.String
  - KubeVirt version installed on the cluster, or null if KubeVirt is not present. Populated by the cluster refresh task.
- loadbalancerIpDns: System.String
  - LoadBalancer IP or DNS name for the kupr proxy service. Populated only for LoadBalancer transport clusters.
- onboardingServiceAccountInfo: ServiceAccountInfo
  - Supported in v9.2+
The details of the RSC service account used for onboarding using manifest.
- helmVersion: System.String
  - Helm chart version deployed on the cluster.
- lastRefreshTime: DateTime
  - Supported in v9.0+
Last refresh time of the Kubernetes cluster.
- namespaceCount: System.Int32
  - Number of Kubernetes namespaces discovered in this cluster.
- numProtectionSets: System.Int32
  - Number of CDM protection sets defined for this cluster. Null on list responses.
- dbServiceAccountInfo: ServiceAccountInfo
  - The details of the internal RSC service account used for database operations.
- region: System.String
  - Supported in v9.1+
Region of the Kubernetes cluster.
- effectiveSlaId: System.String
  - Effective SLA domain ID inherited or directly assigned.
- onboardingType: System.String
  - Supported in v9.2+
The type of onboarding. It can be kubeconfig or manifest.
- pvcGroupingStrategy: System.String
  - PVC grouping strategy (node_affinity | count | none). Omitted when FF is off.
- status: System.String
  - Required. Supported in v9.0+
Connection status of the Kubernetes cluster.
- k8SVersion: System.String
  - Kubernetes server version reported by the cluster API.
- numVms: System.Int32
  - Number of KubeVirt VMs discovered in this cluster. Null on list responses.
