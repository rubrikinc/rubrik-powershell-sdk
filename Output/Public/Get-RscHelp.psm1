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
        DefaultParameterSetName = 'CommandName'
    )]
    Param (
        [Parameter(
            ParameterSetName = 'CommandName',
            HelpMessage = 'The name of the cmdlet to retrieve help for. ' +
                'The output will be the help message for the cmdlet, ' +
                'but this cmdlet extracts just the subcommand help messages.',
            Mandatory = $true)]
        [ValidateSet(
            'New-RscMutationActivitySeries',
            'New-RscMutationAws',
            'New-RscMutationAzure',
            'New-RscMutationAzureO365',
            'New-RscMutationCassandra',
            'New-RscMutationCluster',
            'New-RscMutationDb2',
            'New-RscMutationHyperv',
            'New-RscMutationLdap',
            'New-RscMutationMongo',
            'New-RscMutationMssql',
            'New-RscMutationNutanix',
            'New-RscMutationO365',
            'New-RscMutationOracle',
            'New-RscMutationSla',
            'New-RscMutationVcenter',
            'New-RscMutationVsphere',
            'New-RscMutationVsphereVm',
            'New-RscQueryAccount',
            'New-RscQueryActivitySeries',
            'New-RscQueryAws',
            'New-RscQueryAzure',
            'New-RscQueryAzureO365',
            'New-RscQueryCassandra',
            'New-RscQueryCluster',
            'New-RscQueryDb2',
            'New-RscQueryHyperv',
            'New-RscQueryLdap',
            'New-RscQueryMongo',
            'New-RscQueryMssql',
            'New-RscQueryNutanix',
            'New-RscQueryO365',
            'New-RscQueryOracle',
            'New-RscQuerySla',
            'New-RscQueryVcenter',
            'New-RscQueryVsphere',
            'New-RscQueryVsphereVm'
        )]
        [string]$CommandName,

        [Parameter(
            ParameterSetName = 'Locations',
            HelpMessage = 'Show File System locations the SDK uses.'
        )]
        [Switch]$Locations,

        [Parameter(
            ParameterSetName = 'LookupSchema',
            HelpMessage = 'The name of the element to look up in the schema. ' +
                'If the name is not unique, all matching elements will be ' +
                'returned. Regular expressions are supported.'
        )]
        [string]$LookupSchema
    )
    Begin {
        function GetCommandHelp {
            Param($CommandName)

            # Get the command
            $command = Get-Command $CommandName

            # Get parameters
            $params = $command.Parameters.Values

            # Filter only switch parameters
            $switchParams = $params | Where-Object { $_.ParameterType.Name -eq 'SwitchParameter' -and $_.Name -ne "Verbose" -and $_.Name -ne "Debug" -and $_.Name -ne "GetInput" }

            $switchParams | ForEach-Object {
                try {
                    $paramHelp = ((Get-Help $CommandName -Parameter $_.Name).description)[0].Text
                }
                catch {
                    $paramHelp = "Description not available."
                }
                [PSCustomObject]@{
                    Name        = $_.Name
                    Description = $paramHelp
                }
            }
        }

        function GetLocationHelp {
            Get-RscCmdlet -Locations
        }

        function LookupSchema {
            Param($name)
            # Ensure the name is not 'Unknown'
            if ($name -ieq "Unknown") {
                Write-Output "Unknown"
                return
            }

            # Get all the enums within the SchemaMeta class
            $enums = [RubrikSecurityCloud.Types.SchemaMeta].GetNestedTypes() | Where-Object { $_.IsEnum -and $_.Name -ne 'GqlRootFieldName'}

            # Iterate through each enum and check if it contains the lookup name
            $found = 0
            foreach ($enum in $enums) {
                # Get all names in the current enum
                $enumNames = [Enum]::GetNames($enum) | Where-Object { $_ -ine 'Unknown' }
                # Check if any of the names match the provided pattern
                foreach ($n in $enumNames) {
                    if ($n -like $name) {
                        # Extract the middle part of the enum name
                        $enumName = $enum.Name -replace '^Gql', '' -replace 'Name$', ''
                        Write-Output "${enumName}: $n"
                        $found += 1
                    }
                }
            }
            if ($found -eq 0) {
                Write-Output "No match found for '$name'."
            } elseif ($found -gt 1) {
                Write-Output "${found} matches found for '$name'."
            }
        }

    }
    
    Process {
        switch ($PSCmdlet.ParameterSetName) {
            'CommandName' { GetCommandHelp $CommandName }
            'Locations' { GetLocationHelp }
            'LookupSchema' { LookupSchema $LookupSchema }
        }
    }
}
