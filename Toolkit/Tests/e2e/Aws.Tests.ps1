BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Api "Aws"
    $Global:data = @{ instances = $null }
}

Describe -Name 'Aws' -Tag 'E2E' -Fixture {

    Context 'List EC2 Instances' {
        It 'lists AWS Native EC2 instances' {
            { $Global:data.instances = Get-RscAwsNativeEc2Instance } | Should -Not -Throw
            $count = @($data.instances).Count
            if ($count -le 0) {
                Add-E2eDiagnosticEntry $diag "List EC2 Instances" "skip" "None found"
                Set-ItResult -Skipped -Because "No EC2 instances found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List EC2 Instances" "pass" "Found $count"
        }
    }
}

AfterAll {
    Save-E2eDiagnostics $diag
}
