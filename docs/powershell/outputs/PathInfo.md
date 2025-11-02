### PathInfo
Supported in v6.0+

- aclDetails: System.String
  - Supported in v6.0+
JSON encoded file access control list (ACL) information.
- creationTime: DateTime
  - Supported in v6.0+
File creation time.
- modificationTime: DateTime
  - Supported in v6.0+
File modification time.
- path: System.String
  - Required. Supported in v6.0+
File path that matched the malware Indicator of Compromise.
- requestedHashDetails: list of HashDetails
  - Supported in v6.0+
Hash algorithm and hash values.
- yaraMatchDetails: list of YARAMatchDetails
  - Required. Supported in v6.0+
Details about the matching YARA rule(s).
