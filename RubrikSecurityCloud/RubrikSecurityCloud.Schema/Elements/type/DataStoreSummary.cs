// DataStoreSummary.cs
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
    #region DataStoreSummary
    public class DataStoreSummary: BaseType
    {
        #region members

        //      C# -> System.Int64? Capacity
        // GraphQL -> capacity: Long (scalar)
        [JsonProperty("capacity")]
        public System.Int64? Capacity { get; set; }

        //      C# -> System.String? DataCenterName
        // GraphQL -> dataCenterName: String (scalar)
        [JsonProperty("dataCenterName")]
        public System.String? DataCenterName { get; set; }

        //      C# -> System.String? DataStoreType
        // GraphQL -> dataStoreType: String (scalar)
        [JsonProperty("dataStoreType")]
        public System.String? DataStoreType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsLocal
        // GraphQL -> isLocal: Boolean (scalar)
        [JsonProperty("isLocal")]
        public System.Boolean? IsLocal { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataStoreSummary";
    }

    public DataStoreSummary Set(
        System.Int64? Capacity = null,
        System.String? DataCenterName = null,
        System.String? DataStoreType = null,
        System.String? Id = null,
        System.Boolean? IsLocal = null,
        System.String? Name = null
    ) 
    {
        if ( Capacity != null ) {
            this.Capacity = Capacity;
        }
        if ( DataCenterName != null ) {
            this.DataCenterName = DataCenterName;
        }
        if ( DataStoreType != null ) {
            this.DataStoreType = DataStoreType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsLocal != null ) {
            this.IsLocal = IsLocal;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> System.Int64? Capacity
        // GraphQL -> capacity: Long (scalar)
        if (this.Capacity != null) {
            s += ind + "capacity\n" ;
        }
        //      C# -> System.String? DataCenterName
        // GraphQL -> dataCenterName: String (scalar)
        if (this.DataCenterName != null) {
            s += ind + "dataCenterName\n" ;
        }
        //      C# -> System.String? DataStoreType
        // GraphQL -> dataStoreType: String (scalar)
        if (this.DataStoreType != null) {
            s += ind + "dataStoreType\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsLocal
        // GraphQL -> isLocal: Boolean (scalar)
        if (this.IsLocal != null) {
            s += ind + "isLocal\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? Capacity
        // GraphQL -> capacity: Long (scalar)
        if (this.Capacity == null && ec.Includes("capacity",true))
        {
            this.Capacity = new System.Int64();
        }
        //      C# -> System.String? DataCenterName
        // GraphQL -> dataCenterName: String (scalar)
        if (this.DataCenterName == null && ec.Includes("dataCenterName",true))
        {
            this.DataCenterName = "FETCH";
        }
        //      C# -> System.String? DataStoreType
        // GraphQL -> dataStoreType: String (scalar)
        if (this.DataStoreType == null && ec.Includes("dataStoreType",true))
        {
            this.DataStoreType = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsLocal
        // GraphQL -> isLocal: Boolean (scalar)
        if (this.IsLocal == null && ec.Includes("isLocal",true))
        {
            this.IsLocal = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
    }


    #endregion

    } // class DataStoreSummary
    
    #endregion

    public static class ListDataStoreSummaryExtensions
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
            this List<DataStoreSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DataStoreSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataStoreSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<DataStoreSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types