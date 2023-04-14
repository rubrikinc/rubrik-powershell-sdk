// OraclePdbDetails.cs
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
    #region OraclePdbDetails
    public class OraclePdbDetails: IFragment
    {
        #region members
        //      C# -> List<System.String>? RegularPdbs
        // GraphQL -> regularPdbs: [String!]! (scalar)
        [JsonProperty("regularPdbs")]
        public List<System.String>? RegularPdbs { get; set; }

        //      C# -> List<OraclePdbApplicationContainer>? ApplicationContainers
        // GraphQL -> applicationContainers: [OraclePdbApplicationContainer!]! (type)
        [JsonProperty("applicationContainers")]
        public List<OraclePdbApplicationContainer>? ApplicationContainers { get; set; }

        #endregion

    #region methods

    public OraclePdbDetails Set(
        List<System.String>? RegularPdbs = null,
        List<OraclePdbApplicationContainer>? ApplicationContainers = null
    ) 
    {
        if ( RegularPdbs != null ) {
            this.RegularPdbs = RegularPdbs;
        }
        if ( ApplicationContainers != null ) {
            this.ApplicationContainers = ApplicationContainers;
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
            //      C# -> List<System.String>? RegularPdbs
            // GraphQL -> regularPdbs: [String!]! (scalar)
            if (this.RegularPdbs != null)
            {
                 s += ind + "regularPdbs\n";

            }
            //      C# -> List<OraclePdbApplicationContainer>? ApplicationContainers
            // GraphQL -> applicationContainers: [OraclePdbApplicationContainer!]! (type)
            if (this.ApplicationContainers != null)
            {
                 s += ind + "applicationContainers\n";

                 s += ind + "{\n" + 
                 this.ApplicationContainers.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? RegularPdbs
            // GraphQL -> regularPdbs: [String!]! (scalar)
            if (this.RegularPdbs == null && Exploration.Includes(parent + ".regularPdbs$"))
            {
                this.RegularPdbs = new List<System.String>();
            }
            //      C# -> List<OraclePdbApplicationContainer>? ApplicationContainers
            // GraphQL -> applicationContainers: [OraclePdbApplicationContainer!]! (type)
            if (this.ApplicationContainers == null && Exploration.Includes(parent + ".applicationContainers"))
            {
                this.ApplicationContainers = new List<OraclePdbApplicationContainer>();
                this.ApplicationContainers.ApplyExploratoryFragment(parent + ".applicationContainers");
            }
        }


    #endregion

    } // class OraclePdbDetails
    #endregion

    public static class ListOraclePdbDetailsExtensions
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
            this List<OraclePdbDetails> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OraclePdbDetails> list, 
            String parent = "")
        {
            var item = new OraclePdbDetails();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types