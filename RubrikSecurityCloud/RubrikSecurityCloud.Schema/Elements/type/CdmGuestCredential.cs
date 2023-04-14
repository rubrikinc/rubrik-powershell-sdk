// CdmGuestCredential.cs
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
    #region CdmGuestCredential
    public class CdmGuestCredential: IFragment
    {
        #region members
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> CreateGuestCredentialReply? Detail
        // GraphQL -> detail: CreateGuestCredentialReply! (type)
        [JsonProperty("detail")]
        public CreateGuestCredentialReply? Detail { get; set; }

        #endregion

    #region methods

    public CdmGuestCredential Set(
        Cluster? Cluster = null,
        CreateGuestCredentialReply? Detail = null
    ) 
    {
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Detail != null ) {
            this.Detail = Detail;
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
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CreateGuestCredentialReply? Detail
            // GraphQL -> detail: CreateGuestCredentialReply! (type)
            if (this.Detail != null)
            {
                 s += ind + "detail\n";

                 s += ind + "{\n" + 
                 this.Detail.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> CreateGuestCredentialReply? Detail
            // GraphQL -> detail: CreateGuestCredentialReply! (type)
            if (this.Detail == null && Exploration.Includes(parent + ".detail"))
            {
                this.Detail = new CreateGuestCredentialReply();
                this.Detail.ApplyExploratoryFragment(parent + ".detail");
            }
        }


    #endregion

    } // class CdmGuestCredential
    #endregion

    public static class ListCdmGuestCredentialExtensions
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
            this List<CdmGuestCredential> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmGuestCredential> list, 
            String parent = "")
        {
            var item = new CdmGuestCredential();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types