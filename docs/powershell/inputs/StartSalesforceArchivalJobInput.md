### StartSalesforceArchivalJobInput
Request for startSalesforceArchivalJob.

- policyId: System.Int64
  - ID of the archival policy to run. The handler reads the target
workload, filter clause, retention, and cascade config off the
policy row --callers do not pass them in.
- orgId: System.String
  - RSC ID of the Salesforce organization that owns the policy. Used
as the authorization scope --the caller must be permitted to manage
this organization. The handler rejects if the loaded policy's
organization does not match.
