// IntuneScopeTagAssignment.cs
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
    #region IntuneScopeTagAssignment
    public class IntuneScopeTagAssignment: BaseType
    {
        #region members

        //      C# -> IntunePolicyAssignmentType? Type
        // GraphQL -> type: IntunePolicyAssignmentType! (enum)
        [JsonProperty("type")]
        public IntunePolicyAssignmentType? Type { get; set; }

        //      C# -> System.String? FilterId
        // GraphQL -> filterId: String (scalar)
        [JsonProperty("filterId")]
        public System.String? FilterId { get; set; }

        //      C# -> System.String? FilterName
        // GraphQL -> filterName: String (scalar)
        [JsonProperty("filterName")]
        public System.String? FilterName { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        [JsonProperty("groupName")]
        public System.String? GroupName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? ScopeTagId
        // GraphQL -> scopeTagId: String! (scalar)
        [JsonProperty("scopeTagId")]
        public System.String? ScopeTagId { get; set; }

        //      C# -> System.String? ScopeTagName
        // GraphQL -> scopeTagName: String! (scalar)
        [JsonProperty("scopeTagName")]
        public System.String? ScopeTagName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntuneScopeTagAssignment";
    }

    public IntuneScopeTagAssignment Set(
        IntunePolicyAssignmentType? Type = null,
        System.String? FilterId = null,
        System.String? FilterName = null,
        System.String? GroupId = null,
        System.String? GroupName = null,
        System.String? Id = null,
        System.String? ScopeTagId = null,
        System.String? ScopeTagName = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( FilterId != null ) {
            this.FilterId = FilterId;
        }
        if ( FilterName != null ) {
            this.FilterName = FilterName;
        }
        if ( GroupId != null ) {
            this.GroupId = GroupId;
        }
        if ( GroupName != null ) {
            this.GroupName = GroupName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( ScopeTagId != null ) {
            this.ScopeTagId = ScopeTagId;
        }
        if ( ScopeTagName != null ) {
            this.ScopeTagName = ScopeTagName;
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
        //      C# -> IntunePolicyAssignmentType? Type
        // GraphQL -> type: IntunePolicyAssignmentType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.String? FilterId
        // GraphQL -> filterId: String (scalar)
        if (this.FilterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filterId\n" ;
            } else {
                s += ind + "filterId\n" ;
            }
        }
        //      C# -> System.String? FilterName
        // GraphQL -> filterName: String (scalar)
        if (this.FilterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filterName\n" ;
            } else {
                s += ind + "filterName\n" ;
            }
        }
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? ScopeTagId
        // GraphQL -> scopeTagId: String! (scalar)
        if (this.ScopeTagId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scopeTagId\n" ;
            } else {
                s += ind + "scopeTagId\n" ;
            }
        }
        //      C# -> System.String? ScopeTagName
        // GraphQL -> scopeTagName: String! (scalar)
        if (this.ScopeTagName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scopeTagName\n" ;
            } else {
                s += ind + "scopeTagName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IntunePolicyAssignmentType? Type
        // GraphQL -> type: IntunePolicyAssignmentType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new IntunePolicyAssignmentType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.String? FilterId
        // GraphQL -> filterId: String (scalar)
        if (ec.Includes("filterId",true))
        {
            if(this.FilterId == null) {

                this.FilterId = "FETCH";

            } else {


            }
        }
        else if (this.FilterId != null && ec.Excludes("filterId",true))
        {
            this.FilterId = null;
        }
        //      C# -> System.String? FilterName
        // GraphQL -> filterName: String (scalar)
        if (ec.Includes("filterName",true))
        {
            if(this.FilterName == null) {

                this.FilterName = "FETCH";

            } else {


            }
        }
        else if (this.FilterName != null && ec.Excludes("filterName",true))
        {
            this.FilterName = null;
        }
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.String? ScopeTagId
        // GraphQL -> scopeTagId: String! (scalar)
        if (ec.Includes("scopeTagId",true))
        {
            if(this.ScopeTagId == null) {

                this.ScopeTagId = "FETCH";

            } else {


            }
        }
        else if (this.ScopeTagId != null && ec.Excludes("scopeTagId",true))
        {
            this.ScopeTagId = null;
        }
        //      C# -> System.String? ScopeTagName
        // GraphQL -> scopeTagName: String! (scalar)
        if (ec.Includes("scopeTagName",true))
        {
            if(this.ScopeTagName == null) {

                this.ScopeTagName = "FETCH";

            } else {


            }
        }
        else if (this.ScopeTagName != null && ec.Excludes("scopeTagName",true))
        {
            this.ScopeTagName = null;
        }
    }


    #endregion

    } // class IntuneScopeTagAssignment
    
    #endregion

    public static class ListIntuneScopeTagAssignmentExtensions
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
            this List<IntuneScopeTagAssignment> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntuneScopeTagAssignment> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntuneScopeTagAssignment> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntuneScopeTagAssignment());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntuneScopeTagAssignment> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types