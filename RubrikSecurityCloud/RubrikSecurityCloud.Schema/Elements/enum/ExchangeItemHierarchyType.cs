// ExchangeItemHierarchyType.cs
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
    public enum ExchangeItemHierarchyType
    {
        [EnumMember(Value = "DEFAULT_HIERARCHY")]
        DEFAULT_HIERARCHY,

        [EnumMember(Value = "RIF_HIERARCHY")]
        RIF_HIERARCHY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ExchangeItemHierarchyType

} // namespace RubrikSecurityCloud.Types