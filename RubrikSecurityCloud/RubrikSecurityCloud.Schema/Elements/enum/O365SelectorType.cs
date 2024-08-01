// O365SelectorType.cs
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
    public enum O365SelectorType
    {
        [EnumMember(Value = "SELECTOR_TYPE_AD_GROUP")]
        SELECTOR_TYPE_AD_GROUP,

        [EnumMember(Value = "SELECTOR_TYPE_CONFIGURED_GROUP")]
        SELECTOR_TYPE_CONFIGURED_GROUP,

        [EnumMember(Value = "SELECTOR_TYPE_UNKNOWN")]
        SELECTOR_TYPE_UNKNOWN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum O365SelectorType

} // namespace RubrikSecurityCloud.Types