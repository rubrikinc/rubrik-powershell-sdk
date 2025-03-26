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

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

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

    public override string GetGqlTypeName() {
        return "O365TeamsChannel";
    }

    public O365TeamsChannel Set(
        ChannelMembershipType? MembershipType = null,
        System.String? FolderId = null,
        System.String? FolderName = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
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
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ChannelMembershipType? MembershipType
        // GraphQL -> membershipType: ChannelMembershipType (enum)
        if (this.MembershipType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "membershipType\n" ;
            } else {
                s += ind + "membershipType\n" ;
            }
        }
        //      C# -> System.String? FolderId
        // GraphQL -> folderId: String (scalar)
        if (this.FolderId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "folderId\n" ;
            } else {
                s += ind + "folderId\n" ;
            }
        }
        //      C# -> System.String? FolderName
        // GraphQL -> folderName: String (scalar)
        if (this.FolderName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "folderName\n" ;
            } else {
                s += ind + "folderName\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String (scalar)
        if (this.NaturalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "naturalId\n" ;
            } else {
                s += ind + "naturalId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ChannelMembershipType? MembershipType
        // GraphQL -> membershipType: ChannelMembershipType (enum)
        if (ec.Includes("membershipType",true))
        {
            if(this.MembershipType == null) {

                this.MembershipType = new ChannelMembershipType();

            } else {


            }
        }
        else if (this.MembershipType != null && ec.Excludes("membershipType",true))
        {
            this.MembershipType = null;
        }
        //      C# -> System.String? FolderId
        // GraphQL -> folderId: String (scalar)
        if (ec.Includes("folderId",true))
        {
            if(this.FolderId == null) {

                this.FolderId = "FETCH";

            } else {


            }
        }
        else if (this.FolderId != null && ec.Excludes("folderId",true))
        {
            this.FolderId = null;
        }
        //      C# -> System.String? FolderName
        // GraphQL -> folderName: String (scalar)
        if (ec.Includes("folderName",true))
        {
            if(this.FolderName == null) {

                this.FolderName = "FETCH";

            } else {


            }
        }
        else if (this.FolderName != null && ec.Excludes("folderName",true))
        {
            this.FolderName = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String (scalar)
        if (ec.Includes("naturalId",true))
        {
            if(this.NaturalId == null) {

                this.NaturalId = "FETCH";

            } else {


            }
        }
        else if (this.NaturalId != null && ec.Excludes("naturalId",true))
        {
            this.NaturalId = null;
        }
    }


    #endregion

    } // class O365TeamsChannel
    
    #endregion

    public static class ListO365TeamsChannelExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<O365TeamsChannel> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365TeamsChannel> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365TeamsChannel> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365TeamsChannel());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365TeamsChannel> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types