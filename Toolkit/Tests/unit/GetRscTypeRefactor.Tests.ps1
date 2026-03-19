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

    # Load a baseline (pre-refactor) script, renaming its function so it
    # doesn't collide with the module-imported version.
    function Load-OldScript([string]$cmdletName) {
        $oldPath = "$PSScriptRoot/Baselines/${cmdletName}.ps1"
        if (-not (Test-Path $oldPath)) {
            throw "Baseline script not found: $oldPath"
        }
        $content = Get-Content -Raw $oldPath
        $oldFnName = "${cmdletName}-Old"
        # Replace the function declaration — handles both
        # "function Get-RscFoo {" and "function Get-RscFoo{" (no space).
        $content = $content -replace "function\s+$cmdletName\b", "function $oldFnName"
        # Execute in the caller's scope so the function is visible.
        [scriptblock]::Create($content).Invoke()
    }

    # --- Load all old scripts ---
    Load-OldScript 'Get-RscNutanixVm'
    Load-OldScript 'Get-RscVmwareVm'
    Load-OldScript 'Get-RscMssqlLogShipping'
    Load-OldScript 'Get-RscOrganization'
    Load-OldScript 'Get-RscMssqlInstance'
    Load-OldScript 'Get-RscArchivalLocation'
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
