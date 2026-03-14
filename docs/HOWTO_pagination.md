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

## Automatic Pagination

`Invoke-Rsc` **automatically fetches and collates all pages** for you.
You don't need to write pagination loops — just pipe your query and
get all results back at once:

```powershell
$q = New-RscQuery -Gql clusterConnection
$result = $q | Invoke-Rsc
$result.Nodes   # all clusters, across all pages
$result.Count   # total count
```

Behind the scenes, `Invoke-Rsc` detects `PageInfo` in the response,
follows `endCursor` links, and collates all `Nodes` into a single
result.

## Controlling Page Size

The page size (how many objects per API call) is controlled by:

- `[RubrikSecurityCloud.Config]::ConnectionMaxPageSize` (default: 50)
- The `first` variable on the query

```powershell
# Change default page size for all queries in this session
[RubrikSecurityCloud.Config]::ConnectionMaxPageSize = 200
```

## Limiting Total Results

If you set `first` on the query, `Invoke-Rsc` stops after collecting
that many objects total (not per page):

```powershell
# Get exactly the first 25 clusters
$q = New-RscQuery -Gql clusterConnection -Var @{ first = 25 }
$result = $q | Invoke-Rsc
$result.Nodes.Count   # 25 (or fewer if less exist)
```

> **Large datasets**: If you don't set `first`, `Invoke-Rsc` fetches
> *all* matching objects. On environments with thousands of snapshots
> or workloads, this can be slow and memory-intensive. Set `first` to
> cap the total results when you don't need the full set.

## Tips

- **You usually don't need pagination code** — `Invoke-Rsc` handles it.
- **Set `first`** to limit total results on large datasets.
- **Use `$result.Count`** to know the total number of matching objects
  (not just what was fetched).

## Related Documentation

- [How To Create a Query](./HOWTO_create_a_query.md) — query creation basics
- [How To Run Mutations](./HOWTO_mutations.md) — creating and modifying resources
- [Developer Manual](./developer_manual.md) — cmdlet overview
