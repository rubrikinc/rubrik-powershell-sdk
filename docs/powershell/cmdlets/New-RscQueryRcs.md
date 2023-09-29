# New-RscQueryRcs
## Subcommands
### archivallocationsconsumptionstats
RCS Azure archival location consumption stats.

- There is a single argument of type RcsConsumptionStatsInput.
- Returns RcsAzureArchivalLocationsConsumptionStatsOutput.
### cluster
Get the cluster certificate signing request

Supported in v7.0+
Returns the certificate signing request generated from the private key of the Rubrik cluster.

- There is a single argument of type GetClusterCsrInput.
- Returns ClusterCsr.
### dhcores
DHRC scores for the requested categories and time span.

- There are 3 arguments.
    - categories - list of DhrcCategorys: Optional list of categories to filter on.
    - beginTime - DateTime: Optional start of timespan to filter on.
    - timespan - DhrcScoreTimespan: Optional timespan to filter on.
- Returns list of DhrcScores.
