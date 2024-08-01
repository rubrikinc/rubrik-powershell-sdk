### SetCustomerTagsInput
Input to set customer-specified tags for a particular cloud type.

- cloudVendor: CloudVendor
  - Cloud provider type for which customer-specified tags are to be set.
- customerTags: TagsInput
  - List all customer-specified tags that need to be applied to all resources associated with a specified cloud type.
           For example, {"Application":"Rubrik", "Environment":"Dev", "CreatedDate":"10/07/2023"}.
- shouldOverrideResourceTags: System.Boolean
  - Specifies whether customer-specified tags should override resource tags. By default, this is true.
