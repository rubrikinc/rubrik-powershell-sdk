<#
.SYNOPSIS
Run tests around field specs for interface fields
#>
BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
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
        # New-RscQueryMssql -Op TopLevelDescendants invokes
        # mssqlTopLevelDescendants
        $dbs = (New-RscQueryMssql -Op TopLevelDescendants)
        if ($dbs.Nodes.Count -gt 0) {
            # for each $dbs.Nodes.Id, 
            # make sure that the type is one of the implementations of $inf
            $dbs.Nodes | ForEach-Object {
                $type = $_.GetType().Name
                $impls | Where-Object { $_.Name -eq $type } | Should -Not -BeNullOrEmpty
            }
        }
    }
}