### TagConditionKeyPrefix
IAM Condition key namespace. The backend assembles the full IAM condition
key as <prefix><key>, e.g. RESOURCE_TAG + "ENV" -> "aws:ResourceTag/ENV".

- TAG_CONDITION_KEY_PREFIX_UNSPECIFIED - This prefix is unspecified and is rejected during validation.
- TAG_CONDITION_KEY_PREFIX_RESOURCE_TAG - Scopes the Condition on the resource's tags ("aws:ResourceTag/").
- TAG_CONDITION_KEY_PREFIX_REQUEST_TAG - Scopes the Condition on the request's tags ("aws:RequestTag/").
