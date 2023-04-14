// GetUserDetailReply.cs
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
    #region GetUserDetailReply
    public class GetUserDetailReply: IFragment
    {
        #region members
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumFilesAccessible
        // GraphQL -> numFilesAccessible: Int! (scalar)
        [JsonProperty("numFilesAccessible")]
        public System.Int32? NumFilesAccessible { get; set; }

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }

        #endregion

    #region methods

    public GetUserDetailReply Set(
        System.String? Location = null,
        System.String? Name = null,
        System.Int32? NumFilesAccessible = null,
        RiskLevelType? Risk = null
    ) 
    {
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumFilesAccessible != null ) {
            this.NumFilesAccessible = NumFilesAccessible;
        }
        if ( Risk != null ) {
            this.Risk = Risk;
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
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location != null)
            {
                 s += ind + "location\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? NumFilesAccessible
            // GraphQL -> numFilesAccessible: Int! (scalar)
            if (this.NumFilesAccessible != null)
            {
                 s += ind + "numFilesAccessible\n";

            }
            //      C# -> RiskLevelType? Risk
            // GraphQL -> risk: RiskLevelType! (enum)
            if (this.Risk != null)
            {
                 s += ind + "risk\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location == null && Exploration.Includes(parent + ".location$"))
            {
                this.Location = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumFilesAccessible
            // GraphQL -> numFilesAccessible: Int! (scalar)
            if (this.NumFilesAccessible == null && Exploration.Includes(parent + ".numFilesAccessible$"))
            {
                this.NumFilesAccessible = new System.Int32();
            }
            //      C# -> RiskLevelType? Risk
            // GraphQL -> risk: RiskLevelType! (enum)
            if (this.Risk == null && Exploration.Includes(parent + ".risk$"))
            {
                this.Risk = new RiskLevelType();
            }
        }


    #endregion

    } // class GetUserDetailReply
    #endregion

    public static class ListGetUserDetailReplyExtensions
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
            this List<GetUserDetailReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetUserDetailReply> list, 
            String parent = "")
        {
            var item = new GetUserDetailReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types