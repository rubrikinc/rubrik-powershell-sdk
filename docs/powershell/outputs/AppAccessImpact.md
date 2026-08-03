### AppAccessImpact
Top-level response describing the access impact of an identity event.

- principalId: System.String
  - ID of the user whose access was affected.
- principalName: System.String
  - Display name of the user.
- changedPath: AppAccessPath
  - The access path that was added or removed by the event.
- impacts: list of AppAccessImpactEntrys
  - Impact entries grouped by impact type.
