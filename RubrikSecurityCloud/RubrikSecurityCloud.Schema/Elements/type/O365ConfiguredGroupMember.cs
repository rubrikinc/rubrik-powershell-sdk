// O365ConfiguredGroupMember.cs
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
    #region O365ConfiguredGroupMember
    public class O365ConfiguredGroupMember: IFragment
    {
        #region members
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        [JsonProperty("pdl")]
        public System.String? Pdl { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }

        //      C# -> O365ConfiguredGroupMemberType? ObjectType
        // GraphQL -> objectType: O365ConfiguredGroupMemberType! (enum)
        [JsonProperty("objectType")]
        public O365ConfiguredGroupMemberType? ObjectType { get; set; }

        #endregion

    #region methods

    public O365ConfiguredGroupMember Set(
        System.String? DisplayName = null,
        System.String? Id = null,
        System.String? Pdl = null,
        System.String? Url = null,
        O365ConfiguredGroupMemberType? ObjectType = null
    ) 
    {
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Pdl != null ) {
            this.Pdl = Pdl;
        }
        if ( Url != null ) {
            this.Url = Url;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
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
            //      C# -> System.String? DisplayName
            // GraphQL -> displayName: String! (scalar)
            if (this.DisplayName != null)
            {
                 s += ind + "displayName\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Pdl
            // GraphQL -> pdl: String! (scalar)
            if (this.Pdl != null)
            {
                 s += ind + "pdl\n";

            }
            //      C# -> System.String? Url
            // GraphQL -> url: String! (scalar)
            if (this.Url != null)
            {
                 s += ind + "url\n";

            }
            //      C# -> O365ConfiguredGroupMemberType? ObjectType
            // GraphQL -> objectType: O365ConfiguredGroupMemberType! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DisplayName
            // GraphQL -> displayName: String! (scalar)
            if (this.DisplayName == null && Exploration.Includes(parent + ".displayName$"))
            {
                this.DisplayName = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Pdl
            // GraphQL -> pdl: String! (scalar)
            if (this.Pdl == null && Exploration.Includes(parent + ".pdl$"))
            {
                this.Pdl = new System.String("FETCH");
            }
            //      C# -> System.String? Url
            // GraphQL -> url: String! (scalar)
            if (this.Url == null && Exploration.Includes(parent + ".url$"))
            {
                this.Url = new System.String("FETCH");
            }
            //      C# -> O365ConfiguredGroupMemberType? ObjectType
            // GraphQL -> objectType: O365ConfiguredGroupMemberType! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new O365ConfiguredGroupMemberType();
            }
        }


    #endregion

    } // class O365ConfiguredGroupMember
    #endregion

    public static class ListO365ConfiguredGroupMemberExtensions
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
            this List<O365ConfiguredGroupMember> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365ConfiguredGroupMember> list, 
            String parent = "")
        {
            var item = new O365ConfiguredGroupMember();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types