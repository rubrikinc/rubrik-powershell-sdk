// YaraVersion.cs
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
    public enum YaraVersion
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "YARA39")]
        YAR_A39,

        [EnumMember(Value = "YARA43")]
        YAR_A43


    } // enum YaraVersion

} // namespace RubrikSecurityCloud.Types