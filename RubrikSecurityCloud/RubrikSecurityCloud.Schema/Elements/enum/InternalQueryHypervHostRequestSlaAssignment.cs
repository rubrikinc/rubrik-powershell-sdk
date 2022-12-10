// InternalQueryHypervHostRequestSlaAssignment.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:37.
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
    public enum InternalQueryHypervHostRequestSlaAssignment
    {
        [EnumMember(Value = "INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_DERIVED")]
        INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_DERIVED,

        [EnumMember(Value = "INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_DIRECT")]
        INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_DIRECT,

        [EnumMember(Value = "INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_UNASSIGNED")]
        INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_UNASSIGNED


    } // enum InternalQueryHypervHostRequestSlaAssignment

} // namespace Rubrik.SecurityCloud.Types