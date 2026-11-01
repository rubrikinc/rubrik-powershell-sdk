### CloudNativeSearchFilter
CloudNativeSearchFilter expresses a single predicate applied to a cloud-native
workload attribute during snapshot search. Shared across cloud-native
workloads (e.g. AWS DynamoDB, Azure Cosmos DB).

- fieldName: System.String
  - Attribute name to evaluate.
- operator: CloudNativeSearchOperator
  - Comparison operator.
- values: list of System.Strings
  - Operand values; arity is validated server-side per operator.
