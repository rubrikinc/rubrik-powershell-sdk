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

With the SDK, you can do the same thing with a single cmdlet:

```powershell
PS> (New-RscQueryCluster -List ).Nodes.Id
9b429c53-2afe-44b5-b4e4-e3a4308a69fb
fd326eaa-534d-4f2a-861e-250d192fbaae
```

That's it! you don't need to write the GraphQL query, and you don't need
to parse the JSON response. That list of cluster IDs is already in a
PowerShell array, and you can use it directly.

Let's break down what that one-liner does.

First off, if you look at how many cmdlets are in the SDK, you could
be intrigued by its pretty small size:

```powershell
PS> (Get-Module RubrikSecurityCloud).ExportedCommands.Keys | Measure-Object | Select-Object -ExpandProperty Count
53
```

At the same time, the SDK covers all 650 queries
in the RSC GraphQL schema. How can that be?

The answer is that the SDK is built with a 2-layer command/subcommand
structure: Each cmdlet regroups a set of related queries, and each
subcommand corresponds to a specific query.

For example here, `New-RscQueryCluster` is the cmdlet that regroups
all the queries related to clusters, and `-List` is the subcommand that
corresponds to the query we want to run.

You can see the list of all the cmdlets and their subcommands in
[this sample script](../Samples/AllCmdlets.sample.ps1)

Now, about the `().Nodes.Id`:

`New-RscQueryCluster -List` returns a
[ClusterConnection object](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clusterconnection.doc.html)
which contains a `Nodes` property, which is an array of `Cluster` objects,
which in turn have an `Id` property.

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
and then use the `-OperationFile` parameter
to run them. For example:

```powershell
$query = Get-Content -Path Samples/GetVsphereVmList.query.json -Raw
Invoke-Rsc -OperationText $query
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

- The core cmdlets: `Connect-Rsc`, `Disconnect-Rsc`, `Invoke-Rsc`,
  `Get-RscType`, `Get-RscCmdlet` and `Set-RscServiceAccountFile`.
- The operation cmdlets: `New-RscQuery*` and `New-RscMutation*` .
  These cmdlets are generated from the RSC GraphQL schema, and
  allow you to run any query or mutation.
- The wrapper cmdlets: all the rest that isn't a core cmdlet, and
  that doesn't start with `Invoke-Rsc` :

  These cmdlets are manually written, built on top of the operation cmdlets,
  and capture very common use cases:

  `Get-Rsc*`, `Set-Rsc*`, `Read-Rsc*`, `Write-Rsc*`,
  `Export-Rsc*` and `Import-Rsc*`.

To continue with our cluster id list example, with the `Invoke-Rsc`
core cmdlet, as we saw before, you would do:

```powershell
(Invoke-Rsc  "query {clusterConnection(sortBy:RegisteredAt){nodes{id}}}").Nodes.Id
```

We also saw that with the `New-RscQueryCluster` operation cmdlet,
you would do:

```powershell
(New-RscQueryCluster -List ).Nodes.Id
```

And finally, there is also a `Get-RscCluster` wrapper cmdlet:

```powershell
(Get-RscCluster).Id
```

The SDK is mostly automatically generated from the RSC GraphQL
schema, but we also curate a few wrapper scripts to cover very
common cases. For example, when running the `clusterConnection()`
GraphQL query, typically when looking at the response, you are
only interested in its `Nodes` field. So
[Get-RscCluster](../RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/Public/Get-RscCluster.psm1)
is a wrapper cmdlet that runs the `clusterConnection()` query,
and returns the `Nodes` field (among other things).

### Core cmdlets

| Cmdlet | Description |
| --- | --- |
| `Set-RscServiceAccountFile` | Set the service account file |
| `Connect-Rsc` | Connect to RSC |
| `Disconnect-Rsc` | Disconnect from RSC |
| `Invoke-Rsc` | Run a GraphQL query |
| `Get-RscType` | Work with GraphQL schema types|
| `Get-RscCmdlet` | Look up cmdlets by GraphQL operation name |

```powershell
$coreCmdlets = @('Set-RscServiceAccountFile', 'Connect-Rsc', 'Disconnect-Rsc', 'Invoke-Rsc', 'Get-RscType', 'Get-RscCmdlet')

