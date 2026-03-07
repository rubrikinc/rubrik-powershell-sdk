#Requires -Version 3
function Get-RscAccount {
    <#
    .SYNOPSIS
    Retrieves information about the current Rubrik Security Cloud account.

    .DESCRIPTION
    Returns the account ID and account owner details for the RSC account that
    the current session is connected to. Useful for verifying which account
    you are operating against.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    The User type (returned by the allAccountOwners query):
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/user.doc.html
    

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.EXAMPLE
    # Get current account info
    Get-RscAccount

    .EXAMPLE
    # Display the account ID
    (Get-RscAccount).AccountId
    #>

    [CmdletBinding(
    )]
    Param(
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
        $outputObj = @{}

        if ( $AsQuery ) {
            $q1 = New-RscQuery -GqlQuery accountId
            $q2 = New-RscQuery -GqlQuery allAccountOwners -RemoveField AllOrgs.AllClusterCapacityQuotas
            return @($q1, $q2)
        }

        # Add Account Id:
        $outputObj["AccountId"] = (New-RscQuery -Gql accountId).Invoke()

        $owner = (New-RscQuery -Gql allAccountOwners -RemoveField AllOrgs.AllClusterCapacityQuotas).Invoke()


        $owner | Get-Member -MemberType Properties | ForEach-Object {
            $propName = $_.Name
            $propValue = $owner.$propName
            if ($propName -eq "PasskeyMetadata") {
                $outputObj["AccountOwnerIsPasskeyEnabled"] = $propValue.IsPasskeyEnabled
            }
            elseif ( $propName -eq "LockoutState") {
                $outputObj["AccountOwnerIsLocked"] = $propValue.IsLocked
            }
            # We do not go down into the composite types;
            # composite types renders their ToString() method to
            # their type name, like "RubrikSecurityCloud.Types.TotpStatus"
            # so we skip them.
            elseif ( $null -ne $propValue -and -not $propValue.ToString().StartsWith("RubrikSecurityCloud.Types")) {
                $outputObj["AccountOwner$propName"] = $propValue
            }
        }

        # Convert the hashtable to PSCustomObject and return
        [PSCustomObject]$outputObj
    } 

    
}
