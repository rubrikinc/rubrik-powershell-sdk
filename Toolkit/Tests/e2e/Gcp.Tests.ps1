BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Api "Gcp"
    $Global:data = @{ instances = $null }
}

Describe -Name 'Get-RscGcpGceInstance' -Tag 'E2E' -Fixture {

    Context 'List' {
        It 'retrieves GCE instances' {
            $data.instances = Get-RscGcpGceInstance
            if (@($data.instances).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List" "skip" "None found"
                Set-ItResult -Skipped -Because "No GCE instances found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List" "pass" "Found $(@($data.instances).Count)"
            $data.instances | Should -Not -BeNullOrEmpty
        }
    }

    Context 'By Id' {
        It 'retrieves a GCE instance by Id' {
            if (-not $data.instances) {
                Set-ItResult -Skipped -Because "No instances from list"
                return
            }
            $obj = Get-RscGcpGceInstance -Id $data.instances[0].Id
            $obj | Should -Not -BeNullOrEmpty
            Add-E2eDiagnosticEntry $diag "By Id" "pass" $data.instances[0].Id
        }
    }

    Context 'By Name' {
        It 'retrieves GCE instances by name substring' {
            if (-not $data.instances) {
                Set-ItResult -Skipped -Because "No instances from list"
                return
            }
            $firstName = $data.instances[0].Name
            $result = Get-RscGcpGceInstance -Name $firstName
            $result | Should -Not -BeNullOrEmpty
            Add-E2eDiagnosticEntry $diag "By Name" "pass" $firstName
        }
    }

    Context 'AsQuery' {
        It 'returns a query object with -AsQuery' {
            $q = Get-RscGcpGceInstance -AsQuery
            $q | Should -BeOfType [RubrikSecurityCloud.RscQuery]
        }

        It 'returns a query object for Id parameter set with -AsQuery' {
            $q = Get-RscGcpGceInstance -Id "00000000-0000-0000-0000-000000000000" -AsQuery
            $q | Should -BeOfType [RubrikSecurityCloud.RscQuery]
        }
    }
}

AfterAll {
    Save-E2eDiagnostics $diag
}
