### DynamoDbRestoreTtlInput
DynamoDbRestoreTtlInput groups the TTL handling mode with its optional
custom-expiry parameter for recovered items.

- handling: DynamoDbTtlHandling
  - How TTL is applied to recovered items.
- customExpiry: DateTime
  - Custom TTL expiry to apply when handling is DYNAMODB_TTL_HANDLING_CUSTOM.
