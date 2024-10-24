<#
.SYNOPSIS
Basic tests for the Get-RscCluster cmdlet
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name "Get-RscCluster Tests" -Fixture {

    It -Name 'checks help is not empty' -Test {
        $help = Get-Help Get-RscCluster
        $help.Name | Should -Be "Get-RscCluster"
        $help.Synopsis | Should -Not -BeNullOrEmpty
        $help.Description | Should -Not -BeNullOrEmpty
    }
}
