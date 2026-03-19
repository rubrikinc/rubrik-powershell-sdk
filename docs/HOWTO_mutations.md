# How To Run Mutations

Mutations create, update, or delete resources in RSC. They follow the
same pattern as queries (see [How To Create a Query](./HOWTO_create_a_query.md))
but use `New-RscMutation` instead of `New-RscQuery`.

## 1 — Find the Mutation Name

```powershell
# Search by keyword (shows queries and mutations)
Get-RscHelp sla*
Get-RscHelp snapshot*

# Exact lookup (shows variables, return type, invocation)
Get-RscHelp -Mutation createGlobalSla
```

The output shows the GraphQL field name — that's the name you pass
to `New-RscMutation -Gql`.

## 2 — Create the Mutation Object

```powershell
$m = New-RscMutation -Gql createGlobalSla
```

## 3 — Set Variables

### Inspect available variables

```powershell
$m.Var                    # list all variables
$m.Var.Example()          # show example values
$m.Info()                 # full operation info
```

### Simple variables

```powershell
$m.Var.input = Get-RscType -Name CreateGlobalSlaInput -InitialValues @{
    name        = "Gold-24h"
    description = "24-hour RPO SLA"
}
```

### Complex nested inputs

Many mutations take a single `input` variable that is a complex object.
Use `Get-RscType` to build it:

```powershell
# Build the input object
$input = Get-RscType -Name CreateGlobalSlaInput

# Set scalar fields
$input.name        = "Gold-24h"
$input.description = "24-hour RPO SLA"

# Set nested objects
$freq = Get-RscType -Name BackupFrequency
$freq.retention  = 30
$freq.frequency  = 1
$freq.retentionUnit = "DAYS"
$input.baseFrequency = $freq

# Assign to the mutation
$m.Var.input = $input
```

### Pass variables inline

```powershell
$m = New-RscMutation -Gql createGlobalSla -Var @{
    input = Get-RscType -Name CreateGlobalSlaInput -InitialValues @{
        name = "Gold-24h"
    }
}
```

## 4 — Run the Mutation

```powershell
# Pipe to Invoke-Rsc
$result = $m | Invoke-Rsc

# Or call .Invoke()
$result = $m.Invoke()
```

The return value is a typed object — inspect it like any query result:

```powershell
$result | Remove-NullProperties
```

## Examples

### Take an On-Demand Snapshot

```powershell
# Find the mutation
Get-RscHelp -Mutation createOnDemandBackup

# Build the mutation
$m = New-RscMutation -Gql createOnDemandBackup
$m.Var.input = Get-RscType -Name CreateOnDemandJobInput -InitialValues @{
    objectIds    = @("vm-id-here")
    slaId        = "sla-id-here"
}
$result = $m | Invoke-Rsc
$result | Remove-NullProperties
```

### Assign an SLA to Objects

```powershell
$m = New-RscMutation -Gql assignSla
$m.Var.input = Get-RscType -Name AssignSlaInput -InitialValues @{
    slaDomainAssignType  = "PROTECT_WITH_SLA_ID"
    slaOptionalId        = "sla-id-here"
    objectIds            = @("object-id-1", "object-id-2")
}
$m | Invoke-Rsc
```

### Delete an SLA

```powershell
$m = New-RscMutation -Gql deleteGlobalSla
$m.Var.id = "sla-id-to-delete"
$m | Invoke-Rsc
```

## Error Handling

Mutations can fail for various reasons (permissions, invalid input,
conflicts). Wrap in try/catch:

```powershell
try {
    $result = $m | Invoke-Rsc
    Write-Host "Success: $($result | Remove-NullProperties)"
} catch {
    Write-Host "Mutation failed: $($_.Exception.Message)"
}
```

## Related Documentation

- [How To Create a Query](./HOWTO_create_a_query.md) — same pattern, for queries
- [How To Paginate](./HOWTO_pagination.md) — paginating query results
- [FAQ](./faq.md) — common errors and troubleshooting
