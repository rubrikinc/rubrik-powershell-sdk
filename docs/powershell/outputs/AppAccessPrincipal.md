### AppAccessPrincipal
Summary of a principal in app access context.

- id: System.String
  - ID of the principal.
- name: System.String
  - Display name of the principal.
- principalType: PrincipalRiskySummaryPrincipalType
  - Type of the principal (e.g., USER, GROUP, SERVICE_PRINCIPAL).
- idpType: IdpType
  - Identity provider type for this principal (e.g., ENTRA_ID, AD).
- memberCount: System.Int32
  - Number of users in the group.
- appCount: System.Int32
  - Number of apps accessible via this principal.
- nativeType: NativeType
  - Native type of the principal (e.g., ENTRA_ID_GROUP, ENTRA_ID_SERVICE_PRINCIPAL).
- applicationLogoId: System.String
  - Unique identifier for mapping the application to its logo.
- logoId: AppLogoId
  - Logo enum for the application. UNSPECIFIED means no known logo.
Only populated for SERVICE_ACCOUNT principals; GROUP principals always
have APP_LOGO_ID_UNSPECIFIED.
