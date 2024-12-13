// AzureFeatureForPermissionCheck.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum AzureFeatureForPermissionCheck
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_CROSS_REGION_REPLICATION")]
        AZURE_CROSS_REGION_REPLICATION,

        [EnumMember(Value = "AZURE_EXPORT_VM_IN_POWERED_OFF_STATE")]
        AZURE_EXPORT_VM_IN_POWERED_OFF_STATE,

        [EnumMember(Value = "AZURE_LIST_AVAILABILITY_SET")]
        AZURE_LIST_AVAILABILITY_SET,

        [EnumMember(Value = "AZURE_UNSPECIFIED")]
        AZURE_UNSPECIFIED


    } // enum AzureFeatureForPermissionCheck

} // namespace RubrikSecurityCloud.Types