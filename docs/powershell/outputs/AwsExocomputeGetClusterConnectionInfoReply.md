### AwsExocomputeGetClusterConnectionInfoReply
Response to Exocompute Cluster Connect request.

- connectionCommand: System.String
  - Run the command on the remote Kubernetes cluster to establish a secure connection with RSC.
- clusterSetupYaml: System.String
  - This field contains the Kubernetes configuration YAML, detailing the specifications for the resources that must be created in the customer managed Kubernetes cluster to establish a tunnel connection with  RSC.
- clusterUuid: System.String
  - The unique ID generated for the Kubernetes cluster that is connected to RSC.
