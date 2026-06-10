### IdentityMetadata


- displayName: System.String
  - Display name of the user.
- userPrincipalName: System.String
  - Name of the principal.
- domainName: System.String
  - Name of the domain to which the principal belongs.
- title: System.String
  - Title of principal.
- idpType: IdpType
  - Source of principal.
- principalType: ViolationPrincipalType
  - Principal/Identity type of the principal.
- privilegeType: PrivilegeType
  - Type of privilege of the principal.
- resolutionType: IdentityResolutionType
  - Resolution type/origin of the identity.
- domainUniqueId: System.String
  - Unique ID of the domain to which the principal belongs.
- uniqueId: System.String
  - A unique identifier of the principal.
- accessibleObjectsCount: System.Int64
  - Number of objects accessible to the principal.
- source: System.String
  - The source/entity name of the principal.
- sensitiveHits: SensitiveHits
  - Sensitive hits the principal has access to.
- identityTags: list of IdentityTags
  - List of principal tags.
- status: IdentityStatus
  - Status of the principal.
- nativeType: NativeType
  - Native type of the principal.
- principalOrigin: PrincipalOrigin
  - The origin of the principal. Indicates the upstream system
(e.g., Okta, Entra ID, Active Directory) that surfaced the principal.
