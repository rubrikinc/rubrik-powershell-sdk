// S3CompatibleSubType.cs
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
    public enum S3CompatibleSubType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        [EnumMember(Value = "DEFAULT_BUCKET_IMMUTABLE")]
        DEFAULT_BUCKET_IMMUTABLE,

        [EnumMember(Value = "DELLECS")]
        DELLECS,

        [EnumMember(Value = "IBMCOS")]
        IBMCOS,

        [EnumMember(Value = "IRONCLOUD")]
        IRONCLOUD,

        [EnumMember(Value = "NETAPPSG")]
        NETAPPSG,

        [EnumMember(Value = "PURE_FB")]
        PURE_FB,

        [EnumMember(Value = "SCALITY")]
        SCALITY,

        [EnumMember(Value = "TYPE_UNSPECIFIED")]
        TYPE_UNSPECIFIED,

        [EnumMember(Value = "WASABI")]
        WASABI


    } // enum S3CompatibleSubType

} // namespace RubrikSecurityCloud.Types