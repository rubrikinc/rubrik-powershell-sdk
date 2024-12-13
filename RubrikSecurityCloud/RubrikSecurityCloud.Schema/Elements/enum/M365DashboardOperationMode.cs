// M365DashboardOperationMode.cs
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
    public enum M365DashboardOperationMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DAY_TO_DAY_MODE")]
        DAY_TO_DAY_MODE,

        [EnumMember(Value = "ONBOARDING_MODE")]
        ONBOARDING_MODE


    } // enum M365DashboardOperationMode

} // namespace RubrikSecurityCloud.Types