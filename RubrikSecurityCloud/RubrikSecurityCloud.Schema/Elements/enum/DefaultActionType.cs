// DefaultActionType.cs
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
    public enum DefaultActionType
    {
        [EnumMember(Value = "ALLOW")]
        ALLOW,

        [EnumMember(Value = "DENY")]
        DENY


    } // enum DefaultActionType

} // namespace Rubrik.SecurityCloud.Types