### AwsCdmVersion
Rubrik CDM image version information from the AWS marketplace.

- imageId: System.String
  - Image ID.
- version: System.String
  - Image version.
- tags: list of AwsCdmVersionTags
  - Image tag array with each element in key=value format.
- productCodes: list of System.Strings
  - Product codes of the AWS image.
- isLatest: System.Boolean
  - Indicates whether the Rubrik CDM version is the latest for the product code.
- supportedInstanceTypes: list of AwsInstanceTypes
  - Supported AWS instance types for this Rubrik CDM version.
