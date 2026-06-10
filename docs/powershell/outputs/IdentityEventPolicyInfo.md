### IdentityEventPolicyInfo
Policy-type-specific configuration for identity event policies.

- eventProviders: list of EventProviders
  - The event providers this policy applies to (e.g., ON_PREM_AD_EVENT,
ENTRA_ID_AUDIT_LOG). When empty, the backend defaults to
[ON_PREM_AD_EVENT] for backward compatibility with pre-multi-provider
policies.
