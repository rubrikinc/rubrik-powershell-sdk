// PolicyViolationCsvColumn.cs
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
    public enum PolicyViolationCsvColumn
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_CATEGORY")]
        POLICY_VIOLATION_CSV_COLUMN_CATEGORY,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_DETECTION_TIME")]
        POLICY_VIOLATION_CSV_COLUMN_DETECTION_TIME,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_FRAMEWORK")]
        POLICY_VIOLATION_CSV_COLUMN_FRAMEWORK,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_IDENTITY_NAME")]
        POLICY_VIOLATION_CSV_COLUMN_IDENTITY_NAME,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_IDENTITY_ORIGIN")]
        POLICY_VIOLATION_CSV_COLUMN_IDENTITY_ORIGIN,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_IDENTITY_TITLE")]
        POLICY_VIOLATION_CSV_COLUMN_IDENTITY_TITLE,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_POLICY_NAME")]
        POLICY_VIOLATION_CSV_COLUMN_POLICY_NAME,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_RESOLVED_ON")]
        POLICY_VIOLATION_CSV_COLUMN_RESOLVED_ON,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_SEVERITY")]
        POLICY_VIOLATION_CSV_COLUMN_SEVERITY,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_SOURCE")]
        POLICY_VIOLATION_CSV_COLUMN_SOURCE,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_STATUS")]
        POLICY_VIOLATION_CSV_COLUMN_STATUS,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_TICKET_NUMBER")]
        POLICY_VIOLATION_CSV_COLUMN_TICKET_NUMBER,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_UNSPECIFIED")]
        POLICY_VIOLATION_CSV_COLUMN_UNSPECIFIED,

        [EnumMember(Value = "POLICY_VIOLATION_CSV_COLUMN_VIOLATION_COUNT")]
        POLICY_VIOLATION_CSV_COLUMN_VIOLATION_COUNT


    } // enum PolicyViolationCsvColumn

} // namespace RubrikSecurityCloud.Types