```

### Operation cmdlets

| Cmdlet | Description |
| --- | --- |
| `New-RscMutationActivitySeries` | Run an Activity Series related GraphQL mutation |
| `New-RscMutationAws` | Run an AWS-related GraphQL mutation |
| `New-RscMutationAzure` | Run an Azure-related GraphQL mutation |
| `New-RscMutationCassandra` | Run a Cassandra-related GraphQL mutation|
| `New-RscMutationCluster` | Run a Cluster-related GraphQL mutation|
| `New-RscMutationDb2` | Run a DB2-related GraphQL mutation|
| `New-RscMutationHyperv` | Run a HyperV-related GraphQL mutation|
| `New-RscMutationLdap` | Run an LDAP-related GraphQL mutation|
| `New-RscMutationMongo` | Run a Mongo-related GraphQL mutation|
| `New-RscMutationMssql` | Run a MSSQL-related GraphQL mutation|
| `New-RscMutationNutanix` | Run a Nutanix-related GraphQL mutation |
| `New-RscMutationO365` | Run an Office365-related GraphQL mutation |
| `New-RscMutationOracle` | Run an Oracle-related GraphQL mutation |
| `New-RscMutationSla` | Run an SLA-related GraphQL mutation |
| `New-RscMutationVcenter` | Run a VCenter-related GraphQL mutation |
| `New-RscMutationVsphere` | Run a VSphere-related GraphQL mutation |
| `New-RscMutationVsphereVm` | Run a VSphere VM-related GraphQL mutation |
| `New-RscQueryAccount` | Run an Account-related GraphQL query |
| `New-RscQueryActivitySeries` | Run an Activity Series-related GraphQL query |
| `New-RscQueryAws` | Run an AWS-related GraphQL query |
| `New-RscQueryAzure` | Run an Azure-related GraphQL query |
| `New-RscQueryCassandra` | Run a Cassandra-related GraphQL query |
| `New-RscQueryCluster` | Run a  Cluster-related GraphQL query |
| `New-RscQueryDb2` | Run a DB2-related GraphQL query |
| `New-RscQueryHyperv` | Run an HyperV-related GraphQL query |
| `New-RscQueryLdap` | Run an LDAP-related GraphQL query |
| `New-RscQueryMongo` | Run a Mongo-related GraphQL query |
| `New-RscQueryMssql` | Run a MSSQL-related GraphQL query |
| `New-RscQueryNutanix` | Run a Nutanix-related GraphQL query |
| `New-RscQueryO365` | Run an Office365-related GraphQL query |
| `New-RscQueryOracle` | Run an Oracle-related GraphQL query |
| `New-RscQuerySla` | Run an SLA-related GraphQL query |
| `New-RscQueryVcenter` | Run a VCenter-related GraphQL query |
| `New-RscQueryVsphere` | Run a VSphere-related GraphQL query |
| `New-RscQueryVsphereVm` | Run a VSphere VM-related GraphQL query |

To obtain this list programmatically, you can do:

```powershell
$opCmdlets=(Get-Module RubrikSecurityCloud).ExportedCommands.Keys | Sort-Object | Where-Object { $_ -like 'Invoke-Rsc*' -and $coreCmdlets -notcontains $_ }
```

### Wrapper cmdlets

| Cmdlet | Description |
| --- | --- |
| `Export-RscMssqlDatabase` | Export MSSQL Databases |
| `Get-RscCluster` | Get the list of clusters, or get info about a specific cluster |
| `Get-RscEventSeries` | Get activity series |
| `Get-RscFileset` | Get info about filesets |
| `Get-RscFilesetTemplate` | Get info about fileset templates |
| `Get-RscHost` | Get info about hosts |
| `Get-RscMssqlDatabase` | Get info about MSSQL databases |
| `Get-RscMssqlDatabaseFiles` | Get info about MSSQL database files |
| `Get-RscSnapshot` | Get snapshots |
| `Get-RscVersion` | Get the RSC API server version |
| `Get-RscVsphereVm` | Get info about VSphere VMs |
| `Get-RscVsphereVm` | Get info about VSphere VMs |
| `New-SlaDomain` | Create new SLA domains |

```powershell
$wrappers=(Get-Module RubrikSecurityCloud).ExportedCommands.Keys | Sort-Object | Where-Object { $coreCmdlets -notcontains $_ -and $opCmdlets -notcontains $_}
```

## Finding your way around the SDK

The RSC schema is massive. The SDK introduces the concept of
cmdlets with _commands_ and _subcommands_ to help work with the schema:
instead of a giant flat list of cmdlets, you have a 2-level hierearchy
of cmdlets, with the first level being the _command_ - a general _area_
like MsSQL or AWS, and the second level being the _subcommand_ -
actionable operations like listing, creating, deleting etc. But even with
that, it can be hard to find the cmdlet you need. So let's look at 2
scenarios:

- I know what GraphQL operation I need to run, but I don't know what
  cmdlet to use :point_right: Finding a cmdlet by GraphQL operation
- I know the general area I need to work in, but I don't know what
  cmdlet to use :point_right: Finding a cmdlet by command and subcommand

### Finding a cmdlet by GraphQL operation

Say you know you need to run the `clusterConnection()` query, as we
saw before, you can always call `Invoke-Rsc` but there's a cmdlet
that's a better fit: `New-RscQueryCluster`. How do you find it?

The SDK has a special cmdlet that helps you find cmdlets by GraphQL
operation name: `Get-RscCmdlet`. You can use it like this:

```powershell
PS> Get-RscCmdlet clusterConnection

