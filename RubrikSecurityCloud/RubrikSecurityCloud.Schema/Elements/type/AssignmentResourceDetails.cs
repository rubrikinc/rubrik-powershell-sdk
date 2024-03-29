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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
            this List<AssignmentResourceDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AssignmentResourceDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AssignmentResourceDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AssignmentResourceDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AssignmentResourceDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types