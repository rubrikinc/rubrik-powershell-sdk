BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Api "Organization"
    $Global:data = @{ orgs = $null }
}

Describe -Name 'Organization' -Tag 'E2E' -Fixture {

    Context 'List Organizations' {
        It 'lists organizations' {
            $data.orgs = Get-RscOrganization
            if (@($data.orgs).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List Organizations" "skip" "None found"
                Set-ItResult -Skipped -Because "No organizations found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List Organizations" "pass" "Found $(@($data.orgs).Count)"
        }
    }

    Context 'Retrieve by Id' {
        It 'retrieves org by Id' {
            if (-not $data.orgs -or @($data.orgs).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve Org by Id" "skip" "No orgs"
                Set-ItResult -Skipped -Because "No orgs"
                return
            }
            $org = Get-RscOrganization -Id $data.orgs[0].id
            $org.id | Should -Be $data.orgs[0].id
            $org.name | Should -Be $data.orgs[0].name
            Add-E2eDiagnosticEntry $diag "Retrieve Org by Id" "pass" "'$($org.name)'"
        }
    }

    Context 'Retrieve by Name' {
        It 'retrieves org by name' {
            if (-not $data.orgs -or @($data.orgs).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve Org by Name" "skip" "No orgs"
                Set-ItResult -Skipped -Because "No orgs"
                return
            }
            $filtered = Get-RscOrganization -Name $data.orgs[0].FullName
            foreach ($obj in $filtered) {
                $obj.name | Should -BeLike "*$($data.orgs[0].name)*"
            }
            $ids = $filtered | Where-Object { $_.id -eq $data.orgs[0].id }
            @($ids).Count | Should -BeExactly 1
            Add-E2eDiagnosticEntry $diag "Retrieve Org by Name" "pass" "'$($data.orgs[0].FullName)'"
        }
    }
}

AfterAll {
    Save-E2eDiagnostics $diag
}
