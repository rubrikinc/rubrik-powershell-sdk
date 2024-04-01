### EventDigestInput
An event digest.

- digestId: System.Int32
  - ID of the event digest.
- digestName: System.String
  - Name of the event digest.
- frequencyHours: System.Int32
  - Frequency, in hours, with which the event digests are sent.
- isImmediate: System.Boolean
  - Specifies whether to send the event digest immediately.
- includeAudits: System.Boolean
  - Specifies whether to include audits in the event digest.
- includeEvents: System.Boolean
  - Specifies whether to include events in the event digest.
- eventDigestConfig: EventDigestConfig
  - Event digest configuration.
- recipientUserId: System.String
  - User IDs of the recipients.
- clusterUuids: list of System.Strings
  - Specifies the cluster UUIDs that this event digest applies to.
