### StrainInfo
Information about list of strains identified.

- strainId: System.String
  - Name of the strain detected.
- totalAffectedFiles: System.Int64
  - Total number of files affected by the above strain.
- totalRansomwareNotes: System.Int64
  - Total number of ransomware notes corresponding to the
above strain.
- sampleAffectedFiles: list of System.Strings
  - A sample of filepaths that are affected by the strain.
- sampleRansomwareNotes: list of System.Strings
  - A sample of filepaths that are ransomware notes.
- sampleAffectedFilesInfo: list of SuspiciousFileInfos
  - Additional information on the affected files.
- sampleRansomwareNoteFilesInfo: list of SuspiciousFileInfos
  - Additional information on the ransomware note files.
