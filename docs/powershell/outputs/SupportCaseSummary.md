### SupportCaseSummary
A summary of a single support case (list-view fields).

- caseId: System.String
  - Salesforce case record ID.
- caseNumber: System.String
  - Salesforce case number, e.g. "00123456".
- subject: System.String
  - Support case subject/title.
- status: System.String
  - Raw SFDC status string, e.g. "In Progress".
- priority: NewCasePriority
  - Support case priority level.
- createdDate: DateTime
  - Date and time the support case was created.
- type: System.String
  - Raw SFDC type string, e.g. "Software", "Hardware", or empty.
- productLine: System.String
  - Product line for the support case.
- functionalArea: System.String
  - Functional area for the support case.
- component: System.String
  - Component for the support case.
