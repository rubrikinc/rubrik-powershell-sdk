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
  (for example by running a `Invoke-RscXxx` cmdlet), please open
  an issue on GitHub with the full command you ran, and the
  full error message you got back.

## FAQ2 Nulls in response

Responses from the API server contain fields I did not request, and
they are null. Why?

For example, when running:

```powershell
PS> Invoke-Rsc -Query "query GetVsphereVmList{vSphereVmNewConnection{nodes{id name}}}"
```

I only request `id` and `name`, but I get back a lot more fields:

```powershell
PS> (Invoke-Rsc -Query "query GetVsphereVmList{vSphereVmNewConnection{nodes{id name}}}").Nodes[0]

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
PS> (Invoke-Rsc -Query "query GetVsphereVmList{vSphereVmNewConnection{nodes{id name}}}").Nodes[0] | Remove-NullProperties

Id             : 0024d4d1-631b-b47d-f610df4b052b
Name           : rubrik-vmware-01
```

## FAQ3 Nulls in response for fields I requested

I understand FAQ2, but I still get nulls in the response for fields
I requested. Why?

Example:

```powershell
Invoke-Rsc -Query "query {clusterConnection{nodes{name, defaultAddress}}}" | Select -ExpandProperty Nodes

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
