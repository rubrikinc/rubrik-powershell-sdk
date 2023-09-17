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
    Get-RscHelp -CommandName Invoke-RscQueryCluster

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
            'Invoke-RscMutateActivitySeries',
            'Invoke-RscMutateAws',
            'Invoke-RscMutateAzure',
            'Invoke-RscMutateAzureO365',
            'Invoke-RscMutateCassandra',
            'Invoke-RscMutateCluster',
            'Invoke-RscMutateDb2',
            'Invoke-RscMutateHyperv',
            'Invoke-RscMutateLdap',
            'Invoke-RscMutateMongo',
            'Invoke-RscMutateMssql',
            'Invoke-RscMutateNutanix',
            'Invoke-RscMutateO365',
            'Invoke-RscMutateOracle',
            'Invoke-RscMutateSla',
            'Invoke-RscMutateVcenter',
            'Invoke-RscMutateVsphere',
            'Invoke-RscMutateVsphereVm',
            'Invoke-RscQueryAccount',
            'Invoke-RscQueryActivitySeries',
            'Invoke-RscQueryAws',
            'Invoke-RscQueryAzure',
            'Invoke-RscQueryAzureO365',
            'Invoke-RscQueryCassandra',
            'Invoke-RscQueryCluster',
            'Invoke-RscQueryDb2',
            'Invoke-RscQueryHyperv',
            'Invoke-RscQueryLdap',
            'Invoke-RscQueryMongo',
            'Invoke-RscQueryMssql',
            'Invoke-RscQueryNutanix',
            'Invoke-RscQueryO365',
            'Invoke-RscQueryOracle',
            'Invoke-RscQuerySla',
            'Invoke-RscQueryVcenter',
            'Invoke-RscQueryVsphere',
            'Invoke-RscQueryVsphereVm'
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
