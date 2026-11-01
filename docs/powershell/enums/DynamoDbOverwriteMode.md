### DynamoDbOverwriteMode
DynamoDbOverwriteMode controls how an in-place recovery resolves writes that
collide with existing items in the target table.

- DYNAMODB_OVERWRITE_MODE_UNSPECIFIED - Unspecified overwrite behaviour. Treated as
DYNAMODB_OVERWRITE_MODE_LAST_WRITE_WINS.
- DYNAMODB_OVERWRITE_MODE_LAST_WRITE_WINS - Last write wins: recovered items overwrite existing items.
- DYNAMODB_OVERWRITE_MODE_SKIP_EXISTING - Skip items that already exist in the target table.
- DYNAMODB_OVERWRITE_MODE_CONDITIONAL - Overwrite an existing item only when its conditionalTimestampField value
is strictly earlier than conditionalTimestampValue. Items that are not yet
in the target table are always written. Items missing the timestamp
field are skipped.
