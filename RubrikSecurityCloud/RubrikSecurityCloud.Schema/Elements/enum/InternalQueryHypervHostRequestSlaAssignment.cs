// InternalQueryHypervHostRequestSlaAssignment.cs
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
    public enum InternalQueryHypervHostRequestSlaAssignment
    {
        [EnumMember(Value = "INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_DERIVED")]
        INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_DERIVED,

        [EnumMember(Value = "INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_DIRECT")]
        INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_DIRECT,

        [EnumMember(Value = "INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_UNASSIGNED")]
        INTERNAL_QUERY_HYPERV_HOST_REQUEST_SLA_ASSIGNMENT_UNASSIGNED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum InternalQueryHypervHostRequestSlaAssignment

} // namespace RubrikSecurityCloud.Types