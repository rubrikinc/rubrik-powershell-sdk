BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # Variables shared among tests
    $Global:data = @{
        slaId = $null
        slaName = $null
    }
}

Describe -Name 'Set-RscSla Tests' -Tag 'Public' -Fixture {

    Context -Name 'Set-RscSla should update only specified fields not others' {
        BeforeEach {
            # Create a new SLA for testing
            try {
                $randomNumber = Get-Random -Minimum 1000 -Maximum 9999
                $slaName = "test-pwsh-e2e-$randomNumber"
                $description = "SLA created for PowerShell e2e testing."

                Write-Host "Creating SLA with name: $slaName"

                $query = New-RscMutationSla -Operation CreateGlobal
                $query.Var.input = @{
                    name = $slaName
                    description = $description
                    snapshotSchedule = @{
                        hourly = @{
                            basicSchedule = @{
                                frequency = 1
                                retention = 1
                                retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::HOURS
                            }
                        }
                    }
                    objectTypes = @(
                        [RubrikSecurityCloud.Types.SlaObjectType]::VSPHERE_OBJECT_TYPE
                    )
                    isRetentionLockedSla = $false
                }
                $result = $query | Invoke-Rsc
                $data.slaId = $result.Id
                $data.slaName = $result.Name

                Write-Host "Successfully created SLA with ID: $($Global:data.slaId) and Name: $($Global:data.slaName)"
            }
            catch {
                Set-ItResult -Skipped -Because "Failed to create SLA for the test: $_"
                return
            }
        }

        AfterEach {
            # Delete the SLA created for testing
            if ($data.slaId) {
                Write-Host "Deleting SLA: $($Global:data.slaName)"

                $query = New-RscMutationSla -Operation DeleteGlobal
                $query.Var.id = $data.slaId
                $query | Invoke-Rsc

                Write-Host "Successfully deleted SLA: $($Global:data.slaName)"

                $data.slaId = $null
                $data.slaName = $null
            }
        }
        

        It -Name 'Validates SLAs Update should not change unspecified fields' -Test {
            Write-Host "Starting test for SLA '$($data.slaName)'"
            $sla = Get-RscSla -Name $data.slaName
            $updatedDescription = $sla.description + " Updated"

            try {
                Set-RscSla -Sla $sla -Description $updatedDescription
            } catch {
                Write-Host "Updating Sla '$($data.slaName)' failed with error: $($_.Exception.Message)"
                return
            }

            $retrievedSla = Get-RscSla -Name $sla.Name
            
            $retrievedSla.description | Should -Be $updatedDescription

            # StateVersion will be updated by one after every update
            $sla.stateVersion | Should -Be ($retrievedSla.stateVersion - 1)

            # Clear the stateVersion & description since they already been checked
            $sla.stateVersion = $null
            $retrievedSla.stateVersion = $null
            $sla.description = $null
            $retrievedSla.description = $null

            # Clear `SnapshotScheduleLastUpdatedAt` since it will be updated after every update
            $sla.SnapshotScheduleLastUpdatedAt = $null
            $retrievedSla.SnapshotScheduleLastUpdatedAt = $null
            
            $originalJson = $sla | ConvertTo-Json -Depth 10
            $retrievedJson = $retrievedSla | ConvertTo-Json -Depth 10

            $originalJson | Should -Be $retrievedJson

            Write-Host "Completed test for SLA '$($data.slaName)'"
        }
    }
}