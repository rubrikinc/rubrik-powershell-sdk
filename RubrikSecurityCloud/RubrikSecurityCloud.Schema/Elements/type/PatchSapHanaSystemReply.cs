// PatchSapHanaSystemReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region PatchSapHanaSystemReply
    public class PatchSapHanaSystemReply: BaseType
    {
        #region members

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        //      C# -> SapHanaSystemSummary? SystemSummary
        // GraphQL -> systemSummary: SapHanaSystemSummary (type)
        [JsonProperty("systemSummary")]
        public SapHanaSystemSummary? SystemSummary { get; set; }


        #endregion

    #region methods

    public PatchSapHanaSystemReply Set(
        AsyncRequestStatus? AsyncRequestStatus = null,
        SapHanaSystemSummary? SystemSummary = null
    ) 
    {
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
        }
        if ( SystemSummary != null ) {
            this.SystemSummary = SystemSummary;
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
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus != null) {
            var fspec = this.AsyncRequestStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "asyncRequestStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SapHanaSystemSummary? SystemSummary
        // GraphQL -> systemSummary: SapHanaSystemSummary (type)
        if (this.SystemSummary != null) {
            var fspec = this.SystemSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "systemSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus == null && Exploration.Includes(parent + ".asyncRequestStatus"))
        {
            this.AsyncRequestStatus = new AsyncRequestStatus();
            this.AsyncRequestStatus.ApplyExploratoryFieldSpec(parent + ".asyncRequestStatus");
        }
        //      C# -> SapHanaSystemSummary? SystemSummary
        // GraphQL -> systemSummary: SapHanaSystemSummary (type)
        if (this.SystemSummary == null && Exploration.Includes(parent + ".systemSummary"))
        {
            this.SystemSummary = new SapHanaSystemSummary();
            this.SystemSummary.ApplyExploratoryFieldSpec(parent + ".systemSummary");
        }
    }


    #endregion

    } // class PatchSapHanaSystemReply
    
    #endregion

    public static class ListPatchSapHanaSystemReplyExtensions
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
            this List<PatchSapHanaSystemReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PatchSapHanaSystemReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PatchSapHanaSystemReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types