# New-RscMutationAzureO365
## Subcommands
### setupexocompute
Sets up Exocompute for an O365 subscription. Validates the exocompute
configuration, initialises the Korg job and returns the cluster and
taskchain IDs.

- There are 3 arguments.
    - tenantId - System.String: The Azure tenant ID.
    - subscriptionId - System.String: The Azure subscription ID.
    - exocomputeConfig - AzureO365ExocomputeConfig: The exocompute configuration.
- Returns SetupAzureO365ExocomputeResp.
