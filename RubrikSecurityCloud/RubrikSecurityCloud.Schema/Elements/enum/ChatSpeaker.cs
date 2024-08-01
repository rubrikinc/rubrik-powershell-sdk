// ChatSpeaker.cs
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
    public enum ChatSpeaker
    {
        [EnumMember(Value = "ASSISTANT")]
        ASSISTANT,

        [EnumMember(Value = "SPEAKER_UNSPECIFIED")]
        SPEAKER_UNSPECIFIED,

        [EnumMember(Value = "USER")]
        USER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ChatSpeaker

} // namespace RubrikSecurityCloud.Types