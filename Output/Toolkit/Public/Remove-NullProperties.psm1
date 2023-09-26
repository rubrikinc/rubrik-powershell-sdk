#Requires -Version 3
function Remove-NullProperties {
    <#
    .SYNOPSIS
    Remove null properties from a pscustomobject or list of pscustomobjects

    .DESCRIPTION
    This function removes null properties from a pscustomobject or list of pscustomobjects.

    .EXAMPLE
    $nodes=((New-RscQueryCluster -List).Nodes | Remove-NullProperties)

    Retrieves all clusters in the Rubrik cluster and removes null properties.
    #>
    param(
        [Parameter(Mandatory=$false, ValueFromPipeline=$true)]
        [PSObject]$Object,
        [Parameter(Mandatory=$false)]
        [switch]$NoRecurse
    )
    Process {
        # If the input object is null, return immediately
        if ($null -eq $Object) {
            return
        }
        $properties = $Object.PSObject.Properties | Where-Object { $null -ne $_.Value }
        $newObject = New-Object -Type pscustomobject
        foreach ($property in $properties) {
            $value = $property.Value
            if ( $NoRecurse -eq $false -and
                 $value -is [System.Collections.IList]) {
                $newList = New-Object 'System.Collections.ArrayList' 
                # recurse on each item in the list:
                foreach ($item in $value) {
                    $item = Remove-NullProperties -Object $item -NoRecurse
                    [void]$newList.Add($item)
                }
                $value = $newList
            }
            Add-Member -InputObject $newObject -MemberType NoteProperty -Name $property.Name -Value $value
        }
        return $newObject
    }
}

