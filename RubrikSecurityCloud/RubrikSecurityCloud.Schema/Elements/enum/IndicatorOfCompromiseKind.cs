// IndicatorOfCompromiseKind.cs
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
    public enum IndicatorOfCompromiseKind
    {
        [EnumMember(Value = "IOC_FILE_PATTERN")]
        IOC_FILE_PATTERN,

        [EnumMember(Value = "IOC_HASH")]
        IOC_HASH,

        [EnumMember(Value = "IOC_UNSPECIFIED")]
        IOC_UNSPECIFIED,

        [EnumMember(Value = "IOC_YARA")]
        IOC_YARA


    } // enum IndicatorOfCompromiseKind

} // namespace RubrikSecurityCloud.Types