// ReaderLocationRefreshState.cs
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
    public enum ReaderLocationRefreshState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "READER_REFRESH_STATE_IN_PROGRESS")]
        READER_REFRESH_STATE_IN_PROGRESS,

        [EnumMember(Value = "READER_REFRESH_STATE_NEVER_REFRESHED")]
        READER_REFRESH_STATE_NEVER_REFRESHED,

        [EnumMember(Value = "READER_REFRESH_STATE_NOT_RUNNING")]
        READER_REFRESH_STATE_NOT_RUNNING,

        [EnumMember(Value = "READER_REFRESH_STATE_UNKNOWN")]
        READER_REFRESH_STATE_UNKNOWN


    } // enum ReaderLocationRefreshState

} // namespace RubrikSecurityCloud.Types