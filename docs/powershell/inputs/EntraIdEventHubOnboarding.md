### EntraIdEventHubOnboarding
Event Hub ingestion settings for Entra ID onboarding on the OAuth path. When
provided to completeAzureAdAppSetup, Rubrik enables Event Hub ingestion for
the given subscription and regions.

- subscriptionNativeId: System.String
  - Azure native ID of the single subscription that hosts the Event Hub.
- regions: list of AzureCloudAccountRegions
  - Regions to enable on the Event Hub host subscription. Event Hub ingestion
requires at least one region.
- sessionId: System.String
  - Cloud-accounts OAuth session ID returned by completeAzureCloudAccountOauth.
- resourceGroupName: System.String
  - Optional name for the Event Hub resource group. When empty, Rubrik creates
a default resource group with a generated name and no tags.
- resourceGroupTags: list of TagInputs
  - Optional tags to apply to the Event Hub resource group. Ignored when
resource_group_name is empty.
- eventHubTags: list of TagInputs
  - Optional tags to apply to the Event Hub namespace. When empty, only the
Rubrik-managed tags are applied.
- resourceGroupRegion: AzureCloudAccountRegion
  - Region for the Event Hub resource group. When unset, falls back to the
first entry in regions.
- subscriptionName: System.String
  - Display name of the Event Hub host subscription, as reported by Azure
alongside the native id in the OAuth consent reply. The cloud-account add
rejects a subscription with an empty name.
