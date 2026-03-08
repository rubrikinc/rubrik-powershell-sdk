# How To Paginate

RSC uses cursor-based pagination for queries that return lists of
objects. These queries return a "connection" type (e.g.,
`ClusterConnection`, `VsphereVmConnection`) with the following
structure:

```
nodes     — the objects on this page
pageInfo  — pagination metadata
  hasNextPage — are there more pages?
  endCursor   — cursor to pass as `after` for the next page
count     — total number of objects matching the query
```

## Basic Pattern

### Fetch a single page

```powershell
$q = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 10 } `
    -AddField PageInfo.HasNextPage, PageInfo.EndCursor

$result = $q | Invoke-Rsc
$result.Nodes           # first 10 clusters
$result.PageInfo        # { HasNextPage = True, EndCursor = "abc..." }
```

### Fetch all pages

```powershell
$allNodes = @()

$q = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 50 } `
    -AddField PageInfo.HasNextPage, PageInfo.EndCursor

do {
    $result = $q | Invoke-Rsc
    $allNodes += $result.Nodes

    # Set cursor for next page
    $q.Var.after = $result.PageInfo.EndCursor
} while ($result.PageInfo.HasNextPage)

Write-Host "Retrieved $($allNodes.Count) clusters total"
```

## Page Size

The `first` variable controls how many objects are returned per page.

- Default page size (if `first` is not set): depends on the query
- SDK connection max page size: controlled by
  `[RubrikSecurityCloud.Config]::ConnectionMaxPageSize` (default: 50)
- The server may enforce its own maximum

## Complete Example: All vSphere VMs

```powershell
$allVms = @()
$pageSize = 100

$q = New-RscQuery -Gql vSphereVmNewConnection `
    -Var @{ first = $pageSize } `
    -AddField PageInfo.HasNextPage, PageInfo.EndCursor, Nodes.Name

do {
    $result = $q | Invoke-Rsc
    $allVms += $result.Nodes
    Write-Host "Fetched $($allVms.Count) of $($result.Count) VMs..."
    $q.Var.after = $result.PageInfo.EndCursor
} while ($result.PageInfo.HasNextPage)

$allVms | Select-Object Id, Name | Format-Table
```

## Tips

- **Always add `PageInfo` fields** when you intend to paginate.
  Use `-AddField PageInfo.HasNextPage, PageInfo.EndCursor`.
- **Use `$result.Count`** to know the total number of matching objects
  (not just on the current page).
- **Reuse the query object** — just update `$q.Var.after` between
  iterations. The field spec and other variables stay the same.
- **Don't use `$q.Var.last` / `$q.Var.before`** unless you need
  backward pagination. Forward pagination with `first`/`after` is
  the standard pattern.

## Related Documentation

- [How To Create a Query](./HOWTO_create_a_query.md) — query creation basics
- [How To Run Mutations](./HOWTO_mutations.md) — creating and modifying resources
- [Developer Manual](./developer_manual.md) — cmdlet overview
