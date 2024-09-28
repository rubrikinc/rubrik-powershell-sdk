### ExocomputeClusterConnectReply
Response to the Exocompute cluster connection request.

- clusterSetupYaml: System.String
  - This field contains the Kubernetes configuration YAML file, which details the specifications for the K8s resources/pods to be created in the customer-managed Kubernetes cluster to establish a tunnel connection with RSC.
- clusterUuid: System.String
  - The unique ID generated for the Kubernetes (k8s) cluster that was connected to RSC.
