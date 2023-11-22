<#
.SYNOPSIS
Run tests around custom input profiles.

CAVEAT! This test wipes out the QueryAccountSettings.gql operation files
in both CUSTOM and DEFAULT directories. We assume that nobody would
write override operation files for QueryAccountSettings since it is
a trivial operation that returns 2 booleans.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"

    $script:QueryAccountSettings_CustomFileName = (Get-RscHelp -Locations).CustomDir + "/QueryAccountSettings.gql"
    # Temporarily save the custom file if it exists
    if ( $script:QueryAccountSettings_CustomFileName | Test-Path ) {
        $script:QueryAccountSettings_CustomFileName | Copy-Item -Destination "$script:QueryAccountSettings_CustomFileName.bak"
    }

    $script:QueryAccountSettings_SdkFileName = [RubrikSecurityCloud.Files]::GetSdkOperationsDir("DEFAULT") + "/QueryAccountSettings.gql"
    # Temporarily save the SDK file if it exists
    if ( $script:QueryAccountSettings_SdkFileName | Test-Path ) {
        $script:QueryAccountSettings_SdkFileName | Copy-Item -Destination "$script:QueryAccountSettings_SdkFileName.bak"
    }
}

AfterAll {
    # Delete custom file created by test
    if ( $script:QueryAccountSettings_CustomFileName | Test-Path ) {
        $script:QueryAccountSettings_CustomFileName | Remove-Item
    }
    # Restore the custom file if it existed
    if ( "$script:QueryAccountSettings_CustomFileName.bak" | Test-Path ) {
        "$script:QueryAccountSettings_CustomFileName.bak" | Rename-Item -NewName $script:QueryAccountSettings_CustomFileName
    }
    # Delete SDK file created by test
    if ( $script:QueryAccountSettings_SdkFileName | Test-Path ) {
        $script:QueryAccountSettings_SdkFileName | Remove-Item
    }
    # Restore the SDK file if it existed
    if ( "$script:QueryAccountSettings_SdkFileName.bak" | Test-Path ) {
        "$script:QueryAccountSettings_SdkFileName.bak" | Rename-Item -NewName $script:QueryAccountSettings_SdkFileName
    }
}

Describe -Name "Test custom input profile" -Fixture {

    It -Name 'AccountSettings custom operation' -Test {
        $gqlRequest = (New-RscQueryAccount -Op Settings).GqlRequest()
        $gqlRequest.GetType().Name | Should -Be "RscGqlRequest"
        $gqlRequest.DefaultFileName() | Should -Be $script:QueryAccountSettings_CustomFileName 

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
        $customGqlRequest = (New-RscQueryAccount -Op Settings -FieldProfile CUSTOM).GqlRequest() 
        $retrievedCustomQuery = $customGqlRequest.Query -replace "\s+", " "
        $retrievedCustomQuery | Should -Be $customQuery

        # But it doesn't affect the DEFAULT query
        $defaultGqlRequest = (New-RscQueryAccount -Op Settings).GqlRequest()
        $retrievedDefaultQuery = $defaultGqlRequest.Query -replace "\s+", " "
        $retrievedDefaultQuery | Should -Be $expectedQuery

        # Not the DETAIL query
        $detailGqlRequest = (New-RscQueryAccount -Op Settings ).GqlRequest()
        $retrievedDetailQuery = $detailGqlRequest.Query -replace "\s+", " "
        $retrievedDetailQuery | Should -Be $expectedQuery

        # However, if we copy the custom file to the SDK dir
        Copy-Item $script:QueryAccountSettings_CustomFileName $script:QueryAccountSettings_SdkFileName
        $defaultGqlRequest2 = (New-RscQueryAccount -Op Settings).GqlRequest()
        $retrievedDefaultQuery2 = $defaultGqlRequest2.Query -replace "\s+", " "
        $retrievedDefaultQuery2 | Should -Be $customQuery
    }
}
