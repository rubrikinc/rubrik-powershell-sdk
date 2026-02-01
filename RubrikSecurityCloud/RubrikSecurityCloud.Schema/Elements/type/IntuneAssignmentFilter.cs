// IntuneAssignmentFilter.cs
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
    #region IntuneAssignmentFilter
    public class IntuneAssignmentFilter: BaseType
    {
        #region members

        //      C# -> IntuneAssignmentFilterManagementType? FilterType
        // GraphQL -> filterType: IntuneAssignmentFilterManagementType! (enum)
        [JsonProperty("filterType")]
        public IntuneAssignmentFilterManagementType? FilterType { get; set; }

        //      C# -> IntuneDevicePlatformType? Platform
        // GraphQL -> platform: IntuneDevicePlatformType! (enum)
        [JsonProperty("platform")]
        public IntuneDevicePlatformType? Platform { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> DateTime? LastModifiedTime
        // GraphQL -> lastModifiedTime: DateTime (scalar)
        [JsonProperty("lastModifiedTime")]
        public DateTime? LastModifiedTime { get; set; }

        //      C# -> List<System.String>? RoleScopeTags
        // GraphQL -> roleScopeTags: [String!]! (scalar)
        [JsonProperty("roleScopeTags")]
        public List<System.String>? RoleScopeTags { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntuneAssignmentFilter";
    }

    public IntuneAssignmentFilter Set(
        IntuneAssignmentFilterManagementType? FilterType = null,
        IntuneDevicePlatformType? Platform = null,
        System.String? DisplayName = null,
        DateTime? LastModifiedTime = null,
        List<System.String>? RoleScopeTags = null
    ) 
    {
        if ( FilterType != null ) {
            this.FilterType = FilterType;
        }
        if ( Platform != null ) {
            this.Platform = Platform;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( LastModifiedTime != null ) {
            this.LastModifiedTime = LastModifiedTime;
        }
        if ( RoleScopeTags != null ) {
            this.RoleScopeTags = RoleScopeTags;
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
        //      C# -> IntuneAssignmentFilterManagementType? FilterType
        // GraphQL -> filterType: IntuneAssignmentFilterManagementType! (enum)
        if (this.FilterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filterType\n" ;
            } else {
                s += ind + "filterType\n" ;
            }
        }
        //      C# -> IntuneDevicePlatformType? Platform
        // GraphQL -> platform: IntuneDevicePlatformType! (enum)
        if (this.Platform != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platform\n" ;
            } else {
                s += ind + "platform\n" ;
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
        //      C# -> DateTime? LastModifiedTime
        // GraphQL -> lastModifiedTime: DateTime (scalar)
        if (this.LastModifiedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModifiedTime\n" ;
            } else {
                s += ind + "lastModifiedTime\n" ;
            }
        }
        //      C# -> List<System.String>? RoleScopeTags
        // GraphQL -> roleScopeTags: [String!]! (scalar)
        if (this.RoleScopeTags != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleScopeTags\n" ;
            } else {
                s += ind + "roleScopeTags\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IntuneAssignmentFilterManagementType? FilterType
        // GraphQL -> filterType: IntuneAssignmentFilterManagementType! (enum)
        if (ec.Includes("filterType",true))
        {
            if(this.FilterType == null) {

                this.FilterType = new IntuneAssignmentFilterManagementType();

            } else {


            }
        }
        else if (this.FilterType != null && ec.Excludes("filterType",true))
        {
            this.FilterType = null;
        }
        //      C# -> IntuneDevicePlatformType? Platform
        // GraphQL -> platform: IntuneDevicePlatformType! (enum)
        if (ec.Includes("platform",true))
        {
            if(this.Platform == null) {

                this.Platform = new IntuneDevicePlatformType();

            } else {


            }
        }
        else if (this.Platform != null && ec.Excludes("platform",true))
        {
            this.Platform = null;
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
        //      C# -> DateTime? LastModifiedTime
        // GraphQL -> lastModifiedTime: DateTime (scalar)
        if (ec.Includes("lastModifiedTime",true))
        {
            if(this.LastModifiedTime == null) {

                this.LastModifiedTime = new DateTime();

            } else {


            }
        }
        else if (this.LastModifiedTime != null && ec.Excludes("lastModifiedTime",true))
        {
            this.LastModifiedTime = null;
        }
        //      C# -> List<System.String>? RoleScopeTags
        // GraphQL -> roleScopeTags: [String!]! (scalar)
        if (ec.Includes("roleScopeTags",true))
        {
            if(this.RoleScopeTags == null) {

                this.RoleScopeTags = new List<System.String>();

            } else {


            }
        }
        else if (this.RoleScopeTags != null && ec.Excludes("roleScopeTags",true))
        {
            this.RoleScopeTags = null;
        }
    }


    #endregion

    } // class IntuneAssignmentFilter
    
    #endregion

    public static class ListIntuneAssignmentFilterExtensions
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
            this List<IntuneAssignmentFilter> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntuneAssignmentFilter> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntuneAssignmentFilter> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntuneAssignmentFilter());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntuneAssignmentFilter> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types