// DataTypeSource.cs
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
    public enum DataTypeSource
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CUSTOM")]
        CUSTOM,

        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        [EnumMember(Value = "PREDEFINED")]
        PREDEFINED


    } // enum DataTypeSource

} // namespace RubrikSecurityCloud.Types