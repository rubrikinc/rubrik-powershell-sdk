// PatchDb2InstanceReply.cs
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
    #region PatchDb2InstanceReply
    public class PatchDb2InstanceReply: BaseType
    {
        #region members

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        //      C# -> Db2InstanceSummary? Db2InstanceSummary
        // GraphQL -> db2InstanceSummary: Db2InstanceSummary (type)
        [JsonProperty("db2InstanceSummary")]
        public Db2InstanceSummary? Db2InstanceSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PatchDb2InstanceReply";
    }

    public PatchDb2InstanceReply Set(
        AsyncRequestStatus? AsyncRequestStatus = null,
        Db2InstanceSummary? Db2InstanceSummary = null
    ) 
    {
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
        }
        if ( Db2InstanceSummary != null ) {
            this.Db2InstanceSummary = Db2InstanceSummary;
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
        //      C# -> Db2InstanceSummary? Db2InstanceSummary
        // GraphQL -> db2InstanceSummary: Db2InstanceSummary (type)
        if (this.Db2InstanceSummary != null) {
            var fspec = this.Db2InstanceSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "db2InstanceSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus == null && ec.Includes("asyncRequestStatus",false))
        {
            this.AsyncRequestStatus = new AsyncRequestStatus();
            this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));
        }
        //      C# -> Db2InstanceSummary? Db2InstanceSummary
        // GraphQL -> db2InstanceSummary: Db2InstanceSummary (type)
        if (this.Db2InstanceSummary == null && ec.Includes("db2InstanceSummary",false))
        {
            this.Db2InstanceSummary = new Db2InstanceSummary();
            this.Db2InstanceSummary.ApplyExploratoryFieldSpec(ec.NewChild("db2InstanceSummary"));
        }
    }


    #endregion

    } // class PatchDb2InstanceReply
    
    #endregion

    public static class ListPatchDb2InstanceReplyExtensions
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
            this List<PatchDb2InstanceReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PatchDb2InstanceReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PatchDb2InstanceReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<PatchDb2InstanceReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types