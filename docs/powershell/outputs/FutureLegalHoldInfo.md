### FutureLegalHoldInfo
The forward-looking legal hold rule on a workload. Any snapshot of the
workload whose creation time is at or before the end date is placed on
legal hold when the snapshot is added.

- endDate: DateTime
  - The date until which the rule is valid.
- holdConfig: LegalHoldInfo
  - Hold configuration recorded in the rule.
