### ServiceAppStatus
Status of the Microsoft 365 Backup Storage controller app.

- SERVICE_APP_STATUS_UNSPECIFIED - The status of the object is unspecified.
- ACTIVE - The app is actively in use as a backup service control app.
- PENDING_ACTIVE - A request was made to activate the app, but it is not yet active.
The app cannot be used to control or manage the backup service and has
read-only access to the protection policies and protection units.
- PENDING_INACTIVE - A request was made to deactivate the app, but the app is not inactive yet.
The app can be used to control the backup service until the
effective date.
- INACTIVE - The app is registered with the backup service, but it is not active.
