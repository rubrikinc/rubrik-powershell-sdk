// SnappableCrawlStatus.cs
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
    public enum SnappableCrawlStatus
    {
        [EnumMember(Value = "COMPLETE")]
        COMPLETE,

        [EnumMember(Value = "FAIL")]
        FAIL,

        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS


    } // enum SnappableCrawlStatus

} // namespace Rubrik.SecurityCloud.Types