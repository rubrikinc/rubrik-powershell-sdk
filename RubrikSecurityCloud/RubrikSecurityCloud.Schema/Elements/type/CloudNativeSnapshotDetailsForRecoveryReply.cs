// CloudNativeSnapshotDetailsForRecoveryReply.cs
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
    #region CloudNativeSnapshotDetailsForRecoveryReply
    public class CloudNativeSnapshotDetailsForRecoveryReply: BaseType
    {
        #region members

        //      C# -> List<CloudNativeSnapshotDetailsForRecovery>? SnapshotDetails
        // GraphQL -> snapshotDetails: [CloudNativeSnapshotDetailsForRecovery!]! (type)
        [JsonProperty("snapshotDetails")]
        public List<CloudNativeSnapshotDetailsForRecovery>? SnapshotDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeSnapshotDetailsForRecoveryReply";
    }

    public CloudNativeSnapshotDetailsForRecoveryReply Set(
        List<CloudNativeSnapshotDetailsForRecovery>? SnapshotDetails = null
    ) 
    {
        if ( SnapshotDetails != null ) {
            this.SnapshotDetails = SnapshotDetails;
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
        //      C# -> List<CloudNativeSnapshotDetailsForRecovery>? SnapshotDetails
        // GraphQL -> snapshotDetails: [CloudNativeSnapshotDetailsForRecovery!]! (type)
        if (this.SnapshotDetails != null) {
            var fspec = this.SnapshotDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<CloudNativeSnapshotDetailsForRecovery>? SnapshotDetails
        // GraphQL -> snapshotDetails: [CloudNativeSnapshotDetailsForRecovery!]! (type)
        if (this.SnapshotDetails == null && ec.Includes("snapshotDetails",false))
        {
            this.SnapshotDetails = new List<CloudNativeSnapshotDetailsForRecovery>();
            this.SnapshotDetails.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDetails"));
        }
    }


    #endregion

    } // class CloudNativeSnapshotDetailsForRecoveryReply
    
    #endregion

    public static class ListCloudNativeSnapshotDetailsForRecoveryReplyExtensions
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
            this List<CloudNativeSnapshotDetailsForRecoveryReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeSnapshotDetailsForRecoveryReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeSnapshotDetailsForRecoveryReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeSnapshotDetailsForRecoveryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types