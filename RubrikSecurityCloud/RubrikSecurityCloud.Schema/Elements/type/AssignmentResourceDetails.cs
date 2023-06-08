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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DataGovObjectType? ResourceType
        // GraphQL -> resourceType: DataGovObjectType! (enum)
        if (this.ResourceType != null) {
            s += ind + "resourceType\n" ;
        }
        //      C# -> System.Boolean? IsHigherLevelResource
        // GraphQL -> isHigherLevelResource: Boolean! (scalar)
        if (this.IsHigherLevelResource != null) {
            s += ind + "isHigherLevelResource\n" ;
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId != null) {
            s += ind + "resourceId\n" ;
        }
        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        if (this.ResourceName != null) {
            s += ind + "resourceName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DataGovObjectType? ResourceType
        // GraphQL -> resourceType: DataGovObjectType! (enum)
        if (this.ResourceType == null && Exploration.Includes(parent + ".resourceType", true))
        {
            this.ResourceType = new DataGovObjectType();
        }
        //      C# -> System.Boolean? IsHigherLevelResource
        // GraphQL -> isHigherLevelResource: Boolean! (scalar)
        if (this.IsHigherLevelResource == null && Exploration.Includes(parent + ".isHigherLevelResource", true))
        {
            this.IsHigherLevelResource = true;
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId == null && Exploration.Includes(parent + ".resourceId", true))
        {
            this.ResourceId = "FETCH";
        }
        //      C# -> System.String? ResourceName
        // GraphQL -> resourceName: String! (scalar)
        if (this.ResourceName == null && Exploration.Includes(parent + ".resourceName", true))
        {
            this.ResourceName = "FETCH";
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AssignmentResourceDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AssignmentResourceDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types