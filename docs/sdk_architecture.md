# SDK Architecture

## Overview

The SDK has three layers that stack on top of each other:

```
┌─────────────────────────────────────────────────────────────┐
│  Wrapper Cmdlets  (77 Toolkit scripts, e.g. Get-RscCluster) │
├─────────────────────────────────────────────────────────────┤
│  Domain Cmdlets   (122 generated C#, e.g. New-RscQueryCluster)│
├─────────────────────────────────────────────────────────────┤
│  Core Cmdlets     (10 hand-written C#, e.g. New-RscQuery)    │
├─────────────────────────────────────────────────────────────┤
│  Schema DLL       (~3,100 types, generated from GraphQL schema)│
└─────────────────────────────────────────────────────────────┘
                          │
                          ▼
                   RSC GraphQL API
```

All layers ship in a single PowerShell module (`RubrikSecurityCloud`).
Users can work at any level: Wrapper cmdlets for common tasks,
`New-RscQuery -Gql` for any GraphQL operation by name, or direct
.NET type construction for full control.

## Module Loading

When you `Import-Module RubrikSecurityCloud`, three things happen
in order:

### 1. RootModule: `LoadModule.psm1` → C# DLL

`LoadModule.psm1` detects the PowerShell edition and loads the
compiled DLL from the matching target framework directory:

| PS Edition       | TFM directory | Extra setup                       |
|------------------|---------------|-----------------------------------|
| Desktop (5.1)    | `net481/`     | Registers `AssemblyResolve` handler |
| Core (7+)        | `net6.0/`     | None                              |

On PowerShell Desktop, the module registers a **session-wide**
`AssemblyResolve` handler that redirects five system assemblies
to bundled versions:

1. `System.Runtime.CompilerServices.Unsafe` (6.0.0.0)
2. `System.Numerics.Vectors`
3. `System.Buffers`
4. `System.ComponentModel.Annotations`
5. `System.Text.Json`

This is necessary because .NET Framework 4.8.1 ships older versions
of these assemblies. The handler is fragile — it applies to the
entire AppDomain and can conflict with other modules that bundle
different versions of the same assemblies.

### 2. NestedModules: `PublicFunctions.psm1` → script functions

`PublicFunctions.psm1` loads all script-based functions:

```powershell
$CorePublic   = @(Get-ChildItem -Path $PSScriptRoot\Public\*.ps*1)
$ToolkitPublic = @(Get-ChildItem -Path $PSScriptRoot\Toolkit\Public\*.ps*1)
$Public = $CorePublic + $ToolkitPublic
```

Each file is imported with `Import-Module -Force`, then all functions
are exported by filename:

```powershell
Export-ModuleMember -Function $Public.Basename -Alias *
```

**Important:** the function name defined inside a file must match
the filename. If `Get-RscCluster.ps1` defines `function Get-Foo`,
then `Get-Foo` exists in the session but is not exported — only
`Get-RscCluster` (the basename) gets exported.

### 3. FormatsToProcess: display formatting

The `.psd1` manifest lists `.ps1xml` files from `Toolkit/Format/`
in its `FormatsToProcess` array. These define how SDK types display
in the console (table columns, property sets, etc.).

Do not hand-edit `FormatsToProcess` — the MSBuild target
`GeneratePSD1File` (via `UpdatePsd1.ps1`) regenerates it at build time.

## The Three Cmdlet Layers

### Core Cmdlets (10 hand-written C#)

Located in `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/Cmdlets/`.

These are the foundational cmdlets that everything else builds on:

| Cmdlet              | Purpose                                         |
|---------------------|-------------------------------------------------|
| `New-RscQuery`      | Create a query object (by `-Gql` name or domain) |
| `New-RscMutation`   | Create a mutation object (same interface)        |
| `Invoke-Rsc`        | Send a query to the RSC API and return results   |
| `Connect-Rsc`       | Establish a session with an RSC instance          |
| `Disconnect-Rsc`    | Close the session                                 |
| `Get-RscType`       | Instantiate or inspect .NET types from the schema |
| `Get-RscHelp`       | Browse the GraphQL schema (queries, types, fields) |
| `Get-RscHelp`       | Get help for SDK types and operations             |
| `Set-RscServiceAccountFile` | Configure service account credentials    |
| `New-RscQueryClusterVerify` | (internal validation cmdlet)             |

### Domain Cmdlets (122 generated C#)

Located in `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/generated/`.

One cmdlet per API domain, each grouping multiple operations via the
`-Operation` parameter. Examples:

