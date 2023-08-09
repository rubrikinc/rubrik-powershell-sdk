// LiveMountsFilterMountField.cs
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
    public enum LiveMountsFilterMountField
    {
        [EnumMember(Value = "AZURE_REGION_NAME")]
        AZURE_REGION_NAME,

        [EnumMember(Value = "MOUNT_FIELD_UNSPECIFIED")]
        MOUNT_FIELD_UNSPECIFIED,

        [EnumMember(Value = "SOURCE_VM_ID")]
        SOURCE_VM_ID,

        [EnumMember(Value = "TARGET_SUBSCRIPTION_ID")]
        TARGET_SUBSCRIPTION_ID,

        [EnumMember(Value = "TARGET_VM_ID")]
        TARGET_VM_ID


    } // enum LiveMountsFilterMountField

} // namespace RubrikSecurityCloud.Types