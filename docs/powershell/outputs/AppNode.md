### AppNode
AppNode represents metadata for an application in app access context.

- appId: System.String
  - ID of the application.
- appName: System.String
  - Display name of the application.
- idpType: IdpType
  - Identity provider type for this application.
- principalType: PrincipalRiskySummaryPrincipalType
  - Principal type of the application.
- applicationLogoId: System.String
  - Unique identifier for mapping the application to its logo.
- nativeType: NativeType
  - Native type of the application.
- logoId: AppLogoId
  - Logo enum for the application. UNSPECIFIED means no known logo.
