// KmsSharingMode.cs
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
    public enum KmsSharingMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "KMS_SHARING_MODE_NONE")]
        KMS_SHARING_MODE_NONE,

        [EnumMember(Value = "KMS_SHARING_MODE_SHARING_AND_GATEWAY")]
        KMS_SHARING_MODE_SHARING_AND_GATEWAY,

        [EnumMember(Value = "KMS_SHARING_MODE_SHARING_ONLY")]
        KMS_SHARING_MODE_SHARING_ONLY,

        [EnumMember(Value = "KMS_SHARING_MODE_UNSPECIFIED")]
        KMS_SHARING_MODE_UNSPECIFIED


    } // enum KmsSharingMode

} // namespace RubrikSecurityCloud.Types