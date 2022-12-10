BeforeALl {
    & "$PSScriptRoot\..\..\Samples\import.ps1"
    . "$PSScriptRoot\..\serviceaccount.ps1"
}

Describe -Name "Send a generic GraphQL call\n" -Fixture {
    Context -Name 'Getting account settings using a generic GraphQL call' {
        It -Name 'Invoke-RscGraphQLCall' -Test {

            Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile)
            
            $response = Invoke-RscGraphQLCall -Body '{"query":"query accountSettings{accountSettings{isEulaAccepted}}"}'
            $response | Should -Not -BeNullOrEmpty
            $response | Should -BeLikeExactly $(ConvertFrom-Json -InputObject '{"accountSettings":{"isEulaAccepted":false}}')
        }
    }
}
