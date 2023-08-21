### DataGovObjectType
TODO: SPARK-150447 - Deprecate this enum to use managed object type
 Filters objects by object type.
 Note: All the object types, except CDM, are granular object types.

- OBJECT_TYPE_UNSPECIFIED - Unknown object type.
- CDM - Represents all the object types that belong to CDM. This is the default
 value and is added for maintaining backward compatability.
- O365_ONEDRIVE - Represents O365 OneDrive objects.
- O365_SHAREPOINT_DRIVE - Represents O365 SharePoint Drive objects.
- VSPHERE_VIRTUAL_MACHINE - Represents vSphere Virtual Machine objects.
- LINUX_FILESET - Represents Linux Fileset objects.
- SHARE_FILESET - Represents Share Fileset objects.
- WINDOWS_FILESET - Represents Windows Fileset objects.
- NUTANIX_VIRTUAL_MACHINE - Represents Nutanix Virtual Machine objects.
- HYPERV_VIRTUAL_MACHINE - Represents Hyper-V Virtual Machine objects.
- VOLUME_GROUP - Represents Volume Group objects.
- AZURE_NATIVE_VIRTUAL_MACHINE - Represents an Azure-native virtual machine.
- AZURE_NATIVE_MANAGED_DISK - Represents an Azure-native managed disk.
- CLOUD_DIRECT_NAS_EXPORT - Represents NAS Cloud Direct objects.
- VSPHERE_VCENTER - Represents VMWARE VSPHERE_VCENTER.
- VSPHERE_COMPUTE_CLUSTER - Represent VMWARE compute cluster.
- VSPHERE_FOLDER - Represents VMWARE VSPHERE_FOLDER.
- VSPHERE_TAG - Represents VSPHERE VMWARE_TAG.
- PHYSICAL_HOST - Represents Physical host.
- HYPERV_CLUSTER - Represents Hyper-V cluster.
- NUTANIX_CLUSTER - Represents Nutanix cluster.
- O365_ORGANIZATION - Represents O365 organization.
- O365_GROUP - Represents O365 group.
- AZURE_SUBSCRIPTION - Represents Azure subscription.
- AZURE_RESOURCE_GROUP - Represents Azure common resource group.
- CLOUD_NATIVE_TAG_RULE - Represents Azure Cloud tag rule.
- O365_SHAREPOINT_SITE - Represents O365 SharePoint Site objects.
- AZURE_NATIVE_ROOT - Represents Microsoft Azure native root.
- LINUX_HOST_ROOT - Represents Linux host root.
- WINDOWS_HOST_ROOT - Represents Windows host root.
- VSPHERE_ROOT - Represents vSphere root.
- HYPERV_ROOT - Represents Hyper-V root.
- O365_ROOT - Represents Microsoft Office 365 root.
- NUTANIX_ROOT - Represents Nutanix root.
- CDM_CLUSTER - Represents Rubrik CDM cluster.
- NAS_FILESET - Represents RSC NAS Filesets.
- VMWARE_DATACENTER - Represents VMware Data Center.
- VMWARE_HOST - Represents VMware Host.
- VMWARE_TAG_CATEGORY - Represents VMware Tag Category.
- HYPERV_SCVMM - Represents HyperV SCVMM.
- HYPERV_SERVER - Represents HyperV Server.
- VMWARE_RESOURCE_POOL - Represents VMware resource pool.
- MSSQL_DATABASE - Represents MSSQL Database.
- MSSQL_ROOT - Represents MSSQL Root.
