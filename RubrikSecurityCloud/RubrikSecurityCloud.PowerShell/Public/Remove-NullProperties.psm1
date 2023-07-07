#Requires -Version 3
function Remove-NullProperties {
    <#
    .SYNOPSIS
    Remove null properties from a pscustomobject or list of pscustomobjects

    .DESCRIPTION
    This function removes null properties from a pscustomobject or list of pscustomobjects.

    .EXAMPLE
    $nodes=((Invoke-RscQueryCluster -List).Nodes | Remove-NullProperties)

    Retrieves all clusters in the Rubrik cluster and removes null properties.
    #>
    param(
        [Parameter(Mandatory=$true, ValueFromPipeline=$true)]
        [PSObject]$Object
    )

    Process {
        if ($Object -is [System.Collections.IList]) {
            foreach ($item in $Object) {
                $item | Remove-NullProperties
            }
        }
        elseif ($Object -is [pscustomobject]) {
            $properties = $Object.PSObject.Properties | Where-Object { $null -ne $_.Value }
            $newObject = New-Object -Type pscustomobject
            foreach ($property in $properties) {
                $value = $property.Value
                if ($value -is [pscustomobject] -or $value -is [System.Collections.IList]) {
                    Add-Member -InputObject $newObject -MemberType NoteProperty -Name $property.Name -Value ($value | Remove-NullProperties)
                } else {
                    Add-Member -InputObject $newObject -MemberType NoteProperty -Name $property.Name -Value $value
                }
            }
            return $newObject
        }
    }
}

