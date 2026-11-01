### CloudNativeSearchOperator
CloudNativeSearchOperator enumerates the comparison operators available when
filtering cloud-native workload records during snapshot search. Shared across
cloud-native workloads (e.g. AWS DynamoDB, Azure Cosmos DB) so every service's
search API exposes the same operator set.

- CLOUD_NATIVE_SEARCH_OPERATOR_UNSPECIFIED - Unspecified operator.
- CLOUD_NATIVE_SEARCH_OPERATOR_EQ - Equals.
- CLOUD_NATIVE_SEARCH_OPERATOR_LT - Less than.
- CLOUD_NATIVE_SEARCH_OPERATOR_GT - Greater than.
- CLOUD_NATIVE_SEARCH_OPERATOR_LE - Less than or equal to.
- CLOUD_NATIVE_SEARCH_OPERATOR_GE - Greater than or equal to.
- CLOUD_NATIVE_SEARCH_OPERATOR_BEGINS_WITH - Begins-with prefix match.
- CLOUD_NATIVE_SEARCH_OPERATOR_CONTAINS - Substring containment.
- CLOUD_NATIVE_SEARCH_OPERATOR_IN - Membership in a set of values.
- CLOUD_NATIVE_SEARCH_OPERATOR_BETWEEN - Inclusive range between two values.
- CLOUD_NATIVE_SEARCH_OPERATOR_EXISTS - Attribute is present.
- CLOUD_NATIVE_SEARCH_OPERATOR_NOT_EXISTS - Attribute is absent.
