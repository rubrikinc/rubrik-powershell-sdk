### O365CalendarEvent
An O365 calendar event object.

- id: System.String
- name: System.String
- eventType: CalendarEventType
- parentFolderId: System.String
- organizer: System.String
- attendees: list of System.Strings
- startDateTime: DateTime
- endDateTime: DateTime
- snapshotId: System.String
- snapshotTime: DateTime
  - The snapshot time of this version of the event.
- versionStartSnapshotId: System.String
- recurrence: O365CalendarEventRecurrence
  - The recurrence of the event (if part of a series).
