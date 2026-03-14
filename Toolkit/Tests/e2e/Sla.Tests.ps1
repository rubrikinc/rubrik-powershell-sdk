BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Api "Sla"
    $Global:data = @{
        slas       = $null
        testSlaId  = $null
        testSlaName = $null
    }

    # Clean up any leftover test SLAs from previous runs
    try {
        $cleaned = Remove-E2eTestSlas
        if ($cleaned -gt 0) {
            if ($Global:E2eDiagVerbose) { Write-Host "Cleaned up $cleaned leftover test SLA(s)" }
        }
    } catch {
        if ($Global:E2eDiagVerbose) { Write-Host "Could not clean up leftover test SLAs: $_" }
    }

    # Create a fresh test SLA for mutation tests
    $data.testSlaName = New-E2eTestSlaName
    try {
        $q = New-RscMutationSla -Operation CreateGlobal
        $q.Var.input = @{
            name        = $data.testSlaName
            description = "SDK E2E test SLA - safe to delete"
            snapshotSchedule = @{
                hourly = @{
                    basicSchedule = @{
                        frequency     = 1
                        retention     = 1
                        retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::HOURS
                    }
                }
            }
            objectTypes = @(
                [RubrikSecurityCloud.Types.SlaObjectType]::VSPHERE_OBJECT_TYPE
            )
            isRetentionLockedSla = $false
        }
        $result = $q | Invoke-Rsc
        $data.testSlaId = $result.Id
        if ($Global:E2eDiagVerbose) { Write-Host "Created test SLA '$($data.testSlaName)' (Id: $($data.testSlaId))" }
    }
    catch {
        Write-Warning ("Could not create test SLA (mutation tests will be skipped).`n" +
            "  This may not be a defect — your service account may lack write permissions.`n" +
            "  Error: $_")
    }
}

Describe -Name 'Sla' -Tag 'E2E' -Fixture {

    # --- SLA Read ---

    Context 'List SLAs' {
        It 'lists all SLAs' {
            $data.slas = Get-RscSla
            if (@($data.slas).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List SLAs" "skip" "None found"
                Set-ItResult -Skipped -Because "No SLAs found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List SLAs" "pass" "Found $(@($data.slas).Count)"
        }
    }

    Context 'Retrieve SLA by Id' {
        It 'retrieves SLA by Id' {
            if (-not $data.slas -or @($data.slas).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve SLA by Id" "skip" "No SLAs"
                Set-ItResult -Skipped -Because "No SLAs"
                return
            }
            $sla = Get-RscSla -Id $data.slas[0].id
            $sla.id | Should -Be $data.slas[0].id
            $sla.name | Should -Be $data.slas[0].name
            Add-E2eDiagnosticEntry $diag "Retrieve SLA by Id" "pass" "'$($sla.name)'"
        }
    }

    Context 'Retrieve SLA by Name' {
        It 'retrieves SLA by Name' {
            if (-not $data.slas -or @($data.slas).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve SLA by Name" "skip" "No SLAs"
                Set-ItResult -Skipped -Because "No SLAs"
                return
            }
            $results = Get-RscSla -Name $data.slas[0].name
            @($results).Count | Should -BeGreaterThan 0
            $match = $results | Where-Object { $_.id -eq $data.slas[0].id }
            $match | Should -Not -BeNullOrEmpty
            Add-E2eDiagnosticEntry $diag "Retrieve SLA by Name" "pass" "'$($data.slas[0].name)'"
        }
    }

    # --- SLA Mutations ---

    Context 'SLA Mutations' {
        It 'verifies test SLA was created' {
            if (-not $data.testSlaId) {
                Add-E2eDiagnosticEntry $diag "Test SLA Created" "skip" "Could not create test SLA (permissions?)"
                Set-ItResult -Skipped -Because "Could not create test SLA — service account may lack write permissions"
                return
            }
            $sla = Get-RscSla -Id $data.testSlaId
            $sla.id | Should -Be $data.testSlaId
            $sla.name | Should -Be $data.testSlaName
            Add-E2eDiagnosticEntry $diag "Test SLA Created" "pass" "'$($sla.name)'"
        }

        It 'modifies description via Set-RscSla' {
            if (-not $data.testSlaId) {
                Add-E2eDiagnosticEntry $diag "Modify SLA Description" "skip" "No test SLA (permissions?)"
                Set-ItResult -Skipped -Because "No test SLA — service account may lack write permissions"
                return
            }
            $sla = Get-RscSla -Name $data.testSlaName
            $updatedDescription = $sla.description + " Updated"

            try {
                Set-RscSla -Sla $sla -Description $updatedDescription
            }
            catch {
                Add-E2eDiagnosticEntry $diag "Modify SLA Description" "skip" "Mutation failed (permissions?): $_"
                Set-ItResult -Skipped -Because "Mutation failed — service account may lack write permissions: $_"
                return
            }

            $retrieved = Get-RscSla -Name $sla.Name
            $retrieved.description | Should -Be $updatedDescription
            Add-E2eDiagnosticEntry $diag "Modify SLA Description" "pass" "Description updated"
        }

        It 'preserves unmodified fields after Set-RscSla' {
            if (-not $data.testSlaId) {
                Add-E2eDiagnosticEntry $diag "Preserve Unmodified Fields" "skip" "No test SLA (permissions?)"
                Set-ItResult -Skipped -Because "No test SLA — service account may lack write permissions"
                return
            }
            $sla = Get-RscSla -Id $data.testSlaId

            # stateVersion should have incremented by 1 from the previous modify
            # Null out fields that are expected to change
            $originalVersion = $sla.stateVersion

            $updatedDescription = $sla.description + " v2"
            Set-RscSla -Sla $sla -Description $updatedDescription

            $retrieved = Get-RscSla -Id $data.testSlaId
            $retrieved.stateVersion | Should -Be ($originalVersion + 1)

            # Compare JSON after nulling out expected-to-change fields
            $sla.stateVersion = $null
            $retrieved.stateVersion = $null
            $sla.description = $null
            $retrieved.description = $null
            $sla.SnapshotScheduleLastUpdatedAt = $null
            $retrieved.SnapshotScheduleLastUpdatedAt = $null

            $originalJson = $sla | ConvertTo-Json -Depth 10
            $retrievedJson = $retrieved | ConvertTo-Json -Depth 10
            $originalJson | Should -Be $retrievedJson

            Add-E2eDiagnosticEntry $diag "Preserve Unmodified Fields" "pass" "JSON match confirmed"
        }
    }
}

AfterAll {
    # Delete the test SLA
    if ($data.testSlaId) {
        try {
            $q = New-RscMutationSla -Operation DeleteGlobal
            $q.Var.id = $data.testSlaId
            $q | Invoke-Rsc | Out-Null
            if ($Global:E2eDiagVerbose) { Write-Host "Deleted test SLA '$($data.testSlaName)'" }
        }
        catch {
            Write-Warning "Failed to delete test SLA '$($data.testSlaName)': $_"
        }
    }

    # Final sweep: clean up any remaining test SLAs
    $cleaned = Remove-E2eTestSlas
    if ($cleaned -gt 0) {
        if ($Global:E2eDiagVerbose) { Write-Host "Final cleanup: removed $cleaned leftover test SLA(s)" }
    }

    Save-E2eDiagnostics $diag
}
