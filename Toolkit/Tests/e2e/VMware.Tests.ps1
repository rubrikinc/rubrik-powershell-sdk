BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Topic "VMware"
    $Global:data = @{ vms = $null }
}

Describe -Name 'VMware' -Tag 'E2E' -Fixture {

    Context 'List VMs' {
        It 'lists VMware VMs' {
            $data.vms = Get-RscVmwareVm
            if (@($data.vms).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List VMware VMs" "skip" "None found"
                Set-ItResult -Skipped -Because "No VMware VMs found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List VMware VMs" "pass" "Found $(@($data.vms).Count)"
        }
    }

    Context 'Retrieve by Id' {
        It 'retrieves VM by Id' {
            if (-not $data.vms -or @($data.vms).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve VM by Id" "skip" "No VMs"
                Set-ItResult -Skipped -Because "No VMs"
                return
            }
            $vm = Get-RscVmwareVm -Id $data.vms[0].id
            $vm.id | Should -Be $data.vms[0].id
            $vm.name | Should -Be $data.vms[0].name
            Add-E2eDiagnosticEntry $diag "Retrieve VM by Id" "pass" "'$($vm.name)'"
        }
    }

    Context 'Retrieve by Name' {
        It 'retrieves VM by Name' {
            if (-not $data.vms -or @($data.vms).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve VM by Name" "skip" "No VMs"
                Set-ItResult -Skipped -Because "No VMs"
                return
            }
            $results = Get-RscVmwareVm -Name $data.vms[0].name
            @($results).Count | Should -BeGreaterThan 0
            $match = $results | Where-Object { $_.id -eq $data.vms[0].id }
            $match | Should -Not -BeNullOrEmpty
            Add-E2eDiagnosticEntry $diag "Retrieve VM by Name" "pass" "'$($data.vms[0].name)'"
        }
    }
}

AfterAll {
    Save-E2eDiagnostics $diag
}
