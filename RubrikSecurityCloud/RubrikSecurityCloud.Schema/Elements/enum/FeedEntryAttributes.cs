// FeedEntryAttributes.cs
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
    public enum FeedEntryAttributes
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ADDED_ON")]
        ADDED_ON,

        [EnumMember(Value = "STATUS")]
        STATUS,

        [EnumMember(Value = "THREAT_FEED_FAMILY")]
        THREAT_FEED_FAMILY,

        [EnumMember(Value = "UNSET")]
        UNSET


    } // enum FeedEntryAttributes

} // namespace RubrikSecurityCloud.Types