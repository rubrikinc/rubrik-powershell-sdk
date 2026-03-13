<#
.SYNOPSIS
    Working with snapshots.

.DESCRIPTION
    Interactive sample that demonstrates snapshot operations:
    1. List vSphere VMs to find a workload
    2. Get snapshots for a VM using the Toolkit (Get-RscSnapshot)
    3. Get snapshots using the low-level query (snapshotOfSnappableConnection)
    4. On-demand snapshot (shown as code, not executed)

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json

    This script is read-only — it does not create or delete snapshots.
    Step 4 shows the code but does not execute it.
#>

. "$PSScriptRoot/SampleUtils.ps1"

Connect-Rsc

try {

# ------------------------------------------------------------------
# 1. List vSphere VMs
# ------------------------------------------------------------------
Write-Title "|  Step 1: List vSphere VMs  |"

Write-Message -GreenMessage "Finding VMs to work with..."

# Grab the first 5 VMs using the low-level query (Get-RscVmwareVm
# auto-paginates and returns all, which can be slow on large tenants).
$vms = (New-RscQuery -Gql vSphereVmNewConnection `
    -Var @{ first = 5 } | Invoke-Rsc).Nodes

if (@($vms).Count -eq 0) {
    Write-Message -YellowMessage "  No vSphere VMs found in this tenant. Exiting."
    return
}

$vms | Select-Object Name, Id | Format-Table -AutoSize
Write-Message -GreenMessage "Found $(@($vms).Count) VM(s). We'll use '$($vms[0].Name)' for the next steps."

Write-Code -Pause -CodeSnippet @'
# Quick peek at a few VMs (low-level, avoids fetching all):
$vms = (New-RscQuery -Gql vSphereVmNewConnection `
    -Var @{ first = 5 } | Invoke-Rsc).Nodes

# Or use the Toolkit to get all VMs (auto-paginates):
$allVms = Get-RscVmwareVm

# Or filter by name:
$vm = Get-RscVmwareVm -Name "web-server-01"
'@

# ------------------------------------------------------------------
# 2. Get snapshots using the Toolkit (Get-RscSnapshot)
# ------------------------------------------------------------------
Write-Title "|  Step 2: Snapshots via Toolkit  |"

$vm = $vms[0]
Write-Message -GreenMessage "Getting snapshots for '$($vm.Name)' with Get-RscSnapshot..." `
    -YellowMessage "  Pipe any workload object to Get-RscSnapshot."

$snapshots = $vm | Get-RscSnapshot

if (@($snapshots).Count -gt 0) {
    Write-Message -GreenMessage "$(@($snapshots).Count) snapshot(s) found."
    $snapshots | Select-Object -First 5 Date, Id, IsOnDemandSnapshot |
        Format-Table -AutoSize
    Write-Message -YellowMessage "  (Showing first 5)"
} else {
    Write-Message -YellowMessage "  No snapshots found for this VM."
}

Write-Code -Pause -CodeSnippet @'
# Pipe any workload object to Get-RscSnapshot:
$vm = Get-RscVmwareVm -Name "my-vm"
$vm | Get-RscSnapshot

# Get only the latest snapshot:
$vm | Get-RscSnapshot -Latest

# Filter by date range:
$vm | Get-RscSnapshot -AfterTime "2024-01-01" -BeforeTime "2024-02-01"
'@

# ------------------------------------------------------------------
# 3. Get snapshots using the low-level query
# ------------------------------------------------------------------
Write-Title "|  Step 3: Snapshots via low-level query  |"

Write-Message -GreenMessage "Using New-RscQuery -Gql snapshotOfASnappableConnection..." `
    -YellowMessage "  This is the GraphQL query that Get-RscSnapshot wraps.`n  Useful when you need parameters not exposed by the Toolkit."

$q = New-RscQuery -Gql snapshotOfASnappableConnection `
    -Var @{
        first       = 3
        workloadId  = $vm.Id
    } `
    -AddField Nodes.Date, Nodes.Id, Nodes.IsOnDemandSnapshot, `
              Nodes.ExpirationDate, Nodes.IndexingAttempts

$result = $q | Invoke-Rsc

if (@($result.Nodes).Count -gt 0) {
    Write-Message -GreenMessage "First $(@($result.Nodes).Count) of $($result.Count) snapshots:"
    $result.Nodes | Select-Object Date, Id, IsOnDemandSnapshot |
        Format-Table -AutoSize
} else {
    Write-Message -YellowMessage "  No snapshots returned."
}

Write-Code -Pause -CodeSnippet @'
$vm = Get-RscVmwareVm -Name "my-vm"
$q = New-RscQuery -Gql snapshotOfASnappableConnection `
    -Var @{
        first      = 10
        workloadId = $vm.Id
    } `
    -AddField Nodes.Date, Nodes.Id, Nodes.IsOnDemandSnapshot
$result = $q | Invoke-Rsc
$result.Nodes | Format-Table Date, Id, IsOnDemandSnapshot
'@

# ------------------------------------------------------------------
# 4. On-demand snapshot (shown as code, not executed)
# ------------------------------------------------------------------
Write-Title "|  Step 4: On-demand snapshot (not executed)  |"

Write-Message -GreenMessage "Taking an on-demand snapshot is a mutation." `
    -YellowMessage "  This step shows the code but does NOT execute it.`n  There are two approaches: Toolkit and low-level."

Write-Code -Pause -CodeSnippet @'
# --- Approach A: Cross-workload (recommended) ---
# Works for any workload type (VMs, databases, filesets, etc.)
$vm  = Get-RscVmwareVm -Name "my-vm"
$sla = Get-RscSla -Name "Gold"

$m = New-RscMutation -Gql takeOnDemandSnapshot
$m.Var.input = @{
    workloadIds = @($vm.Id)
    slaId       = $sla.Id
}
$result = $m | Invoke-Rsc

# --- Approach B: vSphere-specific ---
# Uses the vSphere-specific mutation for more control
$m = New-RscMutation -Gql vsphereOnDemandSnapshot
$m.Var.input = @{
    id     = $vm.Id
    config = @{
        slaId = $sla.Id
    }
}
$result = $m | Invoke-Rsc
'@

Write-Title "|  Done!  |"

} catch {
    Write-Warning "Error: $_"
} finally {
    Disconnect-Rsc
}
