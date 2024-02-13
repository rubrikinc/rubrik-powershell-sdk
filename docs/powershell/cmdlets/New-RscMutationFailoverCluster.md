# New-RscMutationFailoverCluster
## Subcommands
### bulkdelete
Delete the provided failover clusters

Supported in v5.3+
Delete the provided failover clusters.

- There is a single argument of type BulkDeleteFailoverClusterInput.
- Returns ResponseSuccess.
### bulkdeleteapp
Delete failover cluster applications

Supported in v5.3+
Delete failover cluster applications from Rubrik cluster.

- There is a single argument of type BulkDeleteFailoverClusterAppInput.
- Returns ResponseSuccess.
### create
Create a failover cluster

Supported in v5.2+
Create a failover cluster.

- There is a single argument of type CreateFailoverClusterInput.
- Returns CreateFailoverClusterReply.
### createapp
Create a failover cluster app

Supported in v5.2+
Create a failover cluster app.

- There is a single argument of type CreateFailoverClusterAppInput.
- Returns CreateFailoverClusterAppReply.
### delete
Delete a failover cluster

Supported in v5.2+
Delete a failover cluster.

- There is a single argument of type DeleteFailoverClusterInput.
- Returns ResponseSuccess.
### deleteapp
Delete a failover cluster

Supported in v5.2+
Delete a failover cluster.

- There is a single argument of type DeleteFailoverClusterAppInput.
- Returns ResponseSuccess.
### update
Update a failover cluster

Supported in v5.2+
Update failover cluster with specified properties.

- There is a single argument of type UpdateFailoverClusterInput.
- Returns UpdateFailoverClusterReply.
### updateapp
Update a failover cluster app

Supported in v5.2+
Update the failover cluster app with specified properties.

- There is a single argument of type UpdateFailoverClusterAppInput.
- Returns UpdateFailoverClusterAppReply.
