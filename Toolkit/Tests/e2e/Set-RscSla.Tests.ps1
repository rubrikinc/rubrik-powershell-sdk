BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # Variables shared among tests
    $Global:data = @{
        slaList = $null
    }
}

# Skip tests for duplicated SLAs in dev/staging due to unique key constraint on SLA name.
# Also, skip tests if slaName is a prefix of another, causing Get-RscSla to return multiple SLAs.
function IsValidSla {
    param (
        [Parameter(Mandatory = $true)]
        [string] $slaName
    )

    $slaList = Get-RscSla -Name $slaName
    if ($slaList.Count -gt 1) {
        Write-Host "Skipping SLA '$slaName' due to duplication or name bieng prefix of another SLA"
        return $false
    }

    return $true
}

function Compare-ArchivalSpecs {
    param (
        [Array]$original,
        [Array]$retrieved
    )
    if ($original.Count -ne $retrieved.Count) {
        return $false
    }

    foreach ($originalSpec in $original) {
        $match = $false
        foreach ($retrievedSpec in $retrieved) {
            $originalSpecJson = $originalSpec | ConvertTo-Json -Depth 10
            $retrievedSpecJson = $retrievedSpec | ConvertTo-Json -Depth 10
            if ($originalSpecJson -eq $retrievedSpecJson) {
                $match = $true
                break
            }
        }
        
        if (-not $match) {
            return $false
        }
    }

    return $true
}

# TODO: Fix this test : replace -Skip with -Fixture
# see https://rubrik.atlassian.net/browse/SPARK-462879
Write-Warning "TODO: Set-RscSla Tests are skipped"
Describe -Name 'Set-RscSla Tests' -Tag 'Public' -Skip {

    Context -Name 'Set-RscSla should update only specified fields not others' {
        BeforeEach {
            $data.slaList = Get-RscSla | Sort-Object -Property SnapshotScheduleLastUpdatedAt -Descending | Select-Object -First 20
            if ($data.slaList.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 SLA is needed"
                return
            }
        }

        It -Name 'Validates SLAs Update should not change unspecified fields' -Test {
            Write-Host "Proceeding testing $($data.slaList.count) SLAs"
            
            foreach ($sla in $data.slaList) {
                $slaName = $sla.Name

                if (-not (IsValidSla -slaName $slaName)) {
                    continue
                }

                Write-Host "Starting test for SLA '$slaName' - Date Updated: $($sla.SnapshotScheduleLastUpdatedAt)"

                # Currently on dev/staging env, there exists a lot of invalid SLAs, 
                # which will cause the test to fail, hence logging the error 
                # and skipping the test. Here we are testing if Set-RscSla operation 
                # is sucessful then it should not change any fields.
                try {
                    # Perform the update without changing any fields
                    Set-RscSla -Sla $sla
                } catch {
                    Write-Host "Test Name: $($sla.Name), Test ID: $($sla.Id), Error: $($_.Exception.Message)"
                    continue
                }

                $retrievedSla = Get-RscSla -Name $sla.Name
    
                # StateVersion will be updated by one after every update
                $sla.stateVersion | Should -Be ($retrievedSla.stateVersion - 1)

                # Clear the stateVersion since they already been checked
                $sla.stateVersion = $null
                $retrievedSla.stateVersion = $null

                # Ignore comparing `storageSetting.Id` field for 
                # archivalSpec, as it gets change every time update is performed
                if ($sla.archivalSpecs -ne $null) {
                    foreach ($spec in $sla.archivalSpecs) {
                        if ($spec.storageSetting -ne $null) {
                            $spec.storageSetting.Id = $null
                        }
                    }
                }

                if ($retrievedSla.archivalSpecs -ne $null) {
                    foreach ($spec in $retrievedSla.archivalSpecs) {
                        if ($spec.storageSetting -ne $null) {
                            $spec.storageSetting.Id = $null
                        }
                    }
                }

                # archivalSepcs are not compared directly as they are arrays of objects
                # and can come in any order, hence comparing them separately
                $archivalSpecsMatch = $true
                if ($sla.archivalSpecs -ne $null -or $retrievedSla.archivalSpecs -ne $null) {
                    $archivalSpecsMatch = Compare-ArchivalSpecs -original $sla.archivalSpecs -retrieved $retrievedSla.archivalSpecs
                }

                $archivalSpecsMatch | Should -Be $true
                
                # Clear the archivalSpecs since they already been checked
                $sla.archivalSpecs = $null
                $retrievedSla.archivalSpecs = $null
                
                # Convert the original & retrieved SLA object to JSON for comparison,
                # and compare the JSON strings
                $originalJson = $sla | ConvertTo-Json -Depth 10
                $retrievedJson = $retrievedSla | ConvertTo-Json -Depth 10
                $originalJson | Should -Be $retrievedJson

                Write-Host "Completed test for SLA '$slaName'"
            }
        }
    }
}