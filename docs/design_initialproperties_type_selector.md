# Design: Type Selector Syntax for -InitialProperties

Status: Implemented

## Problem

When a property is a `List<Interface>` (e.g. `nodes` on a Connection type),
`Get-RscType -InitialProperties` creates one instance of EVERY implementing
type. There's no way to target a single type (e.g. just PhysicalHost).

The current workaround is a manual 4-step process:
1. Create the specific type with `Get-RscType -Name PhysicalHost`
2. Set its properties
3. Create the parent Connection object
4. Manually assign `.nodes`

See the unit test "Double interface list" for a worked example.

## Proposed Syntax: `on:<Type>` and `on:*`

After a `List<Interface>` field in a dotted path, the next segment can be
a type selector:

```
# Only PhysicalHost gets id
"nodes.on:PhysicalHost.id"

# All implementing types get id (explicit)
"nodes.on:*.id"

# Backward compatible: same as on:*
"nodes.id"
```

### Rules

1. After a `List<Interface>` field, if the next segment starts with `on:`
   it is a **type selector**, not a property name.
2. `on:*` means all implementing types (explicit expansion).
3. `on:<TypeName>` means only that implementing type.
4. If the next segment does NOT start with `on:`, treat it as `on:*.<segment>`
   for backward compatibility. Existing code like `"nodes.id"` keeps working.
5. Multiple type selectors compose additively (matches GraphQL semantics):
   ```
   "nodes.on:*.name", "nodes.on:Dog.breed"
   → all types get name, Dog also gets breed
   ```

### The `on:` prefix

Borrowed from GraphQL's `... on Type` inline fragment syntax. Using `on:`
avoids ambiguity with property names (`:` never appears in .NET property
names).

### Why not bare type names?

Property lookup is case-insensitive (`BindingFlags.IgnoreCase`), so a
property named `dog` and a type named `Dog` would collide. The `on:`
prefix eliminates this.

## Tab Completion Behavior

After a `List<Interface>` field, the completer shows ONLY:
- `on:*` (all types)
- `on:Dog` (each implementing type)

It does NOT show bare field names like `name` or `id`. If the user types
a bare field name and presses tab, the completer expands it to the
explicit form: `n<tab>` → `on:*.name`.

This means:
- New interactive usage always produces the explicit `on:` form
- Old scripts using bare fields (`"nodes.id"`) still work at runtime
- The completion list is unambiguous

## Underlying Model

The SDK has no way to express interface-level fields without inline
fragments. There is no "preamble area" like GraphQL has:

```graphql
pet {
  name              # preamble — SDK can't express this
  ... on Dog { breed }
}
```

Instead, the SDK always produces:

```graphql
pet {
  ... on Dog { name breed }
  ... on Cat { name }
}
```

The `on:` syntax matches this reality: every field must be under a
type selector because every field ends up inside an inline fragment.

## Impact

- No breaking changes: bare field syntax still works (implicit `on:*`)
- Purely additive: `on:` is new syntax that enables new capabilities
- Eliminates the manual workaround for single-type targeting
- Tab completion guides users toward the explicit form

## Implementation Notes

### Files Changed

- `RscTypeInitializer.cs` — `InitializeTypeWithSelectedProperties` parses `on:`
  segments; `InitializeInterfaceList` accepts a `typeFilter` parameter to filter
  implementing types.
- `Get-RscType.cs` — new `InitialPropertiesCompleter` class attached to
  `-InitialProperties`, offers `on:*` and `on:TypeName` completions after
  `List<Interface>` fields.
- `Get-RscType.Tests.ps1` — tests for `on:*`, `on:TypeName`, multi-type,
  error cases, backward compat, and double interface via `on:`.

### Examples

```powershell
# Only PhysicalHost — one fragment instead of 6
Get-RscType -Name MssqlTopLevelDescendantTypeConnection -InitialProperties nodes.on:PhysicalHost.id

# Two specific types
Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
    -InitialProperties nodes.on:PhysicalHost.id,nodes.on:MssqlDatabase.name

# Double interface — replaces the manual 4-step workaround
Get-RscType -Name MssqlTopLevelDescendantTypeConnection -InitialProperties @(
    "nodes.on:PhysicalHost.id"
    "nodes.on:PhysicalHost.physicalChildConnection.nodes.on:MssqlInstance.id"
)

# Explicit all-types (same as bare field)
Get-RscType -Name MssqlTopLevelDescendantTypeConnection -InitialProperties nodes.on:*.id

# Backward compatible — still works
Get-RscType -Name MssqlTopLevelDescendantTypeConnection -InitialProperties nodes.id
```
