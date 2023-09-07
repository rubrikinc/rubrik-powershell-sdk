// SetupAtlassianSiteReply.cs
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
    #region SetupAtlassianSiteReply
    public class SetupAtlassianSiteReply: BaseType
    {
        #region members

        //      C# -> System.String? ExocomputeSetupTaskchainId
        // GraphQL -> exocomputeSetupTaskchainId: String! (scalar)
        [JsonProperty("exocomputeSetupTaskchainId")]
        public System.String? ExocomputeSetupTaskchainId { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? RefreshTaskchainId
        // GraphQL -> refreshTaskchainId: String! (scalar)
        [JsonProperty("refreshTaskchainId")]
        public System.String? RefreshTaskchainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SetupAtlassianSiteReply";
    }

    public SetupAtlassianSiteReply Set(
        System.String? ExocomputeSetupTaskchainId = null,
        System.String? OrgId = null,
        System.String? RefreshTaskchainId = null
    ) 
    {
        if ( ExocomputeSetupTaskchainId != null ) {
            this.ExocomputeSetupTaskchainId = ExocomputeSetupTaskchainId;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( RefreshTaskchainId != null ) {
            this.RefreshTaskchainId = RefreshTaskchainId;
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
        //      C# -> System.String? ExocomputeSetupTaskchainId
        // GraphQL -> exocomputeSetupTaskchainId: String! (scalar)
        if (this.ExocomputeSetupTaskchainId != null) {
            s += ind + "exocomputeSetupTaskchainId\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> System.String? RefreshTaskchainId
        // GraphQL -> refreshTaskchainId: String! (scalar)
        if (this.RefreshTaskchainId != null) {
            s += ind + "refreshTaskchainId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ExocomputeSetupTaskchainId
        // GraphQL -> exocomputeSetupTaskchainId: String! (scalar)
        if (this.ExocomputeSetupTaskchainId == null && ec.Includes("exocomputeSetupTaskchainId",true))
        {
            this.ExocomputeSetupTaskchainId = "FETCH";
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId == null && ec.Includes("orgId",true))
        {
            this.OrgId = "FETCH";
        }
        //      C# -> System.String? RefreshTaskchainId
        // GraphQL -> refreshTaskchainId: String! (scalar)
        if (this.RefreshTaskchainId == null && ec.Includes("refreshTaskchainId",true))
        {
            this.RefreshTaskchainId = "FETCH";
        }
    }


    #endregion

    } // class SetupAtlassianSiteReply
    
    #endregion

    public static class ListSetupAtlassianSiteReplyExtensions
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
            this List<SetupAtlassianSiteReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SetupAtlassianSiteReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SetupAtlassianSiteReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SetupAtlassianSiteReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types