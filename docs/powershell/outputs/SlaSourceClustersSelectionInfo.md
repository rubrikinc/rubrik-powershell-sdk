### SlaSourceClustersSelectionInfo
Represents the selection status of a Rubrik cluster, including the cluster ID, name, version and reasons why the cluster might be disabled for use as a source.

- disableReasons: list of SlaSourceClustersDisableReasons
  - List of reasons why the Rubrik cluster selection is disabled. If the list is empty, you can select the Rubrik cluster.
- cluster: SlaDataLocationCluster
  - Basic information about the Rubrik cluster.
