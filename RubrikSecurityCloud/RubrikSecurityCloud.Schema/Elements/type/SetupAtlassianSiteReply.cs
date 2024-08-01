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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ExocomputeSetupTaskchainId
        // GraphQL -> exocomputeSetupTaskchainId: String! (scalar)
        if (this.ExocomputeSetupTaskchainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exocomputeSetupTaskchainId\n" ;
            } else {
                s += ind + "exocomputeSetupTaskchainId\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.String? RefreshTaskchainId
        // GraphQL -> refreshTaskchainId: String! (scalar)
        if (this.RefreshTaskchainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "refreshTaskchainId\n" ;
            } else {
                s += ind + "refreshTaskchainId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ExocomputeSetupTaskchainId
        // GraphQL -> exocomputeSetupTaskchainId: String! (scalar)
        if (ec.Includes("exocomputeSetupTaskchainId",true))
        {
            if(this.ExocomputeSetupTaskchainId == null) {

                this.ExocomputeSetupTaskchainId = "FETCH";

            } else {


            }
        }
        else if (this.ExocomputeSetupTaskchainId != null && ec.Excludes("exocomputeSetupTaskchainId",true))
        {
            this.ExocomputeSetupTaskchainId = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.String? RefreshTaskchainId
        // GraphQL -> refreshTaskchainId: String! (scalar)
        if (ec.Includes("refreshTaskchainId",true))
        {
            if(this.RefreshTaskchainId == null) {

                this.RefreshTaskchainId = "FETCH";

            } else {


            }
        }
        else if (this.RefreshTaskchainId != null && ec.Excludes("refreshTaskchainId",true))
        {
            this.RefreshTaskchainId = null;
        }
    }


    #endregion

    } // class SetupAtlassianSiteReply
    
    #endregion

    public static class ListSetupAtlassianSiteReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SetupAtlassianSiteReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SetupAtlassianSiteReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<SetupAtlassianSiteReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types