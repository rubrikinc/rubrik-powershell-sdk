// CalendarEventType.cs
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
    public enum CalendarEventType
    {
        [EnumMember(Value = "SERIES_EXCEPTION")]
        SERIES_EXCEPTION,

        [EnumMember(Value = "SERIES_MASTER")]
        SERIES_MASTER,

        [EnumMember(Value = "SERIES_OCCURRENCE")]
        SERIES_OCCURRENCE,

        [EnumMember(Value = "SINGLE_INSTANCE")]
        SINGLE_INSTANCE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CalendarEventType

} // namespace RubrikSecurityCloud.Types