<#
.SYNOPSIS
Run tests around SLAs.

.DESCRIPTION
This file is the companion to the Sla.Tests.ps1 file in the e2e folder.

This file tests the integrity of queries.
It does not test if the query runs correctly.
See Tests/e2e/Sla.Tests.ps1 for testing if the query runs correctly.

#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name 'SLAs' -Fixture {
    It -Name 'SLA Domains' -Test {

        # ----------------------------------------------------------
        #
        #            1. Retrieve the list of SLAs
        #
        # (list of 1 but still a list, not a single object)
        # ----------------------------------------------------------

        $q1 = New-RscQuery -GqlQuery slaDomains -Var @{first = 1 }

        $q1.OpInfo().GqlRootFieldName | Should -Be "slaDomains"
        $q1.OpInfo().GqlReturnTypeName | Should -Be "SlaDomainConnection"

        # Inspect what AutoFieldSpec has done
    
        $q1.Field.GetType().FullName | Should -Be "RubrikSecurityCloud.Types.SlaDomainConnection"

        # Nodes in GraphQL is [SlaDomain] (list of SlaDomain interfaces)
        # => so in PowerShell, it is a list of objects that
        #    implement the SlaDomain interface
        $type = $q1.field.nodes.gettype()
        $type.Name | Should -Be 'RscInterfaceList`1'
        $isList = $type.IsGenericType -and $type.GetGenericTypeDefinition() -eq [RubrikSecurityCloud.Types.RscInterfaceList`1]
        $isList | Should -Be $true
        $genericArguments = $type.GetGenericArguments()
        $isSlaDomainList = $genericArguments[0].FullName -eq 'RubrikSecurityCloud.Types.SlaDomain'
        $isSlaDomainList | Should -Be $true

        # AutoFieldSpec filled Nodes with all types that implement
        # the SlaDomain interface. Let's see how many there are:
        $implementingTypes = Get-RscHelp -Interface SlaDomain -ImplementingTypes
        $implementingTypes.Count | Should -Be $q1.Field.Nodes.Count

        # The types in Nodes should match the implementing types retrieved
        # from Get-RscHelp
        $q1.Field.Nodes | ForEach-Object {
            $implementingTypes | Should -Contain $_.GetType().Name
            # There is no composition here since we have a list of 
            # interfaces, each element in the list is an object that
            # implements the SlaDomain interface.
            # Composition is only used when the GraphQL schema specifies
            # a single object that implements an interface.
            $_.IsComposite() | Should -Be $false
            # Which is the same thing as:
            $_.GetNext() | Should -Be $null
        }

        $q1.GqlRequest().operationName | Should -Be "QuerySlaDomains"
        ($q1.GqlRequest().Variables|ConvertFrom-Json).first | Should -Be 1

        # Inspect the resulting GQL query
        $gqlQuery = $q1.GqlRequest().Query

        # We could assert the query string, but this test would then
        # require maintenance whenever the schema changes.
        # Instead we're only checking the {} block names:

        # Build the "... on X" fragments dynamically
        $fragments = $implementingTypes -join " { } ... on " | ForEach-Object { "... on $_ { }" }

        $expectedGqlQuery = "{ { nodes { $fragments } pageInfo { } } }"

        ($gqlQuery -split "`r?`n" | Where-Object { $_ -match "{" -or $_ -match "}" } | ForEach-Object { $_.Trim() }) -join " " | Should -Be $expectedGqlQuery

        # ----------------------------------------------------------
        #
        #               2. Retrieve a single SLA
        #
        # ----------------------------------------------------------

        $q2 = New-RscQuery -GqlQuery slaDomain -Var @{id = "0"}

        $q2.OpInfo().GqlRootFieldName | Should -Be "slaDomain"
        $q2.OpInfo().GqlReturnTypeName | Should -Be "SlaDomain"

        # In GraphQL, this query returns a single object that implements
        # the SlaDomain interface.
        # In PowerShell, we represent the field as an RscInterface
        # object.
        $type = $q2.field.gettype()
        $type.Name | Should -Be 'RscInterface`1'
        $type.IsGenericType | Should -Be $true
        $genericArguments = $type.GetGenericArguments()
        $genericArguments[0].Name | Should -Be "SlaDomain"
        $q2.Field | ForEach-Object {
            $implementingTypes | Should -Contain $_.GetType().Name
        }
        $q2.Field.Count | Should -Be $implementingTypes.Count

        # We can verify that the composite object is expanded into
        # the query by checking the GQL query string
        $gqlQuery = $q2.GqlRequest().Query
        $expectedGqlQuery = "{ { $fragments } }"
        ($gqlQuery -split "`r?`n" | Where-Object { $_ -match "{" -or $_ -match "}" } | ForEach-Object { $_.Trim() }) -join " " | Should -Be $expectedGqlQuery

        # Alternatively to AutoFieldSpec, we can build a composite
        # object manually:
        $q3 = New-RscQuery -Copy $q2
        $q3.Field.Clear()
        $implementingTypes | ForEach-Object {
            $t = Get-RscType -Name $_
            $t.SelectForRetrieval()
            $q3.Field.Add($t)
        }
        $q3.GqlRequest().Query | Should -Be $q2.GqlRequest().Query



    }
}