### KmsSharingMode
KmsSharingMode is the automated-KMS enablement mode of an exocompute mapping.
After creation, this field is the source of truth for whether KMS grants are
managed automatically for the mapping.

- KMS_SHARING_MODE_UNSPECIFIED - Mode not determined: non-AWS vendor or no active mapping.
- KMS_SHARING_MODE_NONE - Active mapping with no automated KMS sharing.
- KMS_SHARING_MODE_SHARING_ONLY - Automated KMS grant creation is enabled.
- KMS_SHARING_MODE_SHARING_AND_GATEWAY - Automated KMS grant creation and gateway key replication are enabled.
