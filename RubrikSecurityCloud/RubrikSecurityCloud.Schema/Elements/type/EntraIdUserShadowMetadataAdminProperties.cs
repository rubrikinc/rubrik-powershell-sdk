// EntraIdUserShadowMetadataAdminProperties.cs
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
    #region EntraIdUserShadowMetadataAdminProperties
    public class EntraIdUserShadowMetadataAdminProperties: BaseType
    {
        #region members

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID! (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        [JsonProperty("groupName")]
        public System.String? GroupName { get; set; }

        //      C# -> List<System.String>? RoleNames
        // GraphQL -> roleNames: [String!]! (scalar)
        [JsonProperty("roleNames")]
        public List<System.String>? RoleNames { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EntraIdUserShadowMetadataAdminProperties";
    }

    public EntraIdUserShadowMetadataAdminProperties Set(
        System.String? GroupId = null,
        System.String? GroupName = null,
        List<System.String>? RoleNames = null
    ) 
    {
        if ( GroupId != null ) {
            this.GroupId = GroupId;
        }
        if ( GroupName != null ) {
            this.GroupName = GroupName;
        }
        if ( RoleNames != null ) {
            this.RoleNames = RoleNames;
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
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID! (scalar)
        if (this.GroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupId\n" ;
            } else {
                s += ind + "groupId\n" ;
            }
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (this.GroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupName\n" ;
            } else {
                s += ind + "groupName\n" ;
            }
        }
        //      C# -> List<System.String>? RoleNames
        // GraphQL -> roleNames: [String!]! (scalar)
        if (this.RoleNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleNames\n" ;
            } else {
                s += ind + "roleNames\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID! (scalar)
        if (ec.Includes("groupId",true))
        {
            if(this.GroupId == null) {

                this.GroupId = "FETCH";

            } else {


            }
        }
        else if (this.GroupId != null && ec.Excludes("groupId",true))
        {
            this.GroupId = null;
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (ec.Includes("groupName",true))
        {
            if(this.GroupName == null) {

                this.GroupName = "FETCH";

            } else {


            }
        }
        else if (this.GroupName != null && ec.Excludes("groupName",true))
        {
            this.GroupName = null;
        }
        //      C# -> List<System.String>? RoleNames
        // GraphQL -> roleNames: [String!]! (scalar)
        if (ec.Includes("roleNames",true))
        {
            if(this.RoleNames == null) {

                this.RoleNames = new List<System.String>();

            } else {


            }
        }
        else if (this.RoleNames != null && ec.Excludes("roleNames",true))
        {
            this.RoleNames = null;
        }
    }


    #endregion

    } // class EntraIdUserShadowMetadataAdminProperties
    
    #endregion

    public static class ListEntraIdUserShadowMetadataAdminPropertiesExtensions
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
            this List<EntraIdUserShadowMetadataAdminProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EntraIdUserShadowMetadataAdminProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EntraIdUserShadowMetadataAdminProperties> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EntraIdUserShadowMetadataAdminProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EntraIdUserShadowMetadataAdminProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types