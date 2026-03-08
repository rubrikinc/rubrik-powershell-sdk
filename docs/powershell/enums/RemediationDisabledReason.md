### RemediationDisabledReason
Describes the reason why a particular remediation might not be available.

- REMEDIATION_DISABLED_REASON_UNSPECIFIED - Unspecified reason.
- REMEDIATION_DISABLED_REASON_REMEDIATION_IN_PROGRESS - Remediation is in progress.
- REMEDIATION_DISABLED_REASON_SERVICE_NOT_CONNECTED - Service is not connected, i.e. Ticketing ServiceNow is in unauthenticated
state.
- REMEDIATION_DISABLED_REASON_SERVICE_NOT_INTEGRATED - Service is not integrated, i.e. Ticketing ServiceNow is not configured.
- REMEDIATION_DISABLED_REASON_DSPM_DISABLED - DSPM is disabled.
- REMEDIATION_DISABLED_REASON_POLICY_VIOLATION_NOT_ACTIVE - Policy violation is not in open or in-progress state.
- REMEDIATION_DISABLED_REASON_TICKET_CREATED - Ticket is already created for the target IDs.
- REMEDIATION_DISABLED_REASON_ACCESS_REVOKED - Access is already revoked for the target IDs.
- REMEDIATION_DISABLED_REASON_AD_RISK_REMEDIATED - AD Risk is already remediated for the target IDs.
- REMEDIATION_DISABLED_REASON_NO_DIRECT_PERMISSIONS - Violation does not have direct permissions.
- REMEDIATION_DISABLED_REASON_ENTRA_ID_RISK_REMEDIATED - Entra ID Risk is already remediated for the target IDs.
- REMEDIATION_DISABLED_REASON_GPO_ROLLBACK_REMEDIATED - GPO Rollback is already remediated for the target IDs.
- REMEDIATION_DISABLED_REASON_MISSING_VIEW_DAG_PERMISSIONS - User does not have VIEW_DAG RBAC permissions.
- REMEDIATION_DISABLED_REASON_BULK_REVERT_ACTIVITIES_REMEDIATED - Bulk Revert Activities is already remediated for the target IDs.
- REMEDIATION_DISABLED_REASON_CROSS_DOMAIN - Activities are from different domains (SourceId mismatch).
Bulk remediation requires all activities to be in the same security boundary.
- REMEDIATION_DISABLED_REASON_POLICY_DELETED_OR_DISABLED - Policy is deleted or inactive.