| Cmdlet                  | Operations (examples)              |
|-------------------------|------------------------------------|
| `New-RscQueryCluster`   | List, Get, Connected, Windows, ... |
| `New-RscMutationSla`    | Create, Update, Delete, Pause, ... |
| `New-RscQueryVmware`    | VmList, Host, Datastore, ...       |

These are auto-generated from the RSC GraphQL schema by an internal
Rubrik pipeline. Do not hand-edit them.

When you use `New-RscQuery -Gql clusterConnection`, the core cmdlet
looks up the GraphQL root field name in `SchemaMeta`, resolves it
to a domain + operation, then dispatches to the matching domain cmdlet
(e.g., `New-RscQueryCluster -Operation List`) via
`PowerShell.Create(RunspaceMode.CurrentRunspace)`.

### Wrapper Cmdlets (77 Toolkit scripts)

Located in `Toolkit/Public/`.

Hand-written PowerShell scripts that provide a user-friendly interface
for common tasks. They follow a consistent pattern:

```
Parse parameters
    ↓
Create query via New-RscQuery -Gql <rootField>
    ↓
Set variables (.Var) using .NET types for filters
    ↓
Select field profile (DEFAULT or DETAIL)
    ↓
If -AsQuery: return query object (for inspection/modification)
    ↓
Invoke-Rsc to execute
    ↓
Unwrap connection (.Nodes) if applicable
    ↓
Remove-NullProperties (unless -IncludeNullProperties)
    ↓
Return result
```

For example, `Get-RscCluster` creates a `clusterConnection` query,
applies filter variables, invokes it, and returns the cluster nodes
with null fields stripped out.

## The Schema Layer

The `RubrikSecurityCloud.Schema` DLL contains all .NET types
generated from the RSC GraphQL schema:

- **~3,100 types** (query results, object models)
- **~980 enums** (status codes, operation modes, etc.)
- **~2,100 input types** (filters, sort specs, mutation inputs)
- **~170 interfaces** (shared type contracts)

These types are available in PowerShell as soon as the DLL loads:

```powershell
# Instantiate an input type
$filter = [RubrikSecurityCloud.Types.ClusterFilterInput]@{
    name = "prod"
}

# Use an enum value
$status = [RubrikSecurityCloud.Types.ClusterStatus]::CONNECTED
```

The schema DLL also includes `SchemaMeta.cs`, which provides
reflection capabilities: looking up GraphQL root field names,
mapping them to domain cmdlets, and listing available operations.
This is what powers `New-RscQuery -Gql`, `Get-RscHelp`, and
tab-completion.

Do not hand-edit files under `RubrikSecurityCloud.Schema/` —
they are regenerated from the upstream schema.

### Null Semantics and Enum Ambiguity

