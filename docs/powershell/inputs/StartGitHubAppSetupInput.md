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
- featuresWithPermissionsGroups: list of FeatureWithPermissionsGroupss
  - Features to protect, each with the permission groups to set up for it. A
GitHub App per purpose (backup/recovery) is shared across features, so its
manifest unions the scopes of every feature listed here.
