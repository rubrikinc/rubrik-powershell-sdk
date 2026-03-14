BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Api "Nutanix"
    $Global:data = @{ vms = $null }
}

Describe -Name 'Nutanix' -Tag 'E2E' -Fixture {

    Context 'List VMs' {
        It 'lists Nutanix VMs' {
            $data.vms = Get-RscNutanixVm
            if (@($data.vms).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List Nutanix VMs" "skip" "None found"
                Set-ItResult -Skipped -Because "No Nutanix VMs found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List Nutanix VMs" "pass" "Found $(@($data.vms).Count)"
        }
    }

    Context 'Retrieve by Id' {
        It 'retrieves VM by Id' {
            if (-not $data.vms -or @($data.vms).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve VM by Id" "skip" "No VMs"
                Set-ItResult -Skipped -Because "No VMs"
                return
            }
            $vm = Get-RscNutanixVm -Id $data.vms[0].id
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
            $results = Get-RscNutanixVm -Name $data.vms[0].name
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
