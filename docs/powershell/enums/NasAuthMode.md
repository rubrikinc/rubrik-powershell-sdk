### NasAuthMode
Authentication mode for NAS protocols (SMB and NFS).
UNSPECIFIED is equivalent to STANDARD and is the default for existing sources.

- NAS_AUTH_MODE_UNSPECIFIED - Equivalent to STANDARD; absence of an explicit auth mode preference.
- STANDARD - Standard authentication: NTLM for SMB, sec=sys for NFS.
- KERBEROS_PREFERRED - Try Kerberos first, fall back to standard on failure.
- KERBEROS_ONLY - Enforce Kerberos; fail closed with no fallback.
