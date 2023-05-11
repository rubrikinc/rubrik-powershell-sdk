### UpdateEventDigestInput
Information required to save an event digest.

- clusterUuids: a list of System.Strings
  - List of Rubrik cluster UUIDs.
- digestName: System.String
  - Name of the event digest.
- eventDigestConfig: EventDigestConfig
  - Event digest configuration.
- frequencyHours: System.Int32
  - Frequency, in hours, with which the event digests are sent.
- includeAudits: System.Boolean
  - Specifies whether to include audits in the event digest or not.
- includeEvents: System.Boolean
  - Specifies whether to include events in the event digest or not.
- isImmediate: System.Boolean
  - Specifies whether to send event digest immediately or not.
- recipientUserIds: a list of System.Strings
  - User IDs of the recipients of the event digest.
