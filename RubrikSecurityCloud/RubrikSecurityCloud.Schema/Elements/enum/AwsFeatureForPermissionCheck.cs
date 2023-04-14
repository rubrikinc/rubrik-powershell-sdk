// AwsFeatureForPermissionCheck.cs
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
    public enum AwsFeatureForPermissionCheck
    {
        [EnumMember(Value = "AWS_EXPORT_VM_IN_POWERED_OFF_STATE")]
        AWS_EXPORT_VM_IN_POWERED_OFF_STATE,

        [EnumMember(Value = "AWS_EXPORT_VM_WITH_IAM_INSTANCE_PROFILE")]
        AWS_EXPORT_VM_WITH_IAM_INSTANCE_PROFILE,

        [EnumMember(Value = "AWS_UNSPECIFIED")]
        AWS_UNSPECIFIED


    } // enum AwsFeatureForPermissionCheck

} // namespace Rubrik.SecurityCloud.Types