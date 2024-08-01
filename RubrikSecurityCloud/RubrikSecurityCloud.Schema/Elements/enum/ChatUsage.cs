// ChatUsage.cs
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
    public enum ChatUsage
    {
        [EnumMember(Value = "ANNAPURNA")]
        ANNAPURNA,

        [EnumMember(Value = "CHATROCK")]
        CHATROCK,

        [EnumMember(Value = "CHATROCK_DEMO")]
        CHATROCK_DEMO,

        [EnumMember(Value = "HELP_CENTER")]
        HELP_CENTER,

        [EnumMember(Value = "USAGE_UNSPECIFIED")]
        USAGE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ChatUsage

} // namespace RubrikSecurityCloud.Types