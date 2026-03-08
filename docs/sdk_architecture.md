# SDK Architecture

The SDK is internally composed of two layers:

- __GQL-SDK__ is the lower layer:
  it is a GraphQL client that handles the
  communication with the RSC GraphQL API, and
  provides:
    - the core cmdlets (`New-RscQuery`, `New-RscMutation`, `Invoke-Rsc`, etc.)
    - the domain cmdlets (generated, one per API domain)
- __SDK-Extensions__ is the upper layer. It provides:
    - the wrapper cmdlets (handwritten PowerShell scripts)

Note that this distinction is not visible to the user;
cmdlets and types from both layers are exposed
in the same module. For example, both
`Get-RscCluster` and `New-RscQuery -Gql clusterConnection` are
available to the user, but the latter uses
the GQL-SDK layer, and the former
is part of the SDK-Extensions layer.

## GQL-SDK

### Introduction

- Auto-generated SDK
- Rubrik GraphQL schema has over 1000 operations
- Use `New-RscQuery -Gql <queryName>` to create a query object
  for any GraphQL query by name
- Use `New-RscMutation -Gql <mutationName>` for mutations

### Creating a Query

```powershell
# Create a query by GraphQL name
$q = New-RscQuery -Gql clusterConnection

# Find query names by keyword
Get-RscCmdlet cluster
```

### Working with Inputs

- Inputs: Variables and Fields
    - Direct match with GraphQL:
        - Variables = Arguments to the GQL Operation,
        - Fields = Fields in the response.
- Using `.Info()` on the query object
    - Example: `(New-RscQuery -Gql clusterConnection).Info()` returns
      information about the operation's variables and field types
- Modifying inputs
    - Set the value of `Var` and `Field` and then invoke the query
- Workflow:
    1. Create the query object
    2. Modify `Var` and `Field`
    3. Invoke the query

## SDK-Extensions

- Handwritten PowerShell scripts that wrap calls around `New-RscQuery`
  and `New-RscMutation` calls
- A few are provided by Rubrik Engineering
- Community is encouraged to contribute

### Creating an Extension

- Connect to RSC if needed
- Create a query with `New-RscQuery -Gql` or `New-RscMutation -Gql`
- Set variables and fields as required
- Call `Invoke-Rsc` to execute the query

### Example: Get-RscCluster.ps1

- Parameters: First, Detail
- Connect to RSC if needed
- Create the query (`New-RscQuery -Gql clusterConnection`)
- Set variables and field profile
- Invoke the query
- Filter and return the results
