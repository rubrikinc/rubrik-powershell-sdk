// ActivityClassification.cs
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
    public enum ActivityClassification
    {
        [EnumMember(Value = "CLASSIFYING")]
        CLASSIFYING,

        [EnumMember(Value = "LEGITIMATE")]
        LEGITIMATE,

        [EnumMember(Value = "SUSPICIOUS")]
        SUSPICIOUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ActivityClassification

} // namespace RubrikSecurityCloud.Types