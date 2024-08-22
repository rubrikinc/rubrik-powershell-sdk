// ScriptErrorAction.cs
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
    public enum ScriptErrorAction
    {
        [EnumMember(Value = "SCRIPT_ERROR_ACTION_ABORT")]
        SCRIPT_ERROR_ACTION_ABORT,

        [EnumMember(Value = "SCRIPT_ERROR_ACTION_CONTINUE")]
        SCRIPT_ERROR_ACTION_CONTINUE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ScriptErrorAction

} // namespace RubrikSecurityCloud.Types