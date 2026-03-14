BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Api "Account"
}

Describe -Name 'Account' -Tag 'E2E' -Fixture {

    Context 'Get-RscAccount' {
        It 'retrieves account info' {
            $account = Get-RscAccount
            if (-not $account) {
                Add-E2eDiagnosticEntry $diag "Get Account" "fail" "Returned null"
                $account | Should -Not -BeNullOrEmpty
                return
            }
            $account.AccountOwnerId | Should -Not -BeNullOrEmpty
            Add-E2eDiagnosticEntry $diag "Get Account" "pass" "Owner: $($account.AccountOwnerId)"
        }
    }
}

AfterAll {
    Save-E2eDiagnostics $diag
}
