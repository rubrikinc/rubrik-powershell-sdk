### EntraIdEventHubOnboardingWithoutOAuth
Event Hub ingestion settings for the non-OAuth path (customer BYO Entra app +
BYO Event Hub). Rubrik persists the customer's hub coordinates and provisions
nothing; the customer grants their app receive access on the hub out-of-band.
Carries no app credentials: reuses the customer app the directory setup
already captured.

- subscriptionNativeId: System.String
  - Azure native ID of the subscription that hosts the customer's Event Hub.
- regions: list of AzureCloudAccountRegions
  - Regions to enable on the host subscription. Event Hub ingestion requires at
least one region.
- namespace: System.String
  - Customer Event Hub namespace name (without the .servicebus.windows.net suffix).
- eventHubName: System.String
  - Customer Event Hub entity (hub) name within the namespace.
- resourceGroupName: System.String
  - Optional name for the Event Hub resource group. When empty, Rubrik creates
a default resource group with a generated name.
- resourceGroupRegion: AzureCloudAccountRegion
  - Region for the Event Hub resource group. When unset, falls back to the
first entry in regions.
- subscriptionName: System.String
  - Display name of the subscription that hosts the customer's Event Hub. The
cloud-account add rejects a subscription with an empty name.
