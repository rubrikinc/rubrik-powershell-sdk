// CloudAccountType.cs
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
    public enum CloudAccountType
    {
        [EnumMember(Value = "CLOUD_ACCOUNT_AWS")]
        CLOUD_ACCOUNT_AWS,

        [EnumMember(Value = "CLOUD_ACCOUNT_AWS_ROLE_BASED")]
        CLOUD_ACCOUNT_AWS_ROLE_BASED,

        [EnumMember(Value = "CLOUD_ACCOUNT_AZURE")]
        CLOUD_ACCOUNT_AZURE,

        [EnumMember(Value = "CLOUD_ACCOUNT_AZURE_ROLE_BASED")]
        CLOUD_ACCOUNT_AZURE_ROLE_BASED,

        [EnumMember(Value = "CLOUD_ACCOUNT_GCP")]
        CLOUD_ACCOUNT_GCP,

        [EnumMember(Value = "UNKNOWN_CLOUD_ACCOUNT")]
        UNKNOWN_CLOUD_ACCOUNT


    } // enum CloudAccountType

} // namespace Rubrik.SecurityCloud.Types