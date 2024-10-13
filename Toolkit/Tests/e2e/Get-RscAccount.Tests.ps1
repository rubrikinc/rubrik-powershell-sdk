BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
    }
}

Describe -Name 'Get-RscAccount Tests' -Tag 'Public' -Fixture {

    It -Name 'gets account' -Test {
        $account = Get-RscAccount
        # Write-Host $account
        $account | Should -Not -BeNullOrEmpty
        $account.AccountOwnerId | Should -Not -BeNullOrEmpty
    }
}
