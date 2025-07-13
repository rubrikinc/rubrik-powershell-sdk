// ExoHealthCheckCategory.cs
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
    public enum ExoHealthCheckCategory
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        [EnumMember(Value = "USE_CASE_SPECIFIC")]
        USE_CASE_SPECIFIC


    } // enum ExoHealthCheckCategory

} // namespace RubrikSecurityCloud.Types