BeforeAll {
    & "$PSScriptRoot\..\..\Utils\import.ps1"
    . "$PSScriptRoot\..\serviceaccount.ps1"
}

Describe -Name 'Connect to API' -Fixture {
    BeforeAll {
        Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile)
    }

    It -Name 'Invoke-RscQueryAccount' -Test {
        $accountSetting = Invoke-RscQueryAccount -Setting
        $accountSetting.IsEulaAccepted | Should -Not -BeNullOrEmpty
        $accountSetting.isEmailNotificationEnabled | Should -Not -BeNullOrEmpty
    }
}
