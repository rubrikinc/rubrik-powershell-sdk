### ProxmoxStorageDomain
Storage domain details for a Proxmox node.

- name: System.String
  - Storage domain name.
- totalStorage: System.String
  - Total storage capacity.
- availableStorage: System.String
  - Available storage capacity.
- fileSystem: System.String
  - File system type.
- storageType: System.String
  - Raw Proxmox storage plugin type, for example "lvmthin", "nfs", or "rbd".
- content: System.String
  - Comma-separated Proxmox content types the storage accepts, for example
"images,rootdir". A storage domain must accept "images" to hold virtual disks.
- isActive: System.Boolean
  - Whether the storage is currently online on the node.
- isEnabled: System.Boolean
  - Whether the storage is enabled in the Proxmox configuration.
- isShared: System.Boolean
  - Whether the storage is shared across nodes in the cluster.
