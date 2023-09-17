// StartThreatHuntReply.cs
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
    #region StartThreatHuntReply
    public class StartThreatHuntReply: BaseType
    {
        #region members

        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        [JsonProperty("huntId")]
        public System.String? HuntId { get; set; }

        //      C# -> System.Boolean? IsSyncSuccessful
        // GraphQL -> isSyncSuccessful: Boolean! (scalar)
        [JsonProperty("isSyncSuccessful")]
        public System.Boolean? IsSyncSuccessful { get; set; }

        //      C# -> AsyncRequestStatus? HuntStatus
        // GraphQL -> huntStatus: AsyncRequestStatus (type)
        [JsonProperty("huntStatus")]
        public AsyncRequestStatus? HuntStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StartThreatHuntReply";
    }

    public StartThreatHuntReply Set(
        System.String? HuntId = null,
        System.Boolean? IsSyncSuccessful = null,
        AsyncRequestStatus? HuntStatus = null
    ) 
    {
        if ( HuntId != null ) {
            this.HuntId = HuntId;
        }
        if ( IsSyncSuccessful != null ) {
            this.IsSyncSuccessful = IsSyncSuccessful;
        }
        if ( HuntStatus != null ) {
            this.HuntStatus = HuntStatus;
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
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        if (this.HuntId != null) {
            s += ind + "huntId\n" ;
        }
        //      C# -> System.Boolean? IsSyncSuccessful
        // GraphQL -> isSyncSuccessful: Boolean! (scalar)
        if (this.IsSyncSuccessful != null) {
            s += ind + "isSyncSuccessful\n" ;
        }
        //      C# -> AsyncRequestStatus? HuntStatus
        // GraphQL -> huntStatus: AsyncRequestStatus (type)
        if (this.HuntStatus != null) {
            var fspec = this.HuntStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "huntStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        if (this.HuntId == null && ec.Includes("huntId",true))
        {
            this.HuntId = "FETCH";
        }
        //      C# -> System.Boolean? IsSyncSuccessful
        // GraphQL -> isSyncSuccessful: Boolean! (scalar)
        if (this.IsSyncSuccessful == null && ec.Includes("isSyncSuccessful",true))
        {
            this.IsSyncSuccessful = true;
        }
        //      C# -> AsyncRequestStatus? HuntStatus
        // GraphQL -> huntStatus: AsyncRequestStatus (type)
        if (this.HuntStatus == null && ec.Includes("huntStatus",false))
        {
            this.HuntStatus = new AsyncRequestStatus();
            this.HuntStatus.ApplyExploratoryFieldSpec(ec.NewChild("huntStatus"));
        }
    }


    #endregion

    } // class StartThreatHuntReply
    
    #endregion

    public static class ListStartThreatHuntReplyExtensions
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
            this List<StartThreatHuntReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<StartThreatHuntReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StartThreatHuntReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StartThreatHuntReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types