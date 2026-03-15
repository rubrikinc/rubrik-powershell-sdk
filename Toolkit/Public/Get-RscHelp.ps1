#Requires -Version 3
function Get-RscHelp {
    <#
    .SYNOPSIS
    Look up GraphQL queries, mutations, types, and other schema elements.

    .DESCRIPTION
    Search the RSC GraphQL schema by name or pattern. By default, matches
    across all schema elements (queries, mutations, types, inputs, enums, etc.)
    and shows queries/mutations with their return types for quick reference.

    Use the -Query, -Mutation, -Type, -Enum, -Input, -Interface, -Scalar,
    or -Union switches to narrow the search to a specific kind.

    .EXAMPLE
    Get-RscHelp clusterConnection

    Search for "clusterConnection" across all schema elements:

    Kind  GqlField          ReturnType
    ----  --------          ----------
    Query clusterConnection ClusterConnection

    Type Name
    ---- ----
    Type ClusterConnection

    # 2 matches found for 'clusterConnection'.

    .EXAMPLE
    Get-RscHelp cluster*

    Wildcard search — shows matching queries with return types, then other types:

    Kind  GqlField                        ReturnType
    ----  --------                        ----------
    Query cluster                         Cluster
    Query clusterCertificates             CertificateSummaryListResponse
    Query clusterConnection               ClusterConnection
    ...

    Type  Name
    ----  ----
    Enum  ClusterSortByEnum
    Input ClusterFilterInput
    Type  Cluster
    Type  ClusterConnection
    ...

    .EXAMPLE
    Get-RscHelp -Query clusterConnection

    Exact query lookup — shows variables, return type, and invocation:

    Name            Type               Description
    ----            ----               -----------
    GQL Field                          clusterConnection
    Invocation                         $query = New-RscQuery -Gql clusterConnection
    Var.first       Int                Int
    Var.filter      ClusterFilterInput ClusterFilterInput: https://...
    Field           ClusterConnection  https://...

    .EXAMPLE
    Get-RscHelp -Locations

    Show file system locations used by the SDK.

    .PARAMETER Match
    Name or wildcard pattern to search for (e.g. "clusterConnection", "cluster*").

    .PARAMETER Schema
    Search across all schema elements (default). Queries and mutations are
    shown with their return types; other elements are listed by kind.

    .PARAMETER Query
    Look up a GraphQL query by name. An exact match shows full details
    (variables, return type, invocation syntax).

    .PARAMETER Mutation
    Look up a GraphQL mutation by name. An exact match shows full details.

    .PARAMETER Type
    Look up a GraphQL object type by name.

    .PARAMETER Enum
    Look up a GraphQL enum by name.

    .PARAMETER Inputs
    Look up a GraphQL input type by name.

    .PARAMETER Interface
    Look up a GraphQL interface by name.

    .PARAMETER ImplementingTypes
    With -Interface, return only the types that implement the interface.

    .PARAMETER Scalar
    Look up a GraphQL scalar by name.

    .PARAMETER Union
    Look up a GraphQL union by name.

    .PARAMETER Cmdlet
    Show full help for a PowerShell cmdlet (equivalent to Get-Help -Full).

    .PARAMETER About
    Show the SDK About page (animated logo and credits).

    .PARAMETER Locations
    Show file system locations the SDK uses.

    .PARAMETER Stats
    Show schema statistics: element counts, top return types, busiest
    interfaces, and other cross-referenced data about the current SDK.

    .EXAMPLE
    Get-RscHelp -Stats

    Display schema statistics for the current SDK version.

    #>
    [CmdletBinding(
        DefaultParameterSetName = 'Schema'
    )]
    Param (
        [Parameter(
            ParameterSetName = 'About',
            HelpMessage = 'Show the SDK About page (animated logo and credits).'
        )]
        [Switch]$About,

        [Parameter(
            ParameterSetName = 'Locations',
            HelpMessage = 'Show File System locations the SDK uses.'
        )]
        [Switch]$Locations,

        [Parameter(
            ParameterSetName = 'Schema',
            HelpMessage = 'Look up any symbol in the schema.'
        )]
        [Switch]$Schema,

        [Parameter(
            ParameterSetName = 'Query',
            HelpMessage = 'Look up a query by name.'
        )]
        [Switch]$Query,

        [Parameter(
            ParameterSetName = 'Mutation',
            HelpMessage = 'Look up a mutation by name.'
        )]
        [Switch]$Mutation,

        [Parameter(
            ParameterSetName = 'Type',
            HelpMessage = 'Look up a type by name.'
        )]
        [Switch]$Type,

        [Parameter(
            ParameterSetName = 'Scalar',
            HelpMessage = 'Look up a scalar by name.'
        )]
        [Switch]$Scalar,

        [Parameter(
            ParameterSetName = 'Union',
            HelpMessage = 'Look up a union by name.'
        )]
        [Switch]$Union,

        [Parameter(
            ParameterSetName = 'Interface',
            HelpMessage = 'Look up an interface by name.'
        )]
        [Switch]$Interface,

        [Parameter(
            ParameterSetName = 'Interface',
            HelpMessage = 'Only show the implementing types.'
        )]
        [Switch]$ImplementingTypes,

        [Parameter(
            ParameterSetName = 'Input',
            HelpMessage = 'Look up an input by name.'
        )]
        [Switch]$Inputs,

        [Parameter(
            ParameterSetName = 'Enum',
            HelpMessage = 'Look up an enum by name.'
        )]
        [Switch]$Enum,

        [Parameter(
            ParameterSetName = 'Stats',
            HelpMessage = 'Show schema statistics about the current SDK.'
        )]
        [Switch]$Stats,

        [Parameter(
            ParameterSetName = 'Cmdlet',
            HelpMessage = 'This is equivalent to Get-Help -Name <cmdlet> -Full'
        )]
        [Switch]$Cmdlet,

        [Parameter(
            HelpMessage = 'Regular expression to match',
            Position = 0
        )]
        [ArgumentCompleter({
            param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameters)
            # Dot syntax: TypeName.field<Tab> -> complete field names
            if ($wordToComplete -match '^([A-Za-z_]\w*)\.(.*)$') {
                $typeName = $Matches[1]
                $fieldPrefix = $Matches[2] + '*'
                $ns = "RubrikSecurityCloud.Types"
                $netType = try { [Type]("$ns.$typeName") } catch { $null }
                if ($netType) {
                    $props = $netType.GetProperties([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance) |
                        Where-Object { $_.Name -ine 'InternalQuery' -and $_.Name -like $fieldPrefix } |
                        Sort-Object Name
                    foreach ($p in $props) {
                        $completion = "$typeName.$($p.Name)"
                        [System.Management.Automation.CompletionResult]::new($completion, $completion, 'ParameterValue', $p.Name)
                    }
                }
            } else {
                $pattern = "$wordToComplete*"
                $sm = [RubrikSecurityCloud.Types.SchemaMeta]
                $seen = @{}
                foreach ($enum in $sm.GetNestedTypes()) {
                    if (-not $enum.IsEnum) { continue }
                    if ($enum.Name -eq 'GqlRootFieldName' -or $enum.Name -eq 'RootFieldKind' -or $enum.Name -eq 'ApiDomainName') { continue }
                    foreach ($val in [Enum]::GetValues($enum)) {
                        $name = [string]$val
                        if ($name -ieq 'Unknown') { continue }
                        if ($name -like $pattern -and -not $seen.ContainsKey($name)) {
                            $seen[$name] = $true
                            [System.Management.Automation.CompletionResult]::new($name, $name, 'ParameterValue', $name)
                        }
                    }
                }
            }
        })]
        [string]$Match = ""

    )
    Begin {
        Write-Debug "=> ParameterSetName: $($PSCmdlet.ParameterSetName) Match: $Match"
        function GetLocationHelp {
            Write-Debug "Getting locations"
            Get-RscCmdlet -Locations
        }

        function GetCmdletHelp {
            Write-Debug "Getting cmdlet help for '$Match'"
            if ($Match -eq "") {
                $Match = "New-Rsc"
            }
            Get-Help -Name $Match -Full
        }

        function LookupFields {
            param([string]$TypeName, [string]$FieldPattern)
            Write-Debug "Looking up fields: $TypeName.$FieldPattern"
            # Load schema descriptions
            $descFile = Join-Path $PSScriptRoot "..\Private\SchemaDescriptions.ps1"
            if (Test-Path $descFile) {
                . $descFile
            }
            # Find the .NET type
            $ns = "RubrikSecurityCloud.Types"
            $netType = [Type]("$ns.$TypeName")
            if (-not $netType) {
                Write-Output "# Type '$TypeName' not found."
                return
            }
            # Get properties via reflection
            $props = $netType.GetProperties([System.Reflection.BindingFlags]::Public -bor [System.Reflection.BindingFlags]::Instance) |
                Where-Object { $_.Name -ine 'InternalQuery' } |
                Sort-Object Name
            if ($FieldPattern -and $FieldPattern -ne '*') {
                $props = $props | Where-Object { $_.Name -like $FieldPattern }
            }
            if ($props.Count -eq 0) {
                Write-Output "# No fields matching '$FieldPattern' on type '$TypeName'."
                return
            }
            $rows = @()
            $n = 0
            foreach ($p in $props) {
                $n++
                # Simplify the .NET type name
                $pt = $p.PropertyType
                if ($pt.IsGenericType -and $pt.GetGenericTypeDefinition() -eq [System.Nullable``1]) {
                    $innerName = $pt.GetGenericArguments()[0].Name
                    $ftName = "$innerName?"
                } elseif ($pt.IsGenericType -and $pt.Name -match '^List') {
                    $innerName = $pt.GetGenericArguments()[0].Name
                    $ftName = "[$innerName]"
                } else {
                    $ftName = $pt.Name
                }
                $desc = ""
                if ($Script:SchemaFieldDescriptions) {
                    $desc = $Script:SchemaFieldDescriptions["$TypeName.$($p.Name)"]
                }
                $rows += New-Object PSObject -Property ([ordered]@{
                    '#'          = $n
                    Field        = $p.Name
                    Type         = $ftName
                    Description  = $desc
                })
            }
            Write-Output ""
            Write-Output "# $($rows.Count) fields on ${TypeName}:"
            $rows | Format-Table -Property '#', Field, Type, Description -AutoSize
        }

        function LookupSchema {
            Write-Debug "Looking up schema for '$Match'"
            if ($Match -imatch "^new-") {
                GetCmdletHelp
                return
            }
            # Dot syntax: TypeName.fieldPattern
            if ($Match -match '^([A-Za-z_]\w*)\.(.*)$') {
                LookupFields -TypeName $Matches[1] -FieldPattern $Matches[2]
                return
            }
            # Load schema descriptions
            $descFile = Join-Path $PSScriptRoot "..\Private\SchemaDescriptions.ps1"
            if (Test-Path $descFile) {
                . $descFile
            }
            $rootFieldData = @()
            $otherData = @()
            # Get all the enums within the SchemaMeta class
            $enums = [RubrikSecurityCloud.Types.SchemaMeta].GetNestedTypes() | Where-Object { $_.IsEnum -and $_.Name -ne 'GqlRootFieldName' -and $_.Name -ne 'RootFieldKind' -and $_.Name -ne 'ApiDomainName' }

            # Names of enums that represent root fields (queries and mutations)
            $rootFieldEnumNames = @('GqlQueryName', 'GqlMutationName')

            # Iterate through each enum and check if it contains the lookup name
            foreach ($enum in $enums) {
                $isRootField = $rootFieldEnumNames -contains $enum.Name
                # Get all names in the current enum
                $enumValues = [Enum]::GetValues($enum) | Where-Object { $_ -ine 'Unknown' }
                # Check if any of the names match the provided pattern
                foreach ($value in $enumValues) {
                    if ($Match -eq "" -or $value -like $Match) {
                        if ($isRootField) {
                            # Look up kind and return type for root fields
                            $kind = try {
                                [RubrikSecurityCloud.Types.SchemaMeta]::GetRootFieldKind($value)
                            } catch { $null }
                            $returnType = try {
                                [RubrikSecurityCloud.Types.SchemaMeta]::ReturnTypeLookupByGqlRootField($value)
                            } catch { "" }
                            $kindStr = if ($kind -and $kind.ToString() -ne 'Unknown') { $kind.ToString() } else {
                                $enum.Name -replace '^Gql', '' -replace 'Name$', ''
                            }
                            $rootFieldData += New-Object PSObject -Property @{
                                Kind       = $kindStr
                                GqlField   = [string]$value
                                ReturnType = [string]$returnType
                            }
                        }
                        else {
                            $enumName = $enum.Name -replace '^Gql', '' -replace 'Name$', ''
                            $otherData += New-Object PSObject -Property @{
                                Type = $enumName
                                Name = [string]$value
                            }
                        }
                    }
                }
            }
            $total = $rootFieldData.Count + $otherData.Count
            if ($total -eq 0) {
                Write-Output "# No match found for '$Match'."
            }
            else {
                # Build a single unified table with numbered matches
                $rows = @()
                $n = 0
                foreach ($rf in ($rootFieldData | Sort-Object Kind, GqlField)) {
                    $n++
                    $desc = ""
                    if ($Script:SchemaDescriptions) {
                        $desc = $Script:SchemaDescriptions["$($rf.Kind):$($rf.GqlField)"]
                    }
                    $info = "returns $($rf.ReturnType)"
                    $rows += New-Object PSObject -Property ([ordered]@{
                        '#'          = $n
                        Kind         = $rf.Kind
                        Name         = $rf.GqlField
                        Info         = $info
                        Description  = $desc
                    })
                }
                foreach ($item in ($otherData | Sort-Object Type, Name)) {
                    $n++
                    $desc = ""
                    if ($Script:SchemaDescriptions) {
                        $desc = $Script:SchemaDescriptions["$($item.Type):$($item.Name)"]
                    }
                    $info = ""
                    if ($item.Type -eq 'Interface') {
                        $impls = try { [RubrikSecurityCloud.Types.SchemaMeta]::InterfaceImpls($item.Name) } catch { @() }
                        if ($impls.Count -gt 0) {
                            $info = "implemented by: $(($impls | Sort-Object) -join ', ')"
                        }
                    }
                    elseif ($item.Type -eq 'Type' -and $Script:SchemaImplements) {
                        $ifaces = $Script:SchemaImplements[$item.Name]
                        if ($ifaces -and $ifaces.Count -gt 0) {
                            $info = "implements: $(($ifaces | Sort-Object) -join ', ')"
                        }
                    }
                    $rows += New-Object PSObject -Property ([ordered]@{
                        '#'          = $n
                        Kind         = $item.Type
                        Name         = $item.Name
                        Info         = $info
                        Description  = $desc
                    })
                }

                # --- Display functions ---
                function ShowCompactTable {
                    Write-Host ""
                    Write-Host "# $total matches for '${Match}':"
                    $rows | Format-Table -Property '#', Kind, Name, Info, Description -AutoSize | Out-Host
                }

                function ShowDetailForRow($row) {
                    Write-Host ""
                    Write-Host "--- [$($row.'#')] $($row.Kind): $($row.Name) ---" -ForegroundColor Cyan
                    if ($row.Description) {
                        Write-Host "  $($row.Description)"
                    }
                    if ($row.Info) {
                        Write-Host "  $($row.Info)" -ForegroundColor DarkGray
                    }
                    $key = "$($row.Kind):$($row.Name)"
                    # Query/Mutation: show arguments
                    if ($row.Kind -eq 'Query' -or $row.Kind -eq 'Mutation') {
                        $args2 = $Script:SchemaRootFieldArgs[$key]
                        if ($args2 -and $args2.Count -gt 0) {
                            Write-Host "  Parameters:" -ForegroundColor Yellow
                            foreach ($a in $args2) {
                                Write-Host "    $a"
                            }
                        }
                    }
                    # Interface: show implementing types with descriptions
                    elseif ($row.Kind -eq 'Interface') {
                        $impls = try { [RubrikSecurityCloud.Types.SchemaMeta]::InterfaceImpls($row.Name) } catch { @() }
                        if ($impls.Count -gt 0) {
                            Write-Host "  Implementing types:" -ForegroundColor Yellow
                            foreach ($impl in ($impls | Sort-Object)) {
                                $implDesc = $Script:SchemaDescriptions["Type:$impl"]
                                if ($implDesc) {
                                    Write-Host "    $impl - $implDesc"
                                } else {
                                    Write-Host "    $impl"
                                }
                            }
                        }
                    }
                    # Type: show interfaces and field count
                    elseif ($row.Kind -eq 'Type') {
                        if ($Script:SchemaImplements) {
                            $ifaces = $Script:SchemaImplements[$row.Name]
                            if ($ifaces -and $ifaces.Count -gt 0) {
                                Write-Host "  Implements:" -ForegroundColor Yellow
                                foreach ($iface in ($ifaces | Sort-Object)) {
                                    $ifaceDesc = $Script:SchemaDescriptions["Interface:$iface"]
                                    if ($ifaceDesc) {
                                        Write-Host "    $iface - $ifaceDesc"
                                    } else {
                                        Write-Host "    $iface"
                                    }
                                }
                            }
                        }
                    }
                }

                function ShowExpandedView {
                    Write-Host ""
                    Write-Host "# $total matches for '${Match}' (expanded):"
                    foreach ($row in $rows) {
                        ShowDetailForRow $row
                    }
                    Write-Host ""
                }

                # --- Initial display ---
                $expanded = $false
                ShowCompactTable

                # --- Interactive loop (only in interactive host) ---
                $isInteractive = $Host.Name -eq 'ConsoleHost' -and [Environment]::UserInteractive
                if ($isInteractive -and $total -gt 0) {
                    while ($true) {
                        $input2 = Read-Host "[1-$total] detail  [d] expand all  [Enter] exit"
                        $input2 = $input2.Trim()
                        # Enter (empty) or q → exit
                        if ($input2 -eq '' -or $input2 -eq 'q') {
                            break
                        }
                        # 'd' → toggle expanded view
                        if ($input2 -eq 'd') {
                            $expanded = -not $expanded
                            Clear-Host
                            if ($expanded) {
                                ShowExpandedView
                            } else {
                                ShowCompactTable
                            }
                            continue
                        }
                        # Number → show detail for that row
                        $num = 0
                        if ([int]::TryParse($input2, [ref]$num) -and $num -ge 1 -and $num -le $total) {
                            Clear-Host
                            ShowCompactTable
                            ShowDetailForRow $rows[$num - 1]
                            Write-Host ""
                            continue
                        }
                    }
                }
            }
        }

        function LookupQuery {
            Write-Debug "Looking up query for '$Match'"
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlQueryName]) | Where-Object { $_ -ine 'Unknown' }
            foreach ($value in $enumValues) {
                # if it's an exact match, print query info
                if ( $value -eq $Match ) {
                    Write-Output "# GraphQL field: $value"
                    try {
                        $query = New-RscQuery -Gql $value
                        $info = $query.Info()
                    }
                    catch {
                        $info = "# Query $value is not supported."
                    }
                    Write-Output $info
                    continue
                }
                # print it if $Query is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    Write-Output $value
                }
            }
        }

        function LookupMutation {
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlMutationName]) | Where-Object { $_ -ine 'Unknown' }
            foreach ($value in $enumValues) {
                # if it's an exact match, print mutation info
                if ( $value -eq $Match ) {
                    Write-Output "# GraphQL field: $value"
                    try {
                        $query = New-RscMutation -Gql $value
                        $info = $query.Info()
                    }
                    catch {
                        $info = "# Mutation $value is not supported."
                    }
                    Write-Output $info
                    continue
                }
                # print it if $Query is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    Write-Output $value
                }
            }
        }

        function LookupUsageInRootFields {
            param (
                [Parameter(
                    Mandatory = $true,
                    HelpMessage = 'Name of the type to look up.'
                )]
                [string]$typeName,

                [Parameter(
                    Mandatory = $false,
                    HelpMessage = 'Kind of type to look up.'
                )]
                [string]$typeKindName,

                [Parameter(
                    Mandatory = $false,
                    HelpMessage = 'Quietly return counts'
                )]
                [switch]$CountOnly
            )
            $info1 = [RubrikSecurityCloud.Types.SchemaMeta]::GqlRootFieldLookupByReturnType($typeName)
            $info2 = [RubrikSecurityCloud.Types.SchemaMeta]::GqlRootFieldLookupByArgType($typeName)
            if ($CountOnly) {
                $count1 = $info1.Count
                $count2 = $info2.Count
                return New-Object PSObject -Property @{
                    TypeName     = $typeName
                    AsReturnType = $count1
                    AsArgument   = $count2
                }
            }
            Write-Output "# GraphQL fields that return this ${typeKindName}:"
            Write-Output $info1
            Write-Output "# GraphQL fields that accept this ${typeKindName} as an argument:"
            Write-Output $info2
        }

        function LookupType {
            $tableData = @()
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlTypeName]) | Where-Object { $_ -ine 'Unknown' }
            foreach ($value in $enumValues) {
                # if it's an exact match, print type info
                if ( $value -eq $Match ) {
                    Write-Output "# Type: $value"
                    Write-Output "# `$t = Get-RscType -Name $value"
                    Write-Output "# `$t.AllFields()"
                    Write-Output "# "
                    LookupUsageInRootFields -typeName $value -typeKindName "type"
                    continue
                }
                # print it if $Input is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    # retrieve usage counts
                    $tableData += LookupUsageInRootFields -typeName $value -CountOnly
                }
            }
            # Display the table, sorted by the number of times the type is used as a return type
            $tableData | Sort-Object AsReturnType | Format-Table -Property TypeName, AsReturnType, AsArgument -AutoSize
        }

        function LookupScalar {
            $tableData = @()
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlScalarName]) | Where-Object { $_ -ine 'Unknown' }
            foreach ($value in $enumValues) {
                # if it's an exact match, print scalar info
                if ( $value -eq $Match ) {
                    Write-Output "# Scalar: $value"
                    LookupUsageInRootFields -typeName $value -typeKindName "scalar"
                    continue
                }
                # print it if $Input is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    # retrieve usage counts
                    $tableData += LookupUsageInRootFields -typeName $value -CountOnly
                }
            }
            # Display the table, sorted by the number of times the type is used as a return type
            $tableData | Sort-Object AsReturnType | Format-Table -Property TypeName, AsReturnType, AsArgument -AutoSize
        }

        function LookupUnion {
            $tableData = @()
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlUnionName]) | Where-Object { $_ -ine 'Unknown' }
            foreach ($value in $enumValues) {
                # if it's an exact match, print union info
                if ( $value -eq $Match ) {
                    Write-Output "# Union: $value"
                    LookupUsageInRootFields -typeName $value -typeKindName "union"
                    continue
                }
                # print it if $Input is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    # retrieve usage counts
                    $tableData += LookupUsageInRootFields -typeName $value -CountOnly
                }
            }
            # Display the table, sorted by the number of times the type is used as a return type
            $tableData | Sort-Object AsReturnType | Format-Table -Property TypeName, AsReturnType, AsArgument -AutoSize
        }

        function LookupInterface {
            $tableData = @()
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlInterfaceName]) | Where-Object { $_ -ine 'Unknown' }
            foreach ($value in $enumValues) {
                # if it's an exact match, print interface info
                if ( $value -eq $Match ) {
                    if ($ImplementingTypes) {
                        Get-RscType -Interface $value
                        return
                    }
                    try {
                        Write-Output "# Types that implement interface ${value}:"
                        $info = Get-RscType -Interface $value
                    }
                    catch {
                        $info = "# Interface $value is not supported."
                    }
                    Write-Output $info
                    LookupUsageInRootFields -typeName $value -typeKindName "interface"
                    continue
                }
                # print it if $Interface is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    # retrieve usage counts
                    $tableData += LookupUsageInRootFields -typeName $value -CountOnly
                }
            }
            # Display the table, sorted by the number of times the type is used as a return type
            $tableData | Sort-Object AsReturnType | Format-Table -Property TypeName, AsReturnType, AsArgument -AutoSize
        }

        function LookupInput {
            $tableData = @()
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlInputName]) | Where-Object { $_ -ine 'Unknown' }
            foreach ($value in $enumValues) {
                # if it's an exact match, print input info
                if ( $value -eq $Match ) {
                    Write-Output "# Input: $value"
                    LookupUsageInRootFields -typeName $value -typeKindName "input"
                    continue
                }
                # print it if $Input is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    # retrieve usage counts
                    $tableData += LookupUsageInRootFields -typeName $value -CountOnly
                }
            }
            # Display the table, sorted by the number of times the type is used as an argument
            $tableData | Sort-Object AsArgument | Format-Table -Property TypeName, AsReturnType, AsArgument -AutoSize
        }

        function LookupEnum {
            $tableData = @()
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlEnumName]) | Where-Object { $_ -ine 'Unknown' }
            foreach ($value in $enumValues) {
                # if it's an exact match, print enum info
                if ( $value -eq $Match ) {
                    Write-Output "# Enum: $value"
                    LookupUsageInRootFields -typeName $value -typeKindName "enum"
                    continue
                }
                # print it if $Enum is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    # retrieve usage counts
                    $tableData += LookupUsageInRootFields -typeName $value -CountOnly
                }
            }
            # Display the table, sorted by the number of times the type is used as an argument
            $tableData | Sort-Object AsArgument | Format-Table -Property TypeName, AsReturnType, AsArgument -AutoSize
        }

        function ShowStats {
            $SM = [RubrikSecurityCloud.Types.SchemaMeta]
            function ExcludeUnknown($enumType) {
                [Enum]::GetValues($enumType) | Where-Object { $_ -ine 'Unknown' }
            }

            # Counts
            $queries    = ExcludeUnknown ([RubrikSecurityCloud.Types.SchemaMeta+GqlQueryName])
            $mutations  = ExcludeUnknown ([RubrikSecurityCloud.Types.SchemaMeta+GqlMutationName])
            $types      = ExcludeUnknown ([RubrikSecurityCloud.Types.SchemaMeta+GqlTypeName])
            $inputs     = ExcludeUnknown ([RubrikSecurityCloud.Types.SchemaMeta+GqlInputName])
            $enumVals   = ExcludeUnknown ([RubrikSecurityCloud.Types.SchemaMeta+GqlEnumName])
            $interfaces = ExcludeUnknown ([RubrikSecurityCloud.Types.SchemaMeta+GqlInterfaceName])
            $unions     = ExcludeUnknown ([RubrikSecurityCloud.Types.SchemaMeta+GqlUnionName])
            $scalars    = ExcludeUnknown ([RubrikSecurityCloud.Types.SchemaMeta+GqlScalarName])
            $nRootFields = $queries.Count + $mutations.Count
            $nTotal      = $nRootFields + $types.Count + $inputs.Count + $enumVals.Count + $interfaces.Count + $unions.Count + $scalars.Count

            Write-Output ""
            Write-Output "# RSC GraphQL Schema Statistics"
            Write-Output ""

            @(
                [PSCustomObject]@{ Element = "Queries";    Count = $queries.Count }
                [PSCustomObject]@{ Element = "Mutations";  Count = $mutations.Count }
                [PSCustomObject]@{ Element = "Types";      Count = $types.Count }
                [PSCustomObject]@{ Element = "Inputs";     Count = $inputs.Count }
                [PSCustomObject]@{ Element = "Enums";      Count = $enumVals.Count }
                [PSCustomObject]@{ Element = "Interfaces"; Count = $interfaces.Count }
                [PSCustomObject]@{ Element = "Unions";     Count = $unions.Count }
                [PSCustomObject]@{ Element = "Scalars";    Count = $scalars.Count }
            ) | Format-Table -AutoSize
            Write-Output "  $nRootFields root fields, $nTotal schema elements total."
            Write-Output ""

            # --- Return type analysis ---
            $queryRts = @{}
            $mutRts   = @{}
            foreach ($q in $queries) {
                $rt = try { $SM::ReturnTypeLookupByGqlRootField($q) } catch { $null }
                if ($rt) { $queryRts[$rt] = ([int]$queryRts[$rt]) + 1 }
            }
            foreach ($m in $mutations) {
                $rt = try { $SM::ReturnTypeLookupByGqlRootField($m) } catch { $null }
                if ($rt) { $mutRts[$rt] = ([int]$mutRts[$rt]) + 1 }
            }

            Write-Output "# Return Types"
            Write-Output ""
            Write-Output "  $($queryRts.Count) unique return types across $($queries.Count) queries."
            Write-Output "  $($mutRts.Count) unique return types across $($mutations.Count) mutations."
            $shared = ($mutRts.Keys | Where-Object { $queryRts.ContainsKey($_) }).Count
            Write-Output "  $shared return types shared between queries and mutations."
            Write-Output ""

            Write-Output "# Most-Returned Types (queries)"
            Write-Output ""
            $queryRts.GetEnumerator() |
                Sort-Object Value -Descending |
                Select-Object -First 10 |
                ForEach-Object { [PSCustomObject]@{ Queries = $_.Value; ReturnType = $_.Key } } |
                Format-Table -AutoSize

            Write-Output "# Most-Returned Types (mutations)"
            Write-Output ""
            $mutRts.GetEnumerator() |
                Sort-Object Value -Descending |
                Select-Object -First 10 |
                ForEach-Object { [PSCustomObject]@{ Mutations = $_.Value; ReturnType = $_.Key } } |
                Format-Table -AutoSize

            # --- Interface implementations ---
            Write-Output "# Largest Interfaces (by implementing types)"
            Write-Output ""
            $ifaceData = foreach ($iface in $interfaces) {
                $impls = try { $SM::InterfaceImpls($iface) } catch { @() }
                [PSCustomObject]@{ Interface = [string]$iface; Types = $impls.Count }
            }
            $ifaceData | Sort-Object Types -Descending | Select-Object -First 10 | Format-Table -AutoSize

            # --- Type coverage ---
            Write-Output "# Type Coverage"
            Write-Output ""
            $directlyReferenced = 0
            $indirectOnly = 0
            foreach ($t in $types) {
                $asReturn = $SM::GqlRootFieldLookupByReturnType($t)
                $asArg    = $SM::GqlRootFieldLookupByArgType($t)
                if ($asReturn.Count -gt 0 -or $asArg.Count -gt 0) {
                    $directlyReferenced++
                } else {
                    $indirectOnly++
                }
            }
            $pct = [math]::Round(100 * $directlyReferenced / $types.Count, 1)
            Write-Output "  $directlyReferenced of $($types.Count) types ($pct%) are directly referenced by a root field."
            Write-Output "  $indirectOnly types are only reachable through nested fields."
            Write-Output ""
        }

    }
    
    Process {
        if ($Match -ieq "Unknown") {
            Write-Output "Unknown"
            return
        }
        switch ($PSCmdlet.ParameterSetName) {
            'About' {
                . "$PSScriptRoot\..\Private\Show-RscAbout.ps1"
                Show-RscAbout
                return
            }
            'Locations' { GetLocationHelp }
            'Stats' { ShowStats }
            'Cmdlet' { GetCmdletHelp }
            'Schema' { LookupSchema }
            'Query' { LookupQuery }
            'Mutation' { LookupMutation }
            'Type' { LookupType }
            'Scalar' { LookupScalar }
            'Union' { LookupUnion }
            'Interface' { LookupInterface }
            'Input' { LookupInput }
            'Enum' { LookupEnum }
        }
    }
}
