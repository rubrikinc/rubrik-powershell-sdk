# RSC PowerShell SDK Developer Manual

## Getting Started

See : [Getting Started](../README.md)

## How is the SDK useful

The SDK is useful for two main reasons:

- It provides a set of cmdlets that wrap
  the RSC GraphQL API, and make it easier
  to work with.
- It automatically converts the JSON
  responses from the RSC GraphQL API
  into PowerShell objects, which are
  easier to work with than JSON.

In the following, we will take a simple example, retrieving the list of
cluster IDs, and see how it can be done with the SDK.

First off, without the SDK, you would do a direct call to the RSC GraphQL API.

The query to run is:

```graphql
query {
  clusterConnection(sortBy:RegisteredAt) {
    nodes {
      id
    }
  }
}
```

Assuming you have a valid API token stored in the `RSC_ACCESS_TOKEN`
environment variable, you can run the query with `curl`:

```bash
curl --no-progress-meter --request POST --header "Content-Type: applic
ation/json" --header "Authorization: $RSC_ACCESS_TOKEN" https://your-account.my.rubrik.com/api/graphql -d '{"query": "{clusterConnection(sortBy:RegisteredAt){nodes{id}}}"}'
```

The output will be a JSON object:
  
  ```json
  {
    "data": {
      "clusterConnection": {
        "nodes": [
          {
            "id": "9b429c53-2afe-44b5-b4e4-e3a4308a69fb"
          },
          {
            "id": "fd326eaa-534d-4f2a-861e-250d192fbaae"
          }
        ]
      }
    }
  }
```

You would then need to parse the JSON, extract the cluster IDs, and store
them in a PowerShell array.

With the SDK, you can do the same thing with a single cmdlet,
using the GraphQL query name directly:

```powershell
PS> (New-RscQuery -Gql clusterConnection).Nodes.Id
9b429c53-2afe-44b5-b4e4-e3a4308a69fb
fd326eaa-534d-4f2a-861e-250d192fbaae
```

That's it! You don't need to write the full GraphQL query, and you don't
need to parse the JSON response. That list of cluster IDs is already in
a PowerShell array, and you can use it directly.

