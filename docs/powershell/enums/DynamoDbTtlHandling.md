### DynamoDbTtlHandling
DynamoDbTtlHandling controls how time-to-live (TTL) is applied to recovered
items.

- DYNAMODB_TTL_HANDLING_UNSPECIFIED - Unspecified TTL handling. Treated as DYNAMODB_TTL_HANDLING_ORIGINAL.
- DYNAMODB_TTL_HANDLING_ORIGINAL - Preserve the original TTL values carried by the snapshot. Items whose TTL
has already passed are restored and then deleted again by DynamoDB.
- DYNAMODB_TTL_HANDLING_CUSTOM - Apply a custom TTL expiry (see customExpiry). The recovery fails if TTL
is not enabled on the table.
- DYNAMODB_TTL_HANDLING_DO_NOT_APPLY - Do not apply any TTL to recovered items.
