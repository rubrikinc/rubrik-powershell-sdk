<#
.SYNOPSIS
Basic tests to check that the Toolkit is intact
#>
BeforeAll {
    . "$PSScriptRoot\..\..\Utils\ToolkitDev.ps1" -Quiet
}

Describe -Name "Toolkit" -Fixture {

    It -Name 'Toolkit' -Test {
        # Check that toolkit directories exist and are readable
        foreach ($property in ($Toolkit.PSObject.Properties | Where-Object { $_.Name -like '*Dir' })) {
            $directoryPath = $property.Value
            $directoryPath | Should -Exist
            { Get-ChildItem -Path $directoryPath } | Should -Not -Throw
        }
    }
}
