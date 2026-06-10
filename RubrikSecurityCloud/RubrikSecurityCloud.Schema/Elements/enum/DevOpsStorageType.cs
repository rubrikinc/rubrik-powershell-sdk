// DevOpsStorageType.cs
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
    public enum DevOpsStorageType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BYOS")]
        BYOS,

        [EnumMember(Value = "RCV")]
        RCV,

        [EnumMember(Value = "STORAGE_TYPE_UNSPECIFIED")]
        STORAGE_TYPE_UNSPECIFIED


    } // enum DevOpsStorageType

} // namespace RubrikSecurityCloud.Types