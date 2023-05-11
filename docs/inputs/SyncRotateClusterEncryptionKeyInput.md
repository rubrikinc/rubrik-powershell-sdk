### SyncRotateClusterEncryptionKeyInput
Input required to perform a one-time key rotation on a Rubrik cluster.

- clusterUuid: System.String
  - ID of the Rubrik cluster.
- currentEncryptionPassword: System.String
  - The current encryption password if the cluster is using password-based software encryption.
- keyType: ClusterKeyProtection
  - Key protection type.
- newEncryptionPassword: System.String
  - New encryption password.
