### AmiType
AMIType to be used for exporting an archived EC2 instance snapshot.

- USER_SPECIFIED - User needs to provide an AMI id, which will be used for export.
- CREATED_AT_RUNTIME - EC2 instance is a linux instance wihtout marketplace code. AMI will be created at runtime.
- EXISTING - An AMI already exists which can be used for export.
- PLATFORM_SPECIFIC_AMI - A platform-specific, auto-detected AMI will be used for export.
