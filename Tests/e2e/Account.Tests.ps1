<#
.SYNOPSIS
Run tests around account settings
#>
BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}

Describe -Name 'Connect to API' -Fixture {
    It -Name 'Invoke-RscQueryAccount' -Test {
        $f = (Invoke-RscQueryAccount -Setting -GetInput).Field
        $f.IsEulaAccepted | Should -Not -BeNullOrEmpty
        $f.isEmailNotificationEnabled | Should -Not -BeNullOrEmpty
        $accountSetting = Invoke-RscQueryAccount -Setting
        $accountSetting.IsEulaAccepted | Should -Not -BeNullOrEmpty
        $accountSetting.isEmailNotificationEnabled | Should -Not -BeNullOrEmpty
    }
}
