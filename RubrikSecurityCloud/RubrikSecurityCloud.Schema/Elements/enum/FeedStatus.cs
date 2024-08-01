// FeedStatus.cs
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
    public enum FeedStatus
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "IMPORTING_IOCS")]
        IMPORTING_IOCS,

        [EnumMember(Value = "INVALID_CREDENTIALS")]
        INVALID_CREDENTIALS,

        [EnumMember(Value = "NEW_DISABLED_IOCS_INGESTED")]
        NEW_DISABLED_IOCS_INGESTED,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FeedStatus

} // namespace RubrikSecurityCloud.Types