#Requires -Version 3
function Get-RscHelp {
    <#
    .SYNOPSIS
    Retrieve help around RSC cmdlets and the RSC schema.
    
    .DESCRIPTION
    This cmdlet is used to retrieve help around RSC cmdlets and the RSC schema.
    It can be used to retrieve help for a specific cmdlet,
    or to look up a schema element.
    but this cmdlet extracts just the subcommand help messages.

    .EXAMPLE
    Get-RscHelp -CommandName New-RscQueryCluster

    .EXAMPLE
    Get-RscHelp -Locations

    .EXAMPLE
    Get-RscHelp -LookupSchema clusterconnection
    Get-RscHelp -LookupSchema clustercon*
    
    #>
    [CmdletBinding(
        DefaultParameterSetName = 'Schema'
    )]
    Param (
        [Parameter(
            ParameterSetName = 'Locations',
            HelpMessage = 'Show File System locations the SDK uses.',
            Position = 0
        )]
        [Switch]$Locations,

        [Parameter(
            ParameterSetName = 'Schema',
            HelpMessage = 'Look up any symbol in the schema.',
            Position = 0
        )]
        [Switch]$Schema,

        [Parameter(
            ParameterSetName = 'Query',
            HelpMessage = 'Look up a query by name.',
            Position = 0
        )]
        [Switch]$Query,

        [Parameter(
            ParameterSetName = 'Mutation',
            HelpMessage = 'Look up a mutation by name.',
            Position = 0
        )]
        [Switch]$Mutation,

        [Parameter(
            ParameterSetName = 'Type',
            HelpMessage = 'Look up a type by name.',
            Position = 0
        )]
        [Switch]$Type,

        [Parameter(
            ParameterSetName = 'Scalar',
            HelpMessage = 'Look up a scalar by name.',
            Position = 0
        )]
        [Switch]$Scalar,

        [Parameter(
            ParameterSetName = 'Union',
            HelpMessage = 'Look up a union by name.',
            Position = 0
        )]
        [Switch]$Union,

        [Parameter(
            ParameterSetName = 'Interface',
            HelpMessage = 'Look up an interface by name.',
            Position = 0
        )]
        [Switch]$Interface,

        [Parameter(
            ParameterSetName = 'Input',
            HelpMessage = 'Look up an input by name.',
            Position = 0
        )]
        [Switch]$Inputs,

        [Parameter(
            ParameterSetName = 'Enum',
            HelpMessage = 'Look up an enum by name.',
            Position = 0
        )]
        [Switch]$Enum,

        [Parameter(
            ParameterSetName = 'Domain',
            HelpMessage = 'Look up an API domain by name.',
            Position = 0
        )]
        [Switch]$Domain,

        [Parameter(
            HelpMessage = 'Regular expression to match',
            Position = 1
        )]
        [string]$Match = ""

    )
    Begin {
        function GetLocationHelp {
            Get-RscCmdlet -Locations
        }

        function LookupSchema {
            $tableData = @()
            # Get all the enums within the SchemaMeta class
            $enums = [RubrikSecurityCloud.Types.SchemaMeta].GetNestedTypes() | Where-Object { $_.IsEnum -and $_.Name -ne 'GqlRootFieldName' -and $_.Name -ne 'RootFieldKind' }

            # Iterate through each enum and check if it contains the lookup name
            $found = 0
            foreach ($enum in $enums) {
                # Get all names in the current enum
                $enumValues = [Enum]::GetValues($enum) | Where-Object { $_ -ine 'Unknown' }
                # Check if any of the names match the provided pattern
                foreach ($value in $enumValues) {
                    if ($Match -eq "" -or $value -like $Match) {
                        # Extract the middle part of the enum name
                        $enumName = $enum.Name -replace '^Gql', '' -replace 'Name$', ''
                        $entry = New-Object PSObject -Property @{
                            Type = $enumName
                            Name = $value
                        }
                        $tableData += $entry
                        $found += 1
                    }
                }
            }
            $found = $tableData.Count
            if ($found -eq 0) {
                Write-Output "# No match found for '$Match'."
            }
            else {
                $tableData | Sort-Object Type, Name | Format-Table -Property Type, Name -AutoSize
                Write-Output "# ${found} matches found for '$Match'."
            }
        }

        function LookupQuery {
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlQueryName]) | Where-Object { $_ -ine 'Unknown' }
            foreach ($value in $enumValues) {
                # if it's an exact match, print query info
                if ( $value -eq $Match ) {
                    Write-Output "# GraphQL field: $value"
                    try {
                        $query = New-RscQuery -GqlQuery $value
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
                        $query = New-RscMutation -GqlMutation $value
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
        
        function LookupDomain {
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+ApiDomainName]) | Where-Object { $_ -ine 'Unknown' }
            foreach ($value in $enumValues) {
                # If it's an exact match, print operations in domain
                if ($value -eq $Match) {
                    $info = [RubrikSecurityCloud.Types.SchemaMeta]::ApiOperationsByApiDomainName($value)
                    Write-Output "# Operations in domain ${value}:"
                    Write-Output $info
                    continue
                }
                # print it if $Enum is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    Write-Output $value
                }
            }
        }

    }
    
    Process {
        if ($Match -ieq "Unknown") {
            Write-Output "Unknown"
            return
        }
        switch ($PSCmdlet.ParameterSetName) {
            'Locations' { GetLocationHelp }
            'Schema' { LookupSchema }
            'Query' { LookupQuery }
            'Mutation' { LookupMutation }
            'Type' { LookupType }
            'Scalar' { LookupScalar }
            'Union' { LookupUnion }
            'Interface' { LookupInterface }
            'Input' { LookupInput }
            'Enum' { LookupEnum }
            'Domain' { LookupDomain }
        }
    }
}
