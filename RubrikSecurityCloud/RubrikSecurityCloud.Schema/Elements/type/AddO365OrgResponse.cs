// AddO365OrgResponse.cs
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
    #region AddO365OrgResponse
    public class AddO365OrgResponse: BaseType
    {
        #region members

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? RefreshOrgTaskchainId
        // GraphQL -> refreshOrgTaskchainId: String! (scalar)
        [JsonProperty("refreshOrgTaskchainId")]
        public System.String? RefreshOrgTaskchainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddO365OrgResponse";
    }

    public AddO365OrgResponse Set(
        System.String? OrgId = null,
        System.String? RefreshOrgTaskchainId = null
    ) 
    {
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( RefreshOrgTaskchainId != null ) {
            this.RefreshOrgTaskchainId = RefreshOrgTaskchainId;
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
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.String? RefreshOrgTaskchainId
        // GraphQL -> refreshOrgTaskchainId: String! (scalar)
        if (this.RefreshOrgTaskchainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "refreshOrgTaskchainId\n" ;
            } else {
                s += ind + "refreshOrgTaskchainId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.String? RefreshOrgTaskchainId
        // GraphQL -> refreshOrgTaskchainId: String! (scalar)
        if (ec.Includes("refreshOrgTaskchainId",true))
        {
            if(this.RefreshOrgTaskchainId == null) {

                this.RefreshOrgTaskchainId = "FETCH";

            } else {


            }
        }
        else if (this.RefreshOrgTaskchainId != null && ec.Excludes("refreshOrgTaskchainId",true))
        {
            this.RefreshOrgTaskchainId = null;
        }
    }


    #endregion

    } // class AddO365OrgResponse
    
    #endregion

    public static class ListAddO365OrgResponseExtensions
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
            this List<AddO365OrgResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AddO365OrgResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AddO365OrgResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddO365OrgResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddO365OrgResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types