### PolarisSnapshotFilterNewInput


- field: FieldEnum
  - Selects which snapshot attribute this filter clause matches on. The paired
"texts" field supplies the value(s), encoded according to the selected Field
(see the "texts" comment for the per-Field encoding rules).
- texts: list of System.Strings
  - For all boolean style filters, the first argument will be a boolean in the
form of a string, either ["true"] or ["false"].
Ex. IS_EXPIRED, will have texts set to ["true"] or ["false"]
For TIME_RANGE_WITH_OFFSET the arguments will be:
[start of time range, end of time range].
Ex. ["2018-01-01T00:00:00.000Z", "2020-01-02T13:04:05.000Z"],
["2019-01-02T11:04:05.000Z", "2020-01-02T13:04:05.000Z"],
["2019-01-02T11:04:05.000Z", "2019-01-20T13:04:05.000Z"],
It is necessary for the user to specify a valid time for at least one of
the 2 values. If both the strings represent valid times, we get the
snapshots created between the 2 times. If the user wants to get all
snapshots created after/before a particular time, he can specify the time
string in the first/second (respectively) place, and keep the other
string as empty.
