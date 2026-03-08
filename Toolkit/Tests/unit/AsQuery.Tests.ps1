<#
.SYNOPSIS
Verify that all exported commands with an -AsQuery parameter
return an [RubrikSecurityCloud.RscQuery] object (or array of them).

Commands with mandatory parameters are tested with mock objects.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name "AsQuery Parameter Tests" -Fixture {

    It -Name 'At least 60 commands have -AsQuery' -Test {
        $commands = Get-Command -Module RubrikSecurityCloud |
            Where-Object { $_.Parameters.ContainsKey('AsQuery') }
        $commands.Count | Should -BeGreaterOrEqual 60
    }

    BeforeAll {
        # Build mock objects for mandatory parameters.
        # These don't need valid data — -AsQuery returns
        # the query object before any API call.
        $mockMssqlDb = New-Object RubrikSecurityCloud.Types.MssqlDatabase
        $mockMssqlInstance = New-Object RubrikSecurityCloud.Types.MssqlInstance
        $mockSla = New-Object RubrikSecurityCloud.Types.GlobalSlaReply
        $mockCluster = New-Object RubrikSecurityCloud.Types.Cluster
        $mockManagedVolume = New-Object RubrikSecurityCloud.Types.ManagedVolume
        $mockRole = New-Object RubrikSecurityCloud.Types.Role
        $mockVm = New-Object RubrikSecurityCloud.Types.VsphereVm
        $mockNasShareInput = @(New-Object RubrikSecurityCloud.Types.CreateNasShareInput)
        $mockUpdateNasShareInput = @(New-Object RubrikSecurityCloud.Types.UpdateNasShareInput)
        $mockLiveMount = New-Object RubrikSecurityCloud.Types.MssqlDatabaseLiveMount
        $mockLogShipping = New-Object RubrikSecurityCloud.Types.MssqlLogShippingTarget
        $mockNasSystem = New-Object RubrikSecurityCloud.Types.NasSystem
        $mockNasSystem.VendorType = [RubrikSecurityCloud.Types.NasVendorType]::GENERIC

        # Mock params for commands that need mandatory arguments.
        $mockParams = @{
            'Get-RscCloudNativeTagRule'              = @{ ObjectType = [RubrikSecurityCloud.Types.CloudNativeTagObjectType]::AWS_EBS_VOLUME }
            'Get-RscMssqlDatabaseFiles'              = @{ RscMssqlDatabase = $mockMssqlDb; RecoveryDateTime = [datetime]'2024-01-01' }
            'Get-RscMssqlDatabaseRecoverableRanges'  = @{ RscMssqlDatabase = $mockMssqlDb }
            'Get-RscMssqlDatabaseRecoveryPoint'      = @{ RscMssqlDatabase = $mockMssqlDb; Latest = $true }
            'Get-RscSnapshot'                        = @{ Id = '00000000-0000-0000-0000-000000000000' }
            'New-RscMssqlExport'                     = @{ RscMssqlDatabase = $mockMssqlDb; RecoveryDateTime = [datetime]'2024-01-01'; TargetMssqlInstance = $mockMssqlInstance; TargetDatabaseName = 'mock'; TargetDataPath = 'c:\data'; TargeLogPath = 'c:\log' }
            'New-RscMssqlLiveMount'                  = @{ RscMssqlDatabase = $mockMssqlDb; MountedDatabaseName = 'mock'; TargetMssqlInstance = $mockMssqlInstance; RecoveryDateTime = [datetime]'2024-01-01' }
            'New-RscMssqlLogBackup'                  = @{ RscMssqlDatabase = $mockMssqlDb }
            'New-RscMssqlLogShippingSecondary'       = @{ RscMssqlDatabase = $mockMssqlDb; TargetMssqlInstance = $mockMssqlInstance; TargetDatabaseName = 'mock'; State = 'RESTORING'; TargetDataPath = 'c:\data'; TargeLogPath = 'c:\log' }
            'New-RscMssqlRestore'                    = @{ RscMssqlDatabase = $mockMssqlDb; RecoveryDateTime = [datetime]'2024-01-01' }
            'New-RscMssqlSnapshot'                   = @{ RscMssqlDatabase = $mockMssqlDb; RscSlaDomain = $mockSla }
            'New-RscNasShare'                        = @{ NasSystemId = '00000000-0000-0000-0000-000000000000'; NasShares = $mockNasShareInput }
            'New-RscNasSystem'                       = @{ Cluster = $mockCluster; Hostname = 'mock-host'; Generic = $true }
            'New-RscPermission'                      = @{ Operation = [RubrikSecurityCloud.Types.Operation]::VIEW_CLUSTER }
            'New-RscSla'                             = @{ Name = 'mock-sla'; ObjectType = [RubrikSecurityCloud.Types.SlaObjectType]::VSPHERE_OBJECT_TYPE }
            'Protect-RscLinkedWorkload'              = @{ InputObject = $mockVm; AssignmentType = [RubrikSecurityCloud.Types.SlaAssignTypeEnum]::PROTECT_WITH_SLA_ID; LinkedObject = $mockVm; LinkingOperation = [RubrikSecurityCloud.Types.ManageProtectionForLinkedObjectsOperationType]::LINK }
            'Register-RscRubrikBackupService'        = @{ VM = $mockVm }
            'Remove-RscMssqlLiveMount'               = @{ MssqlLiveMount = $mockLiveMount }
            'Remove-RscMssqlLogShippingSecondary'    = @{ RscMssqlLogShipping = $mockLogShipping }
            'Remove-RscNasShare'                     = @{ Ids = @('00000000-0000-0000-0000-000000000000') }
            'Remove-RscNasSystem'                    = @{ Id = '00000000-0000-0000-0000-000000000000' }
            'Remove-RscSla'                          = @{ GlobalSla = $mockSla }
            'Resume-RscSla'                          = @{ ClusterUuids = @('00000000-0000-0000-0000-000000000000'); GlobalSla = $mockSla }
            'Set-RscMssqlDatabase'                   = @{ RscMssqlDatabase = $mockMssqlDb; RscCluster = $mockCluster; RemovePreBackupScript = $true }
            'Set-RscMssqlLogShippingSecondary'       = @{ RscMssqlLogShipping = $mockLogShipping }
            'Set-RscNasShare'                        = @{ NasShares = $mockUpdateNasShareInput }
            'Set-RscNasSystem'                       = @{ NasSystem = $mockNasSystem }
            'Set-RscRole'                            = @{ Role = $mockRole }
            'Start-RscManagedVolumeSnapshot'         = @{ RscManagedVolume = $mockManagedVolume }
            'Stop-RscManagedVolumeSnapshot'          = @{ RscManagedVolume = $mockManagedVolume; RscSlaDomain = $mockSla }
            'Suspend-RscSla'                         = @{ ClusterUuids = @('00000000-0000-0000-0000-000000000000'); GlobalSla = $mockSla }
        }

        # All commands with -AsQuery
        $allCommands = Get-Command -Module RubrikSecurityCloud |
            Where-Object { $_.Parameters.ContainsKey('AsQuery') }
    }

    It -Name 'All -AsQuery commands return RscQuery objects' -Test {
        $failures = @()
        foreach ($cmd in $allCommands) {
            try {
                $params = @{ AsQuery = $true }
                if ($mockParams.ContainsKey($cmd.Name)) {
                    foreach ($kv in $mockParams[$cmd.Name].GetEnumerator()) {
                        $params[$kv.Key] = $kv.Value
                    }
                }
                $result = & $cmd.Name @params
                if ($result -is [System.Array]) {
                    foreach ($item in $result) {
                        if ($item -isnot [RubrikSecurityCloud.RscQuery]) {
                            $failures += "$($cmd.Name): array element is $($item.GetType().FullName)"
                        }
                    }
                } elseif ($null -eq $result) {
                    $failures += "$($cmd.Name): returned null"
                } else {
                    if ($result -isnot [RubrikSecurityCloud.RscQuery]) {
                        $failures += "$($cmd.Name): returned $($result.GetType().FullName)"
                    }
                }
            } catch {
                $failures += "$($cmd.Name): threw exception: $_"
            }
        }

        if ($failures.Count -gt 0) {
            $msg = "$($failures.Count) command(s) failed:`n" + ($failures -join "`n")
            $msg | Should -BeNullOrEmpty
        }
    }
}
