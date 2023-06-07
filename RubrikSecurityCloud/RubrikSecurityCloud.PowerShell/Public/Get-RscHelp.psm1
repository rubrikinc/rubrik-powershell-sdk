#Requires -Version 3
function Get-RscHelp {
    <#
    .SYNOPSIS
    Retrieve subcommand help messages for a given cmdlet
    
    .DESCRIPTION
    All info retrieved with this cmdlet is available with
    Get-Help <cmdlet> -Detailed

    but this cmdlet extracts just the subcommand help messages.

    .EXAMPLE
    Get-SubcommandHelp -CommandName Invoke-RscQueryCluster
    #>
    param (
        [Parameter(Mandatory = $true)]
        [ValidateSet(
            'Invoke-RscMutateMongo',
            'Invoke-RscQueryAccount',
            'Invoke-RscQueryMongo',
            'Invoke-RscMutateActivitySeries',
            'Invoke-RscMutateMssql',
            'Invoke-RscQueryActivitySeries',
            'Invoke-RscQueryMssql',
            'Invoke-RscMutateAws',
            'Invoke-RscMutateNutanix',
            'Invoke-RscQueryAws',
            'Invoke-RscQueryNutanix',
            'Invoke-RscMutateAzure',
            'Invoke-RscMutateO365',
            'Invoke-RscQueryAzure',
            'Invoke-RscQueryO365',
            'Invoke-RscMutateAzureO365',
            'Invoke-RscMutateOracle',
            'Invoke-RscQueryAzureO365',
            'Invoke-RscQueryOracle',
            'Invoke-RscMutateCassandra',
            'Invoke-RscMutateSla',
            'Invoke-RscQueryCassandra',
            'Invoke-RscQuerySla',
            'Invoke-RscMutateCluster',
            'Invoke-RscMutateVcenter',
            'Invoke-RscQueryCluster',
            'Invoke-RscQueryVcenter',
            'Invoke-RscMutateHyperv',
            'Invoke-RscMutateVsphere',
            'Invoke-RscQueryHyperv',
            'Invoke-RscQueryVsphere',
            'Invoke-RscMutateLdap',
            'Invoke-RscMutateVsphereVm',
            'Invoke-RscQueryLdap',
            'Invoke-RscQueryVsphereVm'
        )]
        [string]$CommandName
    )

    Process {
        # Get the command
        $command = Get-Command $CommandName

        # Get parameters
        $params = $command.Parameters.Values

        # Filter only switch parameters
        $switchParams = $params | Where-Object { $_.ParameterType.Name -eq 'SwitchParameter' -and $_.Name -ne "Verbose" -and $_.Name -ne "Debug" -and $_.Name -ne "GetInputs"}

        $switchParams | ForEach-Object {
            try {
                $paramHelp = ((Get-Help $CommandName -Parameter $_.Name).description)[0].Text
            } catch {
                $paramHelp = "Description not available."
            }
            [PSCustomObject]@{
                Name = $_.Name
                Description = $paramHelp
            }
        }
    }
}
