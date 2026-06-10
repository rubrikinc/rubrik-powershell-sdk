### AzureAdPimEligibilityStatus
Status of a PIM eligibility schedule. Mirrors the
Microsoft Graph status field on
unifiedRoleEligibilitySchedule and
privilegedAccessGroupEligibilitySchedule (both share the
same value set).

- PIM_ELIGIBILITY_STATUS_UNSPECIFIED - Default zero value. Indicates the status was not set
or did not match any known Microsoft Graph value.
- PIM_ELIGIBILITY_STATUS_CANCELED - Eligibility request was canceled.
- PIM_ELIGIBILITY_STATUS_DENIED - Eligibility request was denied.
- PIM_ELIGIBILITY_STATUS_FAILED - Eligibility provisioning failed.
- PIM_ELIGIBILITY_STATUS_GRANTED - Eligibility request was granted.
- PIM_ELIGIBILITY_STATUS_PENDING_ADMIN_DECISION - Eligibility is pending an admin decision.
- PIM_ELIGIBILITY_STATUS_PENDING_APPROVAL - Eligibility is pending approval.
- PIM_ELIGIBILITY_STATUS_PENDING_PROVISIONING - Eligibility is pending provisioning.
- PIM_ELIGIBILITY_STATUS_PENDING_SCHEDULE_CREATION - Eligibility is pending schedule creation.
- PIM_ELIGIBILITY_STATUS_PROVISIONED - Eligibility has been provisioned and is active.
- PIM_ELIGIBILITY_STATUS_REVOKED - Eligibility has been revoked.
- PIM_ELIGIBILITY_STATUS_SCHEDULE_CREATED - The schedule has been created.
