BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}

Describe -Name "Send a generic GraphQL call" -Fixture {
    It -Name 'Invoke-RscGraphQLCall' -Test {

        $response = Invoke-Rsc -Query "query accountSettings{accountSettings{isEulaAccepted}}"
        $response.GetType().Name | Should -BeExactly 'AccountSetting'
        $fields =  ($response|gm -MemberType Property).Name
        $fields | Should -BeExactly @('IsEmailNotificationEnabled','IsEulaAccepted')
        $response.IsEmailNotificationEnabled | Should -BeNullOrEmpty
        $response.IsEulaAccepted | Should -Not -BeNullOrEmpty
    }
}
