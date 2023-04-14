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
1. Queries can either take zero, one, or multiple arguments. If there are zero
   arguments, we only need to worry about the return fields.
"@

Write-Code "`$reply = Get-RscType -Name `"AccountSetting`" -InitialProperties @(`"IsEulaAccepted`")"
$settings = Get-RscType -Name "AccountSetting" -InitialProperties @("IsEulaAccepted")

Write-Code -Pause "Get-RscAccount -Setting -Reply `$reply"
Get-RscAccount -Setting -Reply $settings

Write-Message @"
2. Queries that take a single argument will have a parameter called -Arg that
   expects an object/variable of the argument's type.
"@

$cluster = Get-RscType -Name "Cluster" -InitialProperties @("EncryptionEnabled")

Write-Code -Pause "Get-RscCluster -Cluster -Input `"7e228077-9194-497d-b553-90c7aed3293f`" -Reply `$cluster"

Write-Message @"
3. Queries that take multiple arguments will instead take a HashTable that
   maps the input field name as a string to its value.
"@

Write-Message @"
   Initializing ActivitySeriesFilter object with startTimeLt set to today's date.
"@

$today = Get-Date
Write-Code -Pause "`$today = Get-Date"

$activitySeriesFilter = Get-RscType -Name "ActivitySeriesFilter" -InitialValues @{"startTimeLt"=$today}
Write-Code -Pause "`$activitySeriesFilter = Get-RscType -Name `"ActivitySeriesFilter`" -InitialValues @{`"startTimeLt`"=`$today}"

Write-Message @"
   Specifying the field we want returned from the query.
   In this case, we are retrieving the Count field.
"@

$connection = Get-RscType -Name "ActivitySeriesConnection" -InitialProperties @("Count", "Nodes.Id")
Write-Code -Pause "Get-RscType -Name `"ActivitySeriesConnection`" -InitialProperties @(`"Count`", `"Nodes.Id`")"

Write-Code -Pause "Query-RscActivitySeries -Connection -Input @{`"filter`"=`$activitySeriesFilter; `"first`"= 3} -Reply `$connection"
Query-RscActivitySeries -Connection -Input @{"filter"=$activitySeriesFilter; "first"= 3} -Reply $connection
