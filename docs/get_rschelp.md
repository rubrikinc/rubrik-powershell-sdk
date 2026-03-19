# Get-RscHelp — Schema Browser and Lookup Tool

`Get-RscHelp` is the primary tool for exploring the RSC GraphQL schema.
It replaces the deprecated `Get-RscCmdlet`.

## Quick Start

```powershell
# Search by keyword (across all schema elements)
Get-RscHelp cluster*

# Look up a specific query
Get-RscHelp -Query clusterConnection

# Look up a specific mutation
Get-RscHelp -Mutation createGlobalSla

# Inspect a type's fields
Get-RscHelp Cluster.Name
Get-RscHelp Cluster.*           # all fields on the Cluster type

# Schema statistics
Get-RscHelp -Stats
```

## How It Works

### Default: Schema-Wide Search

With no switch, `Get-RscHelp` searches **all schema elements** — queries,
mutations, types, inputs, enums, interfaces, unions, and scalars.

```powershell
PS> Get-RscHelp sla*

# 47 matches for 'sla*':

 #  Kind     Name                      Info                           Description
 -- ----     ----                      ----                           -----------
  1 Mutation assignSla                 returns SlaAssignResult
  2 Mutation createGlobalSla           returns GlobalSlaReply
  3 Query    slaDomains                returns SlaDomainConnection
  ...
 31 Enum     SlaAssignTypeEnum
 32 Input    SlaFilterInput
 33 Type     GlobalSlaReply
  ...
```

Queries and mutations show their return types. Types, inputs, and enums
are listed by kind.

### Interactive Mode

When running in a terminal (not piped), `Get-RscHelp` enters an
interactive loop after showing results:

```
[1-47] detail  [d] expand all  [name] go to  [Enter] exit
```

- **Number** — show detail for that row (parameters for queries/mutations,
  implementing types for interfaces, etc.)
- **`d`** — toggle expanded view showing details for all matches
- **Name** — type a new search term to navigate (like a browser)
- **Enter** — exit

### Piped / Non-Interactive

When piped or run from a script, `Get-RscHelp` outputs the compact
table and exits — no interactive prompt.

```powershell
# Get all query names matching "cluster"
Get-RscHelp -Query cluster*
```

## Switches

### `-Query <pattern>`

Look up GraphQL queries. An **exact match** shows full operation details
(variables, return type, invocation syntax):

```powershell
PS> Get-RscHelp -Query clusterConnection

Name            Type               Description
----            ----               -----------
GQL Field                          clusterConnection
Invocation                         $query = New-RscQuery -Gql clusterConnection
Var.first       Int                Int
Var.filter      ClusterFilterInput ClusterFilterInput
Field           ClusterConnection  ClusterConnection
```

A **wildcard** lists matching query names:

```powershell
PS> Get-RscHelp -Query cluster*
cluster
clusterCertificates
clusterConnection
...
```

### `-Mutation <pattern>`

Same as `-Query` but for mutations:

```powershell
PS> Get-RscHelp -Mutation createGlobalSla

Name            Type                  Description
----            ----                  -----------
GQL Field                             createGlobalSla
Invocation                            $query = New-RscMutation -Gql createGlobalSla
Var.input       CreateGlobalSlaInput  CreateGlobalSlaInput
Field           GlobalSlaReply        GlobalSlaReply
```

### `-Type <pattern>`

Look up GraphQL object types. An exact match shows which queries
return the type and which accept it as an argument:

```powershell
PS> Get-RscHelp -Type ClusterConnection
# Type: ClusterConnection
# GraphQL fields that return this type:
clusterConnection
# GraphQL fields that accept this type as an argument:
(none)
```

### `-Enum <pattern>`

Look up GraphQL enums. Works the same as `-Type`.

### `-Interface <pattern>`

Look up GraphQL interfaces. Exact match lists implementing types:

```powershell
PS> Get-RscHelp -Interface CdmHierarchyObject
# Types that implement interface CdmHierarchyObject:
VsphereVm
LinuxFileset
WindowsFileset
...
```

Add `-ImplementingTypes` to get just the type list (no usage info):

```powershell
Get-RscHelp -Interface CdmHierarchyObject -ImplementingTypes
```

