### ActivityAuditorEntity
This struct represents an entity. An entity can be the target of an activity
or the actor of an activity.

- type: ActivityEntityType
  - The type of the entity.
- id: System.String
  - The ID of the entity.
- name: System.String
  - The name of the entity.
- details: ActivityAuditorEntityDetails
  - The details of the entity.
- status: IdentityStatus
  - The status of the entity.
- uniqueIdentifier: System.String
  - The principal's unique identifier: the UPN for users; SAMAccountName / GUID
/ SID for groups, computers, service accounts, etc. This is the same value
the actor / target-entity filters match on. Empty for entities that have no
backing principal (e.g. Entra-internal or application actors, tenant
targets).
