// AssignmentResourceDetails.cs
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
    #region AssignmentResourceDetails
    public class AssignmentResourceDetails: BaseType
    {
        #region members

        //      C# -> DataGovObjectType? ResourceType
        // GraphQL -> resourceType: DataGovObjectType! (enum)
        [JsonProperty("resourceType")]
        public DataGovObjectType? ResourceType { get; set; }

        //      C# -> System.Boolean? IsHigherLevelResource
        // GraphQL -> isHigherLevelResource: Boolean! (scalar)
        [JsonProperty("isHigherLevelResource")]
        public System.Boolean? IsHigherLevelResource { get; set; }

        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        [JsonProperty("resourceId")]
        public System.String? ResourceId { get; set; }

        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        [JsonProperty("resourceName")]
        public System.String? ResourceName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AssignmentResourceDetails";
    }

    public AssignmentResourceDetails Set(
        DataGovObjectType? ResourceType = null,
        System.Boolean? IsHigherLevelResource = null,
        System.String? ResourceId = null,
        System.String? ResourceName = null
    ) 
    {
        if ( ResourceType != null ) {
            this.ResourceType = ResourceType;
        }
        if ( IsHigherLevelResource != null ) {
            this.IsHigherLevelResource = IsHigherLevelResource;
        }
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
        if ( ResourceName != null ) {
            this.ResourceName = ResourceName;
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
        //      C# -> DataGovObjectType? ResourceType
        // GraphQL -> resourceType: DataGovObjectType! (enum)
        if (this.ResourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceType\n" ;
            } else {
                s += ind + "resourceType\n" ;
            }
        }
        //      C# -> System.Boolean? IsHigherLevelResource
        // GraphQL -> isHigherLevelResource: Boolean! (scalar)
        if (this.IsHigherLevelResource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHigherLevelResource\n" ;
            } else {
                s += ind + "isHigherLevelResource\n" ;
            }
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceId\n" ;
            } else {
                s += ind + "resourceId\n" ;
            }
        }
        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        if (this.ResourceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceName\n" ;
            } else {
                s += ind + "resourceName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DataGovObjectType? ResourceType
        // GraphQL -> resourceType: DataGovObjectType! (enum)
        if (ec.Includes("resourceType",true))
        {
            if(this.ResourceType == null) {

                this.ResourceType = new DataGovObjectType();

            } else {


            }
        }
        else if (this.ResourceType != null && ec.Excludes("resourceType",true))
        {
            this.ResourceType = null;
        }
        //      C# -> System.Boolean? IsHigherLevelResource
        // GraphQL -> isHigherLevelResource: Boolean! (scalar)
        if (ec.Includes("isHigherLevelResource",true))
        {
            if(this.IsHigherLevelResource == null) {

                this.IsHigherLevelResource = true;

            } else {


            }
        }
        else if (this.IsHigherLevelResource != null && ec.Excludes("isHigherLevelResource",true))
        {
            this.IsHigherLevelResource = null;
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (ec.Includes("resourceId",true))
        {
            if(this.ResourceId == null) {

                this.ResourceId = "FETCH";

            } else {


            }
        }
        else if (this.ResourceId != null && ec.Excludes("resourceId",true))
        {
            this.ResourceId = null;
        }
        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        if (ec.Includes("resourceName",true))
        {
            if(this.ResourceName == null) {

                this.ResourceName = "FETCH";

            } else {


            }
        }
        else if (this.ResourceName != null && ec.Excludes("resourceName",true))
        {
            this.ResourceName = null;
        }
    }


    #endregion

    } // class AssignmentResourceDetails
    
    #endregion

    public static class ListAssignmentResourceDetailsExtensions
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
            this List<AssignmentResourceDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AssignmentResourceDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AssignmentResourceDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AssignmentResourceDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AssignmentResourceDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types