GqlOperation      InvokeCommand
------------      -------------
clusterConnection New-RscQueryCluster -List
```

Note that the output says `New-RscQueryCluster -List` and not
just `New-RscQueryCluster`.

### Finding a cmdlet by command and subcommand

Now say you know you want to send a query within the _cluster_ area, PowerShell
auto-completion is your friend, start by typing `New-RscQuery` and then
pressing `Tab` twice:

```powershell
PS /Users/guirava/sdk> New-RscQuery
New-RscQueryAccount         New-RscQueryMongo
New-RscQueryActivitySeries  New-RscQueryMssql
New-RscQueryAws             New-RscQueryNutanix
New-RscQueryAzure           New-RscQueryO365
New-RscQueryAzureO365       New-RscQueryOracle
New-RscQueryCassandra       New-RscQuerySla
New-RscQueryCluster         New-RscQueryVcenter
New-RscQueryHyperv          New-RscQueryVsphere
New-RscQueryLdap            New-RscQueryVsphereVm
```

Now you can see `New-RscQueryCluster` is one of the options.

Let's see what subcommands are available for `New-RscQueryCluster`:

```powershell
PS> Get-RscHelp New-RscQueryCluster

Name             Description
----             -----------
Cloud            List of Cloud Clusters with cloud information …
Node             Get list of nodes in this Rubrik cluster…
List             List of the available cluster objects …
Cluster          A cluster object. [GraphQL: cluster]
Dns              Rubrik cluster DNS information. [GraphQL: clusterDns]
Proxy            Rubrik cluster proxy information. [GraphQL: clusterProxy]
Ntpserver        Get NTP Servers…
Networkinterface Get network interfaces for a Rubrik Cluster cluster …
Floatingip       Get a list of a clusters always-available Ips …
Vlan             Rubrik cluster VLAN information. [GraphQL: clusterVlans]
Defaultgateway   Get current default gateway…
Websignedcertif… Get the signed certificate for Web server …
Ipmi             Get IPMI details…
Certificate      Get all certificates…
Webcertsandipmi  Get web server certificate and IPMI details for multiple clus…
Operationjobpro… Get updates on the job progress of the Rubrik cluster operati…
Ipv6mode         Rubrik cluster IPv6 mode. [GraphQL: clusterIpv6Mode]
Csr              Get the cluster certificate signing request …
Typelist         [GraphQL: clusterTypeList]
Groupbyconnecti… [GraphQL: clusterGroupByConnection]
Withconfigprote… A cluster object with config protection information. …
Rcvlocation      List Rubrik Cloud Vault locations of the cluster. …
Connected        List all connected clusters. …
Replicationtarg… All replication targets for a cluster. …
Encryptioninfo   Filter clusters by encryption information. …
Hostfailover     Get details of the given host failover cluster. …
Globalfilesearc… All files and folders matching input filters. …
K8s              [GraphQL: k8sClusters]
Window           A Windows Cluster. [GraphQL: windowsCluster]
Globalsla        Global SLA Domains protecting at least one object on the spec…
Registrationpro… Info about the cluster product types the user is entitled to.…
Vcd              List of vCloud Director clusters. …
Totpackstatus    Checks whether acknowledgement of the Time-based …

```

Perousing the list, you can see that `List` is the subcommand you want.

### Determining a cmdlet's inputs

Now that you've found the cmdlet you want, how do you know what
parameters it takes?

In GraphQL, a given operation needs to be given a set of _arguments_, and
a _field specification_ that determines what fields are returned. In the
context of the SDK, we call the arguments `Var` and the field specification
`Field` (because PowerShell has the convention to use singular nouns).

You can see the arguments and fields for a given cmdlet by using the
`-GetInput` parameter to `New-RscQueryCluster`:

```powershell
PS> New-RscQueryCluster -List -GetInput

Op   Var                                             Field
--   ---                                             -----
List {[before, ], [filter, ], [after, ], [first, ]…} ClusterConnection
```

Note that when passing `-GetInput` to a cmdlet, it does not actually
reach out to the RSC API server, but only return info about its inputs.

Also note that you are only required to pass arguments that are
required by the GraphQL operation. For example, the `List` operation
does not require any arguments, so you can call it like this:

```powershell
PS> New-RscQueryCluster -List
```

and the SDK automatically fills in the field specification.

Now let's say you only want to retrieve the first 3 clusters, you can
pass the `first` argument like this:

```powershell
$query=(New-RscQueryCluster -Operation List)
$query.Var.first=3
```

Subfields can also contain arguments. You can pass subfield
arguments like this:

```powershell
$query=(New-RscQueryVspherevm -Operation NewList)
$query.Field.Nodes[0].Vars.VsphereVirtualDisks.Count=3
```

The field `Nodes` contains a subfield called `VsphereVirtualDisks`.
`VsphereVirtualDisks` contains an argument called `Count`. In the example,
`Nodes[0].Vars` is a directory of all subfields under `Nodes` that contain
arguments.

If the field specification is not given, the SDK fills it in automatically
with sensible defaults, but you can also specify it yourself:

Let's look at what the default field spec looks like for the `Nodes` field:

```powershell
PS> (New-RscQueryCluster -List -Var $query.Var).Nodes[0]

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
Let's add it to the field spec:

```powershell
$query.Field.Nodes[0].Version="fetch"
```

Here we set it to `"fetch"` but anything would work.

Now let's run the command again, with the new field spec:

```powershell
PS> (New-RscQueryCluster -List -Var $query.Var -Field $query.Field).Nodes[0]

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

see [SDK Architecture](./sdk_architecture.md)
