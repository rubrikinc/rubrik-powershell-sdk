### GitHubAppRegistrationInfo
Information needed to register a new GitHub App via the manifest flow
(see https://docs.github.com/en/apps/sharing-github-apps/registering-a-github-app-from-a-manifest).

- manifest: System.String
  - The GitHub App manifest as a JSON string. The manifest contains the
following fields:
- name: The pre-generated name for the GitHub App.
- url: The homepage URL of the GitHub App.
- redirect_url: Must be set by the caller before submitting. GitHub
redirects here after app creation, appending a "code" query parameter
needed for completeGitHubAppRegistration.
- setup_url: Must be set by the caller before submitting. GitHub
redirects here after app installation, appending an "installation_id"
query parameter needed for completeGitHubAppInstallation.
- public: Whether the app is public or private.
- default_permissions: A map of required GitHub permission scopes to
their access levels (e.g., "contents": "read"). These permissions are
pre-configured based on the requested app purpose and should not be
modified.

To register the app, create an HTML form that POSTs to the create_url
with a hidden input field named "manifest" containing the JSON-encoded
manifest string. Submit the form to open the GitHub app creation page.
After the user approves the app on GitHub, GitHub redirects to the
redirect_url with a "code" query parameter. Pass this code along with
the session ID to completeGitHubAppRegistration.

For more details on the manifest flow, see
https://docs.github.com/en/apps/sharing-github-apps/registering-a-github-app-from-a-manifest.
- createUrl: System.String
  - The GitHub URL where the manifest should be submitted to create the app.
This URL is the form action for the POST request containing the
manifest.
