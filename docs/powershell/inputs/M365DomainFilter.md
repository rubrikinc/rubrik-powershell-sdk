### M365DomainFilter
Filter for the domains returned by GetM365SubscriptionDomains.

- domainNameSubstring: System.String
  - Case-insensitive substring matched against the domain name.
- shouldIncludeUnverified: System.Boolean
  - Whether to include domains the tenant has not verified. Unverified domains
cannot host identities, so they are excluded by default.
