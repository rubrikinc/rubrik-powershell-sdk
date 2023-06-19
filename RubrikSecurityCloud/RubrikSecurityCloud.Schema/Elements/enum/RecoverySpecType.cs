// RecoverySpecType.cs
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
    public enum RecoverySpecType
    {
        [EnumMember(Value = "AWS_EC2")]
        AWS_EC2,

        [EnumMember(Value = "UNKNOWN_VM")]
        UNKNOWN_VM,

        [EnumMember(Value = "VMWARE_VM")]
        VMWARE_VM


    } // enum RecoverySpecType

} // namespace RubrikSecurityCloud.Types