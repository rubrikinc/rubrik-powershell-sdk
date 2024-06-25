// ThreatFeedType.cs
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
    public enum ThreatFeedType
    {
        [EnumMember(Value = "FILE_PATTERN")]
        FILE_PATTERN,

        [EnumMember(Value = "HASH")]
        HASH,

        [EnumMember(Value = "YARA")]
        YARA


    } // enum ThreatFeedType

} // namespace RubrikSecurityCloud.Types