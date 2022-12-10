// O365TeamsChannel.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:52.
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
    #region O365TeamsChannel
 
    public class O365TeamsChannel: IFragment, O365TeamsChannelObject
    {
        #region members
        //      C# -> System.String? FolderId
        // GraphQL -> folderId: String (scalar)
        [JsonProperty("folderId")]
        public System.String? FolderId { get; set; }

        //      C# -> System.String? FolderName
        // GraphQL -> folderName: String (scalar)
        [JsonProperty("folderName")]
        public System.String? FolderName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String (scalar)
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }

        //      C# -> ChannelMembershipType? MembershipType
        // GraphQL -> membershipType: ChannelMembershipType (enum)
        [JsonProperty("membershipType")]
        public ChannelMembershipType? MembershipType { get; set; }

        #endregion

    #region methods

    public O365TeamsChannel Set(
        System.String? FolderId = null,
        System.String? FolderName = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? NaturalId = null,
        ChannelMembershipType? MembershipType = null
    ) 
    {
        if ( FolderId != null ) {
            this.FolderId = FolderId;
        }
        if ( FolderName != null ) {
            this.FolderName = FolderName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NaturalId != null ) {
            this.NaturalId = NaturalId;
        }
        if ( MembershipType != null ) {
            this.MembershipType = MembershipType;
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
            //      C# -> System.String? FolderId
            // GraphQL -> folderId: String (scalar)
            if (this.FolderId != null)
            {
                 s += ind + "folderId\n";

            }
            //      C# -> System.String? FolderName
            // GraphQL -> folderName: String (scalar)
            if (this.FolderName != null)
            {
                 s += ind + "folderName\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? NaturalId
            // GraphQL -> naturalId: String (scalar)
            if (this.NaturalId != null)
            {
                 s += ind + "naturalId\n";

            }
            //      C# -> ChannelMembershipType? MembershipType
            // GraphQL -> membershipType: ChannelMembershipType (enum)
            if (this.MembershipType != null)
            {
                 s += ind + "membershipType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? FolderId
            // GraphQL -> folderId: String (scalar)
            if (this.FolderId == null && Exploration.Includes(parent + ".folderId$"))
            {
                this.FolderId = new System.String("FETCH");
            }
            //      C# -> System.String? FolderName
            // GraphQL -> folderName: String (scalar)
            if (this.FolderName == null && Exploration.Includes(parent + ".folderName$"))
            {
                this.FolderName = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? NaturalId
            // GraphQL -> naturalId: String (scalar)
            if (this.NaturalId == null && Exploration.Includes(parent + ".naturalId$"))
            {
                this.NaturalId = new System.String("FETCH");
            }
            //      C# -> ChannelMembershipType? MembershipType
            // GraphQL -> membershipType: ChannelMembershipType (enum)
            if (this.MembershipType == null && Exploration.Includes(parent + ".membershipType$"))
            {
                this.MembershipType = new ChannelMembershipType();
            }
        }


    #endregion

    } // class O365TeamsChannel
    #endregion

    public static class ListO365TeamsChannelExtensions
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
            this List<O365TeamsChannel> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365TeamsChannel> list, 
            String parent = "")
        {
            var item = new O365TeamsChannel();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types