### `-Input <pattern>`, `-Scalar <pattern>`, `-Union <pattern>`

Same pattern as `-Type` — exact match shows usage, wildcard lists matches.

### Dot Syntax for Field Lookup

Use `TypeName.fieldPattern` to inspect fields on a type:

```powershell
PS> Get-RscHelp Cluster.*

# 42 fields on Cluster:

 # Field                Type        Description
 -- -----                ----        -----------
  1 CdmUpgradeInfo       CdmUpgrade?
  2 DefaultAddress       String
  3 EncryptionEnabled    Boolean?
  4 EstimatedRunway      Int32?
  5 GeoLocation          GeoLoc?
  ...
```

This also supports tab completion — type `Cluster.` and press Tab to
cycle through fields.

### `-Stats`

Show schema statistics: element counts, most-returned types,
largest interfaces, type coverage.

```powershell
PS> Get-RscHelp -Stats

# RSC GraphQL Schema Statistics

Element    Count
-------    -----
Queries      467
Mutations    389
Types       3142
Inputs      2117
Enums        981
Interfaces   173
Unions         4
Scalars       11

  856 root fields, 7284 schema elements total.
```

### `-Cmdlet <name>`

Shortcut for `Get-Help -Full`. Useful for wrapper cmdlets:

```powershell
Get-RscHelp -Cmdlet Get-RscCluster
```

### `-Locations`

Show file system paths used by the SDK (config files, log files, etc.).

### `-About`

Show the SDK about page with animated logo.

## Tab Completion

`Get-RscHelp` registers an argument completer for the `Match` parameter.
It provides completions for:

- **Schema element names** — type `cluster` and Tab cycles through
  `clusterConnection`, `ClusterConnection`, `ClusterFilterInput`, etc.
- **Dot syntax fields** — type `Cluster.` and Tab cycles through
  field names on the `Cluster` type.

## Common Workflows

### "What query do I need for X?"

```powershell
# Search by keyword
Get-RscHelp snapshot*

# Found it: snapshotOfASnappableConnection
# Get the invocation syntax
Get-RscHelp -Query snapshotOfASnappableConnection
```

### "What fields does this type have?"

```powershell
Get-RscHelp ClusterConnection.*
```

### "What types implement this interface?"

```powershell
Get-RscHelp -Interface CdmHierarchySnappableNew -ImplementingTypes
```

### "What accepts/returns this type?"

```powershell
Get-RscHelp -Type VsphereVm
```

## Migrating from Get-RscCmdlet

| Old (`Get-RscCmdlet`)                            | New (`Get-RscHelp`)                              |
|--------------------------------------------------|--------------------------------------------------|
| `Get-RscCmdlet cluster`                          | `Get-RscHelp cluster*`                           |
| `Get-RscCmdlet -ExactMatch clusterConnection`    | `Get-RscHelp -Query clusterConnection`           |
| `Get-RscCmdlet sla`                              | `Get-RscHelp sla*`                               |
| `Get-RscCmdlet -ExactMatch createGlobalSla`      | `Get-RscHelp -Mutation createGlobalSla`          |
| `Get-RscCmdlet -Locations`                       | `Get-RscHelp -Locations`                         |

Key differences:

- `Get-RscHelp` searches **all** schema elements by default, not just
  queries/mutations. The old `Get-RscCmdlet` only searched root fields.
- `Get-RscHelp` has an **interactive mode** — you can drill into results
  without re-running the command.
- `Get-RscHelp` supports **dot syntax** for field inspection and
  tab completion.
- `Get-RscHelp -Query <exact>` shows the `New-RscQuery -Gql` invocation
  syntax directly.

## Known Limitations

- **`-Locations` delegates to the deprecated `Get-RscCmdlet`** internally.
  This is a known issue that will be addressed in a future release.
- **`Clear-Host` is called on every search** in interactive mode, which
  clears your terminal scroll-back. This can be disruptive if you're
  copy-pasting from previous output.
- **Wildcard queries with `-Query`/`-Mutation`** return bare names without
  return types. Use the default schema search (`Get-RscHelp cluster*`)
  for richer output.
- **Field descriptions** depend on an optional `SchemaDescriptions.ps1`
  file. If it's not present, the Description column will be empty.
