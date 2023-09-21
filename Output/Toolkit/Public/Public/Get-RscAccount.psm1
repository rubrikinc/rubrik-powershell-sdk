#Requires -Version 3
function Get-RscAccount {
    <#
    .SYNOPSIS
    Retrieve info about the current RSC account in use

    .DESCRIPTION
    Combines the output of 2 queries:
    - accountId : to retrieve the account id
    - allAccountOwners: to retrieve the account owners

    By default, responses contain a minimal set of fields.
    To get more details, use the `-Detail` parameter.

    Note that in the output, 
    `AccountId` is the account ID, and `Id` is the user ID.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    The User type:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/user.doc.html
    
    #>

    [CmdletBinding(
    )]
    Param(
        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$Detail
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine field profile
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }

        # Invoke GraphQL operations 
        #     and collect results into a PSObject:
        $result = New-Object -TypeName PSObject
        $accountId = (New-RscQueryAccount -FieldProfile $fieldProfile).Invoke()
        $result | Add-Member -MemberType NoteProperty -Name "AccountId" -Value $accountId
        $accountOwner = (New-RscQueryAccount -Owner -FieldProfile $fieldProfile).Invoke()
        $accountOwner.PSObject.Properties | ForEach-Object {
            $result | Add-Member -MemberType NoteProperty -Name $_.Name -Value $_.Value }
        
        # Filter out null values:
        $result | Remove-NullProperties
    } 
}
