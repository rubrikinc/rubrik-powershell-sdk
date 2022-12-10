// TagFilterType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:10.
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
    public enum TagFilterType
    {
        [EnumMember(Value = "TAG_KEY")]
        TAG_KEY,

        [EnumMember(Value = "TAG_KEY_VALUE")]
        TAG_KEY_VALUE


    } // enum TagFilterType

} // namespace Rubrik.SecurityCloud.Types