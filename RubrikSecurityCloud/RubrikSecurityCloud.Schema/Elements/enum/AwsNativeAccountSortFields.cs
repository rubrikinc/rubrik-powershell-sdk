// AwsNativeAccountSortFields.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum AwsNativeAccountSortFields
    {
        [EnumMember(Value = "EBS_VOLUME_COUNT")]
        EBS_VOLUME_COUNT,

        [EnumMember(Value = "EC2_INSTANCE_COUNT")]
        EC2_INSTANCE_COUNT,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum AwsNativeAccountSortFields

} // namespace Rubrik.SecurityCloud.Types