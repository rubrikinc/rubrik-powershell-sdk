& "$PSScriptRoot\..\..\Samples\import.ps1"
. "$PSScriptRoot\..\serviceaccount.ps1"

$url = $global:serviceAccount.access_token_uri -replace "https://([^/]*).*", '$1'
$clientId = $global:serviceAccount.client_id
Write-Output "URL: $url"
$plainText = $global:serviceAccount.client_secret
$clientSecret = ConvertTo-SecureString -String $plainText -AsPlainText -Force


Describe -Name 'Connect to API' -Fixture {
    Context -Name 'Connections with service account details' {
        It -Name 'Connect-Rsc -Server xxx -ClientId xxx -ClientSecret xxx' -Test {
            Connect-Rsc -Server $url -ClientId $clientId -ClientSecret $clientSecret | Should -BeLikeExactly "Authentication Status: AUTHORIZED"
        }
        It -Name 'Disconnect-Rsc' -Test {
            Disconnect-Rsc | Should -BeLikeExactly "The Rubrik Security Cloud session has been terminated."
        }
        It -Name 'Connect-Rsc -ServiceAccountFile' -Test {
            Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile) | Should -BeLikeExactly "Authentication Status: AUTHORIZED"
        }
        It -Name 'Disconnect-Rsc 2' -Test {
            Disconnect-Rsc | Should -BeLikeExactly "The Rubrik Security Cloud session has been terminated."
        }
    }
}
