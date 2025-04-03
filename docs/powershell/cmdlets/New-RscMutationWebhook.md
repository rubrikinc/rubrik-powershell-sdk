# New-RscMutationWebhook
## Subcommands
### create
Create a webhook.

- There is a single argument of type CreateWebhookInput.
- Returns CreateWebhookReply.
### createv2
Create webhook configuration.

- There is a single argument of type CreateWebhookV2Input.
- Returns CreateWebhookV2Reply.
### delete
Delete a webhook.

- There is a single argument of type DeleteWebhookInput.
- Returns System.String.
### deletev2
Delete webhook configuration.

- There is a single argument of type DeleteWebhookV2Input.
- Returns System.String.
### generatepreviewmessagefortemplate
Generate a preview message for the webhook message template.

- There is a single argument of type GeneratePreviewMessageForWebhookTemplateInput.
- Returns GeneratePreviewMessageForWebhookTemplateReply.
### sendtestmessageto
Send test message to webhook.

- There is a single argument of type SendTestMessageToWebhookInput.
- Returns SendTestMessageToWebhookReply.
### sendtestmessagetoexisting
Send test message to existing webhook.

- There is a single argument of type SendTestMessageToExistingWebhookInput.
- Returns SendTestMessageToExistingWebhookReply.
### test
Test a webhook configuration.

- There is a single argument of type TestWebhookInput.
- Returns TestWebhookReply.
### testexisting
Test an existing webhook.

- There is a single argument of type TestExistingWebhookInput.
- Returns TestExistingWebhookReply.
### update
Update a webhook.

- There is a single argument of type UpdateWebhookInput.
- Returns UpdateWebhookReply.
### updatestatus
Update the webhook status.

- There is a single argument of type UpdateWebhookStatusInput.
- Returns UpdateWebhookStatusReply.
### updatev2
Update webhook configuration.

- There is a single argument of type UpdateWebhookV2Input.
- Returns UpdateWebhookV2Reply.
