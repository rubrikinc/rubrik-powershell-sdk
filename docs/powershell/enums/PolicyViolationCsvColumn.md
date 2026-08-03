### PolicyViolationCsvColumn
Columns available for the policy violations CSV export. Validity per
group-by view is enforced server-side; not all columns are valid in
every grouping (the server rejects invalid combinations with
INVALID_ARGUMENT).

Valid columns by group-by view:
GROUP_BY_NONE:     POLICY_NAME, SEVERITY, IDENTITY_NAME, STATUS,
SOURCE, DETECTION_TIME, FRAMEWORK, TICKET_NUMBER,
RESOLVED_ON.
GROUP_BY_POLICY:   POLICY_NAME, SEVERITY, VIOLATION_COUNT, CATEGORY,
SOURCE, FRAMEWORK.
GROUP_BY_RESOURCE: IDENTITY_NAME, IDENTITY_TITLE, VIOLATION_COUNT,
SOURCE, IDENTITY_ORIGIN.

- POLICY_VIOLATION_CSV_COLUMN_UNSPECIFIED - Default zero value; treated as no column. Should not be sent by clients.
- POLICY_VIOLATION_CSV_COLUMN_POLICY_NAME - Name of the policy that the violation belongs to.
- POLICY_VIOLATION_CSV_COLUMN_SEVERITY - Severity of the policy / violation.
- POLICY_VIOLATION_CSV_COLUMN_IDENTITY_NAME - Name of the violating identity (a.k.a. "Target" in the UI).
- POLICY_VIOLATION_CSV_COLUMN_STATUS - Current status of the violation (open / dismissed / closed / etc.).
- POLICY_VIOLATION_CSV_COLUMN_SOURCE - Source / entity from which the violation originated.
- POLICY_VIOLATION_CSV_COLUMN_DETECTION_TIME - Timestamp when the violation was first detected.
- POLICY_VIOLATION_CSV_COLUMN_FRAMEWORK - Comma-separated list of compliance frameworks the policy maps to.
- POLICY_VIOLATION_CSV_COLUMN_TICKET_NUMBER - Ticket number (ServiceNow / Jira) associated with the violation, if any.
- POLICY_VIOLATION_CSV_COLUMN_RESOLVED_ON - Timestamp when the violation moved to a terminal status (dismissed /
closed / remediated). Empty for non-terminal violations.
- POLICY_VIOLATION_CSV_COLUMN_VIOLATION_COUNT - Aggregate count of violations for the row (per-policy in
GROUP_BY_POLICY, per-identity in GROUP_BY_RESOURCE).
- POLICY_VIOLATION_CSV_COLUMN_CATEGORY - Policy category.
- POLICY_VIOLATION_CSV_COLUMN_IDENTITY_TITLE - Identity title.
- POLICY_VIOLATION_CSV_COLUMN_IDENTITY_ORIGIN - Origin of the identity (INTERNAL / EXTERNAL).
