### K8sWorkloadComponentSummary
Summary of a Rubrik workload component running (or deployable on-demand) in a Kubernetes cluster.

- name: System.String
  - Required. Name of the workload (e.g. appscontroller, kupr-proxy, backup-agent).
- memoryLimit: System.String
  - Memory limit as a Kubernetes quantity string (e.g. "1024Mi").
- statusMessage: System.String
  - Raw Kubernetes waiting reason or condition message associated with the current status. Null when status is ok or for on-demand workloads.
- cpuLimit: System.String
  - CPU limit as a Kubernetes quantity string (e.g. "500m").
- activeNodes: list of System.Strings
  - Names of cluster nodes hosting a ready pod for this workload. Null when no pods are ready or for on-demand workloads.
- image: System.String
  - Container image reference, or null when not yet determined.
- scope: System.String
  - Required. Deployment scope: Deployment (permanent single workload), Cluster-wide (DaemonSet across all nodes), or On-Demand (workload not permanently deployed).
- replicas: System.Int32
  - Required. Desired replica count. -1 indicates an on-demand workload that is not permanently deployed.
- memoryRequest: System.String
  - Memory request as a Kubernetes quantity string (e.g. "512Mi").
- cpuRequest: System.String
  - CPU request as a Kubernetes quantity string (e.g. "250m").
- status: System.String
  - Machine-readable health status: ok, degraded, crash_loop_back_off, image_pull_back_off, pending, or unknown. Null for on-demand workloads.
