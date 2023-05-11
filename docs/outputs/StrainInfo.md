### StrainInfo
Information about list of strains identified.

- sampleAffectedFiles: a list of System.Strings
  - A sample of filepaths that are affected by the strain.
- sampleAffectedFilesInfo: a list of SuspiciousFileInfos
  - Additional information on the affected files.
- sampleRansomwareNoteFilesInfo: a list of SuspiciousFileInfos
  - Additional information on the ransomware note files.
- sampleRansomwareNotes: a list of System.Strings
  - A sample of filepaths that are ransomware notes.
- strainId: System.String
  - Name of the strain detected.
- totalAffectedFiles: System.Int64
  - Total number of files affected by the above strain.
- totalRansomwareNotes: System.Int64
  - Total number of ransomware notes corresponding to the
 above strain.
