#Requires -Version 3
<#
.SYNOPSIS
    Unit tests for Set-RscMssqlLogShippingSecondary.

.DESCRIPTION
    Verifies that the cmdlet builds the correct mutation and populates
    input fields for each parameter set:

    - AutomaticReseed (default): calls updateMssqlLogShippingConfiguration
      and sets makeupReseedLimit to 1 (enabled) or 0 (disabled).

    - State: calls updateMssqlLogShippingConfigurationV1 and sets the
      secondary state and shouldDisconnectStandbyUsers flag.

    Uses -AsQuery to inspect the built query without an API connection.
    See Get-RscMssqlInstance.Tests.ps1 for notes on why the cmdlet is
    dot-sourced directly into this scope.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
    . "$PSScriptRoot\..\..\Public\Set-RscMssqlLogShippingSecondary.ps1"

    $mockCluster = New-Object RubrikSecurityCloud.Types.Cluster
    $mockCluster.Id = 'cluster-uuid-1'

    $mockLogShipping = New-Object RubrikSecurityCloud.Types.MssqlLogShippingTarget
    $mockLogShipping.Fid     = 'fid-1111'
    $mockLogShipping.CdmId   = 'cdmid-2222'
    $mockLogShipping.Cluster = $mockCluster
}

Describe 'Set-RscMssqlLogShippingSecondary — AutomaticReseed parameter set' {

    It 'builds updateMssqlLogShippingConfiguration query with makeupReseedLimit=1 when -AutomaticReseed is present' {
        $query = Set-RscMssqlLogShippingSecondary `
            -RscMssqlLogShipping $mockLogShipping `
            -AutomaticReseed `
            -AsQuery

        $query | Should -Not -BeNullOrEmpty
        $query.Var.input.GetType().Name          | Should -Be 'UpdateMssqlLogShippingConfigurationInput'
        $query.Var.input.Id                      | Should -Be $mockLogShipping.CdmId
        $query.Var.input.ClusterUuid             | Should -Be $mockCluster.Id
        $query.Var.input.Config.MakeupReseedLimit | Should -Be 1
    }

    It 'sets makeupReseedLimit=0 when -AutomaticReseed is absent' {
        $query = Set-RscMssqlLogShippingSecondary `
            -RscMssqlLogShipping $mockLogShipping `
            -AsQuery

        $query.Var.input.GetType().Name           | Should -Be 'UpdateMssqlLogShippingConfigurationInput'
        $query.Var.input.Config.MakeupReseedLimit  | Should -Be 0
    }

    It 'uses CdmId (not Fid) for the input Id field' {
        $query = Set-RscMssqlLogShippingSecondary `
            -RscMssqlLogShipping $mockLogShipping `
            -AsQuery

        $query.Var.input.Id | Should -Be $mockLogShipping.CdmId
        $query.Var.input.Id | Should -Not -Be $mockLogShipping.Fid
    }

    It 'invokes the query and returns the result' {
        Mock Invoke-Rsc -MockWith {
            $reply = New-Object RubrikSecurityCloud.Types.UpdateMssqlLogShippingConfigurationReply
            $reply.ShouldDisconnectStandbyUsers = $false
            return $reply
        }

        $result = Set-RscMssqlLogShippingSecondary `
            -RscMssqlLogShipping $mockLogShipping `
            -AutomaticReseed

        $result | Should -BeOfType [RubrikSecurityCloud.Types.UpdateMssqlLogShippingConfigurationReply]
        Assert-MockCalled Invoke-Rsc -Times 1
    }
}

Describe 'Set-RscMssqlLogShippingSecondary — State parameter set' {

    It 'builds updateMssqlLogShippingConfigurationV1 query for RESTORING state' {
        $query = Set-RscMssqlLogShippingSecondary `
            -RscMssqlLogShipping $mockLogShipping `
            -State RESTORING `
            -AsQuery

        $query | Should -Not -BeNullOrEmpty
        $query.Var.input.GetType().Name | Should -Be 'UpdateMssqlLogShippingConfigurationV1Input'
        $query.Var.input.Id             | Should -Be $mockLogShipping.Fid
        $query.Var.input.Config.MssqlLogShippingTargetStateOptions.State |
            Should -Be ([RubrikSecurityCloud.Types.MssqlLogShippingOkState]::MSSQL_LOG_SHIPPING_OK_STATE_RESTORING)
        $query.Var.input.Config.MssqlLogShippingTargetStateOptions.ShouldDisconnectStandbyUsers |
            Should -Be $false
    }

    It 'sets STANDBY state and ShouldDisconnectStandbyUsers=true when -DisconnectStandbyUsers is present' {
        $query = Set-RscMssqlLogShippingSecondary `
            -RscMssqlLogShipping $mockLogShipping `
            -State STANDBY `
            -DisconnectStandbyUsers `
            -AsQuery

        $query.Var.input.Config.MssqlLogShippingTargetStateOptions.State |
            Should -Be ([RubrikSecurityCloud.Types.MssqlLogShippingOkState]::MSSQL_LOG_SHIPPING_OK_STATE_STANDBY)
        $query.Var.input.Config.MssqlLogShippingTargetStateOptions.ShouldDisconnectStandbyUsers |
            Should -Be $true
    }

    It 'sets ShouldDisconnectStandbyUsers=false when -DisconnectStandbyUsers is absent' {
        $query = Set-RscMssqlLogShippingSecondary `
            -RscMssqlLogShipping $mockLogShipping `
            -State STANDBY `
            -AsQuery

        $query.Var.input.Config.MssqlLogShippingTargetStateOptions.ShouldDisconnectStandbyUsers |
            Should -Be $false
    }

    It 'uses Fid (not CdmId) for the input Id field' {
        $query = Set-RscMssqlLogShippingSecondary `
            -RscMssqlLogShipping $mockLogShipping `
            -State RESTORING `
            -AsQuery

        $query.Var.input.Id | Should -Be $mockLogShipping.Fid
        $query.Var.input.Id | Should -Not -Be $mockLogShipping.CdmId
    }

    It 'invokes the query and returns the result' {
        Mock Invoke-Rsc -MockWith {
            return [pscustomobject]@{ Status = 'QUEUED'; Id = 'job-1' }
        }

        $result = Set-RscMssqlLogShippingSecondary `
            -RscMssqlLogShipping $mockLogShipping `
            -State RESTORING

        $result.Status | Should -Be 'QUEUED'
        Assert-MockCalled Invoke-Rsc -Times 1
    }
}
