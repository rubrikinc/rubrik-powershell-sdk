### K8sTransformsInput
Supported in v9.6+
Resource transformations to apply on-the-fly during a restore operation.

- patchesJson: System.String
  - Supported in v9.6+
JSON array of RFC 6902 patch operations to apply to restored resources.
- images: ImageMappingInput
  - Map from source image name to replacement image name.
- configmapNames: ConfigmapNameMappingInput
  - Map from source configmap name to replacement configmap name.
- secretNames: SecretNameMappingInput
  - Map from source secret name to replacement secret name.
