BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Topic "Workload"
    $Global:data = @{ vms = $null }
}

Describe -Name 'Workload' -Tag 'E2E' -Fixture {

    # --- Get-RscWorkload ---

    Context 'List Workloads' {
        It 'lists VMware workloads' {
            $data.vms = Get-RscWorkload -Type VMWARE_VIRTUAL_MACHINE
            if (@($data.vms).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List VMware Workloads" "skip" "None found"
                Set-ItResult -Skipped -Because "No VMware workloads found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List VMware Workloads" "pass" "Found $(@($data.vms).Count)"
        }
    }

    Context 'Retrieve by RSC ID' {
        It 'retrieves workload by RSC ID' {
            if (-not $data.vms -or @($data.vms).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve by RSC ID" "skip" "No workloads"
                Set-ItResult -Skipped -Because "No workloads"
                return
            }
            $vm = Get-RscWorkload -Id $data.vms[0].fid
            $vm.fid | Should -Be $data.vms[0].fid
            $vm.name | Should -Be $data.vms[0].name
            Add-E2eDiagnosticEntry $diag "Retrieve by RSC ID" "pass" "'$($vm.name)'"
        }
    }

    Context 'Retrieve by CDM ID' {
        It 'retrieves workload by CDM ID' {
            if (-not $data.vms -or @($data.vms).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve by CDM ID" "skip" "No workloads"
                Set-ItResult -Skipped -Because "No workloads"
                return
            }
            $cluster = Get-RscCluster -Name $data.vms[0].cluster.name
            $vm = Get-RscWorkload -CdmId $data.vms[0].id -Cluster $cluster
            $vm.id | Should -Be $data.vms[0].id
            $vm.name | Should -Be $data.vms[0].name
            Add-E2eDiagnosticEntry $diag "Retrieve by CDM ID" "pass" "'$($vm.name)'"
        }
    }

    Context 'Filter by Compliance Status' {
        It 'retrieves workloads by compliance status' {
            if (-not $data.vms -or @($data.vms).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Filter by Compliance Status" "skip" "No workloads"
                Set-ItResult -Skipped -Because "No workloads"
                return
            }
            $results = Get-RscWorkload -Type VMWARE_VIRTUAL_MACHINE -ComplianceStatus OUT_OF_COMPLIANCE
            $notMatch = $results | Where-Object { $_.complianceStatus -ne 'OUT_OF_COMPLIANCE' }
            @($notMatch).Count | Should -Be 0
            Add-E2eDiagnosticEntry $diag "Filter by Compliance Status" "pass" "Found $(@($results).Count) out-of-compliance"
        }

        It 'filters workloads by compliance time range' {
            if (-not $data.vms -or @($data.vms).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Filter by Compliance Time Range" "skip" "No workloads"
                Set-ItResult -Skipped -Because "No workloads"
                return
            }
            $past7days = @(Get-RscWorkload -ComplianceStatus OUT_OF_COMPLIANCE -ComplianceTimeRange PAST_7_DAYS).Count
            $sinceProtection = @(Get-RscWorkload -ComplianceStatus OUT_OF_COMPLIANCE).Count
            ($sinceProtection -ge $past7days) | Should -BeTrue
            Add-E2eDiagnosticEntry $diag "Filter by Compliance Time Range" "pass" "7d=$past7days, all=$sinceProtection"
        }
    }

    # --- Protect-RscLinkedWorkload ---

    Context 'Protect-RscLinkedWorkload' {
        It 'creates a linked workload protection query' {
            $ag1 = Get-RscType -Name MssqlAvailabilityGroup
            $ag2 = Get-RscType -Name MssqlAvailabilityGroup
            $sla = Get-RscType -Name GlobalSlaReply
            $query = Protect-RscLinkedWorkload -InputObject $ag1 -LinkedObject $ag2 -LinkingOperation LINK -Sla $sla -AssignmentType PROTECT_WITH_SLA_ID -AsQuery
            $query | Should -BeOfType [RubrikSecurityCloud.RscQuery]
            Add-E2eDiagnosticEntry $diag "Protect-RscLinkedWorkload AsQuery" "pass" "Query created"
        }
    }
}

AfterAll {
    Save-E2eDiagnostics $diag
}
