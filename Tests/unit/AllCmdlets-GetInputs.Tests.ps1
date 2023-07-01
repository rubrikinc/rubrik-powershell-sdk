# AllCmdlets.Tests.ps1
Describe 'AllCmdlets Sample Script' {
    Context 'When running the sample script' {
        It 'Should not throw any errors' {
            $ErrorActionPreference = 'Stop'
            $scriptPath = Join-Path $PSScriptRoot '../../Samples/AllCmdlets.sample.ps1'
            {
                # Temporarily replace Write-Host with a no-op
                function Write-Host { return }
                function Write-Message { return }
                . $scriptPath > $null
            } | Should -Not -Throw
            $ErrorActionPreference = 'Continue'
        }
    }
}
