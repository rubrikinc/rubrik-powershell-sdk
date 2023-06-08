### SyncRotateClusterEncryptionKeyInput
Input required to perform a one-time key rotation on a Rubrik cluster.

- clusterUuid: System.String
  - ID of the Rubrik cluster.
- keyType: ClusterKeyProtection
  - Key protection type.
- currentEncryptionPassword: System.String
  - The current encryption password if the cluster is using password-based software encryption.
- newEncryptionPassword: System.String
  - New encryption password.
