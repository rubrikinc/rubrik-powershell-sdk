### StartGitHubAppSetupInput
Request message for StartGitHubAppSetup.

- orgName: System.String
  - The name of the GitHub organization.
- appPurposes: list of PermissionsGroups
  - The purposes for which GitHub Apps need to be set up.
- organizationUrl: System.String
  - Optional canonical URL of the GitHub organization. Used for GHEC data
residency where the org lives on a *.ghe.com domain (e.g.,
"https://acme.ghe.com/my-org"). For github.com orgs, callers may pass
"https://github.com/<org_name>" or omit this field.
