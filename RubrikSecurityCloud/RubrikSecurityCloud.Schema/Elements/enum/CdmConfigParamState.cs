// CdmConfigParamState.cs
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
    public enum CdmConfigParamState
    {
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        [EnumMember(Value = "IMMUTABLE")]
        IMMUTABLE,

        [EnumMember(Value = "MODIFIED")]
        MODIFIED,

        [EnumMember(Value = "OVERRIDE")]
        OVERRIDE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CdmConfigParamState

} // namespace RubrikSecurityCloud.Types