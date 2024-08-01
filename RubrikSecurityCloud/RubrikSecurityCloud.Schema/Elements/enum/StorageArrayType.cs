// StorageArrayType.cs
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
    public enum StorageArrayType
    {
        [EnumMember(Value = "STORAGE_ARRAY_TYPE_DELL_EMC_POWER_STORE")]
        STORAGE_ARRAY_TYPE_DELL_EMC_POWER_STORE,

        [EnumMember(Value = "STORAGE_ARRAY_TYPE_HITACHI_STORAGE")]
        STORAGE_ARRAY_TYPE_HITACHI_STORAGE,

        [EnumMember(Value = "STORAGE_ARRAY_TYPE_NET_APP_ONTAP")]
        STORAGE_ARRAY_TYPE_NET_APP_ONTAP,

        [EnumMember(Value = "STORAGE_ARRAY_TYPE_PURE_STORAGE")]
        STORAGE_ARRAY_TYPE_PURE_STORAGE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum StorageArrayType

} // namespace RubrikSecurityCloud.Types