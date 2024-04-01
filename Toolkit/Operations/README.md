# `Toolkit/Operations` Directory

## `Toolkit/Operations/DEFAULT` Directory

Operation patch files for the DEFAULT field profile.

## `Toolkit/Operations/DETAIL` Directory

Operation patch files for the DETAIL field profile.

## How to write a patch file

Example:

We determined that AutoFieldSpec needs to be tweaked for the query:

```powershell
> $q = New-RscQuery -GqlQuery mssqlDatabaseLiveMounts
>  $q.GqlRequest().query
query QueryMssqlDatabaseLiveMounts($first: Int,$after: String,$sortBy: MssqlDatabaseLiveMountSortByInput,$filters: [MssqlDatabaseLiveMountFilterInput!])
{
  mssqlDatabaseLiveMounts
  (
  first: $first
  after: $after
  sortBy: $sortBy
  filters: $filters
  )
  {
  count
  nodes {
      cdmId
      fid
      isReady
      mountRequestId
      mountedDatabaseId
      ownerId
      unmountRequestId
  }
  pageInfo {
    endCursor
    hasNextPage
    hasPreviousPage
    startCursor
  }
  }
}
```

We want AFS (AutoFieldSpec) to also fill in these 2 fields under Nodes:

- creationDate
- mountedDatabaseName

First, let's make sure building such a query is possible manually:

```powershell
> $q2 = New-RscQuery -Copy $q -AddField Nodes.creationDate,Nodes.mountedDatabaseName
> $q2.GqlRequest().Query
query QueryMssqlDatabaseLiveMounts($first: Int,$after: String,$sortBy: MssqlDatabaseLiveMountSortByInput,$filters: [MssqlDatabaseLiveMountFilterInput!])
{
  mssqlDatabaseLiveMounts
  (
  first: $first
  after: $after
  sortBy: $sortBy
  filters: $filters
  )
  {
  count
  nodes {
      cdmId
      creationDate
      fid
      isReady
      mountRequestId
      mountedDatabaseId
      mountedDatabaseName
      ownerId
      unmountRequestId
  }
  pageInfo {
    endCursor
    hasNextPage
    hasPreviousPage
    startCursor
  }
  }
}
```

so it works. Let's create a patch file for this query.

A patch file is actually written for an _operation_.

The _operation_ is the name of the GraphQL query, here we can see above
in the output of `$q2.GqlRequest().Query`,
it is `QueryMssqlDatabaseLiveMounts`.

Another way to determine the operation name is to use `GqlOperation()`:

```powershell
>  $q2.GqlOperation().Name
QueryMssqlDatabaseLiveMounts
```

A patch file is specific to a given field profile. In our case here,
we want the same patch for both the `DEFAULT` and the `DETAIL` field
profiles.

Let's start with the `DEFAULT` patch file:

Create the file `Toolkit/Operations/DEFAULT/QueryMssqlDatabasesLiveMounts.patch`
and add one entry per field that needs to be added:

```text
+ Nodes.creationDate
+ Nodes.mountedDatabaseName
```

And since we want the same patch for the `DETAIL` profile, we can just
copy the file over:

```powershell
>  cd .\Toolkit\Operations\
>  Copy-Item .\DEFAULT\QueryMssqlDatabaseLiveMounts.patch .\DETAIL\
> cd ..\..
```

and update the Output dir:

```powershell
> . .\Toolkit\Utils\ToolkitDev.ps1
> Update-RscToolkit
```

and let's try it:

```powershell
> $q3 = New-RscQuery -GqlQuery mssqlDatabaseLiveMounts
> $q3.GqlRequest().Query
query QueryMssqlDatabaseLiveMounts($first: Int,$after: String,$sortBy: MssqlDatabaseLiveMountSortByInput,$filters: [MssqlDatabaseLiveMountFilterInput!])
{
  mssqlDatabaseLiveMounts
  (
  first: $first
  after: $after
  sortBy: $sortBy
  filters: $filters
  )
  {
  count
  nodes {
      cdmId
      creationDate
      fid
      isReady
      mountRequestId
      mountedDatabaseId
      mountedDatabaseName
      ownerId
      unmountRequestId
  }
  pageInfo {
    endCursor
    hasNextPage
    hasPreviousPage
    startCursor
  }
  }
}
```
