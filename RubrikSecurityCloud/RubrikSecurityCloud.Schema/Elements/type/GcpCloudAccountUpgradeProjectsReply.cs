// GcpCloudAccountUpgradeProjectsReply.cs
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
    #region GcpCloudAccountUpgradeProjectsReply
    public class GcpCloudAccountUpgradeProjectsReply: BaseType
    {
        #region members

        //      C# -> List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses
        // GraphQL -> gcpProjectUpgradeStatuses: [GcpCloudAccountProjectUpgradeStatus!]! (type)
        [JsonProperty("gcpProjectUpgradeStatuses")]
        public List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountUpgradeProjectsReply";
    }

    public GcpCloudAccountUpgradeProjectsReply Set(
        List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses = null
    ) 
    {
        if ( GcpProjectUpgradeStatuses != null ) {
            this.GcpProjectUpgradeStatuses = GcpProjectUpgradeStatuses;
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
        //      C# -> List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses
        // GraphQL -> gcpProjectUpgradeStatuses: [GcpCloudAccountProjectUpgradeStatus!]! (type)
        if (this.GcpProjectUpgradeStatuses != null) {
            var fspec = this.GcpProjectUpgradeStatuses.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "gcpProjectUpgradeStatuses {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses
        // GraphQL -> gcpProjectUpgradeStatuses: [GcpCloudAccountProjectUpgradeStatus!]! (type)
        if (this.GcpProjectUpgradeStatuses == null && ec.Includes("gcpProjectUpgradeStatuses",false))
        {
            this.GcpProjectUpgradeStatuses = new List<GcpCloudAccountProjectUpgradeStatus>();
            this.GcpProjectUpgradeStatuses.ApplyExploratoryFieldSpec(ec.NewChild("gcpProjectUpgradeStatuses"));
        }
    }


    #endregion

    } // class GcpCloudAccountUpgradeProjectsReply
    
    #endregion

    public static class ListGcpCloudAccountUpgradeProjectsReplyExtensions
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
            this List<GcpCloudAccountUpgradeProjectsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountUpgradeProjectsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountUpgradeProjectsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GcpCloudAccountUpgradeProjectsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types