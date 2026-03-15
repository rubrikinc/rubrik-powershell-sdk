BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}
Describe 'Get-RscType' {
    Context 'When called with the -ListAvailable parameter' {
        It 'Should return a list of valid Rsc types' {
            $result = Get-RscType -ListAvailable
            $result | Should -BeOfType [string]
            $result.Count | Should -BeGreaterThan 0
        }
    }

    Context 'When called with the -Name parameter' {
        It 'Should return an empty object of the specified Rsc type' {
            $result = Get-RscType -Name "AccountSetting"
            $result | Should -BeOfType RubrikSecurityCloud.Types.AccountSetting
            $result | Should -Not -BeNull
        }

        It 'Should initialize specified properties if -InitialProperties parameter is used' {
            $result = Get-RscType -Name "AccountSetting" -InitialProperties @("IsEulaAccepted")
            $result | Should -BeOfType RubrikSecurityCloud.Types.AccountSetting
            $result | Should -Not -BeNull
            $result.IsEulaAccepted | Should -Be $true
        }

        It 'Should throw an exception if the specified Rsc type is not found' {
            {Get-RscType -Name "InvalidType"} | Should -Throw "No type found that matches InvalidType*"
        }

        It 'Should throw when -InitialProperties contains an invalid property name' {
            {Get-RscType -Name "AccountSetting" -InitialProperties @("NonExistentProp")} |
                Should -Throw "*Property 'NonExistentProp' not found on type 'AccountSetting'*"
        }

        It 'Should not set a root field when a dotted path has an invalid prefix' {
            # Cluster has Name at root and CloudInfo.Name nested.
            # "CloudInfo.Name" should set CloudInfo.Name, NOT root Name.
            $result = Get-RscType -Name "Cluster" -InitialProperties @("CloudInfo.Name")
            $result.CloudInfo.Name | Should -Be "FETCH"
            $result.Name | Should -BeNullOrEmpty
        }

        It 'Should not leak a root field name into a child with the same field' {
            # Cluster and CloudInfo both have "Name".
            # Requesting "Name" (root) and "CloudInfo.Region" (nested)
            # must NOT set CloudInfo.Name — only root Name and CloudInfo.Region.
            $result = Get-RscType -Name "Cluster" -InitialProperties @("Name", "CloudInfo.Region")
            $result.Name | Should -Be "FETCH"
            $result.CloudInfo.Region | Should -Be "FETCH"
            $result.CloudInfo.Name | Should -BeNullOrEmpty
        }

        It 'Should match property names case-insensitively' {
            $result = Get-RscType -Name "Cluster" -InitialProperties @("nAmE")
            $result.Name | Should -Be "FETCH"
        }

        It 'Should throw on property names with spaces or invalid characters' {
            {Get-RscType -Name "Cluster" -InitialProperties @(" Name")} |
                Should -Throw "*' Name' not found*"
            {Get-RscType -Name "Cluster" -InitialProperties @("Name ")} |
                Should -Throw "*'Name ' not found*"
            {Get-RscType -Name "Cluster" -InitialProperties @("Name!")} |
                Should -Throw "*'Name!' not found*"
        }

        It 'Should throw on malformed dotted paths' {
            {Get-RscType -Name "Cluster" -InitialProperties @(".Name")} |
                Should -Throw "*'' not found*"
            {Get-RscType -Name "Cluster" -InitialProperties @("Name.")} |
                Should -Throw "*'' not found*"
            {Get-RscType -Name "Cluster" -InitialProperties @("..")} |
                Should -Throw "*'' not found*"
        }

        It -Name 'Return object with specific values in fields' -Test {
            $userCredentials = Get-RscType -Name "UserCredentials" -InitialValues @{"Username"= "admin"; "Password"= "pass"}
            $authInfo = Get-RscType -Name "AuthInfoInput" -InitialValues @{"UserCredentials" = $userCredentials}
            $authInfo.UserCredentials.Username | Should -Be "admin"
            $authInfo.UserCredentials.Password | Should -Be "pass"
        }
    }

    Context 'Sentinel values by property type' {
        # All tests use Cluster which has string, bool?, int?, long?,
        # DateTime?, and enum? properties.

        It 'string → "FETCH"' {
            $r = Get-RscType -Name Cluster -InitialProperties @("Name")
            $r.Name | Should -Be "FETCH"
        }

        It 'bool? → true' {
            $r = Get-RscType -Name Cluster -InitialProperties @("EncryptionEnabled")
            $r.EncryptionEnabled | Should -Be $true
        }

        It 'int? → 0' {
            $r = Get-RscType -Name Cluster -InitialProperties @("DefaultPort")
            $r.DefaultPort | Should -Be 0
        }

        It 'long? → 0' {
            $r = Get-RscType -Name Cluster -InitialProperties @("EstimatedRunway")
            $r.EstimatedRunway | Should -Be 0
        }

        It 'DateTime? → non-null' {
            $r = Get-RscType -Name Cluster -InitialProperties @("ConnectivityLastUpdated")
            $r.ConnectivityLastUpdated | Should -Not -BeNull
        }

        It 'enum? → first value (UNKNOWN)' {
            $r = Get-RscType -Name Cluster -InitialProperties @("Status")
            $r.Status | Should -Be ([RubrikSecurityCloud.Types.ClusterStatus]::UNKNOWN)
        }

        It 'class → non-null instance' {
            $r = Get-RscType -Name Cluster -InitialProperties @("CloudInfo.Name")
            $r.CloudInfo | Should -Not -BeNull
            $r.CloudInfo | Should -BeOfType RubrikSecurityCloud.Types.CcWithCloudInfo
        }

        It 'single interface → first implementing type' {
            # MssqlDatabase.EffectiveSlaDomain is a SlaDomain interface.
            # GetOrCreatePropertyValue picks the first implementing type
            # (ClusterSlaDomain, alphabetically before GlobalSlaReply).
            $r = Get-RscType -Name MssqlDatabase -InitialProperties @("EffectiveSlaDomain.Name")
            $r.EffectiveSlaDomain | Should -Not -BeNull
            $r.EffectiveSlaDomain | Should -BeOfType RubrikSecurityCloud.Types.ClusterSlaDomain
            $r.EffectiveSlaDomain.Name | Should -Be "FETCH"
        }

        It 'List<concrete> → list with one element' {
            # Cluster.AllOrgs is List<Org>
            $r = Get-RscType -Name Cluster -InitialProperties @("AllOrgs.Name")
            $r.AllOrgs | Should -Not -BeNull
            $r.AllOrgs.Count | Should -Be 1
            $r.AllOrgs[0] | Should -BeOfType RubrikSecurityCloud.Types.Org
            $r.AllOrgs[0].Name | Should -Be "FETCH"
        }
    }

    Context 'Dotted path structural behavior' {
        It 'Shared prefix: two paths with same parent create the object once' {
            # "CloudInfo.Name" and "CloudInfo.Region" should both set
            # fields on the SAME CloudInfo instance.
            $r = Get-RscType -Name Cluster -InitialProperties @(
                "CloudInfo.Name", "CloudInfo.Region"
            )
            $r.CloudInfo.Name | Should -Be "FETCH"
            $r.CloudInfo.Region | Should -Be "FETCH"
            # Other fields should still be null
            $r.CloudInfo.Uuid | Should -BeNullOrEmpty
        }

        It 'List<concrete> mid-path walk sets leaf on first element' {
            # "AllOrgs.Name" should create a list with one Org,
            # then set Name on that Org.
            $r = Get-RscType -Name Cluster -InitialProperties @("AllOrgs.Name")
            $r.AllOrgs.Count | Should -Be 1
            $r.AllOrgs[0].Name | Should -Be "FETCH"
            $r.AllOrgs[0].Id | Should -BeNullOrEmpty
        }
    }

    Context 'When the -InitialProperties param contains a field that is of type List<Interface>'{
        It -Name 'Should return a list of types for an interface list' -Test {
            $result = Get-RscType -Name MssqlTopLevelDescendantTypeConnection -InitialProperties @("nodes.id")
            $result.nodes.Count | Should -BeGreaterThan 0
            $typeList = (Get-RscType -Interface "MssqlTopLevelDescendantType")
            foreach ($resultNode in $result.nodes)
            {
                $typeList -Contains $resultNode.GetType().Name | Should -Be $true
                $resultNode.Id | Should -Be "FETCH"
                $resultNode.Name | Should -Be $null
            }
        }

        It 'Should not match a nested field name without the correct path prefix' {
            # MssqlTopLevelDescendantTypeConnection has no "Id" at root,
            # only inside nodes (implementing types). Bare "Id" must throw,
            # not silently reach into implementing types.
            {Get-RscType -Name MssqlTopLevelDescendantTypeConnection -InitialProperties @("Id")} |
                Should -Throw "*Property 'Id' not found on type 'MssqlTopLevelDescendantTypeConnection'*"
        }
    }

    Context 'on: type selector for List<Interface>' {
        It '"nodes.on:*.id" — explicit all-types, same result as "nodes.id"' {
            $explicit = Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
                -InitialProperties @("nodes.on:*.id")
            $implicit = Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
                -InitialProperties @("nodes.id")
            $explicit.nodes.Count | Should -Be $implicit.nodes.Count
            foreach ($node in $explicit.nodes) {
                $node.Id | Should -Be "FETCH"
            }
        }

        It '"nodes.on:PhysicalHost.id" — single type, only PhysicalHost fragment' {
            $result = Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
                -InitialProperties @("nodes.on:PhysicalHost.id")
            $result.nodes.Count | Should -Be 1
            $result.nodes[0] | Should -BeOfType RubrikSecurityCloud.Types.PhysicalHost
            $result.nodes[0].Id | Should -Be "FETCH"
        }

        It '"nodes.on:PhysicalHost.id", "nodes.on:MssqlDatabase.name" — two specific types' {
            $result = Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
                -InitialProperties @("nodes.on:PhysicalHost.id", "nodes.on:MssqlDatabase.name")
            $result.nodes.Count | Should -Be 2
            $phHost = $result.nodes | Where-Object { $_ -is [RubrikSecurityCloud.Types.PhysicalHost] }
            $mssql = $result.nodes | Where-Object { $_ -is [RubrikSecurityCloud.Types.MssqlDatabase] }
            $phHost | Should -Not -BeNull
            $phHost.Id | Should -Be "FETCH"
            $mssql | Should -Not -BeNull
            $mssql.Name | Should -Be "FETCH"
        }

        It '"nodes.on:NonExistent.id" — throws with clear error' {
            { Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
                -InitialProperties @("nodes.on:NonExistent.id") } |
                Should -Throw "*does not implement*MssqlTopLevelDescendantType*"
        }

        It 'Backward compat: "nodes.id" still works unchanged' {
            $result = Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
                -InitialProperties @("nodes.id")
            $typeList = Get-RscType -Interface "MssqlTopLevelDescendantType"
            $result.nodes.Count | Should -Be $typeList.Count
        }

        It 'Double interface with on: produces same field spec as manual workaround' {
            # A: new way — single Get-RscType call with on: selectors
            $a = Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
                -InitialProperties @(
                    "nodes.on:PhysicalHost.id",
                    "nodes.on:PhysicalHost.name",
                    "nodes.on:PhysicalHost.physicalChildConnection.count",
                    "nodes.on:PhysicalHost.physicalChildConnection.nodes.on:MssqlInstance.id",
                    "nodes.on:PhysicalHost.physicalChildConnection.nodes.on:MssqlInstance.name"
                )

            # B: old way — manual 4-step workaround
            # (mirrors Tests/e2e/Invoke-RscQueryMssql-TopLevelDescendant.Tests.ps1)
            $physicalHostFields =
                Get-RscType -Name PhysicalHost -InitialProperties @(
                    "id",
                    "name",
                    "physicalChildConnection.count"
                )
            $physicalHostFields.PhysicalChildConnection.Nodes =
                Get-RscType -Name MssqlInstance -InitialProperties ("Id", "Name")
            $b = Get-RscType -Name MssqlTopLevelDescendantTypeConnection
            $b.nodes = $physicalHostFields

            # A and B must produce the same field spec
            $a.AsFieldSpec() | Should -Be $b.AsFieldSpec()
        }
    }

    Context 'Double interface list: manual field spec construction' {
        # This mirrors the e2e test in Invoke-RscQueryMssql-TopLevelDescendant.Tests.ps1
        # and exercises a real-world pattern for working with nested interface lists.
        #
        # The type hierarchy:
        #
        #   MssqlTopLevelDescendantTypeConnection
        #     .nodes: List<MssqlTopLevelDescendantType>        <- interface (6 types)
        #       PhysicalHost (one of the 6 implementing types)
        #         .physicalChildConnection
        #           .nodes: List<PhysicalHostPhysicalChildType> <- interface (9 types)
        #             MssqlInstance (one of the 9)
        #
        # Get-RscType -InitialProperties on a List<Interface> creates ALL
        # implementing types. When you only want one (e.g. PhysicalHost),
        # you must build it manually and assign it to .nodes.
        #
        # This test validates that pattern produces the correct field spec
        # at both interface levels.

        It 'Should produce a field spec targeting a single implementing type' {
            # Level 1: Build PhysicalHost with a nested connection.
            # "physicalChildConnection.count" walks into the Connection
            # and sets count, also instantiating PhysicalChildConnection.
            $physicalHostFields =
            Get-RscType -Name PhysicalHost -InitialProperties @(
                "id",
                "name",
                "physicalChildConnection.count"
            )
            $physicalHostFields.Id | Should -Be "FETCH"
            $physicalHostFields.Name | Should -Be "FETCH"
            $physicalHostFields.PhysicalChildConnection | Should -Not -BeNull
            $physicalHostFields.PhysicalChildConnection.Count | Should -Be 0

            # Level 2: PhysicalChildConnection.Nodes is List<Interface>.
            # Manually set it to MssqlInstance only (not all 9 implementors).
            $physicalHostFields.PhysicalChildConnection.Nodes =
                Get-RscType -Name MssqlInstance -InitialProperties ("Id", "Name")
            $physicalHostFields.PhysicalChildConnection.Nodes |
                Should -BeOfType RubrikSecurityCloud.Types.MssqlInstance

            # Top level: assign PhysicalHost to .nodes on the Connection,
            # bypassing the automatic expansion of all 6 implementors.
            $fields = Get-RscType -Name MssqlTopLevelDescendantTypeConnection
            $fields.nodes = $physicalHostFields

            # Verify the field spec has exactly one fragment at each level.
            $spec = $fields.AsFieldSpec()
            # Only PhysicalHost fragment, not the other 5
            ($spec -match '\.\.\. on PhysicalHost') | Should -Be $true
            ($spec -match '\.\.\. on MssqlDatabase') | Should -Be $false
            ($spec -match '\.\.\. on WindowsCluster') | Should -Be $false
            # Only MssqlInstance fragment inside physicalChildConnection, not the other 8
            ($spec -match '\.\.\. on MssqlInstance') | Should -Be $true
            ($spec -match '\.\.\. on ExchangeServer') | Should -Be $false
            ($spec -match '\.\.\. on FilesetTemplate') | Should -Be $false
        }

        It 'Contrast: Get-RscType with -InitialProperties expands ALL implementing types' {
            # Same query, but let Get-RscType handle the List<Interface> automatically.
            # "nodes.id" expands all 6 implementors of MssqlTopLevelDescendantType.
            $autoFields = Get-RscType -Name MssqlTopLevelDescendantTypeConnection `
                -InitialProperties @("nodes.id")
            $autoSpec = $autoFields.AsFieldSpec()

            # All 6 implementing types appear as fragments:
            ($autoSpec -match '\.\.\. on PhysicalHost') | Should -Be $true
            ($autoSpec -match '\.\.\. on MssqlDatabase') | Should -Be $true
            ($autoSpec -match '\.\.\. on MssqlInstance') | Should -Be $true
            ($autoSpec -match '\.\.\. on MssqlAvailabilityGroup') | Should -Be $true
            ($autoSpec -match '\.\.\. on MssqlHost') | Should -Be $true
            ($autoSpec -match '\.\.\. on WindowsCluster') | Should -Be $true

            # Count the fragments: exactly 6
            $fragmentCount = ([regex]::Matches($autoSpec, '\.\.\. on ')).Count
            $fragmentCount | Should -Be 6
        }
    }

    Context 'on: type selector for root interface types' {
        It 'Bare "Get-RscType -Name SlaDomain" returns a non-null object' {
            $result = Get-RscType -Name SlaDomain
            $result | Should -Not -BeNull
        }

        It '"on:ClusterSlaDomain.Id" — ClusterSlaDomain fragment has id' {
            $result = Get-RscType -Name SlaDomain `
                -InitialProperties @("on:ClusterSlaDomain.Id")
            $spec = $result.AsFieldSpec()
            ($spec -match '\.\.\. on ClusterSlaDomain') | Should -Be $true
            ($spec -match 'id') | Should -Be $true
        }

        It '"on:GlobalSlaReply.Id" — GlobalSlaReply fragment has id' {
            $result = Get-RscType -Name SlaDomain `
                -InitialProperties @("on:GlobalSlaReply.Id")
            $spec = $result.AsFieldSpec()
            ($spec -match '\.\.\. on GlobalSlaReply') | Should -Be $true
            ($spec -match 'id') | Should -Be $true
        }

        It '"on:*.Id" — composite of all implementing types, each with Id=FETCH' {
            $result = Get-RscType -Name SlaDomain `
                -InitialProperties @("on:*.Id")
            $result | Should -Not -BeNull
            # Result should be a composite (BaseType with linked list)
            $result.Id | Should -Be "FETCH"
            # Verify it's a composite by checking AsFieldSpec has multiple fragments
            $spec = $result.AsFieldSpec()
            ($spec -match '\.\.\. on ClusterSlaDomain') | Should -Be $true
            ($spec -match '\.\.\. on GlobalSlaReply') | Should -Be $true
        }

        It '"Id" (bare, no on:) — same as on:*.Id' {
            $result = Get-RscType -Name SlaDomain `
                -InitialProperties @("Id")
            $result | Should -Not -BeNull
            $spec = $result.AsFieldSpec()
            ($spec -match '\.\.\. on ClusterSlaDomain') | Should -Be $true
            ($spec -match '\.\.\. on GlobalSlaReply') | Should -Be $true
        }

        It '"on:NonExistent.Id" — throws' {
            { Get-RscType -Name SlaDomain `
                -InitialProperties @("on:NonExistent.Id") } |
                Should -Throw "*does not implement*SlaDomain*"
        }

        It 'on: result AsFieldSpec matches equivalent on:*.Id' {
            # Both should produce the same field spec
            $a = Get-RscType -Name SlaDomain `
                -InitialProperties @("on:ClusterSlaDomain.Id", "on:GlobalSlaReply.Id")
            $b = Get-RscType -Name SlaDomain `
                -InitialProperties @("on:*.Id")
            $a.AsFieldSpec() | Should -Be $b.AsFieldSpec()
        }
    }

    Context 'on: type selector for single interface properties' {
        It '"EffectiveSlaDomain.on:GlobalSlaReply.Id" — GlobalSlaReply with Id=FETCH' {
            $result = Get-RscType -Name MssqlDatabase `
                -InitialProperties @("EffectiveSlaDomain.on:GlobalSlaReply.Id")
            $result.EffectiveSlaDomain | Should -Not -BeNull
            $result.EffectiveSlaDomain | Should -BeOfType RubrikSecurityCloud.Types.GlobalSlaReply
            $result.EffectiveSlaDomain.Id | Should -Be "FETCH"
        }

        It '"EffectiveSlaDomain.on:ClusterSlaDomain.Id" — ClusterSlaDomain with Id=FETCH' {
            $result = Get-RscType -Name MssqlDatabase `
                -InitialProperties @("EffectiveSlaDomain.on:ClusterSlaDomain.Id")
            $result.EffectiveSlaDomain | Should -Not -BeNull
            $result.EffectiveSlaDomain | Should -BeOfType RubrikSecurityCloud.Types.ClusterSlaDomain
            $result.EffectiveSlaDomain.Id | Should -Be "FETCH"
        }

        It '"EffectiveSlaDomain.Id" (bare) — first implementing type with Id=FETCH (backward compat)' {
            $result = Get-RscType -Name MssqlDatabase `
                -InitialProperties @("EffectiveSlaDomain.Id")
            $result.EffectiveSlaDomain | Should -Not -BeNull
            $result.EffectiveSlaDomain | Should -BeOfType RubrikSecurityCloud.Types.ClusterSlaDomain
            $result.EffectiveSlaDomain.Id | Should -Be "FETCH"
        }

        It '"EffectiveSlaDomain.on:NonExistent.Id" — throws' {
            { Get-RscType -Name MssqlDatabase `
                -InitialProperties @("EffectiveSlaDomain.on:NonExistent.Id") } |
                Should -Throw "*does not implement*"
        }
    }

    Context '* wildcard for all scalar properties' {
        It '"CloudInfo.*" sets all scalar fields on CloudInfo' {
            $result = Get-RscType -Name Cluster -InitialProperties @("CloudInfo.*")
            $result.CloudInfo | Should -Not -BeNull
            # CcWithCloudInfo has string properties like Name, Uuid, Region
            $result.CloudInfo.Name | Should -Be "FETCH"
            $result.CloudInfo.Uuid | Should -Be "FETCH"
            $result.CloudInfo.Region | Should -Be "FETCH"
            # Root fields should not be set
            $result.Name | Should -BeNullOrEmpty
        }

        It '"*" at root sets all scalar fields' {
            $result = Get-RscType -Name AccountSetting -InitialProperties @("*")
            $result.IsEulaAccepted | Should -Be $true
        }

        It 'Works with on: — "on:GlobalSlaReply.SnapshotSchedule.Minute.BasicSchedule.*"' {
            $result = Get-RscType -Name SlaDomain `
                -InitialProperties @("on:GlobalSlaReply.SnapshotSchedule.Minute.BasicSchedule.*")
            $spec = $result.AsFieldSpec()
            ($spec -match 'retention') | Should -Be $true
            ($spec -match 'frequency') | Should -Be $true
            ($spec -match 'retentionUnit') | Should -Be $true
        }

        It '"*" is equivalent to listing all scalar properties individually' {
            $wildcard = Get-RscType -Name Cluster -InitialProperties @("CloudInfo.*")
            $explicit = Get-RscType -Name Cluster -InitialProperties @(
                "CloudInfo.Name", "CloudInfo.Uuid", "CloudInfo.Region"
            )
            # Wildcard sets at least the same fields as explicit
            $explicit.CloudInfo.Name | Should -Be $wildcard.CloudInfo.Name
            $explicit.CloudInfo.Uuid | Should -Be $wildcard.CloudInfo.Uuid
            $explicit.CloudInfo.Region | Should -Be $wildcard.CloudInfo.Region
        }

        It '"CloudInfo.*.foo" — throws because * must be last segment' {
            { Get-RscType -Name Cluster -InitialProperties @("CloudInfo.*.foo") } |
                Should -Throw "*must be the last segment*"
        }
    }
}
