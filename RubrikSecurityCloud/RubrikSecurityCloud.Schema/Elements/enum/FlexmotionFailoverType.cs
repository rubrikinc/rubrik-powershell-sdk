// FlexmotionFailoverType.cs
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
    public enum FlexmotionFailoverType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FLEXMOTION_FAILOVER_TYPE_CLEAN")]
        FLEXMOTION_FAILOVER_TYPE_CLEAN,

        [EnumMember(Value = "FLEXMOTION_FAILOVER_TYPE_FORCED")]
        FLEXMOTION_FAILOVER_TYPE_FORCED


    } // enum FlexmotionFailoverType

} // namespace RubrikSecurityCloud.Types