// AwsCloudComputeSettingFilterField.cs
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
    public enum AwsCloudComputeSettingFilterField
    {
        [EnumMember(Value = "CLOUD_ACCOUNT_ID")]
        CLOUD_ACCOUNT_ID,

        [EnumMember(Value = "CLUSTER_ALL")]
        CLUSTER_ALL,

        [EnumMember(Value = "CLUSTER_ID")]
        CLUSTER_ID,

        [EnumMember(Value = "IS_SG_RUBRIK_MANAGED")]
        IS_SG_RUBRIK_MANAGED,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum AwsCloudComputeSettingFilterField

} // namespace Rubrik.SecurityCloud.Types