The SDK uses .NET objects both as **field specs** (to describe which
fields to request) and as **response containers** (to hold the
server's answer). The convention:

- A **null** property means "don't request this field."
- A **non-null** property means "request this field." The actual
  value is irrelevant for the request — it's just a marker.

For most types this works cleanly. `Get-RscType -InitialProperties`
sets sentinel values to mark fields as requested:

| Property type     | Sentinel value              |
|-------------------|-----------------------------|
| `string`          | `"FETCH"`                   |
| `bool` / `bool?`  | `true`                     |
| `int` / `int?`    | `0`                        |
| `DateTime?`       | `new DateTime()`           |
| `enum?`           | First enum value (index 0) |

When the response comes back, the server replaces sentinels with
real data. For strings, `"FETCH"` is obviously a sentinel. For
nullable scalars, a null response means the field was empty.

**Enums deserve a note.** `Get-RscType -InitialProperties` sets
enum fields to index 0 (almost always `UNKNOWN` or `UNSPECIFIED`)
to mark them as "requested." This might look like it could create
an ambiguity with actual server responses — but it doesn't.

The field-spec object is only used to generate the GraphQL query
string. The response is deserialized into a **fresh** object
(`JsonConvert.DeserializeObject<T>` in `RscGraphQLClientGenericCall`),
with `NullValueHandling.Ignore` — so any field absent from the JSON
stays `null` on the new object. The sentinel values from the
field-spec object never carry over to the response.

## Query Lifecycle

Here is what happens when you run:

```powershell
New-RscQuery -Gql clusterConnection | Invoke-Rsc
```

### Step 1: Resolve the GraphQL name

`New-RscQuery` receives `-Gql clusterConnection` and calls
`SchemaMeta.RscOpLookupByGqlRootField("clusterConnection")`.
This returns an `RscOp` with domain = `Cluster`,
operation = `List`.

### Step 2: Dispatch to the domain cmdlet

`New-RscQuery` constructs the cmdlet name `New-RscQueryCluster`
and invokes it in the current runspace with `-Operation List`,
passing through any `-Var`, `-Field`, `-FieldProfile`, `-AddField`,
`-RemoveField`, or `-FilePatch` parameters.

### Step 3: Create the RscQuery object

`New-RscQueryCluster -Operation List` creates an `RscQuery` object.
This object holds:
- `.Var` — a typed object for setting query variables
  (filters, sort, pagination)
- `.Field` — a typed object representing the response field
  selection (which fields to request)
- The GraphQL operation metadata (name, type, root field)

### Step 4: AutoField fills the default field spec

If no explicit `-Field` was provided, the AutoField system
populates `.Field` with a default set of fields based on the
field profile (`DEFAULT` or `DETAIL`). Operations patches from
`Toolkit/Operations/` are applied at this stage to add or
remove specific fields.

### Step 5: Invoke-Rsc sends the request

`Invoke-Rsc` receives the `RscQuery` object and:
1. Calls `.GqlRequest()` to serialize the query into a GraphQL
   request (query string + variables JSON)
2. Sends an HTTP POST to the RSC API endpoint
3. Deserializes the JSON response into typed .NET objects
4. Returns the result to the PowerShell pipeline

### Step 6: Result flows back

The typed result object is returned to the pipeline. If this
was called from a Wrapper cmdlet, it typically unwraps the
connection (extracts `.Nodes`) and strips null properties
before returning to the user.

## Toolkit Internals

### Source vs Runtime

Toolkit source files live in the repo under `Toolkit/`:

| Source directory          | Purpose                          |
|---------------------------|----------------------------------|
| `Toolkit/Public/`         | Exported wrapper cmdlets         |
| `Toolkit/Private/`        | Internal helpers                 |
| `Toolkit/Format/`         | `.ps1xml` display formatting     |
| `Toolkit/Operations/DEFAULT/` | Default field profile patches |
| `Toolkit/Operations/DETAIL/`  | Detail field profile patches  |

At build time, MSBuild targets copy these files to `Output/Toolkit/`
(or `Output.Release/Toolkit/` for release builds). The module loads
scripts from the Output directory, not from the source tree.

### Operations Patches

Patch files tweak the auto-generated field selections for specific
GraphQL operations. They live in `Toolkit/Operations/DEFAULT/` and
`Toolkit/Operations/DETAIL/`, with filenames matching the GraphQL
operation name (e.g., `QueryClusterConnection.patch`).

Syntax:
- `+ Nodes.creationDate` — add a field path to the selection
- `-nodes.activitySeriesConnection` — remove a field path

DEFAULT patches typically add a few essential fields.
DETAIL patches typically remove expensive nested connections
to keep queries performant even in expanded mode.

### Dev Workflow

Editing a file under `Toolkit/Public/` does **not** take effect
immediately — the module loads from `Output/Toolkit/`, not the
source tree. Use the dev utilities:

```powershell
. ./Toolkit/Utils/ToolkitDev.ps1   # load dev helpers
Update-RscToolkit                   # copy changed files → Output, reimport, run tests
Update-RscToolkit -SkipTest         # same but skip tests
Get-RscToolkitStatus                # diff source vs Output
```

Typical edit-test cycle:
1. Edit the source file in `Toolkit/Public/`
2. Run `Update-RscToolkit`
3. If tests fail, fix and repeat

## Key Directories

| Path                                                              | What's there                             |
|-------------------------------------------------------------------|------------------------------------------|
| `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/`             | Core module root                         |
| `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/Cmdlets/`     | 10 hand-written C# cmdlets               |
| `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/generated/`   | 122 auto-generated domain cmdlets        |
| `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/Public/`      | Core script functions (.psm1)            |
| `RubrikSecurityCloud/RubrikSecurityCloud.Schema/`                 | Schema DLL (generated, do not edit)      |
| `Toolkit/Public/`                                                 | 77 Wrapper cmdlets (hand-written .ps1)   |
| `Toolkit/Private/`                                                | Internal helpers                         |
| `Toolkit/Format/`                                                 | `.ps1xml` display format definitions     |
| `Toolkit/Operations/`                                             | Field profile patches (DEFAULT/, DETAIL/) |
| `Toolkit/Tests/`                                                  | Pester tests (unit + e2e)                |
| `Toolkit/Utils/`                                                  | Dev utilities (ToolkitDev.ps1, etc.)     |
| `Utils/`                                                          | Build, test, import scripts              |
| `Utils/admin/`                                                    | Release workflow scripts                 |
| `Output/`                                                         | Debug build output (gitignored)          |
| `Output.Release/`                                                 | Release build output (gitignored)        |
