### TagPermission
Permission scoped to one or more system tags. The granted scope is the
union of the objects currently associated with the given tags; the
association is tracked automatically as tag membership changes. Used only
by tag-scoped roles.

- operation: Operation
  - The operation granted on the tagged objects.
- tagIds: list of System.Strings
  - System tag UUIDs; the granted scope is the union of objects associated
with these tags.
