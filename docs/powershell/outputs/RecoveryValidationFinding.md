### RecoveryValidationFinding
A single finding from a CCES recovery pre-flight check.

- check: RecoveryCheck
  - Which check produced this finding.
- severity: RecoverySeverity
  - Whether this finding blocks recovery or is advisory only.
- detail: System.String
  - Human-readable description of what failed or was detected.
- remediation: System.String
  - What the customer should do to resolve this finding.
