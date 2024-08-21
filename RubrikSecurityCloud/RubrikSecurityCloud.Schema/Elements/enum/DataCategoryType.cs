// DataCategoryType.cs
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
    public enum DataCategoryType
    {
        [EnumMember(Value = "CUSTOM")]
        CUSTOM,

        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        [EnumMember(Value = "PREDEFINED")]
        PREDEFINED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum DataCategoryType

} // namespace RubrikSecurityCloud.Types