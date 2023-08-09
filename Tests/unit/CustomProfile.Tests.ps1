<#
.SYNOPSIS
Run tests around custom input profiles.

CAVEAT! This test wipes out the QueryAccountSettings.gql operation files
in both CUSTOM and DEFAULT directories. We assume that nobody would
write override operation files for QueryAccountSettings since it is
a trivial operation that returns 2 booleans.
#>
BeforeAll {
    & "$PSScriptRoot\..\..\Utils\import.ps1"

    $script:QueryAccountSettings_CustomFileName = (Get-RscHelp -CustomOperations).CustomOperationsDir + "/QueryAccountSettings.gql"
    # Delete the custom file if it exists
    if ( $script:QueryAccountSettings_CustomFileName | Test-Path ) {
        Remove-Item $script:QueryAccountSettings_CustomFileName
    }

    $script:QueryAccountSettings_SdkFileName = [RubrikSecurityCloud.FileUtils]::GetSdkOperationsDir("DEFAULT") + "/QueryAccountSettings.gql"
    # Delete the SDK file if it exists
    if ( $script:QueryAccountSettings_SdkFileName | Test-Path ) {
        Remove-Item $script:QueryAccountSettings_SdkFileName
    }
}

Describe -Name "Test custom input profile" -Fixture {


    It -Name 'AccountSettings custom operation' -Test {
        $gqlRequest = Invoke-RscQueryAccount -Settings -GetGqlRequest
        $gqlRequest.GetType().Name | Should -Be "RscGqlRequest"
        $gqlRequest.QueryFileName() | Should -Be $script:QueryAccountSettings_CustomFileName 

        $script:QueryAccountSettings_CustomFileName | Should -Not -Exist
        $gqlRequest.SaveQueryToFile()
        $script:QueryAccountSettings_CustomFileName | Should -Exist

        # Read its content, stripped ("\s" is any whitespace)
        $query = (Get-Content $script:QueryAccountSettings_CustomFileName -Raw) -replace "\s+", " "
        $expectedQuery = $gqlRequest.Query -replace "\s+", " "
        $query | Should -Be $expectedQuery

        # Save custom query to file
        $customQuery = $expectedQuery -replace " isEulaAccepted", ""
        $customQuery | Out-File $script:QueryAccountSettings_CustomFileName

        # Retrieve custom query
        $customGqlRequest = Invoke-RscQueryAccount -Settings -GetGqlRequest -InputProfile CUSTOM
        $retrievedCustomQuery = $customGqlRequest.Query -replace "\s+", " "
        $retrievedCustomQuery | Should -Be $customQuery

        # But it doesn't affect the DEFAULT query
        $defaultGqlRequest = Invoke-RscQueryAccount -Settings -GetGqlRequest
        $retrievedDefaultQuery = $defaultGqlRequest.Query -replace "\s+", " "
        $retrievedDefaultQuery | Should -Be $expectedQuery

        # Not the DETAIL query
        $detailGqlRequest = Invoke-RscQueryAccount -Settings -GetGqlRequest -InputProfile DETAIL
        $retrievedDetailQuery = $detailGqlRequest.Query -replace "\s+", " "
        $retrievedDetailQuery | Should -Be $expectedQuery

        # However, if we copy the custom file to the SDK dir
        Copy-Item $script:QueryAccountSettings_CustomFileName $script:QueryAccountSettings_SdkFileName
        $defaultGqlRequest2 = Invoke-RscQueryAccount -Settings -GetGqlRequest
        $retrievedDefaultQuery2 = $defaultGqlRequest2.Query -replace "\s+", " "
        $retrievedDefaultQuery2 | Should -Be $customQuery
    }

    # Delete the custom file
    AfterAll {
        if ( $script:QueryAccountSettings_CustomFileName | Test-Path ) {
            Remove-Item $script:QueryAccountSettings_CustomFileName
        }
        if ( $script:QueryAccountSettings_SdkFileName | Test-Path ) {
            Remove-Item $script:QueryAccountSettings_SdkFileName
        }
    }
}
