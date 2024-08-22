// ExoBundleApprovalStatus.cs
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
    public enum ExoBundleApprovalStatus
    {
        [EnumMember(Value = "ACCEPTED")]
        ACCEPTED,

        [EnumMember(Value = "REJECTED")]
        REJECTED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ExoBundleApprovalStatus

} // namespace RubrikSecurityCloud.Types