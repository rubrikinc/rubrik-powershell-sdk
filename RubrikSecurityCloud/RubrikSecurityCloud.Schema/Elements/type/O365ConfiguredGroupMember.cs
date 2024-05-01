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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region O365ConfiguredGroupMember
    public class O365ConfiguredGroupMember: BaseType
    {
        #region members

        //      C# -> O365ConfiguredGroupMemberType? ObjectType
        // GraphQL -> objectType: O365ConfiguredGroupMemberType! (enum)
        [JsonProperty("objectType")]
        public O365ConfiguredGroupMemberType? ObjectType { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365ConfiguredGroupMember";
    }

    public O365ConfiguredGroupMember Set(
        O365ConfiguredGroupMemberType? ObjectType = null,
        System.String? DisplayName = null,
        System.String? Id = null,
        System.String? Pdl = null,
        System.String? Url = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> O365ConfiguredGroupMemberType? ObjectType
        // GraphQL -> objectType: O365ConfiguredGroupMemberType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        if (this.Pdl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pdl\n" ;
            } else {
                s += ind + "pdl\n" ;
            }
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (this.Url != null) {
            if (conf.Flat) {
                s += conf.Prefix + "url\n" ;
            } else {
                s += ind + "url\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> O365ConfiguredGroupMemberType? ObjectType
        // GraphQL -> objectType: O365ConfiguredGroupMemberType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new O365ConfiguredGroupMemberType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
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
        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        if (ec.Includes("pdl",true))
        {
            if(this.Pdl == null) {

                this.Pdl = "FETCH";

            } else {


            }
        }
        else if (this.Pdl != null && ec.Excludes("pdl",true))
        {
            this.Pdl = null;
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (ec.Includes("url",true))
        {
            if(this.Url == null) {

                this.Url = "FETCH";

            } else {


            }
        }
        else if (this.Url != null && ec.Excludes("url",true))
        {
            this.Url = null;
        }
    }


    #endregion

    } // class O365ConfiguredGroupMember
    
    #endregion

    public static class ListO365ConfiguredGroupMemberExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<O365ConfiguredGroupMember> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365ConfiguredGroupMember> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365ConfiguredGroupMember> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365ConfiguredGroupMember());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365ConfiguredGroupMember> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types