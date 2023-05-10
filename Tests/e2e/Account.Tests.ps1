& "$PSScriptRoot\..\..\Utils\import.ps1"
. "$PSScriptRoot\..\serviceaccount.ps1"

Describe -Name 'Connect to API' -Fixture {
    Context -Name 'Connections with service account file' {
        It -Name 'Connect-Rsc' -Test {
            Connect-Rsc
        }
        It -Name 'Invoke-RscQueryAccount' -Test {
            $accountSetting = Invoke-RscQueryAccount -Setting
            $accountSetting.IsEulaAccepted | Should -Not -BeNullOrEmpty
            $accountSetting.isEmailNotificationEnabled | Should -Not -BeNullOrEmpty
        }
        It -Name 'Disconnect-Rsc' -Test {
            Disconnect-Rsc | Should -BeLikeExactly "The Rubrik Security Cloud session has been terminated."
        }
    }
}
