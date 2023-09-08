// ResourceInfo.cs
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
    #region ResourceInfo
    public class ResourceInfo: BaseType
    {
        #region members

        //      C# -> ResourceType? ResourceType
        // GraphQL -> resourceType: ResourceType! (enum)
        [JsonProperty("resourceType")]
        public ResourceType? ResourceType { get; set; }

        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        [JsonProperty("resourceId")]
        public System.String? ResourceId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ResourceInfo";
    }

    public ResourceInfo Set(
        ResourceType? ResourceType = null,
        System.String? ResourceId = null
    ) 
    {
        if ( ResourceType != null ) {
            this.ResourceType = ResourceType;
        }
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
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
        //      C# -> ResourceType? ResourceType
        // GraphQL -> resourceType: ResourceType! (enum)
        if (this.ResourceType != null) {
            s += ind + "resourceType\n" ;
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId != null) {
            s += ind + "resourceId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ResourceType? ResourceType
        // GraphQL -> resourceType: ResourceType! (enum)
        if (this.ResourceType == null && ec.Includes("resourceType",true))
        {
            this.ResourceType = new ResourceType();
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId == null && ec.Includes("resourceId",true))
        {
            this.ResourceId = "FETCH";
        }
    }


    #endregion

    } // class ResourceInfo
    
    #endregion

    public static class ListResourceInfoExtensions
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
            this List<ResourceInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ResourceInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ResourceInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ResourceInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types