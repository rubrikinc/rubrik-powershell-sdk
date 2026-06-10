### ThreatIntelProviderConfigType
Provider-specific configuration wrapper. Carries the provider-specific
config payload for providers that need additional configuration beyond
credentials (for example, TAXII).

- taxiiConfig: TaxiiConfigType
  - TAXII-specific configuration. Required when provider_type is TAXII.
