// FailoverReport.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region FailoverReport
    public class FailoverReport: BaseType
    {
        #region members

        //      C# -> AppflowsBlueprintFailoverReportStatusEnum? Status
        // GraphQL -> status: AppflowsBlueprintFailoverReportStatusEnum! (enum)
        [JsonProperty("status")]
        public AppflowsBlueprintFailoverReportStatusEnum? Status { get; set; }

        //      C# -> DateTime? ExpireTime
        // GraphQL -> expireTime: DateTime! (scalar)
        [JsonProperty("expireTime")]
        public DateTime? ExpireTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? ReportUrl
        // GraphQL -> reportUrl: String (scalar)
        [JsonProperty("reportUrl")]
        public System.String? ReportUrl { get; set; }


        #endregion

    #region methods

    public FailoverReport Set(
        AppflowsBlueprintFailoverReportStatusEnum? Status = null,
        DateTime? ExpireTime = null,
        System.String? Id = null,
        System.String? ReportUrl = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ExpireTime != null ) {
            this.ExpireTime = ExpireTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( ReportUrl != null ) {
            this.ReportUrl = ReportUrl;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> AppflowsBlueprintFailoverReportStatusEnum? Status
        // GraphQL -> status: AppflowsBlueprintFailoverReportStatusEnum! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> DateTime? ExpireTime
        // GraphQL -> expireTime: DateTime! (scalar)
        if (this.ExpireTime != null) {
            s += ind + "expireTime\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? ReportUrl
        // GraphQL -> reportUrl: String (scalar)
        if (this.ReportUrl != null) {
            s += ind + "reportUrl\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AppflowsBlueprintFailoverReportStatusEnum? Status
        // GraphQL -> status: AppflowsBlueprintFailoverReportStatusEnum! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new AppflowsBlueprintFailoverReportStatusEnum();
        }
        //      C# -> DateTime? ExpireTime
        // GraphQL -> expireTime: DateTime! (scalar)
        if (this.ExpireTime == null && Exploration.Includes(parent + ".expireTime", true))
        {
            this.ExpireTime = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? ReportUrl
        // GraphQL -> reportUrl: String (scalar)
        if (this.ReportUrl == null && Exploration.Includes(parent + ".reportUrl", true))
        {
            this.ReportUrl = "FETCH";
        }
    }


    #endregion

    } // class FailoverReport
    
    #endregion

    public static class ListFailoverReportExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<FailoverReport> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FailoverReport> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverReport());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types