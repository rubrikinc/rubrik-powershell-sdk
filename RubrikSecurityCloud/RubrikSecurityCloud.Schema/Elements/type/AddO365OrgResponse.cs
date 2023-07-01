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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> System.String? RefreshOrgTaskchainId
        // GraphQL -> refreshOrgTaskchainId: String! (scalar)
        if (this.RefreshOrgTaskchainId != null) {
            s += ind + "refreshOrgTaskchainId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId == null && Exploration.Includes(parent + ".orgId", true))
        {
            this.OrgId = "FETCH";
        }
        //      C# -> System.String? RefreshOrgTaskchainId
        // GraphQL -> refreshOrgTaskchainId: String! (scalar)
        if (this.RefreshOrgTaskchainId == null && Exploration.Includes(parent + ".refreshOrgTaskchainId", true))
        {
            this.RefreshOrgTaskchainId = "FETCH";
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AddO365OrgResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AddO365OrgResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types