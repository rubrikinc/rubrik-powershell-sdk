// StorageAccountSku.cs
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
    public enum StorageAccountSku
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "STANDARD_GRS")]
        STANDARD_GRS,

        [EnumMember(Value = "STANDARD_LRS")]
        STANDARD_LRS,

        [EnumMember(Value = "STANDARD_ZRS")]
        STANDARD_ZRS


    } // enum StorageAccountSku

} // namespace RubrikSecurityCloud.Types