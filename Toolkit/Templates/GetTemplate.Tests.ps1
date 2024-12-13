BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"

    # variables shared among tests
    $Global:data = @{
        objects = $null
    }
}

Describe -Name 'Get-__OBJECT_TYPE__ Tests' -Tag 'Public' -Fixture {

    It -Name 'retrieves __OBJECT_TYPE__s' -Test {
        $data.objects = Get-__OBJECT_TYPE__
        $data.objects | Should -Not -BeNullOrEmpty
    }

    Context -Name '__OBJECT_TYPE__ Count > 0' {
        BeforeEach {
            # Skip the tests if empty 
            if ($data.objects.Count -le 0) {
                Set-ItResult -Skipped -Because "At least 1 __OBJECT_TYPE__ is needed"
                return
            }
        }
    }
}
