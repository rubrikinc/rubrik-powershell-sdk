// PermissionReportType.cs
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
    public enum PermissionReportType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EXCLUDED_PERMISSIONS")]
        EXCLUDED_PERMISSIONS,

        [EnumMember(Value = "MISSING_PERMISSIONS")]
        MISSING_PERMISSIONS


    } // enum PermissionReportType

} // namespace RubrikSecurityCloud.Types