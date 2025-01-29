### AsyncRequestStatus
Supported in v5.0+

- endTime: DateTime
  - Supported in v5.0+
  The end time of the request.
- id: System.String
  - Required. Supported in v5.0+
  v5.0: The ID of the request object. Use it to poll the status.
  v5.1+: The ID of the request object used to poll the status.
- links: list of Links
  - Required. Supported in v5.0+
  References to any related objects.
- nodeId: System.String
  - Supported in v5.0+
  The ID of the node where the job ran.
- progress: System.Single
  - Supported in v5.0+
  v5.0: The current progress in terms of percentage of the async request.
  v5.1+: The current percentage progress of the asynchronous request.
- startTime: DateTime
  - Supported in v5.0+
  The start time of the request.
- status: System.String
  - Required. Supported in v5.0+
  v5.0: Status of the id.
  v5.1+: Status of the ID.
- result: System.String
  - Supported in v9.2+
  The result of the request.
- error: RequestErrorInfo
  - Supported in v5.0+
  Any errors encountered.
