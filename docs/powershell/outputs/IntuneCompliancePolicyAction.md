### IntuneCompliancePolicyAction
Intune compliance policy scheduled action.

- id: System.String
  - ID of the Intune compliance policy action.
- policyId: System.String
  - ID of the Intune compliance policy.
- type: IntuneComplianceActionType
  - Type of the Intune compliance policy action.
- gracePeriodHours: System.Int64
  - Grace period in hours before the action is run.
- notificationTemplateId: System.String
  - ID of the notification template associated with the action.
- notificationTemplateName: System.String
  - Name of the notification template associated with the action.
- recipientCount: System.Int64
  - Number of recipients for the notification.
