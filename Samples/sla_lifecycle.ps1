<#
.SYNOPSIS
    SLA domain lifecycle: create, retrieve, modify, and delete.

.DESCRIPTION
    Interactive sample that walks through the full SLA lifecycle:
    1. Create a temporary SLA (New-RscSla)
    2. List SLAs (Get-RscSla)
    3. Retrieve SLA by ID and by name (Get-RscSla)
    4. Modify the SLA description (Set-RscSla / updateGlobalSla)
    5. Verify the modification preserved other fields
    6. Delete the SLA (Remove-RscSla / deleteGlobalSla)

    Bonus (shown as code, not executed):
    A. Pause / Resume (Suspend-RscSla / Resume-RscSla)
    B. Assign SLA to workloads (Protect-RscWorkload / assignSla)

    The SLA is named with a distinctive prefix so it is easy to
    identify and safe to delete. Cleanup runs even if something fails.

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json

    This script creates and deletes a REAL SLA in your RSC tenant.
    The SLA is short-lived and uses hourly snapshots with 1-hour retention,
    so it has minimal footprint.
#>

. "$PSScriptRoot/SampleUtils.ps1"

# ---- Configuration ----
$SlaPrefix = "_SDK_SAMPLE_"
$SlaName   = "${SlaPrefix}$(New-Guid)"

# ---- Connect ----
Connect-Rsc

# ---- Clean up leftover SLAs from previous interrupted runs ----
$leftover = Get-RscSla | Where-Object { $_.Name -like "${SlaPrefix}*" }
if ($leftover) {
    Write-Host "Found $(@($leftover).Count) leftover sample SLA(s) from a previous run:"
    foreach ($s in $leftover) {
        Write-Host "  Deleting: $($s.Name)"
        $s | Remove-RscSla
    }
    Write-Host ""
}

# Ensure cleanup on exit
$cleanupDone = $false
function Invoke-Cleanup {
    if ($script:cleanupDone) { return }
    $script:cleanupDone = $true
    Write-Host "`n--- Cleanup ---"
    # Remove any SLAs matching our prefix (handles partial failures too)
    $leftover = Get-RscSla | Where-Object { $_.Name -like "${SlaPrefix}*" }
    foreach ($s in $leftover) {
        try {
            $s | Remove-RscSla
            Write-Host "  Deleted SLA: $($s.Name)"
        } catch {
            Write-Warning "  Failed to delete SLA '$($s.Name)': $_"
        }
    }
    if (-not $leftover) {
        Write-Host "  Nothing to clean up."
    }
}

