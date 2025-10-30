BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    # Just getting VM type workloads here as getting all workloads may result in a very long running test.
    $Global:data = @{
        vm = Get-RscWorkload -Type VMWARE_VIRTUAL_MACHINE
    }
}

Describe -Name 'Get-RscWorkload Tests' -Tag 'Public' -Fixture {

    Context -Name 'VM Count > 0' {
        BeforeEach {
            # Skip the tests if empty VM list
            if ($data.vm.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 VM is needed"
                return
            }
        }

        It -Name 'retrieves single workload by RSC ID' -Test {
            $vm0 = Get-RscWorkload -Id $data.vm[0].fid
            $vm0.name | Should -Be $data.vm[0].name
            $vm0.fid | Should -Be $data.vm[0].fid
        }

        It -Name 'retrieves single workload by CDM ID' -Test {
            $vm0 = Get-RscWorkload -CdmId $data.vm[0].id -Cluster (Get-RscCluster -Name $data.vm[0].cluster.name)
            $vm0.name | Should -Be $data.vm[0].name
            $vm0.id | Should -Be $data.vm[0].id
        }

        It -Name 'retrieves workloads by compliance status' -Test {
            $results = Get-RscWorkload -Type VMWARE_VIRTUAL_MACHINE -ComplianceStatus OUT_OF_COMPLIANCE
            $notOutOfCompliance = $results | ForEach-Object { $_.complianceStatus -eq 'OUT_OF_COMPLIANCE' } | 
            Where-Object { $_ -eq $false } | Measure-Object | Select-Object -ExpandProperty Count
            ($isArrayEmpty -or $notOutOfCompliance -eq 0) | Should -BeTrue
        }

        It -Name 'filters workloads by compliance time range' -Test {
            $past7days = (Get-RscWorkload -ComplianceStatus OUT_OF_COMPLIANCE -ComplianceTimeRange PAST_7_DAYS | measure-object).count
            $sinceProtection = (Get-RscWorkload -ComplianceStatus OUT_OF_COMPLIANCE | measure-object).count
            ($sinceProtection -gt $past7days) | Should -BeTrue
        }

    }
}
