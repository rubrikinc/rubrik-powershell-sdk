<#
.SYNOPSIS
Run tests around field specs for interface fields
#>
BeforeAll {
    & "$PSScriptRoot\..\..\Utils\import.ps1"
}

Describe -Name "Test field specs for interface fields" -Fixture {

    It -Name 'Field spec exploration' -Test {
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
        # New-RscQueryMssql -TopLevelDescendant invokes
        $fieldSpecString = (New-RscQueryMssql -Op TopLevelDescendants).Field.AsFieldSpec()
        # The built up field spec should have an inline fragment
        # for each implementation of the interface
        $inlineFragments = [regex]::Matches($fieldSpecString, '\.\.\. on (\w+)')
        $names = $inlineFragments | ForEach-Object { $_.Groups[1].Value } | Sort-Object
        $expectedNames = $impls | ForEach-Object { $_.Name } | Sort-Object
        # There may be other names because subfields may have fragments too.
        # So we only want to make sure that $expectedNames is a subset of $names
        # convert $names to a set
        $nameSet = $names | Select-Object -Unique
        # convert $expectedNames to a set
        $expectedNameSet = $expectedNames | Select-Object -Unique
        # $expectedNameSet should be a subset of $nameSet
        ($expectedNameSet | ForEach-Object { $nameSet -Contains $_ }) -notcontains $false | Should -Be $true
    }
}
