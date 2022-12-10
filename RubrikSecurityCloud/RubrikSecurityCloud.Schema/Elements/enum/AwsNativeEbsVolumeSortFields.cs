// AwsNativeEbsVolumeSortFields.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:10.
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
    public enum AwsNativeEbsVolumeSortFields
    {
        [EnumMember(Value = "AWS_NATIVE_ACCOUNT_NAME")]
        AWS_NATIVE_ACCOUNT_NAME,

        [EnumMember(Value = "EBS_VOLUME_ID")]
        EBS_VOLUME_ID,

        [EnumMember(Value = "EBS_VOLUME_NAME")]
        EBS_VOLUME_NAME,

        [EnumMember(Value = "EBS_VOLUME_SIZE")]
        EBS_VOLUME_SIZE,

        [EnumMember(Value = "EBS_VOLUME_TYPE")]
        EBS_VOLUME_TYPE,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN


    } // enum AwsNativeEbsVolumeSortFields

} // namespace Rubrik.SecurityCloud.Types