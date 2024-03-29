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
            this List<AddO365OrgResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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