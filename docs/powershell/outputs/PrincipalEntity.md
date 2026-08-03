### PrincipalEntity
Principal entity. Generic representation of a principal across IDP
types. For identities (users/groups), id holds the SID; for
domains/OUs, it holds the domain ID.

- id: System.String
  - ID of the entity (e.g., SID for identities, domain ID for domains).
- name: System.String
  - Name of the entity.
- idpType: IdpType
  - IDP type.
