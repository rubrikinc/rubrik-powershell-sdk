// O365TeamsChannel.cs
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
    #region O365TeamsChannel
 
    public class O365TeamsChannel: BaseType, O365TeamsChannelObject
    {
        #region members

        //      C# -> ChannelMembershipType? MembershipType
        // GraphQL -> membershipType: ChannelMembershipType (enum)
        [JsonProperty("membershipType")]
        public ChannelMembershipType? MembershipType { get; set; }

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


        #endregion

    #region methods

    public O365TeamsChannel Set(
        ChannelMembershipType? MembershipType = null,
        System.String? FolderId = null,
        System.String? FolderName = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? NaturalId = null
    ) 
    {
        if ( MembershipType != null ) {
            this.MembershipType = MembershipType;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ChannelMembershipType? MembershipType
        // GraphQL -> membershipType: ChannelMembershipType (enum)
        if (this.MembershipType != null) {
            s += ind + "membershipType\n" ;
        }
        //      C# -> System.String? FolderId
        // GraphQL -> folderId: String (scalar)
        if (this.FolderId != null) {
            s += ind + "folderId\n" ;
        }
        //      C# -> System.String? FolderName
        // GraphQL -> folderName: String (scalar)
        if (this.FolderName != null) {
            s += ind + "folderName\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String (scalar)
        if (this.NaturalId != null) {
            s += ind + "naturalId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ChannelMembershipType? MembershipType
        // GraphQL -> membershipType: ChannelMembershipType (enum)
        if (this.MembershipType == null && Exploration.Includes(parent + ".membershipType", true))
        {
            this.MembershipType = new ChannelMembershipType();
        }
        //      C# -> System.String? FolderId
        // GraphQL -> folderId: String (scalar)
        if (this.FolderId == null && Exploration.Includes(parent + ".folderId", true))
        {
            this.FolderId = "FETCH";
        }
        //      C# -> System.String? FolderName
        // GraphQL -> folderName: String (scalar)
        if (this.FolderName == null && Exploration.Includes(parent + ".folderName", true))
        {
            this.FolderName = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String (scalar)
        if (this.NaturalId == null && Exploration.Includes(parent + ".naturalId", true))
        {
            this.NaturalId = "FETCH";
        }
    }


    #endregion

    } // class O365TeamsChannel
    
    #endregion

    public static class ListO365TeamsChannelExtensions
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
            this List<O365TeamsChannel> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365TeamsChannel> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365TeamsChannel());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types