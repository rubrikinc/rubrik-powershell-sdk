### AdDnsZoneMetadata
On-prem AD DNS zone specific metadata.

- decodedZoneProperties: list of System.Strings
  - Human-readable zone-configuration properties for the DNS zone
(one per property), in the form "<PropertyName>: <Value>"
(e.g. "ZoneType: Primary", "RefreshInterval: 168 hours",
"AllowUpdate: Secure"). Empty when the zone has no decoded
properties or for non-DNS-zone principals.
