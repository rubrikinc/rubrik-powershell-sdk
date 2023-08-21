// AppItemWithCascadingImpact.cs
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
    #region AppItemWithCascadingImpact
    public class AppItemWithCascadingImpact: BaseType
    {
        #region members

        //      C# -> System.String? AppItemTypeDisplayName
        // GraphQL -> appItemTypeDisplayName: String! (scalar)
        [JsonProperty("appItemTypeDisplayName")]
        public System.String? AppItemTypeDisplayName { get; set; }

        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        [JsonProperty("appItemTypeToken")]
        public System.String? AppItemTypeToken { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.Boolean? IsOptionalToRestore
        // GraphQL -> isOptionalToRestore: Boolean! (scalar)
        [JsonProperty("isOptionalToRestore")]
        public System.Boolean? IsOptionalToRestore { get; set; }

        //      C# -> List<AppItemWithCascadingImpact>? CascadedItems
        // GraphQL -> cascadedItems: [AppItemWithCascadingImpact!]! (type)
        [JsonProperty("cascadedItems")]
        public List<AppItemWithCascadingImpact>? CascadedItems { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppItemWithCascadingImpact";
    }

    public AppItemWithCascadingImpact Set(
        System.String? AppItemTypeDisplayName = null,
        System.String? AppItemTypeToken = null,
        System.Int32? Count = null,
        System.Boolean? IsOptionalToRestore = null,
        List<AppItemWithCascadingImpact>? CascadedItems = null
    ) 
    {
        if ( AppItemTypeDisplayName != null ) {
            this.AppItemTypeDisplayName = AppItemTypeDisplayName;
        }
        if ( AppItemTypeToken != null ) {
            this.AppItemTypeToken = AppItemTypeToken;
        }
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( IsOptionalToRestore != null ) {
            this.IsOptionalToRestore = IsOptionalToRestore;
        }
        if ( CascadedItems != null ) {
            this.CascadedItems = CascadedItems;
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
        //      C# -> System.String? AppItemTypeDisplayName
        // GraphQL -> appItemTypeDisplayName: String! (scalar)
        if (this.AppItemTypeDisplayName != null) {
            s += ind + "appItemTypeDisplayName\n" ;
        }
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken != null) {
            s += ind + "appItemTypeToken\n" ;
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> System.Boolean? IsOptionalToRestore
        // GraphQL -> isOptionalToRestore: Boolean! (scalar)
        if (this.IsOptionalToRestore != null) {
            s += ind + "isOptionalToRestore\n" ;
        }
        //      C# -> List<AppItemWithCascadingImpact>? CascadedItems
        // GraphQL -> cascadedItems: [AppItemWithCascadingImpact!]! (type)
        if (this.CascadedItems != null) {
            var fspec = this.CascadedItems.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cascadedItems {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AppItemTypeDisplayName
        // GraphQL -> appItemTypeDisplayName: String! (scalar)
        if (this.AppItemTypeDisplayName == null && Exploration.Includes(parent + ".appItemTypeDisplayName", true))
        {
            this.AppItemTypeDisplayName = "FETCH";
        }
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken == null && Exploration.Includes(parent + ".appItemTypeToken", true))
        {
            this.AppItemTypeToken = "FETCH";
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> System.Boolean? IsOptionalToRestore
        // GraphQL -> isOptionalToRestore: Boolean! (scalar)
        if (this.IsOptionalToRestore == null && Exploration.Includes(parent + ".isOptionalToRestore", true))
        {
            this.IsOptionalToRestore = true;
        }
        //      C# -> List<AppItemWithCascadingImpact>? CascadedItems
        // GraphQL -> cascadedItems: [AppItemWithCascadingImpact!]! (type)
        if (this.CascadedItems == null && Exploration.Includes(parent + ".cascadedItems"))
        {
            this.CascadedItems = new List<AppItemWithCascadingImpact>();
            this.CascadedItems.ApplyExploratoryFieldSpec(parent + ".cascadedItems");
        }
    }


    #endregion

    } // class AppItemWithCascadingImpact
    
    #endregion

    public static class ListAppItemWithCascadingImpactExtensions
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
            this List<AppItemWithCascadingImpact> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AppItemWithCascadingImpact> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AppItemWithCascadingImpact());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types