# HOW TO Create A Query

## 0- Introduction

A query is fully defined by 4 elements:

- The API domain
  
  A domain is a group of related API operations.
  For example, the "Cluster" domain contains all the operations
  that are related to clusters.

- The API operation
  
  An operation is a specific API call.
  For example, the "List" operation withing the "Cluster" API
  domain returns a list of clusters.

- The variables
  
  Variables are the parameters that are passed to the API operation.
  For example, the "List" operation withing the "Cluster" API
  domain accepts a "first" variable that specifies how many
  clusters to return.

  Some variables are required, some are optional.

- The fields

  Fields are the data that is returned by the API operation.
  For example, the "List" operation within the "Cluster" API
  domain returns a list of clusters, and each cluster has
  a "name" field.

  If you come from REST, imagine you can place a REST call
  where you can specify what fields you want in the response.

:point_right: The API domain and operation determine **which** query to run.

:point_right: The variables and the fields determine **what** data to return.

The _domain_ and _operation_ are determined by what you want to do.

The _variables_ are rather constrained,
and you can get help to determine them. In particular, the SDK
can generate an example of how to set the variables.

Without this SDK, GraphQL can be challenging when it comes to specifying
the _fields_ to select for retrieval,
because they are not a lists of names, but trees of objects that can
span multiple levels.

We'll see below this SDK provides the concept of
_field profiles_ and _field patches_
that greatly simplify the selection of fields.

## 1- Determine the operation

Jump to the section that applies to you:

### 1-1 You're exploring what's available in a domain

`Get-Help New-RscQuery<Domain> -Full`

`New-RscQuery<Domain> -`(press TAB)

---

### 1-2 You know the API Domain and Operation names

`New-RscQuery<Domain> -<Operation>`

---

### 1-3 You already have a GraphQL file or string

`Invoke-Rsc -GqlQuery <GQL query string>`

---

### 1-4 You know the name of the GraphQL root field

A _root field_ is a query or a mutation.

You need to determine the API domain that root field is part of.
Typically, the domain is part of the root field name, for example
`clusterConnection()` is part of the "Cluster" domain.

You can pass the GraphQL root field name as an Op parameter:

`New-RscQuery<Domain> -Op <GQL root field name>`

Note: if you guessed the domain wrong, you'll get an error message
telling you what the domain is for that root field.

---

## 2- Determine the variables

Jump to the section that applies to you:

### 2-1 You already have a GraphQL file or string

`<GQL query string>` must contains the variables

If working from a `.gql` file, the variables can be defined in the file.

---

### 2-2 You know what the variables are

Pass them as a hashtable to the `-Var` parameter:

`New-RscQuery<Domain> -<Operation> -Var @{<var1>=<value1>; <var2>=<value2>}`

---

### 2-3 You don't know what the variables are

You can get an example of how to set the variables:

`(New-RscQuery<Domain> -<Operation>).Var.Example()`

---

## 3- Determine the fields

Unless you already have a GraphQL file or string
(see section 3-1 below), there are 2 approaches to determine the fields:
Profiles & Patches, and Field objects.

Any given query can use either approach, or a combination of both.

### 3-1 You already have a GraphQL file or string

The fields are listed in the GraphQL file or string.

### 3-2 Profiles & Patches

#### What are field profiles?

A _field profile_ says what fields to select for a given query.

For example `New-RscQueryCluster -List -FieldProfile DEFAULT` uses
the DEFAULT profile to select fields for the "List" operation.

The same profile applied to another query may select different fields,
because a profile is a set of rules on how to select fields. For
example the DEFAULT profile has the rule:

"If there's a top-level field called `id`, select it".

If no field profile is given, the SDK uses the DEFAULT profile,
so the previous example is equivalent to `New-RscQueryCluster -List`.

For most practical purposes, there are 2 profiles to choose from:
`DEFAULT` and `DETAIL`. The `DETAIL` profile selects more fields
on top of the `DEFAULT` profile.

#### What is patching?

A field profile will select fields for a given query, but sometimes
you want to select additional fields, or remove fields that were
selected by the profile.

#### Combining profiles and patches

### 3-3 Field objects

## Working with queries

`<GQL query string>` must contains the fields
If you need help with the field names and types:

```shell
PS> (New-RscQueryCluster -List).Info()
https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clusterconnection.doc.html
```

Say we want to see the snapshot count:

```shell
PS > (New-RscQueryCluster -List -Var @{first=1} -Patch nodes.snapshotCount).Invoke().Nodes[0]|Remove-NullProperties

PauseStatus         : NOT_PAUSED
Status              : DISCONNECTED
SubStatus           : DEFAULT
SystemStatus        : OK
Type                : ROBO
Id                  : 9b429c53-2afe-44b5-b4e4-e3a4308a69fb
IsHealthy           : False
Name                : WestWales
SnapshotCount       : 68
SystemStatusMessage : 1 Node Down.
Version             : 8.0.2-p2-22662
```

Say we want to see the CDM upgrade info:

```shell
PS > (New-RscQueryCluster -List -Var @{first=1} -Patch nodes.cdmUpgradeInfo).Invoke().Nodes[0].CdmUpgradeInfo|Remove-NullProperties

ClusterJobStatus     : READY_FOR_DOWNLOAD
VersionStatus        : UPGRADE_RECOMMENDED
ClusterUuid          : 9b429c53-2afe-44b5-b4e4-e3a4308a69fb
CurrentStateProgress : 0
FastUpgradePreferred : True
FinishedStates       :
OverallProgress      : 0
PendingStates        :
StateMachineStatus   : IDLE
StateMachineStatusAt : 3/13/2023 2:31:44 PM
Version              : 8.0.2-p2-22662
```

## Working with `-Input`

- no field profile (no autofield, no file overrides.
  => FieldProfile is set to EMPTY)
