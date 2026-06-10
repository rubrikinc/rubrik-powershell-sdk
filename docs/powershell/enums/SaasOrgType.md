### SaasOrgType
The different SaaS organization types supported.

- SAAS_ORG_TYPE_UNSPECIFIED - Unspecified SaaS application type.
- ATLASSIAN_ORG - Atlassian Org type.
- SALESFORCE_ORG - Salesforce Org type.
- DYNAMICS_365_ORG - Dynamics Org type.
- GOOGLE_WORKSPACE_ORG - Google workspace Org type.
- M365_BACKUP_STORAGE_ORG - M365 Backup Storage Org type.
- SLACK_ORG - Slack Org type.
+mo:filter:db:table=saasapps_organizations
+mo:filter:db:column=saas_org_type
+mo:sort:db:table=saasapps_organizations
+mo:sort:db:column=saas_org_type
+comment: No specific index for saas_org_type column, but filtering/sorting
+comment: on this column is expected to be performant due to limited number
+comment: of SaaS organization types and relatively small dataset size.
- OKTA_ORG - OKTA Org type.
- AUTH0_ORG - Auth0 Org type.
- AZURE_DEVOPS_ORG - Azure DevOps Org type.
- GITHUB_ORG - GitHub Org type.
- POWER_PLATFORM_ORG - Power Platform Org type.
