### StorageLocationPurpose
Purpose of an archival location - which service owns it.
MAINTAINERS: when adding a new value here, also update
rubrik/data-location-service/common.AllStorageLocationPurposeNames() and
audit its callers -- that helper expands every consumer's query result
set, so each caller must re-confirm the new purpose is in scope. The
length guard in TestAllStorageLocationPurposeNames will fail until the
helper is updated.

- PURPOSE_DEFAULT - User-created location (default for all existing locations).
Query RPCs default to this value when no LOCATION_PURPOSE filter is provided,
so callers see only user-created locations unless they explicitly filter otherwise.
- CNP_BAAS - Location created by the CNP BaaS service for internal backup-as-a-service use.
- ADO - Location created by the ADO (DevOps protection) service.
- CCES_PRIMARY - Location created for CCES primary storage purpose.
- CCES_BAAS - Location created for CCES BaaS purpose.
