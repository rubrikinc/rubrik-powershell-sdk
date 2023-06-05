# RSC PowerShell SDK Developer Manual

## Getting Started

See : [Getting Started](../README.md)

## Working with GraphQL queries

You only really need these 3 cmdlets
if you want to run raw GraphQL queries;
every other cmdlet in the SDK is a wrapper around
these 3 cmdlets.

- `Connect-Rsc` to connect to RSC
- `Invoke-Rsc` to run GraphQL queries
- `Disconnect-Rsc` to disconnect from RSC

Try: `Get-Help Invoke-Rsc -Full`

Note that you can store your GraphQL queries in files
and then use the `-OperationFile` parameter
to run them. For example:

```powershell
$query = Get-Content -Path Samples/GetVsphereVmList.query.json -Raw
Invoke-Rsc -OperationText $query
```

## Cmdlets

| Cmdlet | Description |
| --- | --- |
| `Connect-Rsc` | Connect to RSC |
| `Disconnect-Rsc` | Disconnect from RSC |
| `Invoke-Rsc` | Run a GraphQL query |
| `Get-RscAccount` | Get the current account info |
| `Get-RscCluster` | Get the list of clusters, or get info about a specific cluster |
| `Export-RscMssqlDatabase` | Export MSSQL Databases |
| `Get-RscEventSeries` | Get activity series |
| `Get-RscMssqlDatabase` | Get info about MSSQL databases |
| `Get-RscSnapshot` | Get snapshots |
| `Get-RscVsphereVm` | Get info about VSphere VMs |
| `Get-RscType` | Work with GraphQL schema types|
| `Invoke-RscMutateActivitySeries` | Run an Activity Series related GraphQL mutation |
| `Invoke-RscMutateAws` | Run an AWS-related GraphQL mutation |
| `Invoke-RscMutateAzure` | Run an Azure-related GraphQL mutation |
| `Invoke-RscMutateCassandra` | Run a Cassandra-related GraphQL mutation|
| `Invoke-RscMutateHyperv` | Run a HyperV-related GraphQL mutation|
| `Invoke-RscMutateLdap` | Run an LDAP-related GraphQL mutation|
| `Invoke-RscMutateMongo` | Run a Mongo-related GraphQL mutation|
| `Invoke-RscMutateMssql` | Run a MSSQL-related GraphQL mutation|
| `Invoke-RscMutateNutanix` | Run a Nutanix-related GraphQL mutation |
| `Invoke-RscMutateO365` | Run an Office365-related GraphQL mutation |
| `Invoke-RscMutateOracle` | Run an Oracle-related GraphQL mutation |
| `Invoke-RscMutateSla` | Run an SLA-related GraphQL mutation |
| `Invoke-RscMutateVsphere` | Run a VSphere-related GraphQL mutation |
| `Invoke-RscQueryAccount` | Run an Account-related GraphQL query |
| `Invoke-RscQueryActivitySeries` | Run an Activity Series-related GraphQL query |
| `Invoke-RscQueryAws` | Run an AWS-related GraphQL query |
| `Invoke-RscQueryAzure` | Run an Azure-related GraphQL query |
| `Invoke-RscQueryCassandra` | Run a Cassandra-related GraphQL query |
| `Invoke-RscQueryCluster` | Run a  Cluster-related GraphQL query |
| `Invoke-RscQueryHyperv` | Run an HyperV-related GraphQL query |
| `Invoke-RscQueryLdap` | Run an LDAP-related GraphQL query |
| `Invoke-RscQueryMongo` | Run a Mongo-related GraphQL query |
| `Invoke-RscQueryMssql` | Run a MSSQL-related GraphQL query |
| `Invoke-RscQueryNutanix` | Run a Nutanix-related GraphQL query |
| `Invoke-RscQueryO365` | Run an Office365-related GraphQL query |
| `Invoke-RscQueryOracle` | Run an Oracle-related GraphQL query |
| `Invoke-RscQuerySla` | Run an SLA-related GraphQL query |
| `Invoke-RscQueryVsphere` | Run a VSphere-related GraphQL query |

## SDK Architecture

The SDK is internally composed of two layers:

- __GQL-SDK__ is the lower layer:
  it is a GraphQL client that handles the
  communication with the RSC GraphQL API, and
  provide a set of cmdlets to run GraphQL queries
  and mutations.
- __SDK-Extensions__ is the upper layer:
  it is a set of handwritten PowerShell
  scripts that wrap calls around GQL-SDK calls
  and provide a more user-friendly interface.

Note that distinction is not visible to the user,
cmdlets and types from both layers are exposed
in the same module. For example, both
`Get-RscAccount` and `Invoke-RscQueryAccount` are
available to the user, but the latter is
part of the GQL-SDK layer, and the former
is part of the SDK-Extensions layer.

## GQL-SDK

### Introduction

- Auto-generated SDK
- Rubrik GraphQL schema has over 1000 operations
  => impractical to have 1 cmdlet per operation
- Operations are grouped under "commands"
  Example: `Query-RscCluster` command regroups all operations from the
  GraphQL Schema that start with the word "cluster"

### Commands and Operations

- Selecting an operation from a command is done with switches like `-List`, `-Connected`, etc.

Example: Query-RscCluster command

- Operations: List, Connected, DefaultGateway, etc.

### Working with Inputs

- Inputs: Arguments and Fields
  - Direct match with GraphQL:
    - Operation = GQL Operation,
    - Arguments = Arguments to the GQL Operation,
    - Fields = Fields in the response.
- Using -GetInputs switch
  - Example: `Query-RscCluster -List -GetInputs` returns
    an object with three fields: Arg, Field, and Op
- Modifying inputs
  - Typically, you don't set `Op` since it's already
    set to the operation you're calling.
  - Set the value of `Arg` and `Field` and then call the query
- Workflow: Define inputs using variables ahead of calling the query
  - Call -GetInputs
  - Modify the inputs
  - Call the query

## SDK-Extensions

- Handwritten PowerShell scripts that wrap calls around `Query-Rsc*` and `Mutate-Rsc*` calls
- A few are provided by Rubrik Engineering
- Community is encouraged to contribute

### Creating an Extension

- Connect to RSC if needed
- Get inputs using -GetInputs
- Modify inputs as required
- Call the appropriate `Query-Rsc*` or `Mutate-Rsc*` cmdlet

### Example: Get-RscCluster.ps1

- Parameters: First, Detail
- Connect to RSC if needed
- Get inputs
- Modify inputs
- Call the query
- Filter the results
