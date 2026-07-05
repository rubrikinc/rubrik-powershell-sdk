### DevopsAuthMechanism
Authentication mechanism a DevOps organization's tenant was onboarded
with. The mechanism is a per-tenant property: once a tenant onboards
its first org via one mechanism, all subsequent orgs under that tenant
use the same mechanism.

- DEVOPS_AUTH_MECHANISM_UNSPECIFIED - Mechanism could not be determined (e.g. tenant UUID not yet
backfilled for a legacy organization).
- DEVOPS_AUTH_MECHANISM_OAUTH - Onboarded via OAuth using Rubrik's multi-tenant application.
- DEVOPS_AUTH_MECHANISM_NON_OAUTH - Onboarded via non-OAuth using a per-tenant customer-supplied
application.
