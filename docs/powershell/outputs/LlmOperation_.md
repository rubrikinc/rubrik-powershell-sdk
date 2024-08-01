### LlmOperation
An operation performed by the LLM.

- name: System.String
  - Name of the operation.
- status: LlmOperationStatus
  - Status of the operation.
- serializedResult: System.String
  - Result of the operation, if completed.
- serializedParams: System.String
  - Input parameters of the operation.
- updatedAt: DateTime
  - Time when the operation was last updated.
- progress: System.Single
  - Progress of the operation.
- jobId: System.String
  - ID of the associated job, if applicable.
- error: System.String
  - Error, if the operation failed.
- createdAt: DateTime
  - Time when the operation was created.
- downloadId: System.Int64
  - The integer ID of the download associated with the operation, if applicable.
- id: System.String
  - The ID of the LLM operation.
