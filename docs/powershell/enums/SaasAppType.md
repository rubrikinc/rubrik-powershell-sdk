### SaasAppType
SaaS application type.

- ATLASSIAN_JIRA - Atlassian Jira application type.
- SALESFORCE - Salesforce application type.
- M365_BACKUP_STORAGE - Microsoft 365 Backup Storage application type.
- ATLASSIAN_CONFLUENCE - Atlassian Confluence application type.
- DYNAMICS_365 - Dynamics 365 application type.
- ENTRA_ID - Entra ID application type.
- GOOGLE_DRIVE - Google Workspace drive application type.
- SLACK - Slack application type.
+mo:filter:db:table=saasapps_organizations
+mo:filter:db:column=saas_app_type
+mo:filter:db:index:key=IX_saas_app_type
+mo:filter:db:index:seq=1
+mo:filter:db:index:type=BTREE
+mo:filter:db:index:unique=false
+mo:sort:db:table=saasapps_organizations
+mo:sort:db:column=saas_app_type
+mo:sort:db:index:key=IX_saas_app_type
+mo:sort:db:index:seq=1
+mo:sort:db:index:type=BTREE
+mo:sort:db:index:unique=false
- OKTA - Okta application type.
+mo:filter:db:table=saas_app
+mo:filter:db:column=okta_app_type
+mo:filter:db:index:key=okta_app_type_idx
+mo:filter:db:index:seq=1
+mo:filter:db:index:type=BTREE
+mo:filter:db:index:unique=false
- GOOGLE_MAIL - Google Workspace gmail application type.
