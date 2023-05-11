### DeleteLogShippingInput
Input for deleting a SQL Server log shipping target.

- deleteSecondaryDatabase: System.Boolean
  - Boolean value that determines whether to attempt to delete the secondary database associated with the specified log shipping configuration. The default value is false. When set to false, no attempt is made to delete the secondary database. When set to true, starts an asynchronous job to delete the secondary database.
- id: System.String
  - Required. ID of a log shipping configuration object.
