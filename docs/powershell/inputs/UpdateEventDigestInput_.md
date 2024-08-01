### UpdateEventDigestInput
Information required to save an event digest.

- digestId: System.Int32
  - ID of the event digest.
- digestName: System.String
  - Name of the event digest.
- frequencyHours: System.Int32
  - Frequency, in hours, with which the event digests are sent.
- isImmediate: System.Boolean
  - Specifies whether to send event digest immediately or not.
- includeAudits: System.Boolean
  - Specifies whether to include audits in the event digest or not.
- includeEvents: System.Boolean
  - Specifies whether to include events in the event digest or not.
- eventDigestConfig: EventDigestConfig
  - Event digest configuration.
- recipientUserIds: list of System.Strings
  - User IDs of the recipients of the event digest.
- clusterUuids: list of System.Strings
  - List of Rubrik cluster UUIDs.
