& "$PSScriptRoot\..\..\Utils\import.ps1"
. "$PSScriptRoot\..\serviceaccount.ps1"

Describe -Name 'Connect to API' -Fixture {
    Context -Name 'Connections with service account file' {
        It -Name 'Connect-Rsc -ServiceAccountFile' -Test {
            Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile) | Should -BeLikeExactly "Authentication Status: AUTHORIZED"
        }
        It -Name 'Query-RscAccount' -Test {
            Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile)
            $accountSetting = [Rubrik.SecurityCloud.Types.AccountSetting]@{}
            $accountSetting.IsEulaAccepted = "FETCH ME!"
            $accountSetting = Query-RscAccount -Setting $accountSetting
            $accountSetting.IsEulaAccepted | Should -Not -BeLikeExactly "FETCH ME!"
            $accountSetting.isEmailNotificationEnabled | Should -BeNullOrEmpty
        }
        It -Name 'Disconnect-Rsc' -Test {
            Disconnect-Rsc | Should -BeLikeExactly "The Rubrik Security Cloud session has been terminated."
        }
    }
}
