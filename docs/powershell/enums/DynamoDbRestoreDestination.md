### DynamoDbRestoreDestination
DynamoDbRestoreDestination identifies where a DynamoDB snapshot recovery
writes its output.

- DYNAMODB_RESTORE_DESTINATION_UNSPECIFIED - Unspecified destination. Defaults to creating a new DynamoDB table.
- DYNAMODB_RESTORE_DESTINATION_NEW_TABLE - Recover into a brand new DynamoDB table.
- DYNAMODB_RESTORE_DESTINATION_IN_PLACE - Recover in place into the existing source table.
- DYNAMODB_RESTORE_DESTINATION_EXPORT_JSON - Export the matched records to a newline-delimited JSON (NDJSON) file, one
item per line, using DynamoDB attribute types such as {"S": "value"}.
The file is available for download from the File Preparation Center.
