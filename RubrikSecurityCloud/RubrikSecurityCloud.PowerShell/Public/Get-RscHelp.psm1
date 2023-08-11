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
    Get-RscHelp -CommandName Invoke-RscQueryCluster
    #>
    [CmdletBinding(
        DefaultParameterSetName = 'CommandName'
    )]
    Param (
        [Parameter(
            ParameterSetName = 'CommandName',
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
            ParameterSetName = 'CustomOperations'
        )]
        [Switch]$CustomOperations
    )
    Begin {
        function GetCommandHelp {
            Param($CommandName)

            # Get the command
            $command = Get-Command $CommandName

            # Get parameters
            $params = $command.Parameters.Values

            # Filter only switch parameters
            $switchParams = $params | Where-Object { $_.ParameterType.Name -eq 'SwitchParameter' -and $_.Name -ne "Verbose" -and $_.Name -ne "Debug" -and $_.Name -ne "GetInputs" }

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

        function GetCustomOperationsHelp {
            $profDir = [RubrikSecurityCloud.Files]::GetCustomDir($RSC_CUSTOM_DIR)
            [PSCustomObject]@{
                CustomOperationsDir = $profDir
                CustomOperations    = @(Get-ChildItem $profDir -Filter *.gql | Select-Object -ExpandProperty Name)
            }
        }
    }
    
    Process {
        switch ($PSCmdlet.ParameterSetName) {
            'CommandName' { GetCommandHelp $CommandName }
            'CustomOperations' { GetCustomOperationsHelp }
        }
    }
}
