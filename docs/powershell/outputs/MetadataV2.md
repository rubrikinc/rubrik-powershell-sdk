### MetadataV2
MetadataV2 is a new version of generic Metadata type and will deprecate the
old Metadata type in the future. It contains a key and a list of values,
where the key is an enum MetadataKey and the value is a Value type.

- key: MetadataKey
  - The key of the metadata.
- values: list of Values
  - The list of the metadata values.
