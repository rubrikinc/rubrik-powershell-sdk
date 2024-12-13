# New-RscQueryWebhook
## Subcommands
### byid
Get webhook configuration by ID.

- There is a single argument of type System.Int32.
- Returns WebhookV2.
### messagetemplatebyid
Retrieve webhook message template according to ID.

- There is a single argument of type System.Int32.
- Returns WebhookMessageTemplate.
### messagetemplates
Retrieve webhook message templates.

- There is a single argument of type WebhookMessageTemplatesReqInput.
- Returns list of WebhookMessageTemplates.
### v2
Retrieve webhook configurations.

- The v2 subcommand takes no arguments.
- Returns list of WebhookV2s.
### webhook
All webhooks in the account.

- There is a single argument of type System.String.
- Returns WebhookConnection.
