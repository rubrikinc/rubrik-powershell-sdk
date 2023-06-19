// PactsafeEvent.cs
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
    public enum PactsafeEvent
    {
        [EnumMember(Value = "AGREED")]
        AGREED,

        [EnumMember(Value = "DISAGREED")]
        DISAGREED,

        [EnumMember(Value = "DISPLAYED")]
        DISPLAYED,

        [EnumMember(Value = "EVENT_UNSPECIFIED")]
        EVENT_UNSPECIFIED


    } // enum PactsafeEvent

} // namespace RubrikSecurityCloud.Types