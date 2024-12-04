BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        objects = $null
    }
}

Describe -Name 'Get-RscAwsNativeEc2Instance Tests' -Tag 'Public' -Fixture {

    It -Name 'retrieves RscAwsNativeEc2Instances' -Test {
        $data.objects = Get-RscAwsNativeEc2Instance
        $data.objects | Should -Not -BeNullOrEmpty
    }

    Context -Name 'RscAwsNativeEc2Instance Count > 0' {
        BeforeEach {
            # Skip the tests if empty 
            if ($data.objects.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 RscAwsNativeEc2Instance is needed"
                return
            }
        }
    }
}

