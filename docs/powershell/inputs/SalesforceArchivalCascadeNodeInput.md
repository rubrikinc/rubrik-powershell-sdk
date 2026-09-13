### SalesforceArchivalCascadeNodeInput
One node in the cascade selection tree for Salesforce archival,
describing which related child objects to include alongside an
object. Recursive: each node may select its own children.

For each node, set include_all_children to include every related
child object, or leave it false and list specific children. The
root node's object_name identifies the object the tree applies to.
relationship_type and object_label are populated on read and
ignored on write.

- objectName: System.String
  - Salesforce API name (e.g. "Contact", "Foo__c"). Stable identifier.
- includeAllChildren: System.Boolean
  - When true, all descendants are implicitly included and `children`
is ignored. Replaces the legacy "*" wildcard sentinel.
- children: list of SalesforceArchivalCascadeNodeInputs
  - Explicit child selections. Only meaningful when includeAllChildren
is false.
- relationshipType: SalesforceRelationshipType
  - Display-only on read paths, ignored on write. Resolved from describe
metadata at query time. Persisted relationship type would risk
staleness if Salesforce metadata changes after the policy was saved.
Nullable: the root node has no parent relationship, and the enum
excludes its zero value.
- relationshipField: System.String
  - FK field on the child that references this parent (Salesforce
ChildRelationship.Field, e.g. "AccountId"). Disambiguates when the
parent has multiple relationships to the same child object via
different fields (e.g. Account -> Contact via AccountId vs via a
custom Account__c lookup). Empty matches any field for backward
compatibility with policies persisted before this field existed.
