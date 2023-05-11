### EventDigest
An Event Digest.

- account: System.String
  - Account related to the event digest.
- clusterUuids: a list of System.Strings
  - Specifies the cluster UUIDs that this event digest applies to.
- digestId: System.Int32
  - ID of the event digest.
- digestName: System.String
  - Name of the event digest.
- eventDigestConfigJson: System.String
  - Event digest configuration.
- frequency: System.Int32
  - Frequency, in hours, with which the event digests are sent.
- includeAudits: System.Boolean
  - Specifies whether to include audits in the event digest.
- includeEvents: System.Boolean
  - Specifies whether to include events in the event digest.
- isImmediate: System.Boolean
  - Specifies whether to send the event digest immediately.
- recipientUserId: System.String
  - User ID of the recipient.
