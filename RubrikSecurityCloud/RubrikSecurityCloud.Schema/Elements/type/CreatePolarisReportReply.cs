// CreatePolarisReportReply.cs
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
    #region CreatePolarisReportReply
    public class CreatePolarisReportReply: BaseType
    {
        #region members

        //      C# -> System.Int64? ReportId
        // GraphQL -> reportId: Long! (scalar)
        [JsonProperty("reportId")]
        public System.Int64? ReportId { get; set; }


        #endregion

    #region methods

    public CreatePolarisReportReply Set(
        System.Int64? ReportId = null
    ) 
    {
        if ( ReportId != null ) {
            this.ReportId = ReportId;
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
        //      C# -> System.Int64? ReportId
        // GraphQL -> reportId: Long! (scalar)
        if (this.ReportId != null) {
            s += ind + "reportId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? ReportId
        // GraphQL -> reportId: Long! (scalar)
        if (this.ReportId == null && Exploration.Includes(parent + ".reportId", true))
        {
            this.ReportId = new System.Int64();
        }
    }


    #endregion

    } // class CreatePolarisReportReply
    
    #endregion

    public static class ListCreatePolarisReportReplyExtensions
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
            this List<CreatePolarisReportReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreatePolarisReportReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CreatePolarisReportReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types