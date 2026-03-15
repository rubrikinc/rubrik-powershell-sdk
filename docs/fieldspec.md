# Field Spec: Explicit Field Selection with Get-RscType

## Two Approaches to Field Selection

The SDK provides two approaches to control which fields your GraphQL
queries retrieve. They serve different needs:

| Approach    | How it works                            | Best for                            |
|-------------|-----------------------------------------|-------------------------------------|
| [AutoField](./autofield.md) | SDK picks fields automatically via profiles | Exploration, scripts that want "enough data" without specifying every field |
| **Field Spec** | You specify exactly which fields to retrieve | Production scripts, stable integrations, precise control |

### AutoField: Let the SDK Decide

AutoField selects fields automatically based on name-pattern matching
and profile depth. It's great for getting started quickly:

```powershell
$q = New-RscQuery -Gql clusterConnection              # DEFAULT profile
$q = New-RscQuery -Gql clusterConnection -FieldProfile DETAIL  # more fields
$q = New-RscQuery -Gql clusterConnection -AddField Nodes.GeoLocation.Address
```

AutoField results can change across SDK versions as profiles are tuned
or new fields are added to the schema. This is a feature, not a bug: you
automatically get useful new fields without changing your scripts.

But if your script processes specific fields and you don't want surprises,
use a field spec.

### Field Spec: You Decide

A field spec is a typed .NET object where non-null properties mark the
fields to retrieve. The SDK convention: `$null` = "don't request",
non-null = "request".

```powershell
$fields = Get-RscType -Name ClusterConnection -InitialProperties Nodes.Id,Nodes.Name,Nodes.Status
$q = New-RscQuery -Gql clusterConnection -Field $fields -FieldProfile EMPTY
```

This query will always return exactly `id`, `name`, and `status` for
each cluster node — nothing more, nothing less, regardless of SDK
version or schema changes.

`-FieldProfile EMPTY` is important here: it turns off AutoField so only
your explicitly marked fields are included. Without it, AutoField's
default selections would be merged in.

## Building Field Specs with Get-RscType

`Get-RscType -InitialProperties` creates a typed object and sets
sentinel values on the specified properties. The sentinel values (strings
get `"FETCH"`, bools get `$true`, etc.) just mark the field as non-null
— their actual value doesn't matter for the query.

### Basic Usage

```powershell
# Simple flat fields
$fields = Get-RscType -Name Cluster -InitialProperties Id,Name,Status

# Dotted paths walk into nested objects
$fields = Get-RscType -Name ClusterConnection -InitialProperties Nodes.Id,Nodes.Name,Nodes.GeoLocation.Address
```

### Tab Completion

`-InitialProperties` has tab completion that walks the type hierarchy:

```
Get-RscType -Name ClusterConnection -InitialProperties N<tab>
# completes to: Nodes

Get-RscType -Name ClusterConnection -InitialProperties Nodes.N<tab>
# completes to: Nodes.Name, Nodes.NoSqlWorkloadCount, ...
```

Tab completion works best with unquoted, comma-separated values:

```
Get-RscType -Name ClusterConnection -InitialProperties Count,Nodes.I<tab>
```

For multi-line readability, use `@(...)` with each path quoted:

```powershell
$fields = Get-RscType -Name ClusterConnection -InitialProperties @(
    "Nodes.Id"
    "Nodes.Name"
    "Nodes.Status"
    "Nodes.GeoLocation.Address"
)
```

### Inspecting the Field Spec

Use `.AsFieldSpec()` to see the GraphQL field selection your object
produces:

```powershell
$fields = Get-RscType -Name ClusterConnection -InitialProperties Nodes.Id,Nodes.Name
$fields.AsFieldSpec()
# nodes {
#   id
#   name
# }
```

## Interface Fields: The `on:` Type Selector

Interfaces appear in three contexts in the RSC schema. The `on:` type
selector works uniformly in all three:

| Context                | Example type / property                          | What `on:` does                         |
|------------------------|--------------------------------------------------|-----------------------------------------|
| **Root interface**     | `SlaDomain`                                      | Choose which implementing types to include in the composite |
| **List\<Interface\>**  | `MssqlTopLevelDescendantTypeConnection.Nodes`    | Choose which inline fragments to emit   |
| **Single interface**   | `MssqlDatabase.EffectiveSlaDomain`               | Choose which implementing type to instantiate |

### 1. Root Interface

When the type passed to `-Name` is itself an interface:

```powershell
# Specific type — only GlobalSlaReply fragment
$fields = Get-RscType -Name SlaDomain -InitialProperties on:GlobalSlaReply.Id
$fields.AsFieldSpec()
# ... on GlobalSlaReply { id }

# Multiple types — one fragment per type
$fields = Get-RscType -Name SlaDomain -InitialProperties on:ClusterSlaDomain.Id,on:GlobalSlaReply.UiColor
$fields.AsFieldSpec()
# ... on ClusterSlaDomain { id }
# ... on GlobalSlaReply { uiColor }

# All types
$fields = Get-RscType -Name SlaDomain -InitialProperties on:*.Id
```

### 2. List\<Interface\>

When a property is a `List<Interface>` (e.g. a Connection's `Nodes`
field backed by a GraphQL interface), each `on:` selector becomes an
inline fragment:

