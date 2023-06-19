### CdmUpgradeReleaseDetail
CDM release detail.

- name: System.String
  - Name of CDM release.
- description: System.String
  - Description of CDM release.
- releaseDate: System.String
  - CDM package release date.
- gaReleaseDate: System.String
  - Release date of GA version.
- tarDownloadLink: System.String
  - Download link to tarball.
- releaseNotesLink: System.String
  - Release notes link.
- md5Sum: System.String
  - Md5Sum of the package.
- size: System.Int64
  - Size of CDM package.
- isRecommended: System.Boolean
  - Is this a recommended version.
- isUpgradable: System.Boolean
  - Is cluster upgradeable to version.
- adoptionStatus: AdoptionStatus
  - The customer adoption status of the Rubrik CDM release.
