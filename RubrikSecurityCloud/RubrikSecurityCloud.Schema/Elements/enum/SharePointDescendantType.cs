// SharePointDescendantType.cs
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
    public enum SharePointDescendantType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "APP_CATALOG")]
        APP_CATALOG,

        [EnumMember(Value = "DESCENDANT_UNSPECIFIED")]
        DESCENDANT_UNSPECIFIED,

        [EnumMember(Value = "LIBRARY")]
        LIBRARY,

        [EnumMember(Value = "LIST")]
        LIST,

        [EnumMember(Value = "SITE")]
        SITE,

        [EnumMember(Value = "WEBPART")]
        WEBPART


    } // enum SharePointDescendantType

} // namespace RubrikSecurityCloud.Types