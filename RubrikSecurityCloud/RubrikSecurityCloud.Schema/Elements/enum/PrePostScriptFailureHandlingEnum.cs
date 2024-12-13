// PrePostScriptFailureHandlingEnum.cs
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
    public enum PrePostScriptFailureHandlingEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "abort")]
        ABORT,

        [EnumMember(Value = "continue")]
        CONTINUE


    } // enum PrePostScriptFailureHandlingEnum

} // namespace RubrikSecurityCloud.Types