// SapHanaSystemSummaryStatus.cs
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
    public enum SapHanaSystemSummaryStatus
    {
        [EnumMember(Value = "SAP_HANA_SYSTEM_SUMMARY_STATUS_ERROR")]
        SAP_HANA_SYSTEM_SUMMARY_STATUS_ERROR,

        [EnumMember(Value = "SAP_HANA_SYSTEM_SUMMARY_STATUS_OK")]
        SAP_HANA_SYSTEM_SUMMARY_STATUS_OK,

        [EnumMember(Value = "SAP_HANA_SYSTEM_SUMMARY_STATUS_UNKNOWN")]
        SAP_HANA_SYSTEM_SUMMARY_STATUS_UNKNOWN,

        [EnumMember(Value = "SAP_HANA_SYSTEM_SUMMARY_STATUS_WARNING")]
        SAP_HANA_SYSTEM_SUMMARY_STATUS_WARNING


    } // enum SapHanaSystemSummaryStatus

} // namespace Rubrik.SecurityCloud.Types