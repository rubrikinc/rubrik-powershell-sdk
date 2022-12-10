// V2QueryLogShippingConfigurationsV2RequestStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:47.
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
    public enum V2QueryLogShippingConfigurationsV2RequestStatus
    {
        [EnumMember(Value = "V2_QUERY_LOG_SHIPPING_CONFIGURATIONS_V2_REQUEST_STATUS_BROKEN")]
        V2_QUERY_LOG_SHIPPING_CONFIGURATIONS_V2_REQUEST_STATUS_BROKEN,

        [EnumMember(Value = "V2_QUERY_LOG_SHIPPING_CONFIGURATIONS_V2_REQUEST_STATUS_INITIALIZING")]
        V2_QUERY_LOG_SHIPPING_CONFIGURATIONS_V2_REQUEST_STATUS_INITIALIZING,

        [EnumMember(Value = "V2_QUERY_LOG_SHIPPING_CONFIGURATIONS_V2_REQUEST_STATUS_OK")]
        V2_QUERY_LOG_SHIPPING_CONFIGURATIONS_V2_REQUEST_STATUS_OK,

        [EnumMember(Value = "V2_QUERY_LOG_SHIPPING_CONFIGURATIONS_V2_REQUEST_STATUS_STALE")]
        V2_QUERY_LOG_SHIPPING_CONFIGURATIONS_V2_REQUEST_STATUS_STALE


    } // enum V2QueryLogShippingConfigurationsV2RequestStatus

} // namespace Rubrik.SecurityCloud.Types