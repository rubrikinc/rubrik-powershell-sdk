### WorkflowProtectionStatus
WorkflowProtectionStatus indicates the lifecycle state of workflow
protection for an Okta tenant.

- UNCONFIGURED - User has not set up workflow protection for this tenant.
- DISCOVERED - Workflow protection is configured; new workflows have been discovered
and will be backed up in the next snapshot.
- PROTECTED - At least one snapshot has captured the workflows.
- FAILED - The last workflow protection attempt failed.
