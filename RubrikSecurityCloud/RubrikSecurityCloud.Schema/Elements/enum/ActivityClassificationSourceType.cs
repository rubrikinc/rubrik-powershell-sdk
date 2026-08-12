// ActivityClassificationSourceType.cs
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
    public enum ActivityClassificationSourceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CROWDSTRIKE")]
        CROWDSTRIKE,

        [EnumMember(Value = "IOC_FILE")]
        IOC_FILE,

        [EnumMember(Value = "MICROSOFT_DEFENDER")]
        MICROSOFT_DEFENDER,

        [EnumMember(Value = "SAILPOINT")]
        SAILPOINT,

        [EnumMember(Value = "WORKDAY")]
        WORKDAY


    } // enum ActivityClassificationSourceType

} // namespace RubrikSecurityCloud.Types