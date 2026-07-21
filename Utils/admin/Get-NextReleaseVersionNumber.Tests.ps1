Describe 'Get-NextReleaseVersionNumber' {

    BeforeAll {
        $script:scriptPath = "$PSScriptRoot\Get-NextReleaseVersionNumber.ps1"

        function New-TempVersionMd($major, $minor) {
            $path = [System.IO.Path]::GetTempFileName()
            @"
# Current Version

### Major Version: $major
### Minor Version: $minor
### Schema Version: 99999999
"@ | Set-Content -Path $path
            return $path
        }

        function New-TempChangelog($features, $fixes, $breaking, $lastMajor, $lastMinor = 5) {
            $path = [System.IO.Path]::GetTempFileName()
            @"
# Changelog

## Version TBD

New Features:
$features
Fixes:
$fixes
Breaking Changes:
$breaking
## Version ${lastMajor}.${lastMinor}.20260101

New Features:
- Initial release
"@ | Set-Content -Path $path
            return $path
        }

        function New-TempPsd1($schemaDate) {
            $path = [System.IO.Path]::GetTempFileName() + ".psd1"
            @"
@{
    Description = 'PowerShell Module for Rubrik Security Cloud. GraphQL schema version: v${schemaDate}-1 .'
}
"@ | Set-Content -Path $path
            return $path
        }
    }

    Context 'Schema version' {
        It 'reads schema date from psd1 Description' {
            $vf = New-TempVersionMd 1 5
            $cf = New-TempChangelog '' '' '' 1 18
            $pf = New-TempPsd1 '20260601'
            try {
                $result = & $script:scriptPath -VersionFile $vf -ChangelogFile $cf -Psd1File $pf
                $result.Schema | Should -Be 20260601
            } finally {
                Remove-Item $vf, $cf, $pf -ErrorAction SilentlyContinue
            }
        }
    }

    Context 'Minor version — no changelog entries' {
        It 'keeps Minor unchanged when TBD sections are empty' {
            $vf = New-TempVersionMd 1 18
            $cf = New-TempChangelog '' '' '' 1 18
            $pf = New-TempPsd1 '20260601'
            try {
                $result = & $script:scriptPath -VersionFile $vf -ChangelogFile $cf -Psd1File $pf
                $result.Minor | Should -Be 18
            } finally {
                Remove-Item $vf, $cf, $pf -ErrorAction SilentlyContinue
            }
        }

        It 'keeps Minor unchanged when all TBD sections contain only "None"' {
            $vf = New-TempVersionMd 1 18
            $cf = New-TempChangelog 'None' 'None' 'None' 1 18
            $pf = New-TempPsd1 '20260601'
            try {
                $result = & $script:scriptPath -VersionFile $vf -ChangelogFile $cf -Psd1File $pf
                $result.Minor | Should -Be 18
            } finally {
                Remove-Item $vf, $cf, $pf -ErrorAction SilentlyContinue
            }
        }
    }

    Context 'Minor version — changelog has entries' {
        It 'increments Minor by 1 when New Features has an entry' {
            $vf = New-TempVersionMd 1 18
            $cf = New-TempChangelog '- New cmdlet added' '' '' 1 18
            $pf = New-TempPsd1 '20260601'
            try {
                $result = & $script:scriptPath -VersionFile $vf -ChangelogFile $cf -Psd1File $pf
                $result.Minor | Should -Be 19
            } finally {
                Remove-Item $vf, $cf, $pf -ErrorAction SilentlyContinue
            }
        }

        It 'increments Minor by 1 when Fixes has an entry' {
            $vf = New-TempVersionMd 1 18
            $cf = New-TempChangelog '' '- Fixed a bug' '' 1 18
            $pf = New-TempPsd1 '20260601'
            try {
                $result = & $script:scriptPath -VersionFile $vf -ChangelogFile $cf -Psd1File $pf
                $result.Minor | Should -Be 19
            } finally {
                Remove-Item $vf, $cf, $pf -ErrorAction SilentlyContinue
            }
        }

        It 'increments Minor by 1 when Breaking Changes has an entry' {
            $vf = New-TempVersionMd 1 18
            $cf = New-TempChangelog '' '' '- Removed old parameter' 1 18
            $pf = New-TempPsd1 '20260601'
            try {
                $result = & $script:scriptPath -VersionFile $vf -ChangelogFile $cf -Psd1File $pf
                $result.Minor | Should -Be 19
            } finally {
                Remove-Item $vf, $cf, $pf -ErrorAction SilentlyContinue
            }
        }
    }

    Context 'Major version bump' {
        It 'resets Minor to 0 when Major in VERSION.md is greater than last released Major' {
            $vf = New-TempVersionMd 2 18
            $cf = New-TempChangelog '- New feature' '' '' 1 18
            $pf = New-TempPsd1 '20260601'
            try {
                $result = & $script:scriptPath -VersionFile $vf -ChangelogFile $cf -Psd1File $pf
                $result.Major | Should -Be 2
                $result.Minor | Should -Be 0
            } finally {
                Remove-Item $vf, $cf, $pf -ErrorAction SilentlyContinue
            }
        }
    }
}
