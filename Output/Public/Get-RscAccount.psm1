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
        # -1- Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # -2- Determine input profile:
        $inputProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $inputProfile = "DETAIL"
        }

        # -3- Invoke GraphQL operations 
        #     and collect results into a PSObject:
        $result = New-Object -TypeName PSObject
        $accountId = (Invoke-RscQueryAccount -InputProfile $inputProfile)
        $result | Add-Member -MemberType NoteProperty -Name "AccountId" -Value $accountId
        $accountOwner = (Invoke-RscQueryAccount -Owner -InputProfile $inputProfile)
        $accountOwner.PSObject.Properties | ForEach-Object {
            $result | Add-Member -MemberType NoteProperty -Name $_.Name -Value $_.Value }
        
        # -4- Filter out null values:
        $result | Remove-NullProperties

        $result
    } 
}
