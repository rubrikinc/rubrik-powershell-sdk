# Retrieving Interface Fields

## TL;DR

Most of the time, you don't need to think about interfaces at all.
`-AddField` handles them automatically:

```powershell
# Add a field that only exists on GlobalSlaReply (not ClusterSlaDomain)
$q = New-RscQuery -GqlQuery slaDomains -AddField Nodes.UiColor

# The SDK places it in the correct fragment automatically
```

Read on if you want to understand how it works under the covers, or if
you need to manipulate interface fields manually.

## Background: How the SDK Represents Fields

In the SDK, a field set to `$null` means "don't retrieve this field".
Any non-null value means "retrieve it" (the actual value doesn't matter
for the request — it's just a marker).

```powershell
$t = [RubrikSecurityCloud.Types.AccountSetting]@{}
$t.IsEulaAccepted = $false       # retrieve this field
$t.IsEmailNotificationEnabled = $true  # retrieve this field too

$q = New-RscQuery -GqlQuery accountSettings -Field $t -FieldProfile EMPTY
$q | Invoke-Rsc
```

Using `-FieldProfile EMPTY` turns off [AutoField](./autofield.md) so
only the fields you explicitly set are retrieved.

## Interfaces in GraphQL vs .NET

In GraphQL, an interface like
[SlaDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/sladomain.doc.html)
is implemented by multiple concrete types
([ClusterSlaDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clustersladomain.doc.html)
and
[GlobalSlaReply](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/globalslareply.doc.html)).
To retrieve fields, you use **fragments**:

```graphql
nodes {
  ... on ClusterSlaDomain { id name version }
  ... on GlobalSlaReply   { id name description uiColor }
}
```

The SDK handles this mapping automatically. There are two cases:
lists of interfaces and single interface objects.

## Case 1: Lists of Interfaces

The `slaDomains` query returns a `SlaDomainConnection` whose `Nodes`
field is a `List<SlaDomain>`. The SDK populates this list with one
element per concrete type:

```powershell
$q = New-RscQuery -GqlQuery slaDomains
$q.Field.Nodes | ForEach-Object { $_.GetType().Name }
# ClusterSlaDomain
# GlobalSlaReply
```

Each element has its own set of selected fields (populated by
AutoField). The SDK generates the correct `... on` fragments
when building the GraphQL query.

### Adding fields to a list of interfaces

Use `-AddField` — the SDK figures out which fragment(s) to put it in:

```powershell
# UiColor only exists on GlobalSlaReply → added to that fragment only
$q = New-RscQuery -GqlQuery slaDomains -AddField Nodes.UiColor

# ProtectedObjectCount exists on both → added to both fragments
$q = New-RscQuery -GqlQuery slaDomains -AddField Nodes.ProtectedObjectCount
```

You can verify with `$q.GqlRequest().Query`.

## Case 2: Single Interface Objects (Composite Objects)

The `slaDomain` query (singular) returns a single `SlaDomain`.
In GraphQL this is straightforward — you still use fragments.
But in .NET, a single field can only hold one object.

The SDK solves this with **composite objects**: a linked list of
concrete types that *looks like* a single object:

```powershell
$q = New-RscQuery -GqlQuery slaDomain -Var @{id="0"}

$q.Field.GetType().Name       # ClusterSlaDomain (the "outer" type)
$q.Field.IsComposite()        # True
```

### Working with composite objects using `.AsList()`

The cleanest way to work with composite objects is `.AsList()`,
which returns a list you can iterate, filter, and index:

```powershell
# List all concrete types in the composite
$q.Field.AsList() | ForEach-Object { $_.GetType().Name }
# ClusterSlaDomain
# GlobalSlaReply

# Filter by type name
$q.Field.AsList().WhereType("GlobalSlaReply")

# Index by type name
$q.Field.AsList()["GlobalSlaReply"]

# Set a field on a specific type
$q.Field.AsList()["GlobalSlaReply"].UiColor = "FETCH"
```

### Adding fields to composite objects

`-AddField` works the same way as with lists:

```powershell
# UiColor is added to the GlobalSlaReply fragment only
$q = New-RscQuery -GqlQuery slaDomain -Var @{id="0"} -AddField UiColor
```

### Alternative: navigating with `.GetNext()`

Composite objects are internally a linked list. You can traverse it
with `.GetNext()`:

```powershell
$current = $q.Field
while ($current -ne $null) {
    Write-Host $current.GetType().Name
    $current = $current.GetNext()
}
# ClusterSlaDomain
# GlobalSlaReply
```

`.GetNext()` returns `$null` at the end of the chain.

This is equivalent to `.AsList()` but more verbose — prefer `.AsList()`
for new code.

## Summary

| Task | Approach |
|------|----------|
| Add a field to an interface query | `-AddField` (handles fragments automatically) |
| Inspect concrete types in a list  | `$q.Field.Nodes \| ForEach-Object { $_.GetType().Name }` |
| Inspect concrete types in a composite | `$q.Field.AsList() \| ForEach-Object { $_.GetType().Name }` |
| Set a field on one concrete type  | `$q.Field.AsList()["TypeName"].FieldName = "FETCH"` |
| Check if a field is composite     | `$q.Field.IsComposite()` |
