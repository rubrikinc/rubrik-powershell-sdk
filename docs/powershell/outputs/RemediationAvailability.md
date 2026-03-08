### RemediationAvailability
RemediationAvailability provides details about the availability of a
particular remediation type for target IDs, target type, location,
resource ID and resource type.

- type: RemediationType
  - The remediation type.
- isAvailable: System.Boolean
  - This field indicates whether the remediation is available or not.
For example, when type=TICKETING_SERVICENOW, true if ServiceNow integration
is connected and there is no other open ticket for the target IDs.
- disabledReason: RemediationDisabledReason
  - The reason why a particular remediation might not be available.
