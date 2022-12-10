# RSC PowerShell SDK Developer Manual

## Installation

```powershell
Install-Module -Name RubrikSecurityCloud
```

## Getting Started

### Connect to RSC

The easiest way to connect to RSC is to use a service account file
(which can be downloaded from the RSC UI). Just store the path to it
in the `RSC_SERVICE_ACCOUNT_FILE` environment variable,
and call `Connect-Rsc` without any parameters.

```powershell
[Environment]::SetEnvironmentVariable(
    "RSC_SERVICE_ACCOUNT_FILE", 
    "/path/to/service/account/file.json", "User"
)
Connect-Rsc
```

It will retrieve an access token and store it in the session state.
Any subsequent calls to `Connect-Rsc` will use the same token.

You can then run any of the commands in the SDK, for example,
to retrieve the current account id:

```powershell
Invoke-RscQueryAccount
```

And end the session with:

```powershell
Disconnect-Rsc
```

## RSC-PowerShell-SDK-GQL

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

## RSC-PowerShell-SDK-Extensions

- Handwritten PowerShell scripts that wrap calls around `Query-Rsc*` and `Mutate-Rsc*` calls
- A few are provided by Rubrik Engineering
- Community is encouraged to contribute

### Creating an Extension

- Connect to RSC if needed
- Get inputs using -GetInputs
- Modify inputs as required
- Call the appropriate `Query-Rsc*` or `Mutate-Rsc*` cmdlet

### Example: List-RscCluster.ps1

- Parameters: First, Detail
- Connect to RSC if needed
- Get inputs
- Modify inputs
- Call the query
