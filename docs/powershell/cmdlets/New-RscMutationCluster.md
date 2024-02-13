# New-RscMutationCluster
## Subcommands
### addclusternodes
Add nodes to the CDM cluster.

- There is a single argument of type AddClusterNodesInput.
- Returns AddClusterNodesReply.
### addnodestocloud
Add nodes to cloud cluster.

- There is a single argument of type AddNodesToCloudClusterInput.
- Returns CcProvisionJobReply.
### generateclusterregistrationtoken
Generate a JWT that can be used to register clusters with Rubrik. If ManagedByRubrikArg is not given, the product type is inferred automatically.

- There is a single argument of type GenerateClusterRegistrationTokenInput.
- Returns ClusterRegistrationToken.
### recovercloud
Recover a Rubrik Cloud Cluster.

- There is a single argument of type RecoverCloudClusterInput.
- Returns CcProvisionJobReply.
### registercloud
Register a cloud cluster.

- There is a single argument of type RegisterCloudClusterInput.
- Returns RegisterCloudClusterReply.
### removecdm
- There are 3 arguments.
    - clusterUUID - System.String: UUID of the Rubrik cluster.
    - isForce - System.Boolean
    - expireInDays - System.Int64: Number of days after which data from Rubrik is removed.
- Returns System.Boolean.
### removeclusternodes
Remove healthy nodes from a cluster.

- There is a single argument of type RemoveClusterNodesInput.
- Returns CcProvisionJobReply.
### updateclusterdefaultaddress
Update the default address of a Rubrik cluster.

- There is a single argument of type UpdateClusterDefaultAddressInput.
- Returns UpdateClusterDefaultAddressReply.
### updateclusterlocation
- There are 2 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - clusterLocation - ClusterLocationEdit
- Returns Cluster.
### updateclusterntpservers
Assign NTP servers to Rubrik cluster

Supported in v5.0+
Assign NTP servers to Rubrik cluster.

- There is a single argument of type UpdateClusterNtpServersInput.
- Returns ResponseSuccess.
### updateclustersettings
Update Rubrik CDM cluster settings.

- There is a single argument of type UpdateClusterSettingsInput.
- Returns UpdateClusterSettingsReply.
### updatepreviewerclusterconfig
Update previewer cluster configuration.

- There is a single argument of type PreviewerClusterConfigInput.
- Returns Cluster.
