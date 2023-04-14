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

namespace Rubrik.SecurityCloud.Types
{
    #region AddO365OrgResponse
    public class AddO365OrgResponse: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId != null)
            {
                 s += ind + "orgId\n";

            }
            //      C# -> System.String? RefreshOrgTaskchainId
            // GraphQL -> refreshOrgTaskchainId: String! (scalar)
            if (this.RefreshOrgTaskchainId != null)
            {
                 s += ind + "refreshOrgTaskchainId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId == null && Exploration.Includes(parent + ".orgId$"))
            {
                this.OrgId = new System.String("FETCH");
            }
            //      C# -> System.String? RefreshOrgTaskchainId
            // GraphQL -> refreshOrgTaskchainId: String! (scalar)
            if (this.RefreshOrgTaskchainId == null && Exploration.Includes(parent + ".refreshOrgTaskchainId$"))
            {
                this.RefreshOrgTaskchainId = new System.String("FETCH");
            }
        }


    #endregion

    } // class AddO365OrgResponse
    #endregion

    public static class ListAddO365OrgResponseExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<AddO365OrgResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AddO365OrgResponse> list, 
            String parent = "")
        {
            var item = new AddO365OrgResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types