try {

# ------------------------------------------------------------------
# 1. Create a temporary SLA
# ------------------------------------------------------------------
Write-Title "|  Step 1: Create a temporary SLA  |"
Write-Message -GreenMessage "Creating SLA '$SlaName' ..."

$hourly = New-RscSlaSnapshotSchedule -Type Hourly -Frequency 1 -Retention 1 -RetentionUnit HOURS
$newSla = New-RscSla -Name $SlaName -HourlySchedule $hourly -ObjectType VSPHERE_OBJECT_TYPE
$slaId  = $newSla.Id

Write-Message -GreenMessage "Created SLA:" `
    -YellowMessage "  Name: $SlaName`n  Id:   $slaId"

Write-Code -Pause -CodeSnippet @'
# High-level (recommended):
$hourly = New-RscSlaSnapshotSchedule -Type Hourly -Frequency 1 -Retention 1 -RetentionUnit HOURS
New-RscSla -Name "My-SLA" -HourlySchedule $hourly -ObjectType VSPHERE_OBJECT_TYPE

# Low-level equivalent (createGlobalSla):
$q = New-RscMutation -Gql createGlobalSla
$q.Var.input = @{
    name             = "My-SLA"
    snapshotSchedule = @{
        hourly = @{
            basicSchedule = @{
                frequency     = 1
                retention     = 1
                retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::HOURS
            }
        }
    }
    objectTypes = @([RubrikSecurityCloud.Types.SlaObjectType]::VSPHERE_OBJECT_TYPE)
}
$newSla = $q | Invoke-Rsc
'@

# ------------------------------------------------------------------
# 2. List SLAs and verify the new one exists
# ------------------------------------------------------------------
Write-Title "|  Step 2: List SLAs  |"

$allSlas = Get-RscSla
$match   = $allSlas | Where-Object { $_.Id -eq $slaId }

Write-Message -GreenMessage "Total SLAs: $(@($allSlas).Count)" `
    -YellowMessage "Our SLA found in list: $($null -ne $match)"

Write-Code -Pause -CodeSnippet @'
# High-level (recommended):
$allSlas = Get-RscSla
$allSlas[0] | Remove-NullProperties | Format-List

# Low-level equivalent (slaDomains query):
$result = New-RscQuery -Gql slaDomains -Var @{ first = 10 } | Invoke-Rsc
$result.Nodes | Select-Object Id, Name | Format-Table -AutoSize
'@

# ------------------------------------------------------------------
# 3. Retrieve SLA by ID and by Name
# ------------------------------------------------------------------
Write-Title "|  Step 3: Retrieve SLA by ID and Name  |"

$byId = Get-RscSla -Id $slaId
Write-Message -GreenMessage "By ID:" -YellowMessage "  $($byId.Name) (Id: $($byId.Id))"

$byName = Get-RscSla -Name $SlaName
Write-Message -GreenMessage "By Name:" -YellowMessage "  $($byName.Name) (Id: $($byName.Id))"

Write-Code -Pause -CodeSnippet @'
$sla = Get-RscSla -Id $slaId
$sla = Get-RscSla -Name "My-SLA"
'@

# ------------------------------------------------------------------
# 4. Modify the SLA description
# ------------------------------------------------------------------
Write-Title "|  Step 4: Modify SLA description  |"

$originalDesc = $byId.Description
$updatedDesc  = "$originalDesc — modified by sample script"

Write-Message -GreenMessage "Original description:" -YellowMessage "  $originalDesc"

Set-RscSla -Sla $byId -Description $updatedDesc

$after = Get-RscSla -Id $slaId
Write-Message -GreenMessage "Updated description:" -YellowMessage "  $($after.Description)"

Write-Code -Pause -CodeSnippet @'
# High-level (recommended):
$sla = Get-RscSla -Id $slaId
Set-RscSla -Sla $sla -Description "New description"

# Low-level equivalent (updateGlobalSla):
$q = New-RscMutation -Gql updateGlobalSla
$q.Var.input = @{
    id           = $slaId
    name         = $sla.Name
    description  = "New description"
    stateVersion = $sla.StateVersion
}
$q | Invoke-Rsc
'@

# ------------------------------------------------------------------
# 5. Verify modification preserved other fields
# ------------------------------------------------------------------
Write-Title "|  Step 5: Verify other fields are preserved  |"

$stateVersionBefore = $byId.StateVersion
$stateVersionAfter  = $after.StateVersion

Write-Message -GreenMessage "StateVersion before: $stateVersionBefore" `
    -YellowMessage "StateVersion after:  $stateVersionAfter (should be +1)"

# Quick sanity check
if ($stateVersionAfter -eq ($stateVersionBefore + 1)) {
    Write-Message -GreenMessage "StateVersion incremented correctly."
} else {
    Write-Warning "StateVersion mismatch — expected $($stateVersionBefore + 1), got $stateVersionAfter"
}

Write-Message -GreenMessage "Name is still: $($after.Name)" -Pause

# ------------------------------------------------------------------
# 6. Delete the SLA
# ------------------------------------------------------------------
Write-Title "|  Step 6: Delete the SLA  |"

Remove-RscSla -SlaId $slaId -UserNote "Cleaned up by SDK sample script"

Write-Message -GreenMessage "Deleted SLA '$SlaName'"

Write-Code -Pause -CodeSnippet @'
# High-level (recommended):
Remove-RscSla -SlaId $slaId -UserNote "reason for deletion"
# or pipe from Get-RscSla:
Get-RscSla -Name "My-SLA" | Remove-RscSla

# Low-level equivalent (deleteGlobalSla):
$q = New-RscMutation -Gql deleteGlobalSla
$q.Var.id = $slaId
$q | Invoke-Rsc
'@

$cleanupDone = $true

# ------------------------------------------------------------------
# Bonus A: Pause / Resume an SLA (Suspend-RscSla / Resume-RscSla)
# ------------------------------------------------------------------
# NOT executed — pause/resume requires the SLA to be synced to a
# cluster (i.e. assigned to workloads on that cluster).
Write-Title "|  Bonus A: Pause / Resume SLA (not executed)  |"
Write-Message -GreenMessage "Suspend-RscSla and Resume-RscSla pause and resume snapshots." `
    -YellowMessage "  This step is shown as code only — it is not executed`n  because the SLA must be synced to a cluster first."

Write-Code -Pause -CodeSnippet @'
# Pause an SLA on a cluster:
$cluster = (Get-RscCluster)[0]
Suspend-RscSla -SlaId $slaId -ClusterUuids @($cluster.Id)
# or pipe from Get-RscSla:
Get-RscSla -Name "Gold" | Suspend-RscSla -ClusterUuids @($cluster.Id)

# Resume it:
Resume-RscSla -SlaId $slaId -ClusterUuids @($cluster.Id)

# Low-level equivalent (pauseSla mutation, used by both):
$q = New-RscMutation -Gql pauseSla
$q.Var.input = @{ slaId = $slaId; pauseSla = $true; clusterUuids = @($cluster.Id) }
$q | Invoke-Rsc
# To resume, set pauseSla = $false
'@

# ------------------------------------------------------------------
# Bonus B: Assign an SLA to workloads (Protect-RscWorkload)
# ------------------------------------------------------------------
# NOT executed — assigning SLAs to real objects is not safe in a sample.
Write-Title "|  Bonus B: Assign SLA to workloads (not executed)  |"
Write-Message -GreenMessage "Protect-RscWorkload assigns an SLA to workloads." `
    -YellowMessage "  This step is shown as code only — it is not executed`n  because it would modify protection on real objects."

Write-Code -Pause -CodeSnippet @'
# Assign a VM to the Gold SLA:
$sla = Get-RscSla -Name "Gold"
Get-RscVmwareVm -Name "MyVM" | Protect-RscWorkload -Sla $sla

# Bulk-assign all VMs in a single API call:
Protect-RscWorkload -InputObject (Get-RscVmwareVm) -Sla $sla

# Set a VM to DO NOT PROTECT:
Get-RscVmwareVm -Name "MyVM" | Protect-RscWorkload -AssignmentType doNotProtect

# Remove SLA assignment entirely:
Get-RscVmwareVm -Name "MyVM" | Protect-RscWorkload -AssignmentType noAssignment

# Low-level equivalent (assignSla):
$q = New-RscMutation -Gql assignSla
$q.Var.input = @{
    slaDomainAssignType = "PROTECT_WITH_SLA_ID"
    slaOptionalId       = $sla.Id
    objectIds           = @("object-id-1", "object-id-2")
}
$q | Invoke-Rsc
'@

Write-Title "|  Done!  |"

} catch {
    Write-Warning "Error: $_"
} finally {
    Invoke-Cleanup
    Disconnect-Rsc
}
