### V1DeleteK8sClusterRequestSource
Origin of the Kubernetes cluster delete request.

- V1_DELETE_K8S_CLUSTER_REQUEST_SOURCE_HELM - The delete request originates from a Helm uninstall pre-delete hook; only database-side cluster state is archived, leaving in-cluster resource cleanup to Helm.
- V1_DELETE_K8S_CLUSTER_REQUEST_SOURCE_UI - The delete request originates from the user interface. This is the default.
