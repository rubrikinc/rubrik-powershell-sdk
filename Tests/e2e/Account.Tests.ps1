<#
.SYNOPSIS
Run tests around account settings
#>
BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}

Describe -Name 'Connect to API' -Fixture {
    It -Name 'New-RscQueryAccount' -Test {

        # API Domain: Account
        # API Operation: AccountSettings
        # Return type: AccountSetting, consists of 2 bools
        # Default profile selects them both for retrieval
        $query = New-RscQueryAccount -Setting
        $query.Field.isEmailNotificationEnabled | Should -Not -BeNullOrEmpty
        $query.Field.IsEulaAccepted | Should -Not -BeNullOrEmpty

        # Result should show both fields
        $accountSetting = $query | Invoke-Rsc
        $accountSetting.isEmailNotificationEnabled | Should -Not -BeNullOrEmpty
        $accountSetting.IsEulaAccepted | Should -Not -BeNullOrEmpty

        # Take out second bool out of the query
        $query.Field.IsEulaAccepted = $null

        # Result should show only the first bool
        $accountSetting = $query | Invoke-Rsc
        $accountSetting.isEmailNotificationEnabled | Should -Not -BeNullOrEmpty
        $accountSetting.IsEulaAccepted | Should -BeNullOrEmpty


    }
}
