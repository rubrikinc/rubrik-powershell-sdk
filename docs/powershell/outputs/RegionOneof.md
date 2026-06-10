### RegionOneof
Region carried by this oneof, as either a standard or auth-server-based
AWS region enum value.

- standardRegion: AwsCloudAccountRegion
  - Standard AWS commercial region (e.g. us-east-1).
- authServerRegion: AwsAuthServerBasedCloudAccountRegion
  - Auth-server-based region used in non-commercial partitions
(e.g. ISO/ISOB).
