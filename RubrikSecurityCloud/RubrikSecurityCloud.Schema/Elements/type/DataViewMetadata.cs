// DataViewMetadata.cs
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
    #region DataViewMetadata
    public class DataViewMetadata: BaseType
    {
        #region members

        //      C# -> DataViewTypeEnum? DataViewType
        // GraphQL -> dataViewType: DataViewTypeEnum! (enum)
        [JsonProperty("dataViewType")]
        public DataViewTypeEnum? DataViewType { get; set; }

        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "dataViewMetadata";
    }

    public DataViewMetadata Set(
        DataViewTypeEnum? DataViewType = null,
        System.Int64? Count = null
    ) 
    {
        if ( DataViewType != null ) {
            this.DataViewType = DataViewType;
        }
        if ( Count != null ) {
            this.Count = Count;
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
        //      C# -> DataViewTypeEnum? DataViewType
        // GraphQL -> dataViewType: DataViewTypeEnum! (enum)
        if (this.DataViewType != null) {
            s += ind + "dataViewType\n" ;
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DataViewTypeEnum? DataViewType
        // GraphQL -> dataViewType: DataViewTypeEnum! (enum)
        if (this.DataViewType == null && Exploration.Includes(parent + ".dataViewType", true))
        {
            this.DataViewType = new DataViewTypeEnum();
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = new System.Int64();
        }
    }


    #endregion

    } // class DataViewMetadata
    
    #endregion

    public static class ListDataViewMetadataExtensions
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
            this List<DataViewMetadata> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DataViewMetadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DataViewMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types