#Requires -Version 3
function Remove-NullProperties {
    <#
    .SYNOPSIS
    Removes null-valued properties from objects returned by RSC cmdlets.

    .DESCRIPTION
    Strips properties with null values from PSCustomObjects or lists of objects.
    This is applied automatically by most Toolkit cmdlets but can be used
    manually to clean up raw query results. Use -NoRecurse to only strip
    top-level null properties without descending into nested objects.

    .PARAMETER Object
    The object or list of objects to clean. Accepts pipeline input.

    .PARAMETER NoRecurse
    Only remove null properties at the top level; do not recurse into nested objects.

    .EXAMPLE
    # Clean up raw query results
    (New-RscQuery -Gql clusterConnection).Nodes | Remove-NullProperties

    .EXAMPLE
    # Pipe a workload object through to strip nulls
    Get-RscVmwareVm -Name "web-server-01" -IncludeNullProperties | Remove-NullProperties
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

