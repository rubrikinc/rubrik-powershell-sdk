// IndicatorOfCompromiseType.cs
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
    public enum IndicatorOfCompromiseType
    {
        [EnumMember(Value = "INDICATOR_OF_COMPROMISE_TYPE_HASH")]
        INDICATOR_OF_COMPROMISE_TYPE_HASH,

        [EnumMember(Value = "INDICATOR_OF_COMPROMISE_TYPE_PATH_OR_FILENAME")]
        INDICATOR_OF_COMPROMISE_TYPE_PATH_OR_FILENAME,

        [EnumMember(Value = "INDICATOR_OF_COMPROMISE_TYPE_YARA_RULE")]
        INDICATOR_OF_COMPROMISE_TYPE_YARA_RULE


    } // enum IndicatorOfCompromiseType

} // namespace Rubrik.SecurityCloud.Types