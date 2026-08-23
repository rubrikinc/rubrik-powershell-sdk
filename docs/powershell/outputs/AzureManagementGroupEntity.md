### AzureManagementGroupEntity
A single entity in the management group hierarchy.

- isEligible: System.Boolean
  - Is the entity eligible for onboarding.
- ineligibilityReason: AzureOnboardingIneligibilityReason
  - The reason the entity cannot be onboarded in the current pass, or
UNSPECIFIED when it is eligible.
- entity: EntityType
  - This represents the entity under Azure MG.
