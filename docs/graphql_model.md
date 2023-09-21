# How the SDK works with GraphQL under the covers

This section is for advanced users who want to understand how the SDK
works under the covers.

## Limitations

The SDK is not a full GraphQL client, it only supports a subset of
GraphQL features.

### Aliases

The SDK does not support aliases.

For example, the label `objects` in the following will not work:

  ```graphql
  query getSLADomainByName($slaName: String!) {
    objects: slaDomains(filter: {field: NAME, text: $slaName}) {
      nodes { name id }
    }
  }
  ```

  If you need to run a field more than once (with different arguments),
  you'll need to run the query multiple times.

### Variables on sub-fields

The SDK does not support variables on sub-fields.

## Meta-information about the GraphQL Schema

The SDK cross-references the GraphQL Schema in multiple ways.

### Schema types that implement a given interface

Given a GraphQL interface, the SDK can find the types that implement
that interface. For example, to answer the question "what are the
GraphQL types that implement the interface `GenericSnapshot`?":

```powershell
PS> [RubrikSecurityCloud.Types.SchemaMeta]::InterfaceImpls("GenericSnapshot")
CdmSnapshot
CloudDirectSnapshot
PolarisSnapshot
```

### Schema types that are part of a union

Given a GrqphQL object, the SDK can find the union types that it is
part of. For example, to answer the question "what are the GraphQL
unions that include the type `ClusterType`?":

```powershell
PS> [RubrikSecurityCloud.Types.SchemaMeta]::UnionMembership("ClusterType")
ActivitySeriesGroupByInfo
ClusterGroupByInfo
SnappableGroupByInfo
TaskSummaryGroupByInfo
```

### List of all GraphQL root fields

Root fields are listed in an enum:

```powershell
PS> [RubrikSecurityCloud.Types.SchemaMeta+GqlRootFieldName]

IsPublic IsSerial Name                                     BaseType
-------- -------- ----                                     --------
False    True     GqlRootFieldName                         System.Enum
```

### SDK Operation lookup by root field name

```powershell
PS> [RubrikSecurityCloud.Types.SchemaMeta]::RscOpLookupByGqlRootField("clusterConnection")

CmdletName             CmdletSwitchName GqlRootFieldName
----------             ---------------- ----------------
New-RscQueryCluster List             clusterConnection
```

### Root field lookup by return type

GraphQL schema objects are mapped to .NET types.
Given a .NET type, the SDK can find the GraphQL root fields that
return that type. For example, to answer the question "what are the
GraphQL root fields that return the type `ClusterConnection`?":

```powershell
PS> [RubrikSecurityCloud.Types.SchemaMeta]::GqlRootFieldLookupByReturnType("ClusterConnection")
allClusterConnection
clusterConnection
clusterWithConfigProtectionInfo
clusterWithUpgradesInfo
protectedClustersForGlobalSla
radarClusterConnection
```
