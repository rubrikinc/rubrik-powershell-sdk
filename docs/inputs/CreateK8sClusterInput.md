### CreateK8sClusterInput
Configuration of the Kubernetes cluster to onboard.

- cdmClusterId: System.String
  - The ID of the CDM cluster for ON_PREM Kubernetes clusters.
- hostList: a list of System.Strings
  - List of host IPs/hostnames of the Kubernetes nodes.
- name: System.String
  - Name of the Kubernetes cluster.
- port: System.Int32
  - Port on the Kubernetes node for the Kubernetes Ingress Controller.
- proxyUrl: System.String
  - The proxy URL for the Kubernetes agent.
- rbsPortRanges: a list of PortRanges
  - Ports in the NodePort service range of the Kubernetes cluster.
- type: K8sClusterProtoType
  - KuprClusterType of the Kubernetes cluster.
- userDrivenPortRanges: a list of PortRanges
  - NodePort ranges dedicated for export operations.
