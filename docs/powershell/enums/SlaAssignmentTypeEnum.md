### SlaAssignmentTypeEnum
Specifies the method used to apply an SLA Domain to an object.
Determines how the SLA assignment was established for the object.

- Derived - Object inherits SLA from its parent in the hierarchy chain.
The SLA is not directly assigned to this object but comes from an ancestor.
- Direct - SLA is directly assigned to this specific object.
The object has an explicit SLA assignment configured on it.
- Unassigned - No SLA assignment found for this object or its ancestors.
The object has no SLA protection configured.
