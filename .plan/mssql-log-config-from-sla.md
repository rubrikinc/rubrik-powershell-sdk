# Plan: Add `-MssqlLogConfigFromSla` to Protect-RscWorkload and Protect-RscLinkedWorkload

## Context

**JIRA:** SPARK-743168

For MSSQL workloads (especially SQL AAG), customers need to set the
"Follow the log configuration in the SLA Domain" option when protecting
workloads. Today this requires a two-step workflow:

1. Assign SLA via `Protect-RscWorkload` or `Protect-RscLinkedWorkload`
2. Separately call `Set-RscMssql*` cmdlets to set log config

The RSC UI does both in a single action. This plan adds a
`-MssqlLogConfigFromSla` switch to both `Protect-*` cmdlets so the SDK
matches the UI behavior in a single call.

## GraphQL Mutation

The follow-up mutation is `assignMssqlSlaDomainPropertiesAsync`. Its input
shape:

```graphql
mutation assignMssqlSlaDomainPropertiesAsync(
  $input: AssignMssqlSlaDomainPropertiesAsyncInput!
) {
  assignMssqlSlaDomainPropertiesAsync(input: $input) {
    items { objectId, slaDomainId }
  }
}
```

Key input fields:

| Field                                                  | Value                          |
|--------------------------------------------------------|--------------------------------|
| `input.userNote`                                       | `""` (empty string)            |
| `input.updateinfo.ids`                                 | Array of workload IDs          |
| `input.updateinfo.mssqlSlaPatchProperties.configuredSLADomainId` | `$Sla.Id`            |
| `input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hasLogConfigFromSla` | `$true` |
| `input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention`    | `-1`    |

The `hostLogRetention = -1` signals "use SLA default" (matches RSC UI behavior).

## Files to Modify

### 1. `Toolkit/Public/Protect-RscLinkedWorkload.ps1`

Add `-MssqlLogConfigFromSla` switch parameter.

**Parameter definition:**

```powershell
# For MSSQL workloads: inherit log backup configuration from the SLA Domain
[Parameter()]
[switch]$MssqlLogConfigFromSla,
```

**Comment-based help additions:**

```powershell
.PARAMETER MssqlLogConfigFromSla
For MSSQL workloads: after linking and assigning the SLA, automatically
set the database to inherit its log backup configuration from the SLA Domain
(equivalent to the RSC UI option "Follow the log configuration in the SLA Domain").
This fires a follow-up assignMssqlSlaDomainPropertiesAsync mutation.

.EXAMPLE
Link two AGs and use the SLA Domain's log backup configuration:

$ag1 = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "Foo" -Cluster (Get-RscCluster -Name "Bar") -Relic:$false -Replica:$false
$ag2 = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "Foo" -Cluster (Get-RscCluster -Name "Baz") -Relic:$false -Replica:$false
Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 -LinkingOperation LINK -AssignmentType PROTECT_WITH_SLA_ID -Sla (Get-RscSla -Name "Bronze") -MssqlLogConfigFromSla
```

**Behavior:**

- When `-AsQuery` is combined with `-MssqlLogConfigFromSla`, emit a warning:
  `"-AsQuery returns the primary query only. The -MssqlLogConfigFromSla follow-up mutation is not included."`
- After the primary `manageProtectionForLinkedObjects` mutation succeeds,
  fire the follow-up `assignMssqlSlaDomainPropertiesAsync` mutation using
  both workload IDs (`$InputObjects[0].id`, `$LinkedObject.id`)
- Wrap the follow-up in `try/catch` — on failure, warn but do not throw
  (the SLA assignment already succeeded)

**Follow-up mutation code:**

```powershell
if ($MssqlLogConfigFromSla) {
    if (-not $Sla) {
        throw "-MssqlLogConfigFromSla requires -Sla to be specified."
    }
    $mssqlQuery = New-RscMutation -GqlMutation assignMssqlSlaDomainPropertiesAsync
    $mssqlQuery.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.AssignMssqlSlaDomainPropertiesAsyncInput
    $mssqlQuery.Var.input.userNote = ""
    $mssqlQuery.Var.input.updateinfo = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaDomainAssignInfoInput
    $mssqlQuery.Var.input.updateinfo.ids = @($InputObjects[0].id, $LinkedObject.id)
    $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaPatchPropertiesInput
    $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.configuredSLADomainId = $Sla.Id
    $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaRelatedPropertiesInput
    $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hasLogConfigFromSla = $true
    $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention = -1
    try {
        $mssqlQuery.invoke() | Out-Null
    } catch {
        Write-Warning "SLA assigned successfully, but failed to set MSSQL log config from SLA: $_"
    }
}
```

