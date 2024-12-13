// CloudNativeVmAppConsistentObjectType.cs
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
    public enum CloudNativeVmAppConsistentObjectType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_EC2_INSTANCE")]
        AWS_EC2_INSTANCE,

        [EnumMember(Value = "AZURE_VIRTUAL_MACHINE")]
        AZURE_VIRTUAL_MACHINE


    } // enum CloudNativeVmAppConsistentObjectType

} // namespace RubrikSecurityCloud.Types