BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}

Describe -Name "Send a generic GraphQL call" -Fixture {
    It -Name 'Invoke-RscGraphQLCall' -Test {

        $response = Invoke-Rsc -Query "query accountSettings{accountSettings{isEulaAccepted}}"
        $response | Should -Not -BeNullOrEmpty
        $response | Should -BeLikeExactly $(ConvertFrom-Json -InputObject '{"accountSettings":{"isEulaAccepted":false}}')
    }
}
