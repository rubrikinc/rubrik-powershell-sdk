// CloudAccountFilterFieldEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:22.
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
    public enum CloudAccountFilterFieldEnum
    {
        [EnumMember(Value = "ACCOUNT_PROVIDER_TYPE")]
        ACCOUNT_PROVIDER_TYPE,

        [EnumMember(Value = "IS_KEY_BASED")]
        IS_KEY_BASED,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum CloudAccountFilterFieldEnum

} // namespace Rubrik.SecurityCloud.Types