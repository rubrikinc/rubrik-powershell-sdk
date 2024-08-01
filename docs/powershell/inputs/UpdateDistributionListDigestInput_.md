### UpdateDistributionListDigestInput
Information required to save a distribution list digest.

- digestId: System.Int32
  - ID of the distribution list digest.
- digestName: System.String
  - Name of the distribution list digest.
- frequencyHours: System.Int32
  - Frequency, in hours, with which the distribution list digests are sent.
- isImmediate: System.Boolean
  - Specifies whether to send distribution list  digest immediately or not.
- includeAudits: System.Boolean
  - Specifies whether to include audits in the distribution list digest or not.
- includeEvents: System.Boolean
  - Specifies whether to include events in the distribution list digest or not.
- eventDigestConfig: EventDigestConfig
  - Distribution list digest configuration.
- recipientUserIds: list of System.Strings
  - User IDs of the recipients of the distribution list digest.
- clusterUuids: list of System.Strings
  - List of Rubrik cluster UUIDs.