`New-RscQuery -Gql clusterConnection` creates a query object for the
`clusterConnection` GraphQL query. The SDK automatically fills in a
sensible default set of fields (see [AutoField](./autofield.md)).
This auto-selection is great for exploration and reporting, but if
your script processes specific known fields, you may prefer explicit
field selection with [Field Spec](./fieldspec.md) for stability —
see [AutoField vs Fixed Queries](./autofield.md#autofield-vs-fixed-queries).
For a step-by-step walkthrough of query creation, see
[How To Create a Query](./HOWTO_create_a_query.md).
The result is a
[ClusterConnection object](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clusterconnection.doc.html)
which contains a `Nodes` property, which is an array of `Cluster` objects,
which in turn have an `Id` property.

To find the GraphQL query name you need, use `Get-RscHelp`:

```powershell
PS> Get-RscHelp cluster*                          # search by keyword
PS> Get-RscHelp -Query clusterConnection          # exact query lookup (shows variables, return type)
```

> **Note**: The SDK also has domain-specific cmdlets like
> `New-RscQueryCluster -Operation List` which do the same thing.
> These are still supported but `New-RscQuery -Gql` is the
> recommended approach — it's simpler and maps directly to the
> GraphQL schema without needing to know which "API domain" a
> query belongs to.

For mutations (creating, updating, deleting resources), see
[How To Run Mutations](./HOWTO_mutations.md).

For paginating through large result sets, see
[How To Paginate](./HOWTO_pagination.md).

## Working directly with GraphQL queries

There are cases where you may want to work directly with GraphQL queries,
for example if you want to run a query that is not covered by the SDK,
or if you already have a GraphQL query that you want to run.

`Invoke-Rsc` is the cmdlet that allows you to do that.

Try: `Get-Help Invoke-Rsc -Full` for docs and examples.

To continue with our cluster id list example, you could do:

```powershell
PS> $query = "query Clusters{clusterConnection(sortBy:RegisteredAt){nodes{id}}}"
PS> (Invoke-Rsc  $query).Nodes.Id
9b429c53-2afe-44b5-b4e4-e3a4308a69fb
fd326eaa-534d-4f2a-861e-250d192fbaae
```

Note that `Invoke-Rsc` is still superior to just using `curl`:
the response is not JSON but native PowerShell objects.

Instead of specifying the query as a string, you can
also store your GraphQL queries in files
and read them with `Get-Content`. For example:

```powershell
$query = Get-Content -Path Samples/GetVsphereVmList.query.json -Raw
Invoke-Rsc -Gql $query
```

You can also pass arguments to your query. For example if you wanted to
retrieve only the first cluster:

```powershell
PS> $query = "query Clusters(`$first: Int){clusterConnection(first: `$first, sortBy:RegisteredAt){nodes{id}}}"
PS> (Invoke-Rsc $query -Var @{first=1}).Nodes.Id
9b429c53-2afe-44b5-b4e4-e3a4308a69fb
```

## Cmdlets

The SDK cmdlets can be divided into 3 categories:

- **Core cmdlets**: `Connect-Rsc`, `Disconnect-Rsc`, `Invoke-Rsc`,
  `New-RscQuery`, `New-RscMutation`,
  `Get-RscType`, `Get-RscHelp` and `Set-RscServiceAccountFile`.
- **Domain cmdlets** (generated): `New-RscQueryCluster`,
  `New-RscMutationSla`, etc. These group operations by API domain.
  Still supported, but prefer `New-RscQuery -Gql` instead.
- **Wrapper cmdlets** (handwritten): `Get-RscCluster`, `Get-RscSla`,
  `New-RscSla`, etc. Built on top of the core/domain cmdlets for
  common use cases.

To continue with our cluster ID list example, there are several
equivalent ways to get the same result:

```powershell
# Recommended: use the GraphQL query name directly
(New-RscQuery -Gql clusterConnection | Invoke-Rsc).Nodes.Id

# Raw GraphQL string (for complex or custom queries)
(Invoke-Rsc "query {clusterConnection(sortBy:RegisteredAt){nodes{id}}}").Nodes.Id

# Wrapper cmdlet (convenient for common operations)
(Get-RscCluster).Id
```

The SDK is mostly automatically generated from the RSC GraphQL
schema, but we also curate wrapper scripts to cover very common cases.
For example,
[Get-RscCluster](../Toolkit/Public/Get-RscCluster.ps1)
runs the `clusterConnection()` query and returns the `Nodes` field
(among other things), saving you from having to unwrap the connection.

### Core cmdlets

| Cmdlet | Description |
| --- | --- |
| `Set-RscServiceAccountFile` | Set the service account file |
| `Connect-Rsc`              | Connect to RSC |
| `Disconnect-Rsc`           | Disconnect from RSC |
| `New-RscQuery`             | Create a query by GraphQL query name (recommended) |
| `New-RscMutation`          | Create a mutation by GraphQL mutation name (recommended) |
| `Invoke-Rsc`               | Send a query to RSC and return results |
| `Get-RscType`              | Work with GraphQL schema types |
| `Get-RscHelp`              | Browse the GraphQL schema (queries, types, fields) |

### Domain cmdlets (generated)

> **Prefer `New-RscQuery -Gql` over domain cmdlets.** Domain cmdlets
> group operations by "API domain" (e.g., Cluster, SLA), which requires
> knowing which domain a query belongs to. `New-RscQuery -Gql`
> accepts the GraphQL query name directly and resolves the domain
> automatically.

There are 61 `New-RscQuery*` domain cmdlets and 61 `New-RscMutation*`
domain cmdlets (122 total). Each one groups related GraphQL operations
under a single domain. For example, `New-RscQueryCluster` covers all
cluster-related queries.

Some examples:

| Cmdlet | Description |
| --- | --- |
| `New-RscQueryCluster`  | Cluster-related GraphQL queries  |
| `New-RscQueryVsphereVm`| VSphere VM-related queries       |
| `New-RscQueryMssql`    | MSSQL-related queries            |
| `New-RscQueryAws`      | AWS-related queries              |
| `New-RscQuerySla`      | SLA-related queries              |
| `New-RscMutationCluster` | Cluster-related mutations      |
| `New-RscMutationSla`   | SLA-related mutations            |
| `New-RscMutationSnapshot` | Snapshot-related mutations    |

To obtain the full list programmatically:

```powershell
$opCmdlets = (Get-Module RubrikSecurityCloud).ExportedCommands.Keys | Sort-Object | Where-Object { $_ -like 'New-RscQuery*' -or $_ -like 'New-RscMutation*' }
```

### Wrapper cmdlets

There are 77 wrapper cmdlets in `Toolkit/Public/`. These are
handwritten PowerShell scripts built on top of the operation cmdlets.
Some examples:

| Cmdlet | Description |
| --- | --- |
| `Get-RscCluster`           | Get clusters                        |
| `Get-RscSla`               | Get SLA domains                     |
| `New-RscSla`               | Create new SLA domains              |
| `Set-RscSla`               | Update SLA domains                  |
| `Get-RscSnapshot`          | Get snapshots                       |
| `Get-RscVsphereVm`         | Get VSphere VMs                     |
| `Get-RscMssqlDatabase`     | Get MSSQL databases                 |
| `Export-RscMssqlDatabase`   | Export MSSQL databases              |
| `Get-RscAccount`           | Get account info                    |
| `Get-RscEventSeries`       | Get activity series                 |
| `Get-RscHelp`              | Get help on SDK operations          |
| `Remove-NullProperties`    | Strip null fields from responses    |

To obtain the full list programmatically:

```powershell
$wrappers = (Get-Module RubrikSecurityCloud).ExportedCommands.Keys | Sort-Object | Where-Object { $coreCmdlets -notcontains $_ -and $opCmdlets -notcontains $_ }
```

## Finding your way around the SDK

The RSC schema is massive. Here's how to find the query you need:

### If you know the GraphQL query name

Use it directly:

```powershell
$q = New-RscQuery -Gql clusterConnection
```

### If you're searching by keyword

Use `Get-RscHelp` to search:

```powershell
PS> Get-RscHelp cluster*

 # Kind  Name              Info                      Description
 -- ----  ----              ----                      -----------
  1 Query cluster           returns Cluster
  2 Query clusterConnection returns ClusterConnection
  ...

PS> Get-RscHelp -Query clusterConnection    # exact lookup → shows variables and invocation
```

Then use the GraphQL query name with `New-RscQuery -Gql`:

```powershell
$q = New-RscQuery -Gql clusterConnection
```

### Determining a query's inputs

In GraphQL, an operation needs _arguments_ (variables) and a
_field specification_ (what fields to return). In the SDK, these are
called `Var` and `Field`.

Call `.Info()` on a query object to see its variables and field types:

```powershell
PS> $q = New-RscQuery -Gql clusterConnection
PS> $q.Info()
```

This does not reach out to the RSC API server — it only returns
metadata about the operation.

You are only required to pass variables that are required by the
GraphQL operation. For example, `clusterConnection` does not require
any variables, so you can invoke it directly:

```powershell
PS> New-RscQuery -Gql clusterConnection | Invoke-Rsc
```

The SDK automatically fills in the field specification using
[AutoField](./autofield.md).

Now let's say you only want to retrieve the first 3 clusters, you can
pass the `first` variable like this:

```powershell
$query = New-RscQuery -Gql clusterConnection
$query.Var.first = 3
```

Subfields can also contain arguments. You can pass subfield
arguments like this:

```powershell
$query = New-RscQuery -Gql vSphereVmNewConnection
$query.Field.Nodes[0].Vars.VsphereVirtualDisks.Count = 3
```

The field `Nodes` contains a subfield called `VsphereVirtualDisks`.
`VsphereVirtualDisks` contains an argument called `Count`. In the example,
`Nodes[0].Vars` is a directory of all subfields under `Nodes` that contain
arguments.

If the field specification is not given, the SDK fills it in automatically
with sensible defaults (see [AutoField](./autofield.md)). This is
convenient for exploration and ad-hoc queries, but for scripts where
you want full control over which fields are retrieved (and which aren't),
see [Field Spec](./fieldspec.md).
When working with GraphQL interfaces and composite objects, see
[Retrieving Interface Fields](./retrieving_interface_fields.md).
You can also specify fields yourself:

Let's look at what the default field spec looks like for the `Nodes` field:

```powershell
PS> (New-RscQuery -Gql clusterConnection -Var @{first=3} | Invoke-Rsc).Nodes[0]

PauseStatus                     : NOT_PAUSED
Status                          : DISCONNECTED
SubStatus                       : DEFAULT
SystemStatus                    : FATAL
Type                            : ROBO
DefaultAddress                  :
EncryptionEnabled               :
EstimatedRunway                 :
Id                              : 9b429c53-2afa-44b1-b4e4-e3a4308a69fb
IsHealthy                       : False
LastConnectionTime              :
Name                            : WestWales
NoSqlWorkloadCount              :
PassesConnectivityCheck         :
RegistrationTime                :
SnapshotCount                   :
SystemStatusMessage             : 1 Node Down.
Timezone                        :
Version                         :
```

Note how the `Version` field is not automatically retrieved by the SDK:

```powershell
PS> $query.Field.Nodes[0].Version -eq $null
True
```

Any field in the field spec that is set to null is not retrieved by the SDK.
To retrieve it, you just have to set it to something else than null;
it doesn't matter what, as long as it's not null.

The easier way is to use `-AddField`:

```powershell
$query = New-RscQuery -Gql clusterConnection -AddField Nodes.Version
```

Or you can manually set it on the field object:

```powershell
$query.Field.Nodes[0].Version = "fetch"
```

Here we set it to `"fetch"` but anything would work.

Now let's run the command again, with the new field spec:

```powershell
PS> ($query | Invoke-Rsc).Nodes[0]

PauseStatus                     : NOT_PAUSED
Status                          : DISCONNECTED
SubStatus                       : DEFAULT
SystemStatus                    : FATAL
Type                            : ROBO
DefaultAddress                  :
EncryptionEnabled               :
EstimatedRunway                 :
Id                              : 9b429c53-2afa-44b1-b4e4-e3a4308a69fb
IsHealthy                       : False
LastConnectionTime              :
Name                            : WestWales
NoSqlWorkloadCount              :
PassesConnectivityCheck         :
RegistrationTime                :
SnapshotCount                   :
SystemStatusMessage             : 1 Node Down.
Timezone                        :
Version                         : 8.0.2-p2-22662
```

## SDK Architecture

See [SDK Architecture](./sdk_architecture.md).

For schema introspection utilities, see
[GraphQL Model](./graphql_model.md).

## What's Next

Recommended reading order:

1. [How To Create a Query](./HOWTO_create_a_query.md) — step-by-step query creation
2. [How To Run Mutations](./HOWTO_mutations.md) — creating, updating, deleting resources
3. [How To Paginate](./HOWTO_pagination.md) — walking through large result sets
4. [AutoField](./autofield.md) — field profiles, patches, and customization
5. [Retrieving Interface Fields](./retrieving_interface_fields.md) — advanced: GraphQL interfaces
6. [FAQ](./faq.md) — common errors and troubleshooting
