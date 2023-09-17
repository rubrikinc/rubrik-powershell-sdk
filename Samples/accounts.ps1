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

#
# Query-RscAccount -Id
#
# Input: None
# Output: a string containing the account ID
$accountId = Query-RscAccount -Id
Write-Message "Account ID:" "(type=$($accountId.GetType()))"
$accountId

#
# Query-RscAccount -Setting
#
# Input: None
# Output: an AccountSetting object
$accountSetting = (Query-RscAccount -Setting -About).Input
$accountSetting.
Write-Message "Account setting:" "(type=$($accountSetting.GetType()))"
$accountSetting.isEmailNotificationEnabled = "FETCH"
$accountSetting.isEulaAccepted = "FETCH"
return


Write-Message @"
1. Account queries are done with Query-RscAccount:
"@
Get-Help Query-RscAccount


Write-Message @"
2. By default, the Id query is used. Query-RscAccount is the same
   as Query-RscAccount -Id:
"@
Write-Code -Pause "Query-RscAccount"
Query-RscAccount
Write-Code -Pause "Query-RscAccount -Id"
Query-RscAccount -Id


Write-Message -Pause @"
3. Note that we called the query without specifying any fields, and yet,
   the query returned a result. This is because when no fields are specified,
   the *exploratory* query is used.
   In production code, you want to specify the fields that
   need to be fetched in the reply.
   To do so, you first need to know the response type. You can get it from
   help with "Get-Help Query-RscAccount -Full" or by using the
   -ResponseType parameter:

"@
Query-RscAccount -Setting -ResponseType


Write-Message @"

4. The response type is RubrikSecurityCloud.Types.AccountSetting.
   You can use it to create an instance of the type, and then specify
   the fields you want to fetch:
"@
$accountSetting = [RubrikSecurityCloud.Types.AccountSetting]@{}
$accountSetting.IsEulaAccepted = 1
Query-RscAccount -Setting -Field $accountSetting


Write-Message @"
5. Note that we said we just want to fetch the IsEulaAccepted field by
   setting it to 1 : it doesn't matter what we set it to, as long as it's 
   not `$null:
"@
$accountSetting.IsEulaAccepted = "FETCH ME!"
Query-RscAccount -Setting -Field $accountSetting


Write-Message @"
6. In other words, we define the fields we want to fetch by setting them
   to a non-null value. We can also set them to null, which means we don't
   want to fetch them...
"@
$accountSetting.IsEulaAccepted = $null
try {
   Query-RscAccount -Setting -Field $accountSetting
}
catch {
   Write-Host $_.Exception.Message -ForegroundColor Magenta
}


Write-Message @"
7. ...but we can't set them *all* to `$null ! because then we're not
   fetching any fields, and the query fails.
"@
$accountSetting.IsEmailNotificationEnabled = 1
Query-RscAccount -Setting -Field $accountSetting


Write-Message @"
8. All schema types have an SelectForRetrieval() method.
   It sets *some* fields in the object to non-null values.
   It is meant to be used when you don't know which fields you want to fetch,
   and you want to see what the query would look like.
   This is more of a development / debugging tool and is not 
   meant to be used in production code.
   In production code, you should always specify the fields you want to fetch.
"@
$accountSetting = [RubrikSecurityCloud.Types.AccountSetting]@{}
$accountSetting
$accountSetting.SelectForRetrieval()
$accountSetting
Query-RscAccount -Setting -Field $accountSetting


Write-Message @"
9. All schema types also have an AsFieldSpec() method.
   It returns a string that is a valid GraphQL fieldspec of the object,
   that is: a string that lists all the fields of the object that
    are not null, *recursively*.

"@
$accountSetting.AsFieldSpec()


Write-Message @"
10. You can use the AsFieldSpec() method to build queries manually:
"@
$fieldspec = $accountSetting.AsFieldSpec()
$query = "{accountSettings { $fieldspec }}"
Invoke-Rsc -OutputType AccountSetting $query
