BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
    $Global:diag = New-E2eDiagnostics -Topic "Nas"
    $Global:data = @{
        nasShares  = $null
        nasSystems = $null
    }
}

Describe -Name 'Nas' -Tag 'E2E' -Fixture {

    # --- NAS Systems ---

    Context 'List NAS Systems' {
        It 'lists NAS systems' {
            $data.nasSystems = Get-RscNasSystem
            if (@($data.nasSystems).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List NAS Systems" "skip" "None found"
                Set-ItResult -Skipped -Because "No NAS systems found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List NAS Systems" "pass" "Found $(@($data.nasSystems).Count)"
        }
    }

    Context 'NAS System by Id' {
        It 'retrieves NAS system by Id' {
            if (-not $data.nasSystems -or @($data.nasSystems).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve NAS System by Id" "skip" "No systems"
                Set-ItResult -Skipped -Because "No systems"
                return
            }
            $sys = Get-RscNasSystem -Id $data.nasSystems[0].id
            $sys.id | Should -Be $data.nasSystems[0].id
            $sys.name | Should -Be $data.nasSystems[0].name
            Add-E2eDiagnosticEntry $diag "Retrieve NAS System by Id" "pass" "'$($sys.name)'"
        }
    }

    Context 'NAS System by Name' {
        It 'retrieves NAS system by Name' {
            if (-not $data.nasSystems -or @($data.nasSystems).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve NAS System by Name" "skip" "No systems"
                Set-ItResult -Skipped -Because "No systems"
                return
            }
            $results = @(Get-RscNasSystem -Name $data.nasSystems[0].name)
            $results.Count | Should -BeGreaterThan 0
            $match = $results | Where-Object { $_.id -eq $data.nasSystems[0].id }
            $match | Should -Not -BeNullOrEmpty
            Add-E2eDiagnosticEntry $diag "Retrieve NAS System by Name" "pass" "'$($data.nasSystems[0].name)'"
        }
    }

    # --- NAS Shares ---

    Context 'List NAS Shares' {
        It 'lists NAS shares' {
            $data.nasShares = Get-RscNasShare
            if (@($data.nasShares).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "List NAS Shares" "skip" "None found"
                Set-ItResult -Skipped -Because "No NAS shares found"
                return
            }
            Add-E2eDiagnosticEntry $diag "List NAS Shares" "pass" "Found $(@($data.nasShares).Count)"
        }
    }

    Context 'NAS Share by Id' {
        It 'retrieves NAS share by Id' {
            if (-not $data.nasShares -or @($data.nasShares).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve NAS Share by Id" "skip" "No shares"
                Set-ItResult -Skipped -Because "No shares"
                return
            }
            $share = Get-RscNasShare -Id $data.nasShares[0].id
            $share.id | Should -Be $data.nasShares[0].id
            $share.name | Should -Be $data.nasShares[0].name
            Add-E2eDiagnosticEntry $diag "Retrieve NAS Share by Id" "pass" "'$($share.name)'"
        }
    }

    Context 'NAS Share by Name' {
        It 'retrieves NAS share by Name' {
            if (-not $data.nasShares -or @($data.nasShares).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Retrieve NAS Share by Name" "skip" "No shares"
                Set-ItResult -Skipped -Because "No shares"
                return
            }
            $results = @(Get-RscNasShare -Name $data.nasShares[0].name)
            $results.Count | Should -BeGreaterThan 0
            $match = $results | Where-Object { $_.id -eq $data.nasShares[0].id }
            $match | Should -Not -BeNullOrEmpty
            Add-E2eDiagnosticEntry $diag "Retrieve NAS Share by Name" "pass" "'$($data.nasShares[0].name)'"
        }
    }

    Context 'NAS Shares by NAS System' {
        It 'retrieves shares associated with a NAS system' {
            if (-not $data.nasSystems -or @($data.nasSystems).Count -le 0) {
                Add-E2eDiagnosticEntry $diag "Shares by NAS System" "skip" "No systems"
                Set-ItResult -Skipped -Because "No systems"
                return
            }
            $nasSystem = Get-RscNasSystem -Id $data.nasSystems[0].id
            $query = $nasSystem | Get-RscNasShare -AsQuery
            $query.Field.DescendantConnection.Nodes[0].NasSystem = New-Object -TypeName RubrikSecurityCloud.Types.NasSystem
            $query.Field.DescendantConnection.Nodes[0].NasSystem.Id = "Fetch"
            $result = $query.Invoke()
            $shares = $result.DescendantConnection.Nodes
            foreach ($share in $shares) {
                if ($null -eq $share.Id) { continue }
                $share.NasSystem.Id | Should -Be $data.nasSystems[0].id
            }
            Add-E2eDiagnosticEntry $diag "Shares by NAS System" "pass" "System '$($nasSystem.name)'"
        }
    }
}

AfterAll {
    Save-E2eDiagnostics $diag
}
