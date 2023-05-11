### UpdateWebhookReply
The webhook that was updated.

- testError: ErrorInfo
  - This field is empty if the webhook test was not requested (shouldSendTestEvent request field), or was carried out successfully. In case of a webhook test failure, this field contains the failure details.
- webhook: Webhook
  - The webhook that was updated.
