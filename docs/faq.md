# RSC PowerShell SDK FAQ

## FAQ1 Query complexity errors

The API server responded to my query with an error like this:

```log
Error: Query reducing error: Query is too expensive. Actual Complexity (100003) >= Threshold Complexity (1001)
```

This means that the query you sent to the API server was too
complex. The API server has a limit on how complex a query can be
(rationale: to prevent denial of service attacks, and help
with rate limiting). The complexity of a query is calculated by
the number of fields requested, the number of nested objects,
and the number of items in lists.

### FAQ1 Resolution

- If it is a query you are running manually, try to reduce the
  number of fields (and nested fields) requested. If needed,
  break up the fields and run multiple queries.
- If you got that error without specifying fields explicitly
  (for example by running `New-RscQuery -Gql clusterConnection`
  or `Get-RscCluster`), please open an issue on GitHub with the
  full command you ran, and the full error message you got back.

## FAQ2 Nulls in response

Responses from the API server contain fields I did not request, and
they are null. Why?

For example, when running:

```powershell
PS> Invoke-Rsc -Gql "query GetVsphereVmList{vSphereVmNewConnection{nodes{id name}}}"
```

I only request `id` and `name`, but I get back a lot more fields:

```powershell
PS> (Invoke-Rsc -Gql "query GetVsphereVmList{vSphereVmNewConnection{nodes{id name}}}").Nodes[0]

Id             : 0024d4d1-631b-b47d-f610df4b052b
Name           : rubrik-vmware-01
GuestOsType    :
ProtectionDate :
Cluster        :
... <more fields> ...
```

### FAQ2 Explanation

The SDK works with PowerShell native objects. In the example above, we
retrieved a `VsphereVm` object. We only requested `id` and `name`, and
we can see these fields populated in the output. However, the object
also contains other fields, which are populated with null values.

The SDK uses the convention that null fields in a request means
that they are not requested, and null fields in a response means
the server did not return a value for them.

### FAQ2 Resolution

You can safely ignore the nulls in the response. If you want to
remove them, you can use the `Remove-NullProperties` cmdlet:

```powershell
PS> (Invoke-Rsc -Gql "query GetVsphereVmList{vSphereVmNewConnection{nodes{id name}}}").Nodes[0] | Remove-NullProperties

Id             : 0024d4d1-631b-b47d-f610df4b052b
Name           : rubrik-vmware-01
```

## FAQ3 Nulls in response for fields I requested

I understand FAQ2, but I still get nulls in the response for fields
I requested. Why?

Example:

```powershell
Invoke-Rsc -Gql "query {clusterConnection{nodes{name, defaultAddress}}}" | Select -ExpandProperty Nodes

Name : ABCDEFGHIJ
DefaultAddress :
... <more fields> ...
```

### FAQ3 Explanation

The API server returned a null value for the field you requested.
If you only look at the response without knowing what was requested,
it is impossible to tell if the field was requested or not.

### FAQ3 Resolution

Cross-reference with the request and only inspect fields that were requested.

## FAQ4 Capturing an error log

When I run the SDK script `some-sdk-script.ps1`,
I get quite a long error message.
How can I capture this error message to a file ?

### FAQ4 Explanation

SDK error messages can indeed be extensive because they often capture the
whole request and the whole response. This is useful for debugging, but
it can be overwhelming.

### FAQ4 Resolution

Use `Start-Transcript` to capture the whole output of the script to a file:

```powershell
PS> Start-Transcript -Path "C:\path\to\output.log"
PS> some-sdk-script.ps1
PS> Stop-Transcript
```

## FAQ5 Authentication errors

I get an error like `UNAUTHENTICATED` or `Token is expired` when
running a query.

### FAQ5 Explanation

The access token retrieved by `Connect-Rsc` has a limited lifetime.
If your session runs long enough, the token expires. Additionally,
authentication fails if the service account file is corrupted, moved,
or contains invalid credentials.

### FAQ5 Resolution

- **Token expired**: Run `Disconnect-Rsc` then `Connect-Rsc` to get a
  fresh token.
- **Bad service account file**: Re-run `Set-RscServiceAccountFile` with
  a fresh JSON file from the RSC UI:
  ```powershell
  Set-RscServiceAccountFile /path/to/new/service_account.json
  Connect-Rsc
  ```
- **Wrong RSC environment**: Check that the service account file matches
  the RSC instance you intend to connect to.

## FAQ6 Field not in response

I expected a field to be in the response but it's null even though
the object supports it.

### FAQ6 Explanation

The SDK uses [AutoField](./autofield.md) to select a default subset
of fields. Not every field is included in the default profile — some
are omitted to keep queries within complexity limits.

### FAQ6 Resolution

Add the missing field explicitly:

```powershell
# Add a specific field
$q = New-RscQuery -Gql clusterConnection -AddField Nodes.Version

# Or use the DETAIL profile for more fields
$q = New-RscQuery -Gql clusterConnection -FieldProfile DETAIL
```

To see all available fields for a query:

