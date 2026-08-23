### AzureOnboardingIneligibilityReason
AzureOnboardingIneligibilityReason explains why a discovered Azure
subscription or management-group entity cannot be onboarded in the current
discovery pass. UNSPECIFIED is returned for an entity that is eligible for
onboarding.

- AZURE_ONBOARDING_INELIGIBILITY_REASON_UNSPECIFIED - The entity is eligible for onboarding.
- AZURE_ONBOARDING_INELIGIBILITY_REASON_AUTH_TYPE_MISMATCH - The subscription is already onboarded with a different authentication
method and cannot be onboarded again in this pass.
- AZURE_ONBOARDING_INELIGIBILITY_REASON_DIFFERENT_MANAGEMENT_GROUP - The subscription already belongs to a different management group.
- AZURE_ONBOARDING_INELIGIBILITY_REASON_ALREADY_ONBOARDED - The subscription is already onboarded for all of the requested features.
