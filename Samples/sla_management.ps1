<#
.SYNOPSIS
    SLA domain management.

.DESCRIPTION
    This sample demonstrates:
    1. Listing SLA domains
    2. Creating a new SLA domain
    3. Assigning an SLA to objects

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json
#>

Connect-Rsc

# ------------------------------------------------------------------
# 1. List SLA domains
# ------------------------------------------------------------------
Write-Host "Listing SLA domains..."
$result = New-RscQuery -Gql slaDomains `
    -Var @{ first = 10 } | Invoke-Rsc
$result.Nodes | Select-Object Id, Name | Format-Table -AutoSize
Write-Host "Total SLAs: $($result.Count)"

# ------------------------------------------------------------------
# 2. Get details for a specific SLA (using the wrapper cmdlet)
# ------------------------------------------------------------------
$slas = Get-RscSla
if ($slas.Count -gt 0) {
    Write-Host "`nFirst SLA details:"
    $slas[0] | Remove-NullProperties | Format-List
}

# ------------------------------------------------------------------
# 3. Create a new SLA (commented out — uncomment to run)
# ------------------------------------------------------------------
<#
Write-Host "`nCreating new SLA..."
$m = New-RscMutation -Gql createGlobalSla
$m.Var.input = Get-RscType -Name CreateGlobalSlaInput -InitialValues @{
    name        = "Sample-SLA-Bronze"
    description = "Sample SLA created by SDK sample script"
}
$newSla = $m | Invoke-Rsc
Write-Host "Created SLA: $($newSla.Name) (ID: $($newSla.Id))"
#>

# ------------------------------------------------------------------
# 4. Assign an SLA to objects (commented out — uncomment to run)
# ------------------------------------------------------------------
<#
$m = New-RscMutation -Gql assignSla
$m.Var.input = Get-RscType -Name AssignSlaInput -InitialValues @{
    slaDomainAssignType = "PROTECT_WITH_SLA_ID"
    slaOptionalId       = "sla-id-here"         # Replace with actual SLA ID
    objectIds           = @("object-id-here")    # Replace with actual object IDs
}
$m | Invoke-Rsc
Write-Host "SLA assigned successfully."
#>

Disconnect-Rsc
