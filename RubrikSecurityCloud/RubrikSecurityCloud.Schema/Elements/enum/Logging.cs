// Logging.cs
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
    public enum Logging
    {
        [EnumMember(Value = "LOGGING_DISABLED")]
        LOGGING_DISABLED,

        [EnumMember(Value = "LOGGING_ENABLED")]
        LOGGING_ENABLED,

        [EnumMember(Value = "LOGGING_UNSPECIFIED")]
        LOGGING_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum Logging

} // namespace RubrikSecurityCloud.Types