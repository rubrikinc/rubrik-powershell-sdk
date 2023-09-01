### Trial
A trial offered within Rubrik Security Cloud.

- id: System.String
  - The ID of the trial.
- duration: System.Int32
  - The duration of the trial in days.
- endDate: DateTime
  - The date that the trial ends.
- activatedAt: DateTime
  - The date when the trial was activated.
- isOnboardingComplete: System.Boolean
  - Specifies if any user has completed the trial onboarding.
- isIgnored: System.Boolean
  - Specifies if the user has ignored the trial.
- wasExplicitlyInvited: System.Boolean
  - Specifies if the user was invited to the trial by another user.
- type: TrialType
  - The type of the trial.
- params: TrialSpecificParams
  - The parameters of the trial.
- tasks: list of TrialTasks
  - The tasks of the trial.
- offeredAt: DateTime
  - The date the trial was offered.
- state: ProductState
  - The state of the trial.
