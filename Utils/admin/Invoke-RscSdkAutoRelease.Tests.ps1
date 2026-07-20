Describe 'Invoke-RscSdkAutoRelease - VERSION.md update (step 2b)' {

    BeforeAll {
        function New-TempVersionMd($major, $minor, $schema) {
            $path = [System.IO.Path]::GetTempFileName()
            @"
# PowerShell SDK Versioning

### Major Version: $major
### Minor Version: $minor
### Schema Version: $schema
"@ | Set-Content -Path $path -NoNewline
            return $path
        }

        # Mirrors the regex replacements in Invoke-RscSdkAutoRelease step 2b.
        function Update-VersionMd($path, $newMinor, $newSchema) {
            $content = Get-Content $path -Raw
            $content = $content -replace '(###\s+Minor Version:\s*)\d+',  "`${1}$newMinor"
            $content = $content -replace '(###\s+Schema Version:\s*)\d+', "`${1}$newSchema"
            Set-Content -Path $path -Value $content -NoNewline
        }
    }

    Context 'Minor version update' {
        It 'updates Minor Version field' {
            $p = New-TempVersionMd 1 18 20260601
            try {
                Update-VersionMd $p 19 20260601
                (Get-Content $p | Where-Object { $_ -match '###\s+Minor Version:' }) |
                    Should -Match '###\s+Minor Version:\s*19'
            } finally { Remove-Item $p -ErrorAction SilentlyContinue }
        }

        It 'does not change Major Version when updating Minor' {
            $p = New-TempVersionMd 1 18 20260601
            try {
                Update-VersionMd $p 19 20260601
                (Get-Content $p | Where-Object { $_ -match '###\s+Major Version:' }) |
                    Should -Match '###\s+Major Version:\s*1'
            } finally { Remove-Item $p -ErrorAction SilentlyContinue }
        }
    }

    Context 'Schema version update' {
        It 'updates Schema Version field' {
            $p = New-TempVersionMd 1 18 20260601
            try {
                Update-VersionMd $p 18 20260901
                (Get-Content $p | Where-Object { $_ -match '###\s+Schema Version:' }) |
                    Should -Match '###\s+Schema Version:\s*20260901'
            } finally { Remove-Item $p -ErrorAction SilentlyContinue }
        }

        It 'does not change Minor Version when updating Schema only' {
            $p = New-TempVersionMd 1 18 20260601
            try {
                Update-VersionMd $p 18 20260901
                (Get-Content $p | Where-Object { $_ -match '###\s+Minor Version:' }) |
                    Should -Match '###\s+Minor Version:\s*18'
            } finally { Remove-Item $p -ErrorAction SilentlyContinue }
        }
    }

    Context 'Combined update' {
        It 'updates both Minor and Schema in one pass' {
            $p = New-TempVersionMd 1 18 20260601
            try {
                Update-VersionMd $p 19 20260901
                (Get-Content $p | Where-Object { $_ -match '###\s+Minor Version:' }) |
                    Should -Match '###\s+Minor Version:\s*19'
                (Get-Content $p | Where-Object { $_ -match '###\s+Schema Version:' }) |
                    Should -Match '###\s+Schema Version:\s*20260901'
            } finally { Remove-Item $p -ErrorAction SilentlyContinue }
        }

        It 'preserves Major Version after a combined update' {
            $p = New-TempVersionMd 2 0 20260601
            try {
                Update-VersionMd $p 1 20260901
                (Get-Content $p | Where-Object { $_ -match '###\s+Major Version:' }) |
                    Should -Match '###\s+Major Version:\s*2'
            } finally { Remove-Item $p -ErrorAction SilentlyContinue }
        }
    }
}