```powershell
New-RscQuery -Gql clusterConnection -ValidPatchSet
```

## FAQ7 Schema version mismatch warnings

I see a warning like `SDK schema version does not match server version`.

### FAQ7 Explanation

The SDK is generated from a specific version of the RSC GraphQL schema.
When the server is newer than your SDK, some new operations or fields
may not be available. When the SDK is newer than the server, some
operations may not work.

### FAQ7 Resolution

- Run `Get-RscVersion` to compare your SDK and server versions.
- Update the SDK: `Update-Module RubrikSecurityCloud`
- The SDK is backward compatible for a limited time. If you see
  deprecation warnings, update as soon as possible.

## FAQ8 Should I use AutoField in production?

I'm writing a production script. Should I use AutoField or specify
fields explicitly?

### FAQ8 Explanation

Both are valid in production. The question is: **does your script want
to react to schema changes, or be insulated from them?**

**Use AutoField** when your script's job is to *discover* what's in the
system — reporting, data dumps, audit/inventory, or schema drift
detection. AutoField automatically picks up new fields when the schema
evolves, which is exactly what you want for these use cases.

**Use explicit field specs** when your script *processes* specific known
data — ETL pipelines, integrations with fixed downstream schemas, or
scripts where correctness depends on specific field semantics.

### FAQ8 Resolution

For explicit field selection, use `Get-RscType -InitialProperties`
and `New-RscQuery` with `-FieldProfile EMPTY`:

```powershell
# Fixed query — only these three fields, forever
$fields = Get-RscType -Name ClusterConnection -InitialProperties Nodes.Id,Nodes.Name,Nodes.Status
$q = New-RscQuery -Gql clusterConnection -Field $fields -FieldProfile EMPTY
```

For interface fields, use `on:TypeName` to pin the query to specific
implementing types. This is actually **more deterministic than raw
GraphQL** — a bare GQL query implicitly resolves all types implementing
an interface, including ones added after you wrote the query.

```powershell
# Pinned to Dog and Cat — a new Parrot type won't appear
$fields = Get-RscType -Name PetConnection -InitialProperties @(
    "Nodes.on:Dog.Name"
    "Nodes.on:Cat.Name"
)
```

Be aware that `Get-RscType -InitialProperties "*"` wildcards all leaf
fields on the current type. This is schema-dependent — new leaf fields
will appear when the schema changes — so it's a middle ground between
AutoField and fully explicit selection.

The wildcard is most useful on **small, stable sub-objects** where you
want completeness but the type is narrow enough that new fields are
rare and welcome. For example, `Get-RscSla` uses a fixed field spec
overall, but wildcards schedule details:

```powershell
$fields = Get-RscType -Name GlobalSlaReply -InitialProperties @(
    "Id"
    "Name"
    "Description"
    "ObjectTypes"
    "BaseFrequency.Minute.BasicSchedule.*"   # wildcard here
    "BaseFrequency.Hourly.BasicSchedule.*"
)
```

`BasicSchedule` is a small leaf object — a handful of scalars like
`frequency`, `retention`, `retentionUnit`. It changes rarely, and
when it does, a new scalar there (say `retentionLockMode`) is
almost certainly something you'd want in the SLA output. Spelling
out each field would just create a maintenance burden for no safety
benefit — you'd have to update the script every time a schedule
property is added, and the "update" would always be "yes, include
it."

The rule of thumb: wildcard leaf fields on types where **any new
scalar is likely relevant to your script's purpose**. Keep explicit
field lists on types where new fields could be noise or could change
the meaning of your output.

See [AutoField vs Fixed Queries](./autofield.md#autofield-vs-fixed-queries)
for the full trade-off analysis.

## FAQ9 Boolean field returns wrong value on arrays

When I access a boolean field like `IsReadOnly` on an array, it returns
a different value than what the table display shows:

```powershell
PS> $serviceAccount.Roles

Name                     Description                  IsOrgAdmin IsReadOnly
----                     -----------                  ---------- ----------
Read-only Administrator  Has full read-only access.   False      True

PS> $serviceAccount.Roles.IsReadOnly
False
```

### FAQ9 Explanation

This is a PowerShell property shadowing issue, not an SDK bug.
`Roles` is an array, and `System.Array` implements `IList`, which has
its own `IsReadOnly` property (always `False` for regular arrays).
When you write `$array.IsReadOnly`, PowerShell resolves the array's
own property instead of enumerating the field on each element.

This affects any field whose name collides with a .NET array/collection
property: `Count`, `Length`, `LongLength`, `Rank`, `SyncRoot`,
`IsReadOnly`, `IsFixedSize`, `IsSynchronized`.

### FAQ9 Resolution

Index into the array or pipe to enumerate the elements:

```powershell
# Single element
$serviceAccount.Roles[0].IsReadOnly

# All elements
$serviceAccount.Roles | ForEach-Object IsReadOnly

# Or using the .ForEach() method
$serviceAccount.Roles.ForEach({$_.IsReadOnly})
```
