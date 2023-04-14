. "${PSScriptRoot}\..\Utils\import.ps1"
. "${PSScriptRoot}\SampleUtils.ps1"


# Check if the RSC_SERVICE_ACCOUNT_FILE environment variable is defined
if (!(Test-Path Env:RSC_SERVICE_ACCOUNT_FILE)) {
   # RSC_SERVICE_ACCOUNT_FILE environment variable is not defined
   throw "Error: RSC_SERVICE_ACCOUNT_FILE environment variable is not defined"
}

# Connect to the Rubrik Security Cloud using the service account
# file specified in the RSC_SERVICE_ACCOUNT_FILE environment variable:
Connect-Rsc -FromEnv

Write-Message @"
1. We start by building the inputs to the cluster list query. We'll
   be supplying the "first" and "filter" arguments.
"@

Write-Code "`$filter = Get-RscType -Name `"ClusterFilterInput`" -InitialValues @{`"excludeEmptyCluster`"=`$false}"
$filter = Get-RscType -Name "ClusterFilterInput" -InitialValues @{"excludeEmptyCluster"=$false}

Write-Message @"
2. Specifying which fields we want to retrieve from the cluster connection.
"@
Write-Code "`$clusters = Get-RscType -Name `"ClusterConnection`" -InitialProperties @(`"Count`", `"Nodes.Version`")"
$connection = Get-RscType -Name "ClusterConnection" -InitialProperties @("Count", "Nodes.Version")

Write-Message @"
3. Calling the cluster connection query with the input fields and reply fields."
"@
Write-Code -Pause "`$clusters = Query-RscCluster -Connection -Input @{`"filter`"=`$filter; `"first`"=5} -Reply `$connection"
Query-RscCluster -Connection -Input @{"filter"=$filter; "first"=5} -Reply $connection
