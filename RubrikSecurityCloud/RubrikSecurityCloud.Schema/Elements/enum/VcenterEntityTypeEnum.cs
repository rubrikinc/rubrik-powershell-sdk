// VcenterEntityTypeEnum.cs
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
    public enum VcenterEntityTypeEnum
    {
        [EnumMember(Value = "CLUSTER")]
        CLUSTER,

        [EnumMember(Value = "DATASTORE")]
        DATASTORE,

        [EnumMember(Value = "ESXI_HOST")]
        ESXI_HOST,

        [EnumMember(Value = "NETWORK")]
        NETWORK,

        [EnumMember(Value = "PROFILE_DRIVEN_STORAGE")]
        PROFILE_DRIVEN_STORAGE,

        [EnumMember(Value = "RESOURCE_POOL")]
        RESOURCE_POOL,

        [EnumMember(Value = "SESSION")]
        SESSION,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "VCENTER")]
        VCENTER,

        [EnumMember(Value = "VM")]
        VM,

        [EnumMember(Value = "VM_FOLDER")]
        VM_FOLDER


    } // enum VcenterEntityTypeEnum

} // namespace RubrikSecurityCloud.Types