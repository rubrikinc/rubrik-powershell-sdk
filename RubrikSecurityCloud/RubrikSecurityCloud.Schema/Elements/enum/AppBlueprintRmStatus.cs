// AppBlueprintRmStatus.cs
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
    public enum AppBlueprintRmStatus
    {
        [EnumMember(Value = "Configured")]
        CONFIGURED,

        [EnumMember(Value = "Invalid")]
        INVALID,

        [EnumMember(Value = "MissingVms")]
        MISSING_VMS,

        [EnumMember(Value = "NotConfigured")]
        NOT_CONFIGURED


    } // enum AppBlueprintRmStatus

} // namespace RubrikSecurityCloud.Types