### 2. `Toolkit/Public/Protect-RscWorkload.ps1`

Same `-MssqlLogConfigFromSla` switch parameter, same follow-up mutation logic.

**Differences from `Protect-RscLinkedWorkload`:**

| Aspect         | Protect-RscLinkedWorkload              | Protect-RscWorkload                    |
|----------------|----------------------------------------|----------------------------------------|
| Workload IDs   | `@($InputObjects[0].id, $LinkedObject.id)` | `$query.Var.Input.ObjectIds`      |
| Placement      | After `$query.invoke()` in else-branch | After `Invoke-Rsc -Query $query`       |
| `-AsQuery`     | Warning about missing follow-up        | Not applicable (no `-AsQuery` in this cmdlet) |

### 3. `Toolkit/Tests/e2e/Protect-RscLinkedWorkload.Tests.ps1`

Add two Pester tests:

```powershell
It -Name 'accepts -MssqlLogConfigFromSla parameter' -Test {
    $ag1 = Get-RscType -Name MssqlAvailabilityGroup
    $ag2 = Get-RscType -Name MssqlAvailabilityGroup
    $sla = Get-RscType -Name GlobalSlaReply
    # AsQuery returns before the follow-up mutation fires,
    # so this validates the parameter is accepted
    $query = Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 `
        -LinkingOperation LINK -Sla $sla -AssignmentType PROTECT_WITH_SLA_ID `
        -MssqlLogConfigFromSla -AsQuery
    $query | Should -BeOfType [RubrikSecurityCloud.RscQuery]
}

It -Name '-MssqlLogConfigFromSla requires -Sla' -Test {
    $ag1 = Get-RscType -Name MssqlAvailabilityGroup
    $ag2 = Get-RscType -Name MssqlAvailabilityGroup
    { Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 `
        -LinkingOperation LINK -AssignmentType PROTECT_WITH_SLA_ID `
        -MssqlLogConfigFromSla } | Should -Throw "*requires -Sla*"
}
```

## Design Decisions

| Decision | Rationale |
|----------|-----------|
| Switch parameter (not boolean) | PowerShell convention for opt-in flags; `-MssqlLogConfigFromSla` reads naturally |
| Follow-up mutation (not combined) | The GraphQL API requires two separate mutations — there is no single mutation that assigns SLA + sets MSSQL log config |
| Warn on failure, don't throw | The primary SLA assignment already succeeded; failing the follow-up shouldn't undo the protection |
| `-Sla` required when switch is set | The log config mutation needs `configuredSLADomainId`; runtime check with clear error message |
| `hostLogRetention = -1` | Matches RSC UI behavior — signals "use SLA default" rather than a custom retention value |
| `AsQuery` warning in linked variant | User should know the returned query object doesn't include the follow-up mutation |
| PS 5.1 compatible syntax | No `??`, `?.`, ternary, or pipeline chain operators — required by project conventions |

## Verification

```powershell
# Build
make build

# Run tests
./Utils/Test-RscSdk.ps1 -SkipCoreTests

# Manual E2E: protect a SQL AAG with -MssqlLogConfigFromSla
$ag1 = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "Foo" `
    -Cluster (Get-RscCluster -Name "Bar") -Relic:$false -Replica:$false
$ag2 = Get-RscMssqlAvailabilityGroup -AvailabilityGroupName "Foo" `
    -Cluster (Get-RscCluster -Name "Baz") -Relic:$false -Replica:$false
Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 `
    -LinkingOperation LINK -AssignmentType PROTECT_WITH_SLA_ID `
    -Sla (Get-RscSla -Name "Bronze") -MssqlLogConfigFromSla

# Verify in RSC UI: the AG should show "Follow the log configuration in the SLA Domain" enabled
```

## Key Reference Files

| File | Purpose |
|------|---------|
| `Toolkit/Public/Protect-RscLinkedWorkload.ps1` | Linked workload protection (SQL AAG cross-cluster) |
| `Toolkit/Public/Protect-RscWorkload.ps1`       | Single workload protection                         |
| `Toolkit/Tests/e2e/Protect-RscLinkedWorkload.Tests.ps1` | Pester tests for linked workload cmdlet   |