```powershell
# Default (no on:) — all implementing types
$fields = Get-RscType -Name MssqlTopLevelDescendantTypeConnection -InitialProperties Nodes.Id
$fields.AsFieldSpec()
# nodes {
#   ... on MssqlAvailabilityGroup { id }
#   ... on MssqlDatabase { id }
#   ... on MssqlHost { id }
#   ... on MssqlInstance { id }
#   ... on PhysicalHost { id }
#   ... on WindowsCluster { id }
# }

# Specific type — only PhysicalHost
$fields = Get-RscType -Name MssqlTopLevelDescendantTypeConnection -InitialProperties Nodes.on:PhysicalHost.Id
$fields.AsFieldSpec()
# nodes {
#   ... on PhysicalHost { id }
# }

# Multiple types
$fields = Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
    -InitialProperties @(
        "Nodes.on:PhysicalHost.Id"
        "Nodes.on:MssqlDatabase.Name"
    )
$fields.AsFieldSpec()
# nodes {
#   ... on PhysicalHost { id }
#   ... on MssqlDatabase { name }
# }
```

### 3. Single Interface Property

When a property is a single interface (not a list):

```powershell
# Default (no on:) — picks the first implementing type (alphabetically)
$fields = Get-RscType -Name MssqlDatabase -InitialProperties EffectiveSlaDomain.Name
$fields.EffectiveSlaDomain.GetType().Name  # ClusterSlaDomain

# Specific type — choose which implementing type to use
$fields = Get-RscType -Name MssqlDatabase -InitialProperties EffectiveSlaDomain.on:GlobalSlaReply.UiColor
$fields.EffectiveSlaDomain.GetType().Name  # GlobalSlaReply
```

### Explicit All-Types with `on:*`

`on:*` explicitly requests all implementing types (same as omitting
`on:`, but self-documenting):

```powershell
"Nodes.on:*.Id"    # all types get id — same as "Nodes.Id"
```

### Nested Interfaces

The `on:` syntax composes naturally across multiple interface levels:

```powershell
# PhysicalHost → physicalChildConnection → Nodes (another interface) → MssqlInstance
$fields = Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
    -InitialProperties @(
        "Nodes.on:PhysicalHost.Id"
        "Nodes.on:PhysicalHost.Name"
        "Nodes.on:PhysicalHost.PhysicalChildConnection.Count"
        "Nodes.on:PhysicalHost.PhysicalChildConnection.Nodes.on:MssqlInstance.Id"
        "Nodes.on:PhysicalHost.PhysicalChildConnection.Nodes.on:MssqlInstance.Name"
    )
```

This produces a field spec with exactly two inline fragments (PhysicalHost
at the outer level, MssqlInstance at the inner level) — no other
implementing types are included.

### Tab Completion for `on:`

Tab completion offers `on:` selectors whenever the current position is
an interface — whether at root, after a `List<Interface>` field, or
after a single interface property:

```
Get-RscType -Name SlaDomain -InitialProperties <tab>
# on:*  on:ClusterSlaDomain  on:GlobalSlaReply  ...

Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
    -InitialProperties Nodes.<tab>
# on:*  on:MssqlAvailabilityGroup  on:MssqlDatabase  ...

Get-RscType -Name MssqlDatabase -InitialProperties EffectiveSlaDomain.<tab>
# on:*  on:ClusterSlaDomain  on:GlobalSlaReply  ...
```

### Stability: `on:*` vs `on:TypeName`

Using `on:*` (or omitting `on:` entirely) means your field spec includes
**all** implementing types. If a future schema update adds a new type
that implements the interface, your query automatically grows a new
inline fragment — which may be what you want (exploration, ad-hoc
queries) or may not (stable automation).

This is the same trade-off that exists in GraphQL itself: a query like
`{ pets { name } }` returns fragments for every type implementing `Pet`,
and grows as the schema grows.

For production scripts where you want full control over the query shape,
prefer naming specific types with `on:TypeName`. Your query will only
include the types you listed, regardless of schema changes.

### The `on:` Prefix

The `on:` prefix is borrowed from GraphQL's `... on Type` inline
fragment syntax. It avoids ambiguity with property names (`:` never
appears in .NET property names), so the parser always knows whether a
dotted path segment is a type selector or a property lookup.

## Using Field Specs with Queries

Pass the field spec object to `New-RscQuery -Field` with
`-FieldProfile EMPTY`:

```powershell
$fields = Get-RscType -Name ClusterConnection -InitialProperties Nodes.Id,Nodes.Name,Nodes.Status
$result = New-RscQuery -Gql clusterConnection -Field $fields -FieldProfile EMPTY | Invoke-Rsc
$result.Nodes | Select-Object Id, Name, Status
```

Without `-FieldProfile EMPTY`, the field spec is merged with AutoField's
default selections (which may add fields you didn't ask for).

## When to Use Which

| Situation | Use |
|-----------|-----|
| Exploring the API, trying things out | AutoField (`New-RscQuery -Gql ...`) |
| Quick scripts, ad-hoc queries | AutoField + `-AddField` / `-RemoveField` |
| Production automation, CI/CD | Field Spec (`Get-RscType -InitialProperties`) |
| Stable integration that shouldn't break on SDK updates | Field Spec |
| Query with interface fields where you want specific types | Field Spec with `on:` |
| You want the SDK to pick up new useful fields automatically | AutoField |

## Related Documentation

- [AutoField](./autofield.md) — automatic field selection profiles and patches
- [Retrieving Interface Fields](./retrieving_interface_fields.md) — how
  interfaces and composite objects work under the covers
- [How To Create a Query](./HOWTO_create_a_query.md) — end-to-end query creation
