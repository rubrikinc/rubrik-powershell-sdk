#Requires -Version 3
function Get-RscAccount {
    <#
    .SYNOPSIS
    Retrieve info about the current RSC account in use

    .DESCRIPTION
    Combines the output of 2 queries:
    - New-RscQueryAccount -Id    : to retrieve the account id
    - New-RscQueryAccount -Owner : to retrieve the account owner

    Not all account owner fields are returned.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    The User type (returned by New-RscQueryAccount -Owner)
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/user.doc.html
    
    #>

    [CmdletBinding(
    )]
    Param(
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        $outputObj = @{}
        
        # Add Account Id:
        $outputObj["AccountId"] = (New-RscQueryAccount -Id).Invoke()

        $owner = (New-RscQueryAccount -Owner -FieldProfile FULL).Invoke()


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
