### VsphereVmServiceInfo
Placement of a vSphere virtual machine that a vSphere Supervisor manages.

- supervisor: PathNode
  - Supervisor that manages the virtual machine.
- namespace: PathNode
  - Namespace the virtual machine belongs to.
- vmClassName: System.String
  - Virtual machine class the virtual machine was deployed with.
- storageClassName: System.String
  - Storage class of the virtual machine disks.
- zoneName: System.String
  - Zone the virtual machine is placed in.
