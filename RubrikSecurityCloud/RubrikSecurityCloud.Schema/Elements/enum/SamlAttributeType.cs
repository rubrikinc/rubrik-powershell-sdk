// SamlAttributeType.cs
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
    public enum SamlAttributeType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EMAIL")]
        EMAIL,

        [EnumMember(Value = "GROUPS")]
        GROUPS,

        [EnumMember(Value = "UNSPECIFIED_ATTRIBUTE")]
        UNSPECIFIED_ATTRIBUTE


    } // enum SamlAttributeType

} // namespace RubrikSecurityCloud.Types