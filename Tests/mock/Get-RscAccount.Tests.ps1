<#
.SYNOPSIS
Mock test for Get-RscAccount

.DESCRIPTION
This script makes use of the SDK's mock API server 'mock_api_server'

.PARAMETER u
Equivalent to --user-existing. Set this to use an already running
mock_api_server and skip start and stop.
#>
param(
    [Alias("u")]
    [Parameter(Mandatory = $false)]
    [switch]$UseExistingMockServer
)

& "$PSScriptRoot\..\..\Samples\import.ps1"
. "$PSScriptRoot\..\mock_api_server.ps1"

BeforeAll {
    if ( ! $UseExistingMockServer) {
        Start-MockApiServer
    }
    $Env:RSC_SERVICE_ACCOUNT_FILE = "$PSScriptRoot/mock_service_account.json"
    . "$PSScriptRoot\..\serviceaccount.ps1"
}

Describe -Name 'Connect to API' -Fixture {
    It "Returns <expected> (for <name>)" -ForEach @(
        @{ 
            Query         =
            "{
                    'query':
                        'query QueryAccountSettings{
                            accountSettings{
                                isEmailNotificationEnabled
                                isEulaAccepted
                                __typename
                            }
                            __typename
                        }',
                        'operationName': 'QueryAccountSettings',
                        'variables': '{}'
                }"
            ExpectedReply =
            "{
                    'accountSettings': {
                        'isEmailNotificationEnabled': true,
                        'isEulaAccepted': false,
                        '__typename': 'AccountSetting'
                    }
                }"
        }
    ) {
        Update-MockApiServerCache -Query $Query -Reply $ExpectedReply
        Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile) |
        Should -BeLikeExactly "AUTHORIZED"
        $accountSetting = Query-RscAccount -Setting -Debug
        $accountSetting | Should -Not -BeNullOrEmpty

        $accountSetting.IsEmailNotificationEnabled | Should -Be $true
        $accountSetting.IsEulaAccepted | Should -Be $false
    }
}

AfterAll {
    if ( ! $UseExistingMockServer) {
        Close-MockApiServer
    }
}
