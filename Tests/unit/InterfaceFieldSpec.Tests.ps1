<#
.SYNOPSIS
Run tests around field specs for interface fields
#>
BeforeAll {
    & "$PSScriptRoot\..\..\Utils\import.ps1"
}

Describe -Name "Test field specs for interface fields" -Fixture {

    It -Name 'Field spec exploration' -Test {
        Connect-Rsc # TODO: SPARK-225839 Don't require connection if cmdlet called with -GetInputs

        # Retrieve all interfaces
        $interfaces = (Get-RscType -ListAvailable -Interfaces)
        # Inf1 should be one of them
        $inf = "MssqlTopLevelDescendantType"
        ($interfaces | Where-Object { $_.Name -eq $inf }).Count | Should -Be 1
        # inf should have at least one implementation
        $impls = (Get-RscType -Interface $inf)
        $impls.Count | Should -BeGreaterThan 0
        Write-Host "Found $($impls.Count) implementations of interface $inf"
        # Build exploration field spec for 
        # Invoke-RscQueryMssql -TopLevelDescendant invokes
        $fieldSpecString = (Invoke-RscQueryMssql -TopLevelDescendant -GetInputs).Field.AsFieldSpec()
        # The built up field spec should have an inline fragment
        # for each implementation of the interface
        $inlineFragments = [regex]::Matches($fieldSpecString, '\.\.\. on (\w+)')
        $names = $inlineFragments | ForEach-Object { $_.Groups[1].Value } | Sort-Object
        $expectedNames = $impls | ForEach-Object { $_.Name } | Sort-Object
        Compare-Object $names $expectedNames -SyncWindow 0 | Measure-Object | ForEach-Object { $_.Count } | Should -Be 0
        
        
    }
}
