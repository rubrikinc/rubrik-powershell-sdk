### ReleaseNote
A single release note.

- id: System.String
  - The ID of the release note.
- title: System.String
  - The title of the release note.
- description: System.String
  - The description of the release note.
- version: System.String
  - The name of the Rubrik Security Cloud release.
- releaseDate: DateTime
  - The date of the release.
- jiraKey: System.String
  - The key of the customer found defect in JIRA.
- cdmDependencies: list of System.Strings
  - The CDM versions on which the features in the release are dependent.
- featureLimitations: list of System.Strings
  - The known limitations of the changes introduced in the release.
- helpUrl: System.String
  - A URL pointing to the release note documentation.
- type: ReleaseNoteTypeType
  - The type of the release note.
- tags: list of ReleaseNoteTags
  - A list of flat tags describing the release note.
