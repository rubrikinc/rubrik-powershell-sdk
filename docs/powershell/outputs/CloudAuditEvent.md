### CloudAuditEvent
CloudAuditEvent carries the cloud provider audit log entry that recorded the
deletion of a monitored resource, such as an AWS CloudTrail DeleteBucket
event for an S3 bucket.

- deletedBy: System.String
  - Identity that performed the deletion, for example an AWS IAM user ARN.
- accountName: System.String
  - Human-readable name of the cloud account that owns the deleted resource.
- accountId: System.String
  - Identifier of the cloud account that owns the deleted resource.
- eventId: System.String
  - Identifier of the audit log event itself.
- sourceIp: System.String
  - IP address from which the deletion request originated.
- action: System.String
  - Cloud provider API action that deleted the resource, for example
DeleteBucket.
