# Field Spec: Explicit Field Selection with Get-RscType

## Two Approaches to Field Selection

The SDK provides two field-selection strategies. The choice between them
is not "production vs development" — it's **"do I want to react to
schema changes, or be insulated from them?"**

| Approach    | How it works                            | Best for                            |
|-------------|-----------------------------------------|-------------------------------------|
| [AutoField](./autofield.md) | SDK picks fields automatically via profiles | Exploration, reporting, data dumps, schema drift detection |
| **Field Spec** | You specify exactly which fields to retrieve | ETL, stable integrations, scripts where correctness depends on specific fields |

Both are valid in production. See
[AutoField vs Fixed Queries](./autofield.md#autofield-vs-fixed-queries)
for the full trade-off analysis.

### AutoField: Let the SDK Decide

AutoField selects fields automatically based on name-pattern matching
and profile depth. It's great for getting started quickly, but also
has legitimate production use cases: reporting scripts that want
breadth, audit/inventory scripts that want completeness, and schema
drift sentinels that use new fields as a change signal.

```powershell
$q = New-RscQuery -Gql clusterConnection              # DEFAULT profile
$q = New-RscQuery -Gql clusterConnection -FieldProfile DETAIL  # more fields
$q = New-RscQuery -Gql clusterConnection -AddField Nodes.GeoLocation.Address
```

AutoField results can change across SDK versions as profiles are tuned
or new fields are added to the schema. This is a feature when your
script's job is to *discover* what's in the system. It's a liability
when your script *processes* specific known data — use a field spec
for that.

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
inline fragment — which may be what you want (reporting, discovery)
or may not (ETL, stable integrations).

This is the same trade-off that exists in GraphQL itself — but with an
important difference. In raw GraphQL, `{ pets { name } }` implicitly
resolves *all* implementing types, and you can't prevent the server
from resolving a newly added `Parrot` type. With the SDK's `on:TypeName`
syntax, you produce explicit fragments (`... on Dog { name }`) that
**exclude** types you didn't list. The SDK gives you stronger
determinism than raw GraphQL.

When your script's job is to *discover* what's available, use `on:*`.
When your script *processes* specific known types, name them explicitly
with `on:TypeName` — your query won't change when the schema grows.

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

The question is: **does your script want to react to schema changes
or be insulated from them?**

| Situation | Use | Why |
|-----------|-----|-----|
| Exploring the API, trying things out | AutoField | You want breadth without effort |
| Reporting / data dumps (export to CSV, dashboards) | AutoField | New fields in the report = more data, which is the goal |
| Audit / inventory ("show me everything about X") | AutoField | Completeness is the value |
| Schema drift sentinel (detect when schema changed) | AutoField | New fields are the *signal*, not noise |
| ETL feeding downstream systems with fixed schemas | Field Spec | Surprise fields break consumers |
| Scripts where correctness depends on specific field semantics | Field Spec | You process known fields — extra fields are noise |
| Stable integration that shouldn't change across SDK upgrades | Field Spec | The query is a contract |
| Query with interface fields where you want specific types | Field Spec with `on:` | Pins the query to named types only |

### A note on GraphQL determinism

Even raw GraphQL queries are not fully deterministic. If the schema adds
a new type implementing an interface, `{ pets { name } }` will resolve
that new type — triggering new server-side code paths you didn't
anticipate.

The SDK's field spec with explicit `on:TypeName` selectors is **more
deterministic than raw GraphQL**: it produces `... on Dog { name }`
fragments that won't expand when new types are added. See
[AutoField vs Fixed Queries](./autofield.md#autofield-vs-fixed-queries)
for details.

### Both cmdlets can be dynamic or fixed

`New-RscQuery` and `Get-RscType` both have dynamic capabilities —
it's not one cmdlet per strategy:

- `New-RscQuery` uses AutoField by default. Use `-FieldProfile EMPTY`
  to turn it off entirely.
- `Get-RscType -InitialProperties "*"` wildcards all leaf fields
  (scalars and enums) on the current type — but does not recurse into
  nested objects. It's schema-dependent: new leaf fields will appear
  when the schema changes.
- `Get-RscType` without `on:` (or with `on:*`) expands to all
  implementing types — also schema-dependent. Use `on:TypeName` for
  stability.

## Related Documentation

- [AutoField](./autofield.md) — automatic field selection profiles and patches
- [Retrieving Interface Fields](./retrieving_interface_fields.md) — how
  interfaces and composite objects work under the covers
- [How To Create a Query](./HOWTO_create_a_query.md) — end-to-end query creation
