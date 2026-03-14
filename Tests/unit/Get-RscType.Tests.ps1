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
}
