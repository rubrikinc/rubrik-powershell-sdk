### QueryLogReportInput
Input for getting the database log report.

- name: System.String
  - Filter by the database name substring.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- logBackupDelay: System.Int32
  - Filter database log reports where the database log backup delay value, in seconds, is greater than the logBackupDelay value.
- limit: System.Int32
  - Limit the number of matches returned.
- offset: System.Int32
  - Integer specifying the number of initial matches to ignore.
- effectiveSlaDomainId: System.String
  - Filter by effective SLA Domain.
- sortOrder: V1QueryLogReportRequestSortOrder
  - Sort order, either ascending or descending.
- databaseType: System.String
  - Filter by the database type.
- sortBy: V1QueryLogReportRequestSortBy
  - Specifies the attribute to use while sorting the summary information. Performs an ASCII sort using the specified attribute, in the order specified by sort_order.
- location: System.String
  - Filter by the database location.
