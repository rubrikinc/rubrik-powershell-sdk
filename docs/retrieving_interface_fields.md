# Retrieving Interface Fields

Types are represented differently in GraphQL and in .NET, and this SDK
follows a few conventions to go between the two.

## Recap: Retrieving simple types

Before getting into interfaces, let's first look at simple types.

Take for example the GraphQL type `AccountSetting`:

```graphql
type AccountSetting {
    # Specifies whether the EULA has been accepted.
    isEulaAccepted: Boolean
    # Specifies whether email notifications are enabled.
    isEmailNotificationEnabled: Boolean
}
```

( from the
[schema docs](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/accountsetting.doc.html)
)

It is matched in .NET by the `AccountSetting` class:

```powershell
PS > $t1 = [RubrikSecurityCloud.Types.AccountSetting]@{}
PS > $t1 | Get-Member -MemberType Property

   TypeName: RubrikSecurityCloud.Types.AccountSetting

Name                       MemberType Definition
----                       ---------- ----------
IsEmailNotificationEnabled Property   System.Nullable[bool]
                                        IsEmailNotificationEnabled {get;set;}
IsEulaAccepted             Property   System.Nullable[bool]
                                        IsEulaAccepted {get;set;}
```

Note how the `Boolean` type in GraphQL is represented by `System.Nullable[bool]`.
The reason for `System.Nullable` is because the SDK uses the convention
that all fields are nullable, even if they are not marked as such in the schema.
In the SDK, if a field is set to `$null`, it means that the field is not
to be included in the query. If it is set to anything but `$null`,
it means that the field is to be included in the query.

So here we have a class with 2 scalar fields, if we wanted to retrieve
them, we would set them to anything but $null:

```powershell
PS > $t1 = [RubrikSecurityCloud.Types.AccountSetting]@{}
PS > $t1.IsEulaAccepted = $false
PS > $t1.IsEmailNotificationEnabled = $true
```

Now if `$t1` is sent as part of a query to the API server, both fields will
be retrieved. For example, the `accountSettings` query returns such a type:

```graphql
PS > $q1 = New-RscQuery -GqlQuery accountSettings -Field $t1 -FieldProfile EMPTY
PS > $q1.Invoke()

IsEmailNotificationEnabled IsEulaAccepted
-------------------------- --------------
                      True          False
```

Say we don't want to return `IsEulaAccepted`, we can set it to `$null`:

```powershell
PS > $t1.IsEulaAccepted = $null
PS > $q1 = New-RscQuery -GqlQuery accountSettings -Field $t -FieldProfile EMPTY
PS > $q1.Invoke()

IsEmailNotificationEnabled IsEulaAccepted
-------------------------- --------------
                      True
``` 

(Note: when giving a field object to a query with `-Field` , the SDK's
AutoFieldSpec feature will automatically mark common fields for
retrieval; for the sake of this example, we are manually setting the
fields so we turn off AutoFieldSpec with `-FieldProfile EMPTY`)

## Interfaces

Interfaces are a bit more complex than simple types. In GraphQL, an
interface is a type that other types can implement.

For example, the
[SlaDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/sladomain.doc.html)
interface is implemented by the types
[ClusterSlaDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clustersladomain.doc.html)
and
[GlobalSlaReply](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/globalslareply.doc.html).


### Retrieving fields that are lists of interfaces

The query `slaDomains` returns an
[SlaDomainConnection](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/sladomainconnection.doc.html)
object, which has a `nodes` fields of type `[SlaDomain!]!` in GraphQL,
which is mapped to a `List<RubrikSecurityCloud.Types.SlaDomain>` in .NET :

