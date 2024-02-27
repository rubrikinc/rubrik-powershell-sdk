<#
.SYNOPSIS
Basic tests for the Get-RscCluster cmdlet
#>
BeforeAll {
    . "$PSScriptRoot\..\..\Utils\ToolkitDev.ps1" -Quiet
}

Describe -Name "Get-RscCluster" -Fixture {

    It -Name 'Get-RscCluster' -Test {
        (Get-Help Get-RscCluster).Name | Should -Be "Get-RscCluster"
        (Get-Help Get-RscCluster).Synopsis | Should -Not -BeNullOrEmpty
        (Get-Help Get-RscCluster).Description | Should -Not -BeNullOrEmpty
    }
}
