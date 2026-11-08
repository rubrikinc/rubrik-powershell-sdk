### ApplicationWarningFlag
Actionable warning that applies to an otherwise-protected cloud native
resource (e.g. missing exocompute, missing backup location, non-compliant
SLA).

- APPLICATION_WARNING_FLAG_UNSPECIFIED - Unspecified warning flag.
- APPLICATION_WARNING_FLAG_EXOCOMPUTE_MISSING - No exocompute configuration is available for the resource, either mapped
to its account+region or through central exocompute.
- APPLICATION_WARNING_FLAG_BACKUP_LOCATION_MISSING - No backup location is configured for the resource's account.
- APPLICATION_WARNING_FLAG_NON_COMPLIANT_SLA - The effective SLA is non-compliant.
