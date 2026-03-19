<#
.SYNOPSIS
Verify that the Get-RscType refactored scripts produce exactly the same
GraphQL queries as the original New-Object-based scripts.

Each test loads the old (pre-refactor) version of a script, renames its
function with an -Old suffix, then compares its -AsQuery output against
the current module version. Both the full GQL query text and the field
spec are compared.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"

    # --- helpers ---

    # Normalize a GQL query string for comparison:
    # collapse whitespace, trim.
    function Normalize-Gql([string]$gql) {
        ($gql -replace '\s+', ' ').Trim()
    }

    # Extract normalized GQL query text from an RscQuery object.
    function Get-NormalizedQuery([RubrikSecurityCloud.RscQuery]$q) {
        Normalize-Gql $q.GqlRequest().Query
    }

    # Extract normalized field spec from an RscQuery object.
    function Get-NormalizedFieldSpec([RubrikSecurityCloud.RscQuery]$q) {
        Normalize-Gql ($q.Field.AsFieldSpec())
    }

    # Load baseline (pre-refactor) scripts, renaming each function with
    # an -Old suffix so it doesn't collide with the module-imported version.
    # We write a temp file and dot-source it so the functions are defined
    # in the current (Pester) scope.
    $baselineDir = "$PSScriptRoot/Baselines"
    $tempFile = [System.IO.Path]::GetTempFileName() + ".ps1"
    $allContent = ""
    foreach ($cmdletName in @(
        'Get-RscNutanixVm',
        'Get-RscVmwareVm',
        'Get-RscMssqlLogShipping',
        'Get-RscOrganization',
        'Get-RscMssqlInstance',
        'Get-RscArchivalLocation'
    )) {
        $oldPath = Join-Path $baselineDir "${cmdletName}.ps1"
        if (-not (Test-Path $oldPath)) {
            throw "Baseline script not found: $oldPath"
        }
        $content = Get-Content -Raw $oldPath
        $content = $content -replace "function\s+$cmdletName\b", "function ${cmdletName}-Old"
        $allContent += $content + "`n"
    }
    Set-Content -Path $tempFile -Value $allContent -Encoding UTF8
    . $tempFile
    Remove-Item $tempFile -ErrorAction SilentlyContinue
}

Describe 'Get-RscType Refactor — GQL query equivalence' {

    # ---------------------------------------------------------------
    # Get-RscNutanixVm
    # ---------------------------------------------------------------
    Context 'Get-RscNutanixVm' {
        It 'produces the same GQL query (list mode)' {
            $old = Get-RscNutanixVm-Old -AsQuery
            $new = Get-RscNutanixVm -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (list mode)' {
            $old = Get-RscNutanixVm-Old -AsQuery
            $new = Get-RscNutanixVm -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
        It 'produces the same GQL query (Id mode)' {
            $old = Get-RscNutanixVm-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscNutanixVm -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (Id mode)' {
            $old = Get-RscNutanixVm-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscNutanixVm -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
    }

    # ---------------------------------------------------------------
    # Get-RscVmwareVm
    # ---------------------------------------------------------------
    Context 'Get-RscVmwareVm' {
        It 'produces the same GQL query (list mode)' {
            $old = Get-RscVmwareVm-Old -AsQuery
            $new = Get-RscVmwareVm -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (list mode)' {
            $old = Get-RscVmwareVm-Old -AsQuery
            $new = Get-RscVmwareVm -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
        It 'produces the same GQL query (Id mode)' {
            $old = Get-RscVmwareVm-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscVmwareVm -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (Id mode)' {
            $old = Get-RscVmwareVm-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscVmwareVm -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
        It 'produces the same GQL query (Detail + Id mode)' {
            $old = Get-RscVmwareVm-Old -Id '00000000-0000-0000-0000-000000000000' -Detail -AsQuery
            $new = Get-RscVmwareVm -Id '00000000-0000-0000-0000-000000000000' -Detail -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
    }

    # ---------------------------------------------------------------
    # Get-RscMssqlLogShipping
    # ---------------------------------------------------------------
    Context 'Get-RscMssqlLogShipping' {
        It 'produces the same GQL query (list mode)' {
            $old = Get-RscMssqlLogShipping-Old -AsQuery
            $new = Get-RscMssqlLogShipping -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (list mode)' {
            $old = Get-RscMssqlLogShipping-Old -AsQuery
            $new = Get-RscMssqlLogShipping -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
        It 'produces the same GQL query (Id mode)' {
            $old = Get-RscMssqlLogShipping-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscMssqlLogShipping -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (Id mode)' {
            $old = Get-RscMssqlLogShipping-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscMssqlLogShipping -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
    }

    # ---------------------------------------------------------------
    # Get-RscOrganization
    # ---------------------------------------------------------------
    Context 'Get-RscOrganization' {
        It 'produces the same GQL query (list mode)' {
            $old = Get-RscOrganization-Old -AsQuery
            $new = Get-RscOrganization -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (list mode)' {
            $old = Get-RscOrganization-Old -AsQuery
            $new = Get-RscOrganization -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
        It 'produces the same GQL query (Id mode)' {
            $old = Get-RscOrganization-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscOrganization -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (Id mode)' {
            $old = Get-RscOrganization-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscOrganization -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
    }

    # ---------------------------------------------------------------
    # Get-RscMssqlInstance
    # ---------------------------------------------------------------
    Context 'Get-RscMssqlInstance' {
        It 'produces the same GQL query (list mode)' {
            $old = Get-RscMssqlInstance-Old -AsQuery
            $new = Get-RscMssqlInstance -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (list mode)' {
            $old = Get-RscMssqlInstance-Old -AsQuery
            $new = Get-RscMssqlInstance -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
        It 'produces the same GQL query (Id mode)' {
            $old = Get-RscMssqlInstance-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscMssqlInstance -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (Id mode)' {
            $old = Get-RscMssqlInstance-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscMssqlInstance -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
    }

    # ---------------------------------------------------------------
    # Get-RscArchivalLocation
    # ---------------------------------------------------------------
    Context 'Get-RscArchivalLocation' {
        It 'produces the same GQL query (list mode)' {
            $old = Get-RscArchivalLocation-Old -AsQuery
            $new = Get-RscArchivalLocation -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (list mode)' {
            $old = Get-RscArchivalLocation-Old -AsQuery
            $new = Get-RscArchivalLocation -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
        It 'produces the same GQL query (Id mode)' {
            $old = Get-RscArchivalLocation-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscArchivalLocation -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedQuery $new | Should -Be (Get-NormalizedQuery $old)
        }
        It 'produces the same field spec (Id mode)' {
            $old = Get-RscArchivalLocation-Old -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            $new = Get-RscArchivalLocation -Id '00000000-0000-0000-0000-000000000000' -AsQuery
            Get-NormalizedFieldSpec $new | Should -Be (Get-NormalizedFieldSpec $old)
        }
    }
}
