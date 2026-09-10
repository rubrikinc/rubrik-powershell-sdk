### Operator
Comparison operator to use in the condition.

- OPERATOR_UNSPECIFIED - Operator is unspecified.
- EQUALS - Returns `true` if the two values are equal.
String comparisons are case-sensitive.
- NOT_EQUALS - Returns `true` if the two values are not equal.
String comparisons are case-sensitive.
- LESS_THAN - Returns `true` if the column value is less than
the specified value. Applies to numeric types.
- LESS_THAN_EQUALS - Returns `true` if the column value is less than
or equals the specified value. Applies to numeric types.
- GREATER_THAN - Returns `true` if the column value is greater than
the specified value. Applies to numeric types.
- GREATER_THAN_EQUALS - Returns `true` if the column value is greater than
or equals the specified value. Applies to numeric types.
- IN - Returns `true` if the column value is equal to one of the values
in the specified list. String comparisons are case-sensitive.
- NOT_IN - Returns `true` if the column value is not equal to any value
in the specified list. String comparisons are case-sensitive.
- LIKE - Returns `true` if the column value matches the specified
value using SQL `LIKE` operator. Case-insensitive.
- NOT_LIKE - Returns `true` if the column value does not match the specified
value using SQL `LIKE` operator. Case-insensitive.
