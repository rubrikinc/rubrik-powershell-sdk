// PlanName.cs
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
    public enum PlanName
    {
        [EnumMember(Value = "ISOLATED_RECOVERY")]
        ISOLATED_RECOVERY,

        [EnumMember(Value = "PROD")]
        PROD,

        [EnumMember(Value = "PROD_LOCAL")]
        PROD_LOCAL,

        [EnumMember(Value = "TEST")]
        TEST


    } // enum PlanName

} // namespace Rubrik.SecurityCloud.Types