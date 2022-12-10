// OraclePdbApplicationContainer.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:58.
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
    #region OraclePdbApplicationContainer
    public class OraclePdbApplicationContainer: IFragment
    {
        #region members
        //      C# -> List<System.String>? ApplicationPdbs
        // GraphQL -> applicationPdbs: [String!]! (scalar)
        [JsonProperty("applicationPdbs")]
        public List<System.String>? ApplicationPdbs { get; set; }

        //      C# -> System.String? ApplicationRoot
        // GraphQL -> applicationRoot: String! (scalar)
        [JsonProperty("applicationRoot")]
        public System.String? ApplicationRoot { get; set; }

        #endregion

    #region methods

    public OraclePdbApplicationContainer Set(
        List<System.String>? ApplicationPdbs = null,
        System.String? ApplicationRoot = null
    ) 
    {
        if ( ApplicationPdbs != null ) {
            this.ApplicationPdbs = ApplicationPdbs;
        }
        if ( ApplicationRoot != null ) {
            this.ApplicationRoot = ApplicationRoot;
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
            //      C# -> List<System.String>? ApplicationPdbs
            // GraphQL -> applicationPdbs: [String!]! (scalar)
            if (this.ApplicationPdbs != null)
            {
                 s += ind + "applicationPdbs\n";

            }
            //      C# -> System.String? ApplicationRoot
            // GraphQL -> applicationRoot: String! (scalar)
            if (this.ApplicationRoot != null)
            {
                 s += ind + "applicationRoot\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? ApplicationPdbs
            // GraphQL -> applicationPdbs: [String!]! (scalar)
            if (this.ApplicationPdbs == null && Exploration.Includes(parent + ".applicationPdbs$"))
            {
                this.ApplicationPdbs = new List<System.String>();
            }
            //      C# -> System.String? ApplicationRoot
            // GraphQL -> applicationRoot: String! (scalar)
            if (this.ApplicationRoot == null && Exploration.Includes(parent + ".applicationRoot$"))
            {
                this.ApplicationRoot = new System.String("FETCH");
            }
        }


    #endregion

    } // class OraclePdbApplicationContainer
    #endregion

    public static class ListOraclePdbApplicationContainerExtensions
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
            this List<OraclePdbApplicationContainer> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OraclePdbApplicationContainer> list, 
            String parent = "")
        {
            var item = new OraclePdbApplicationContainer();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types