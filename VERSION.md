# PowerShell SDK Versioning

The PowerShell SDK uses the versioning format `<Major>.<Minor>.<Schema>`:

- **Major Version**: Incremented when core SDK changes are made.
- **Minor Version**: Incremented for bug fixes or when cmdlets in the Toolkit are added or modified.
- **Schema Version**: Reflects the version of the GraphQL schema used to build the SDK.

# Current Version

This reflects the in-progress state of the SDK on GitHub, not the last published release.
It drives the automated release process. Only the major version should be changed manually; optionally reset the minor version to 0 at the same time — if not, it will be reset to 0 automatically during the auto-release.

### Major Version: 1
### Minor Version: 19
### Schema Version: 20260803
