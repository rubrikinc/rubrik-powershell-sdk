### AdDnsNodeMetadata
On-prem AD DNS node (record) specific metadata.

- decodedDnsRecords: list of System.Strings
  - Human-readable DNS record values for the DNS node (one per
record), in the form "<TYPE> <value>, TTL=<seconds>"
(e.g. "A 10.0.0.1, TTL=3600", "MX 10 mail.example.com,
TTL=3600"). Multi-valued for round-robin records and
multi-target sets. Empty for non-DNS-node principals.
