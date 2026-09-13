### UnarchiveObjectInfo
Specifies which records of a single Salesforce object should be
unarchived, plus options that apply to that object.

- objectName: System.String
  - API name of the Salesforce object (e.g. "Opportunity").
- objectId: System.String
  - Object ID of the Salesforce object.
- recordCriteria: ArchivedRecordCriteria
  - Optional. The criteria for which matching records will be
unarchived, as an alternative to specifying the records directly.
- recordsToUnarchive: UnarchiveRecordsInfo
  - Optional. The list of records to be unarchived directly.
- cascadePolicy: SalesforceArchivalCascadeNodeInput
  - Optional. Cascade selection tree describing which related child
objects to unarchive alongside this object's records. The root
node's object_name must equal this entry's object_name. Uses the
same shape as the archival policy's cascade selection. If omitted,
only this object's records are unarchived.
- areAutomationsDisabled: System.Boolean
  - If true, Salesforce automations are suppressed for the duration
of the unarchival job.
