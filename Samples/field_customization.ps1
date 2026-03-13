<#
.SYNOPSIS
    Customizing which fields are returned in queries.

.DESCRIPTION
    Interactive sample that demonstrates the field selection system:
    1. Default fields — AutoField picks a sensible DEFAULT profile
    2. Adding fields — -AddField includes extra fields on top of defaults
    3. Removing fields — -RemoveField drops fields you don't need
    4. DETAIL profile — broader field set for deeper inspection
    5. Discovering fields — -ValidPatchSet lists every field path you can use
    6. Manual field selection — -FieldProfile EMPTY + -AddField for full control

    See also: docs/autofield.md

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json
#>

. "$PSScriptRoot/SampleUtils.ps1"

Connect-Rsc

try {

# ------------------------------------------------------------------
# 1. Default fields (DEFAULT profile via AutoField)
# ------------------------------------------------------------------
Write-Title "|  Step 1: Default field selection  |"

Write-Message -GreenMessage "Every query starts with a DEFAULT field profile." `
    -YellowMessage "  AutoField selects commonly needed fields automatically.`n  You get a useful result without specifying any fields."

$result = New-RscQuery -Gql clusterConnection -Var @{ first = 1 } | Invoke-Rsc
Write-Message -GreenMessage "Fields returned by default:"
$result.Nodes[0] | Remove-NullProperties | Format-List

Write-Code -Pause -CodeSnippet @'
# No field arguments needed — DEFAULT profile is automatic:
$result = New-RscQuery -Gql clusterConnection -Var @{ first = 1 } | Invoke-Rsc
$result.Nodes[0] | Remove-NullProperties | Format-List
'@

# ------------------------------------------------------------------
# 2. Adding specific fields with -AddField
# ------------------------------------------------------------------
Write-Title "|  Step 2: Adding fields with -AddField  |"

Write-Message -GreenMessage "Use -AddField to include extra fields on top of the defaults." `
    -YellowMessage "  Dot-separated paths navigate into nested objects.`n  Example: Nodes.GeoLocation.Address fetches the cluster's address."

$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 1 } `
    -AddField Nodes.Version, Nodes.GeoLocation.Address | Invoke-Rsc

$node = $result.Nodes[0]
Write-Message -GreenMessage "Added Version and GeoLocation:" `
    -YellowMessage "  Name:     $($node.Name)`n  Version:  $($node.Version)`n  Address:  $($node.GeoLocation.Address)"

Write-Code -Pause -CodeSnippet @'
$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 1 } `
    -AddField Nodes.Version, Nodes.GeoLocation.Address | Invoke-Rsc
'@

# ------------------------------------------------------------------
# 3. Removing fields with -RemoveField
# ------------------------------------------------------------------
Write-Title "|  Step 3: Removing fields with -RemoveField  |"

Write-Message -GreenMessage "Use -RemoveField to exclude fields from the default profile." `
    -YellowMessage "  Useful when a default field causes errors or is too expensive."

$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 1 } `
    -RemoveField Nodes.Status | Invoke-Rsc

$node = $result.Nodes[0]
Write-Message -GreenMessage "Removed Status from defaults:" `
    -YellowMessage "  Name:   $($node.Name)`n  Status: $($node.Status)  (should be empty/null)"

Write-Code -Pause -CodeSnippet @'
# Status is in the DEFAULT profile, but we can exclude it:
$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 1 } `
    -RemoveField Nodes.Status | Invoke-Rsc
$result.Nodes[0].Status  # null — field was excluded
'@

# ------------------------------------------------------------------
# 4. DETAIL profile for broader field selection
# ------------------------------------------------------------------
Write-Title "|  Step 4: DETAIL profile  |"

Write-Message -GreenMessage "The DETAIL profile returns more fields than DEFAULT." `
    -YellowMessage "  Useful for deep inspection or when you need everything.`n  You can combine -FieldProfile DETAIL with -RemoveField to`n  drop fields that cause issues (e.g. required arguments)."

# The DETAIL profile for clusterConnection includes MetricTimeSeriesNew
# which requires a non-null 'unit' argument. Remove it to avoid a 400 error.
# This is a real-world example of why -RemoveField exists.
$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 1 } `
    -FieldProfile DETAIL `
    -RemoveField Nodes.MetricTimeSeriesNew | Invoke-Rsc

$node = $result.Nodes[0]
$propCount = ($node | Remove-NullProperties | Get-Member -MemberType NoteProperty).Count
Write-Message -GreenMessage "DETAIL returned $propCount non-null properties (vs DEFAULT)."
$node | Remove-NullProperties | Format-List

Write-Code -Pause -CodeSnippet @'
# Some DETAIL fields have required arguments and will fail without them.
# Use -RemoveField to exclude them:
$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 1 } `
    -FieldProfile DETAIL `
    -RemoveField Nodes.MetricTimeSeriesNew | Invoke-Rsc
$result.Nodes[0] | Remove-NullProperties | Format-List
'@

# ------------------------------------------------------------------
# 5. Discovering available fields with -ValidPatchSet
# ------------------------------------------------------------------
Write-Title "|  Step 5: Discover available fields  |"

Write-Message -GreenMessage "Use -ValidPatchSet to list every field path you can add or remove." `
    -YellowMessage "  Returns an array of dot-separated paths.`n  Filter with Where-Object to find what you need."

$fields = New-RscQuery -Gql clusterConnection -ValidPatchSet

Write-Message -GreenMessage "$($fields.Count) total fields available. First 20:"
$fields | Select-Object -First 20 | ForEach-Object { Write-Host "  $_" }

Write-Host ""
Write-Message -GreenMessage "Fields matching 'snapshot':"
$matched = $fields | Where-Object { $_ -match "snapshot" }
$matched | ForEach-Object { Write-Host "  $_" -ForegroundColor Yellow }

Write-Code -Pause -CodeSnippet @'
$fields = New-RscQuery -Gql clusterConnection -ValidPatchSet
$fields | Where-Object { $_ -match "snapshot" }
$fields | Where-Object { $_ -match "GeoLocation" }
'@

# ------------------------------------------------------------------
# 6. Full manual control with -Field + -FieldProfile EMPTY
# ------------------------------------------------------------------
Write-Title "|  Step 6: Manual field selection  |"

Write-Message -GreenMessage "For full control, combine -FieldProfile EMPTY with -AddField." `
    -YellowMessage "  EMPTY starts with zero fields.`n  -AddField specifies exactly which fields to include.`n  The result contains only what you asked for — nothing more."

$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 5 } `
    -FieldProfile EMPTY `
    -AddField Nodes.Id, Nodes.Name, Nodes.Version, Count | Invoke-Rsc

Write-Message -GreenMessage "Only the 3 requested fields + Count:"
Write-Host "  Total clusters: $($result.Count)"
$result.Nodes | Select-Object Id, Name, Version | Format-Table -AutoSize

Write-Code -Pause -CodeSnippet @'
# EMPTY profile = start with nothing, then add exactly what you need:
$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 5 } `
    -FieldProfile EMPTY `
    -AddField Nodes.Id, Nodes.Name, Nodes.Version, Count | Invoke-Rsc
$result.Nodes | Select-Object Id, Name, Version | Format-Table -AutoSize
'@

Write-Title "|  Done!  |"

} catch {
    Write-Warning "Error: $_"
} finally {
    Disconnect-Rsc
}
