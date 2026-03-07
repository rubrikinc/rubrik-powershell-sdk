#Requires -Version 3
function Get-RscAccount {
    <#
    .SYNOPSIS
    Retrieve info about the current RSC account in use

    .DESCRIPTION
    Combines the output of 2 queries:
    - accountId          : to retrieve the account id
    - allAccountOwners   : to retrieve the account owner

    Not all account owner fields are returned.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    The User type (returned by the allAccountOwners query):
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/user.doc.html
    
    #>

    [CmdletBinding(
    )]
    Param(
    )
    
    Process {
        $outputObj = @{}
        
        # Add Account Id:
        $outputObj["AccountId"] = (New-RscQuery -GqlQuery accountId).Invoke()

        $owner = (New-RscQuery -GqlQuery allAccountOwners -RemoveField AllOrgs.AllClusterCapacityQuotas).Invoke()


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
