#Requires -Version 3
<#
.SYNOPSIS
    Unit tests for Get-RscMssqlInstance response flattening logic.

.DESCRIPTION
    Mocks Invoke-Rsc to return a synthetic mssqlTopLevelDescendants response
    containing PhysicalHost, MssqlHost, and WindowsCluster top-level rows.
    Verifies the wrapper:
      - dispatches on ObjectType to the right connection
        (descendantConnection for PhysicalHost / WindowsCluster,
         physicalChildConnection for MssqlHost — authz lacks the descendant
         edge for MSSQL_HOST -> MSSQL_INSTANCE under HierarchyOverlapFix)
      - filters non-MssqlInstance children out of the result
      - dedupes when the same instance appears via multiple parents
        (HierarchyOverlapFix can return the same host as both PhysicalHost
         and MssqlHost in a single response)

    SDK module-loading note: PublicFunctions.psm1 imports each Toolkit/Public
    *.ps1 wrapper via Import-Module, which puts the function body in a private
    dynamic module scope that Pester cannot reach with `-ModuleName`. To make
    `Mock Invoke-Rsc` actually intercept, we dot-source the wrapper file
    directly into this test's scope below — the function is then defined
    locally and calls Invoke-Rsc through the test scope where the mock lives.

    Fixtures are built INSIDE each Mock scriptblock rather than in BeforeAll.
    Pester v5 executes Mock bodies in their own scope, and closing over
    Describe/BeforeAll variables can silently yield $null.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"

    # Re-define Get-RscMssqlInstance in THIS scope so Mock Invoke-Rsc
    # (registered without -ModuleName) is visible to its calls.
    . "$PSScriptRoot\..\..\Public\Get-RscMssqlInstance.ps1"
}

Describe 'Get-RscMssqlInstance -HostName response flattening' {

    BeforeAll {
        Mock Invoke-Rsc -MockWith {
            # Three MssqlInstance fixtures with stable ids.
            $inst1 = New-Object RubrikSecurityCloud.Types.MssqlInstance
            $inst1.Id = 'inst-1'
            $inst1.Name = 'INSTANCE-1'

            $inst2 = New-Object RubrikSecurityCloud.Types.MssqlInstance
            $inst2.Id = 'inst-2'
            $inst2.Name = 'INSTANCE-2'

            $inst3 = New-Object RubrikSecurityCloud.Types.MssqlInstance
            $inst3.Id = 'inst-3'
            $inst3.Name = 'INSTANCE-3'

            # A non-MssqlInstance child to verify the -is [MssqlInstance] filter.
            # MssqlDatabase implements PhysicalHostDescendantType, so it can sit
            # in PhysicalHost.descendantConnection.Nodes without a type mismatch.
            $db = New-Object RubrikSecurityCloud.Types.MssqlDatabase
            $db.Id = 'db-1'
            $db.Name = 'DB-1'

            # PhysicalHost — children via descendantConnection.
            # One MssqlInstance plus one MssqlDatabase (should be filtered).
            $ph = New-Object RubrikSecurityCloud.Types.PhysicalHost
            $ph.ObjectType = [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::PHYSICAL_HOST
            $ph.DescendantConnection = New-Object RubrikSecurityCloud.Types.PhysicalHostDescendantTypeConnection
            $ph.DescendantConnection.Nodes = New-Object -TypeName 'System.Collections.Generic.List[RubrikSecurityCloud.Types.PhysicalHostDescendantType]'
            $ph.DescendantConnection.Nodes.Add($inst1)
            $ph.DescendantConnection.Nodes.Add($db)

            # MssqlHost — children via physicalChildConnection.
            # inst1 is duplicated to exercise dedupe-by-id across parents.
            $mh = New-Object RubrikSecurityCloud.Types.MssqlHost
            $mh.ObjectType = [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::MSSQL_HOST
            $mh.PhysicalChildConnection = New-Object RubrikSecurityCloud.Types.MssqlHostPhysicalChildTypeConnection
            $mh.PhysicalChildConnection.Nodes = New-Object -TypeName 'System.Collections.Generic.List[RubrikSecurityCloud.Types.MssqlHostPhysicalChildType]'
            $mh.PhysicalChildConnection.Nodes.Add($inst1)
            $mh.PhysicalChildConnection.Nodes.Add($inst2)

            # WindowsCluster — children via descendantConnection.
            $wc = New-Object RubrikSecurityCloud.Types.WindowsCluster
            $wc.ObjectType = [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::WINDOWS_CLUSTER
            $wc.DescendantConnection = New-Object RubrikSecurityCloud.Types.WindowsClusterDescendantTypeConnection
            $wc.DescendantConnection.Nodes = New-Object -TypeName 'System.Collections.Generic.List[RubrikSecurityCloud.Types.WindowsClusterDescendantType]'
            $wc.DescendantConnection.Nodes.Add($inst3)

            return [pscustomobject]@{ nodes = @($ph, $mh, $wc) }
        }
    }

    It 'returns one row per unique MssqlInstance id (deduped across parents)' {
        $result = @(Get-RscMssqlInstance -HostName 'test-host')
        $result.Count | Should -Be 3

        ($result | ForEach-Object { $_.Id } | Sort-Object) |
            Should -Be @('inst-1', 'inst-2', 'inst-3')
    }

    It 'filters non-MssqlInstance children out of the result' {
        $result = @(Get-RscMssqlInstance -HostName 'test-host')

        foreach ($r in $result) {
            $r | Should -BeOfType [RubrikSecurityCloud.Types.MssqlInstance]
        }
        # MssqlDatabase 'db-1' was planted on PhysicalHost.descendantConnection
        # and must not appear in the result.
        ($result | Where-Object { $_.Id -eq 'db-1' }).Count | Should -Be 0
    }
}

Describe 'Get-RscMssqlInstance -WindowsClusterName response flattening' {

    BeforeAll {
        Mock Invoke-Rsc -MockWith {
            $inst = New-Object RubrikSecurityCloud.Types.MssqlInstance
            $inst.Id = 'wc-inst-1'
            $inst.Name = 'WC-INSTANCE-1'

            # WindowsCluster — children via descendantConnection (legacy path,
            # unaffected by HierarchyOverlapFix).
            $wc = New-Object RubrikSecurityCloud.Types.WindowsCluster
            $wc.ObjectType = [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::WINDOWS_CLUSTER
            $wc.DescendantConnection = New-Object RubrikSecurityCloud.Types.WindowsClusterDescendantTypeConnection
            $wc.DescendantConnection.Nodes = New-Object -TypeName 'System.Collections.Generic.List[RubrikSecurityCloud.Types.WindowsClusterDescendantType]'
            $wc.DescendantConnection.Nodes.Add($inst)

            return [pscustomobject]@{ nodes = @($wc) }
        }
    }

    It 'returns the MssqlInstance from a WindowsCluster row' {
        $result = @(Get-RscMssqlInstance -WindowsClusterName 'test-cluster')
        $result.Count | Should -Be 1
        $result[0].Id | Should -Be 'wc-inst-1'
    }
}
