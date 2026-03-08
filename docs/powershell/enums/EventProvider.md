### EventProvider
EventProvider is the enum signifying the event provider for the events
which are uploaded.

- EVENT_PROVIDER_UNSPECIFIED - EVENT_PROVIDER_UNSPECIFIED specifies un found event provider.
- ON_PREM_AD_EVENT - Signifies an event in the on-prem ad environment.
- ON_PREM_AD_ACTOR_LOG - Signifies actor log in the on-prem ad environment.
- ENTRA_ID_AUDIT_LOG - Signifies an audit log from EntraID (cloud Azure AD).
- ENTRA_ID_SIGNIN_LOG - Signifies a sign-in log from EntraID (cloud Azure AD).
- OKTA_SIGNIN_LOG - Signifies an authentication event from Okta.
- ON_PREM_AD_SIGNIN_LOG - Signifies Windows 4624/4625 sign-in events from on-prem AD.
- OKTA_AUDIT_LOG - Signifies an audit log from Okta (system log events).
