// S3CompatibleSubType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:19.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum S3CompatibleSubType
    {
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        [EnumMember(Value = "DELLECS")]
        DELLECS,

        [EnumMember(Value = "IBMCOS")]
        IBMCOS,

        [EnumMember(Value = "NETAPPSG")]
        NETAPPSG,

        [EnumMember(Value = "SCALITY")]
        SCALITY,

        [EnumMember(Value = "TYPE_UNSPECIFIED")]
        TYPE_UNSPECIFIED


    } // enum S3CompatibleSubType

} // namespace Rubrik.SecurityCloud.Types