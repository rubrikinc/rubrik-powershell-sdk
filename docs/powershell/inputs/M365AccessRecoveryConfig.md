### M365AccessRecoveryConfig
Automated M365 Access Recovery configuration for a directory. An absent
configuration carries no selection, which leaves the directory following its
account's eligibility on setup and leaves an already persisted selection
untouched on update.

- isEnabled: System.Boolean
  - Indicates whether M365 access recovery is turned on for the directory. True
selects the on state and false the off state; there is no way to ask for the
default state, which is what a directory carries until it is configured.
- certificate: System.String
  - X.509 certificate (PEM) for SharePoint app-only auth, required for a
non-OAuth directory that turns M365 access recovery on. The certificate is
public and is carried as a plain string.
- privateKey: System.String
  - PKCS#1 private key (PEM) paired with the certificate, required for a
non-OAuth directory that turns M365 access recovery on. The key is secret
material.
