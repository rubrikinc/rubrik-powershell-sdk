### Condition
A single condition in a filter.

- column: System.String
  - The name of the column is free-form and case-insensitive. Which columns
are applicable to a workload is implementation-dependent.
- operator: Operator
  - Operator to use in the condition.
Some combinations of operators and values may be invalid with respect to
the specified column. For instance, 'NAME > true' is not a valid condition.
- values: list of ConditionValues
  - Comparison value.
Most operators expect a single value. However, IN and NOT_IN require
multiple values. When you supply multiple values, they must all be
the same type.
