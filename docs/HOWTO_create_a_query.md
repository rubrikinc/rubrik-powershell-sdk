# How To Create a Query

## Overview

A query is defined by three elements:

1. **The GraphQL query name** — which operation to run
   (e.g., `clusterConnection`, `slaDomains`)
2. **Variables** — parameters passed to the operation
   (e.g., how many results, filters)
3. **Fields** — what data to return
   (the SDK selects sensible defaults automatically via
   [AutoField](./autofield.md))

## 1 — Find the Query Name

### You're exploring by keyword

```powershell
Get-RscHelp cluster*                          # search by keyword
Get-RscHelp sla*                              # another example
Get-RscHelp -Query clusterConnection          # exact lookup (shows variables, invocation)
```

### You already know the GraphQL query name

Use it directly:

```powershell
$q = New-RscQuery -Gql clusterConnection
```

### You have a raw GraphQL string or file

```powershell
# Inline string
Invoke-Rsc -Gql "query { clusterConnection { nodes { id name } } }"

# From a file
$gql = Get-Content -Path ./my-query.gql -Raw
Invoke-Rsc -Gql $gql
```

## 2 — Set Variables

### See what variables are available

```powershell
$q = New-RscQuery -Gql clusterConnection
$q.Var                    # list all variables
$q.Var.Example()          # show example values
$q.Info()                 # full operation info (variables + field types)
```

### Pass variables inline

```powershell
$q = New-RscQuery -Gql clusterConnection -Var @{ first = 3 }
```

### Set variables on the query object

```powershell
$q = New-RscQuery -Gql clusterConnection
$q.Var.first = 3
$q.Var.sortBy = "REGISTERED_AT"
```

Variables that are not set default to null and are omitted from the
request. Only required variables must be set.

## 3 — Control Field Selection

The SDK offers two field-selection strategies:

- **AutoField** — the SDK picks fields automatically. Great for
  exploration, reporting, and scripts that want breadth. Fields can
  change across SDK versions as the schema evolves.
- **Field Spec** — you specify exactly which fields to retrieve. Best
  for ETL, stable integrations, and scripts where correctness depends
  on specific fields.

The choice is not "production vs development" — it's whether your
script wants to **react to** schema changes or be **insulated from**
them. See [AutoField vs Fixed Queries](./autofield.md#autofield-vs-fixed-queries)
for the full analysis.

### Use AutoField defaults (simplest)

```powershell
$q = New-RscQuery -Gql clusterConnection
$q | Invoke-Rsc    # returns id, name, status, type, etc.
```

### Choose a field profile

```powershell
# More fields (depth ≤ 1 expansion)
$q = New-RscQuery -Gql clusterConnection -FieldProfile DETAIL

# Nearly all fields (can be very large)
$q = New-RscQuery -Gql clusterConnection -FieldProfile FULL
```

### Add or remove specific fields

```powershell
$q = New-RscQuery -Gql clusterConnection `
    -AddField Nodes.SnapshotCount, Nodes.GeoLocation.Address `
    -RemoveField Nodes.Status
```

### Discover what fields are available

```powershell
# List all valid field paths
New-RscQuery -Gql clusterConnection -ValidPatchSet

# Search for a specific field
New-RscQuery -Gql clusterConnection -ValidPatchSet |
    Where-Object { $_ -match "snapshot" }
```

### Use a field object for full manual control

```powershell
$fieldObj = Get-RscType -Name ClusterConnection -InitialProperties Nodes.Id,Nodes.Name,Nodes.Version
$q = New-RscQuery -Gql clusterConnection -Field $fieldObj -FieldProfile EMPTY
```

This is the **field spec** approach: you specify exactly which fields
to retrieve, and the query never changes unless you change it. The
`-FieldProfile EMPTY` is critical — it turns off AutoField so only
your explicitly marked fields are included.

For interface fields, use `on:TypeName` to pin the query to specific
implementing types (e.g., `Nodes.on:Dog.Name`). This is actually
**more deterministic than raw GraphQL** — a bare GQL query like
`{ pets { name } }` implicitly resolves all implementing types,
including ones added after you wrote the query. The SDK's explicit
fragments don't.

See [Field Spec](./fieldspec.md) for the full guide (including `on:`
type selectors), and [AutoField](./autofield.md) for the automatic
approach.

## 4 — Run the Query

```powershell
# Pipe to Invoke-Rsc
$q | Invoke-Rsc

# Or call .Invoke() on the query object
$q.Invoke()

# One-liner
(New-RscQuery -Gql clusterConnection | Invoke-Rsc).Nodes | Select-Object Id, Name
```

## Examples

### List clusters with snapshot counts

```powershell
$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 5 } `
    -AddField Nodes.SnapshotCount |
    Invoke-Rsc

$result.Nodes | Select-Object Name, SnapshotCount, Status
```

### Get CDM upgrade info

```powershell
$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 1 } `
    -AddField Nodes.CdmUpgradeInfo |
    Invoke-Rsc

$result.Nodes[0].CdmUpgradeInfo | Remove-NullProperties
```

### Inspect the generated GraphQL

```powershell
$q = New-RscQuery -Gql clusterConnection -AddField Nodes.SnapshotCount
$q.GqlRequest().Query    # see the full query text
```

## Related Documentation

- [AutoField](./autofield.md) — how field profiles and patches work
- [Field Spec](./fieldspec.md) — explicit field selection with Get-RscType
- [Retrieving Interface Fields](./retrieving_interface_fields.md) —
  working with GraphQL interfaces and composite objects
- [Developer Manual](./developer_manual.md) — getting started,
  cmdlet overview
