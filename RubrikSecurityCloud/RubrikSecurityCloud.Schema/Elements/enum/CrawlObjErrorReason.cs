// CrawlObjErrorReason.cs
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
    public enum CrawlObjErrorReason
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONCURRENT_CRAWL_IN_PROGRESS")]
        CONCURRENT_CRAWL_IN_PROGRESS,

        [EnumMember(Value = "GENERIC_ERROR")]
        GENERIC_ERROR,

        [EnumMember(Value = "SNAPSHOT_NOT_FOUND")]
        SNAPSHOT_NOT_FOUND,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum CrawlObjErrorReason

} // namespace RubrikSecurityCloud.Types