<#
.SYNOPSIS
    Working with snapshots.

.DESCRIPTION
    This sample demonstrates:
    1. Listing snapshots for a vSphere VM
    2. Taking an on-demand snapshot

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json
#>

Connect-Rsc

# ------------------------------------------------------------------
# 1. List vSphere VMs (to find an object to snapshot)
# ------------------------------------------------------------------
Write-Host "Listing vSphere VMs..."
$vms = (New-RscQuery -Gql vSphereVmNewConnection `
    -Var @{ first = 5 } | Invoke-Rsc).Nodes
$vms | Select-Object Id, Name | Format-Table -AutoSize

if ($vms.Count -eq 0) {
    Write-Host "No vSphere VMs found. Exiting."
    Disconnect-Rsc
    return
}

# ------------------------------------------------------------------
# 2. Get snapshots for the first VM
# ------------------------------------------------------------------
$vmId = $vms[0].Id
Write-Host "`nSnapshots for VM '$($vms[0].Name)':"

$q = New-RscQuery -Gql vSphereVmNewConnection `
    -Var @{ first = 1 } `
    -AddField Nodes.NewestSnapshot.Date, Nodes.NewestSnapshot.Id, `
              Nodes.OldestSnapshot.Date, Nodes.OldestSnapshot.Id

# Filter to our specific VM
$filter = Get-RscType -Name Filter -InitialValues @{
    field = "IS_RELIC"
    texts = @("false")
}
$q.Var.filter = @($filter)

$result = ($q | Invoke-Rsc).Nodes | Where-Object { $_.Id -eq $vmId }
if ($result) {
    Write-Host "  Newest snapshot: $($result.NewestSnapshot.Date)"
    Write-Host "  Oldest snapshot: $($result.OldestSnapshot.Date)"
}

# ------------------------------------------------------------------
# 3. Take an on-demand snapshot (commented out — uncomment to run)
# ------------------------------------------------------------------
<#
Write-Host "`nTaking on-demand snapshot..."
$m = New-RscMutation -Gql createOnDemandBackup
$m.Var.input = Get-RscType -Name CreateOnDemandJobInput -InitialValues @{
    objectIds = @($vmId)
    slaId     = "sla-id-here"   # Replace with actual SLA ID
}
$snapResult = $m | Invoke-Rsc
Write-Host "Snapshot job started: $($snapResult | Remove-NullProperties)"
#>

Disconnect-Rsc
