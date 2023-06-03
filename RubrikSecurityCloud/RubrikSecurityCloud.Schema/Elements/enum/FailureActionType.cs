// FailureActionType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum FailureActionType
    {
        [EnumMember(Value = "FAILURE_ACTION_TYPE_UNKNOWN")]
        FAILURE_ACTION_TYPE_UNKNOWN,

        [EnumMember(Value = "IGNORE_AND_CONTINUE")]
        IGNORE_AND_CONTINUE


    } // enum FailureActionType

} // namespace Rubrik.SecurityCloud.Types