```powershell
PS > $q2 = New-RscQuery -GqlQuery slaDomains
PS > $q2.Field.Nodes.GetType().FullName
System.Collections.Generic.List`1[[RubrikSecurityCloud.Types.SlaDomain, RubrikSecurityCloud.Schema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

In GraphQL, when retrieving an interface, you specify a fragment for each
type that implements the interface. In the case of `SlaDomain`, it would look
like this:

```graphql
{
    ... on ClusterSlaDomain {
        << fields to retrieve for ClusterSlaDomain >>
    }
    ... on GlobalSlaReply {
        << fields to retrieve for GlobalSlaReply >>
    }
}
```

In the SDK, the Auto Field Spec feature will automatically fill in the
`Nodes` list with 1 element per type that implements the interface:

```powershell
PS > $q2.Field.Nodes | ForEach-Object { $_.GetType().FullName }
RubrikSecurityCloud.Types.ClusterSlaDomain
RubrikSecurityCloud.Types.GlobalSlaReply
PS > $q2.Field.Nodes[0].GetType().Name
ClusterSlaDomain
PS > $q2.Field.Nodes[0].SelectedFields()
CdmId
Fid
Id
IsReadOnly
IsRetentionLockedSla
Name
PolarisManagedId
Version
PS > $q2.Field.Nodes[1].GetType().Name
GlobalSlaReply
PS > $q2.Field.Nodes[1].SelectedFields()
ClusterUuid
Description
Id
IsArchived
IsDefault
IsReadOnly
IsRetentionLockedSla
Name
StateVersion
Version
```

And the resulting query is:

```powershell
PS > $q2.GqlRequest().query
query QuerySlaDomains($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)
{
  slaDomains
  (
  first: $first
  after: $after
  last: $last
  before: $before
  sortBy: $sortBy
  sortOrder: $sortOrder
  filter: $filter
  contextFilter: $contextFilter
  contextFilterInput: $contextFilterInput
  shouldShowSyncStatus: $shouldShowSyncStatus
  shouldShowProtectedObjectCount: $shouldShowProtectedObjectCount
  shouldShowUpgradeInfo: $shouldShowUpgradeInfo
  showRemoteSlas: $showRemoteSlas
  shouldShowPausedClusters: $shouldShowPausedClusters
  )
  {
  nodes {
     ... on ClusterSlaDomain {
      cdmId
      fid
      id
      isReadOnly
      isRetentionLockedSla
      name
      polarisManagedId
      version
    }
     ... on GlobalSlaReply {
      clusterUuid
      description
      id
      isArchived
      isDefault
      isReadOnly
      isRetentionLockedSla
      name
      stateVersion
      version
    }
  }
  count
  pageInfo {
    endCursor
    hasNextPage
    hasPreviousPage
    startCursor
  }
  }
}
```

So in other words, the list of fragments we see in GraphQL is represented
in the SDK as a list of objects, each object representing a type that
implements the interface.

Now say you need to retrieve a field that AutoFieldSpec didn't mark for
retrieval. You can manually set the fields for each type. For example, the
[GlobalSlaReply](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/globalslareply.doc.html)
type has a `uiColor` field that doesn't exist in
[ClusterSlaDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clustersladomain.doc.html).

Adding it to the query will tell AutoFieldSpec to include it in the proper
type:


```powershell
PS > $q3=new-rscquery -GqlQuery slaDomains -AddField Nodes.UiColor
PS > $q3.GqlRequest().Query
query QuerySlaDomains($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)
{
  slaDomains
  (
  first: $first
  after: $after
  last: $last
  before: $before
  sortBy: $sortBy
  sortOrder: $sortOrder
  filter: $filter
  contextFilter: $contextFilter
  contextFilterInput: $contextFilterInput
  shouldShowSyncStatus: $shouldShowSyncStatus
  shouldShowProtectedObjectCount: $shouldShowProtectedObjectCount
  shouldShowUpgradeInfo: $shouldShowUpgradeInfo
  showRemoteSlas: $showRemoteSlas
  shouldShowPausedClusters: $shouldShowPausedClusters
  )
  {
  nodes {
     ... on ClusterSlaDomain {
      cdmId
      fid
      id
      isReadOnly
      isRetentionLockedSla
      name
      polarisManagedId
      version
    }
     ... on GlobalSlaReply {
      clusterUuid
      description
      id
      isArchived
      isDefault
      isReadOnly
      isRetentionLockedSla
      name
      stateVersion
      uiColor
      version
    }
  }
  count
  pageInfo {
    endCursor
    hasNextPage
    hasPreviousPage
    startCursor
  }
  }
}
```

Note that `uiColor` was added in the `GlobalSlaReply` fragment, but not
in the `ClusterSlaDomain` fragment.

If you add a field that is common to both types, it will be added to both.
For example, `ProtectedObjectCount` is common to both types:

```powershell
PS > $q4=new-rscquery -GqlQuery slaDomains -AddField Nodes.UiColor,Nodes.ProtectedObjectCount
PS > $q4.GqlRequest().Query
query QuerySlaDomains($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)
{
  slaDomains
  (
  first: $first
  after: $after
  last: $last
  before: $before
  sortBy: $sortBy
  sortOrder: $sortOrder
  filter: $filter
  contextFilter: $contextFilter
  contextFilterInput: $contextFilterInput
  shouldShowSyncStatus: $shouldShowSyncStatus
  shouldShowProtectedObjectCount: $shouldShowProtectedObjectCount
  shouldShowUpgradeInfo: $shouldShowUpgradeInfo
  showRemoteSlas: $showRemoteSlas
  shouldShowPausedClusters: $shouldShowPausedClusters
  )
  {
  nodes {
     ... on ClusterSlaDomain {
      cdmId
      fid
      id
      isReadOnly
      isRetentionLockedSla
      name
      polarisManagedId
      protectedObjectCount
      version
    }
     ... on GlobalSlaReply {
      clusterUuid
      description
      id
      isArchived
      isDefault
      isReadOnly
      isRetentionLockedSla
      name
      protectedObjectCount
      stateVersion
      uiColor
      version
    }
  }
  count
  pageInfo {
    endCursor
    hasNextPage
    hasPreviousPage
    startCursor
  }
  }
}
```

### Retrieving fields that are single interface objects

The query `slaDomain` returns a single
[SlaDomain](https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/sladomain.doc.html)
object, which is an interface. In GraphQL, you specify a fragment for each
type that implements the interface. The fact that it is a single object
or a list of objects doesn't matter in GraphQL, you can still specify
fragments for each type.

However, in .NET it becomes a bit tricky because the SDK mapped the single
GraphQL field to a single .NET object. In other words, there is only
one `SlaDomain` object in .NET, so how can we specify fragments for each type?

The SDK solves this by using **Composite Objects**. A composite object is
an object that contains a list of objects, each object representing a type
that implements the interface. A Composite Object _looks like_ a single object:

```powershell
PS > $q5 = New-RscQuery -GqlQuery slaDomain -Var @{id="0"}
PS > $q5.Field.GetType().FullName
RubrikSecurityCloud.Types.ClusterSlaDomain
```

(note: the `Var` parameter is used to pass variables to the query, in this
case the `id` variable is arbitrary and not used in the query, but needs
to be set because it is a required parameter)

Note how the resulting `Field` is of type `ClusterSlaDomain`, so at first
look it may seem like the SDK decided to only retrieve `ClusterSlaDomain`.
But it is actually a composite object that has 2 objects in it, one
for `ClusterSlaDomain` and one for `GlobalSlaReply`:

```powershell
PS > $q5.Field.IsComposite()
True
PS > $q5.Field.GetNext().GetType().FullName
RubrikSecurityCloud.Types.GlobalSlaReply
```

The `GetNext()` method returns the next object in the composite object.
It is an internal linked list of objects, terminated by a `$null`.
Here we see that the next object is of type `GlobalSlaReply`,
and if we call `GetNext()` on that object, it will return `$null`.

```powershell
PS > $q5.Field.GetNext().GetNext() -eq $null
True
```

Composite objects get expanded when the query is formed:

```powershell
PS > $q5.GqlRequest().Query
query QuerySlaDomain($id: UUID!,$shouldShowSyncStatus: Boolean,$shouldShowUpgradeInfo: Boolean,$shouldShowPausedClusters: Boolean)
{
  slaDomain
  (
  id: $id
  shouldShowSyncStatus: $shouldShowSyncStatus
  shouldShowUpgradeInfo: $shouldShowUpgradeInfo
  shouldShowPausedClusters: $shouldShowPausedClusters
  )
  {
   ... on ClusterSlaDomain {
    cdmId
    fid
    id
    isReadOnly
    isRetentionLockedSla
    name
    polarisManagedId
    version
  }
   ... on GlobalSlaReply {
    clusterUuid
    description
    id
    isArchived
    isDefault
    isReadOnly
    isRetentionLockedSla
    name
    stateVersion
    version
  }
  }
}
```

And just like with list of interfaces, you can add fields to the query
that are not marked for retrieval by AutoFieldSpec:

```powershell
PS > $q6 = New-RscQuery -GqlQuery slaDomain -Var @{id="0"} -AddField UiColor
PS > $q6.GqlRequest().Query
query QuerySlaDomain($id: UUID!,$shouldShowSyncStatus: Boolean,$shouldShowUpgradeInfo: Boolean,$shouldShowPausedClusters: Boolean)
{
  slaDomain
  (
  id: $id
  shouldShowSyncStatus: $shouldShowSyncStatus
  shouldShowUpgradeInfo: $shouldShowUpgradeInfo
  shouldShowPausedClusters: $shouldShowPausedClusters
  )
  {
   ... on ClusterSlaDomain {
    cdmId
    fid
    id
    isReadOnly
    isRetentionLockedSla
    name
    polarisManagedId
    version
  }
   ... on GlobalSlaReply {
    clusterUuid
    description
    id
    isArchived
    isDefault
    isReadOnly
    isRetentionLockedSla
    name
    stateVersion
    uiColor
    version
  }
  }
}
```

We just saw how to add fields with `-AddField` to composite objects, but
you can also add fields to the individual objects in the composite object -
although it is a bit more complex. You need to use the `GetNext()` method to
navigate the composite object and set the field on the object you want:

```powershell
PS > $q7 = New-RscQuery -GqlQuery slaDomain -Var @{id="0"}
PS > $current = $q7.Field
PS > while ($current -ne $null) {
>>   if ($current.GetType().Name -eq "GlobalSlaReply") {
>>     $current.UiColor = "FETCH"
>>   }
>>   $current = $current.GetNext()
>> }
PS > $q7.GqlRequest().Query
query QuerySlaDomain($id: UUID!,$shouldShowSyncStatus: Boolean,$shouldShowUpgradeInfo: Boolean,$shouldShowPausedClusters: Boolean)
{
  slaDomain
  (
  id: $id
  shouldShowSyncStatus: $shouldShowSyncStatus
  shouldShowUpgradeInfo: $shouldShowUpgradeInfo
  shouldShowPausedClusters: $shouldShowPausedClusters
  )
  {
   ... on ClusterSlaDomain {
    cdmId
    fid
    id
    isReadOnly
    isRetentionLockedSla
    name
    polarisManagedId
    version
  }
   ... on GlobalSlaReply {
    clusterUuid
    description
    id
    isArchived
    isDefault
    isReadOnly
    isRetentionLockedSla
    name
    stateVersion
    uiColor
    version
  }
  }
}
```

### Conclusion

We saw how to retrieve fields that are interfaces, both when they are
lists of objects and when they are single objects. In both cases, there are
2 ways to go about it : Use `-AddField` to add fields to the query, or
manually set the fields on the list objects or composite objects.

It is obviously a lot simpler to use `-AddField`, but if you need to
manipulate the fields in a more complex way, you can always manually set
the fields on the objects.

