# SDK Architecture

The SDK is internally composed of two layers:

- __GQL-SDK__ is the lower layer:
  it is a GraphQL client that handles the
  communication with the RSC GraphQL API, and
  provide:
    - the core cmdlets
    - the operation cmdlets
    and mutations.
- __SDK-Extensions__ is the upper layer. It provides:
    - the wrapper cmdlets

Note that distinction is not visible to the user,
cmdlets and types from both layers are exposed
in the same module. For example, both
`Get-RscAccount` and `New-RscQueryAccount` are
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

- Selecting an operation from a command is done with switches
  like `-List`, `-Connected`, etc.

Example: Query-RscCluster command

- Operations: List, Connected, DefaultGateway, etc.

### Working with Inputs

- Inputs: Arguments and Fields
    - Direct match with GraphQL:
        - Operation = GQL Operation,
        - Arguments = Arguments to the GQL Operation,
        - Fields = Fields in the response.
- Using -GetInput switch
    - Example: `Query-RscCluster -List -GetInput` returns
      an object with three fields: Var, Field, and Op
- Modifying inputs
    - Typically, you don't set `Op` since it's already
      set to the operation you're calling.
    - Set the value of `Var` and `Field` and then call the query
- Workflow: Define inputs using variables ahead of calling the query
    - Call -GetInput
    - Modify the inputs
    - Call the query

## SDK-Extensions

- Handwritten PowerShell scripts that wrap calls around `New-RscQuery*`
  and `New-RscMutation*` calls
- A few are provided by Rubrik Engineering
- Community is encouraged to contribute

### Creating an Extension

- Connect to RSC if needed
- Get inputs using -GetInput
- Modify inputs as required
- Call the appropriate `New-RscQuery*` or `New-RscMutation*` cmdlet

### Example: Get-RscCluster.ps1

- Parameters: First, Detail
- Connect to RSC if needed
- Get inputs
- Modify inputs
- Call the query
- Filter the results
