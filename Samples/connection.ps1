<#
.SYNOPSIS
    Minimal "hello world" — connect, query, disconnect.

.DESCRIPTION
    The simplest possible RSC script. Shows the three-step pattern
    that every SDK script follows:

    1. Connect-Rsc        — reuses an existing session or creates one
    2. (do work)          — any query, mutation, or Toolkit cmdlet
    3. Disconnect-Rsc     — clean up the session

    Before running, register your service account once:
      Set-RscServiceAccountFile /path/to/service_account.json

    That command encrypts the JSON into a per-user config file,
    so Connect-Rsc can pick it up automatically from then on.

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json
#>

Connect-Rsc

try {

# Show what we're connected to
$v = Get-RscVersion
Write-Host "Connected to RSC  (SDK: $($v.SdkSchemaVersion)  Server: $($v.ServerVersion))"

# Run a simple query — count clusters as a quick smoke test
$result = New-RscQuery -Gql clusterConnection -Var @{ first = 3 } | Invoke-Rsc
Write-Host "$($result.Count) cluster(s) in this tenant:"
$result.Nodes | Format-Table Name, Status, Type -AutoSize

} catch {
    Write-Warning "Error: $_"
} finally {
    Disconnect-Rsc
}
