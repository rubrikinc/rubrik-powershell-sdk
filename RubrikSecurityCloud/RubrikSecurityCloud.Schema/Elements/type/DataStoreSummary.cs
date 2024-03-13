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

        //      C# -> System.Int64? FreeSpaceInBytes
        // GraphQL -> freeSpaceInBytes: Long (scalar)
        [JsonProperty("freeSpaceInBytes")]
        public System.Int64? FreeSpaceInBytes { get; set; }

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
        System.Int64? FreeSpaceInBytes = null,
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
        if ( FreeSpaceInBytes != null ) {
            this.FreeSpaceInBytes = FreeSpaceInBytes;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? Capacity
        // GraphQL -> capacity: Long (scalar)
        if (this.Capacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capacity\n" ;
            } else {
                s += ind + "capacity\n" ;
            }
        }
        //      C# -> System.String? DataCenterName
        // GraphQL -> dataCenterName: String (scalar)
        if (this.DataCenterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataCenterName\n" ;
            } else {
                s += ind + "dataCenterName\n" ;
            }
        }
        //      C# -> System.String? DataStoreType
        // GraphQL -> dataStoreType: String (scalar)
        if (this.DataStoreType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataStoreType\n" ;
            } else {
                s += ind + "dataStoreType\n" ;
            }
        }
        //      C# -> System.Int64? FreeSpaceInBytes
        // GraphQL -> freeSpaceInBytes: Long (scalar)
        if (this.FreeSpaceInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "freeSpaceInBytes\n" ;
            } else {
                s += ind + "freeSpaceInBytes\n" ;
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
        //      C# -> System.Boolean? IsLocal
        // GraphQL -> isLocal: Boolean (scalar)
        if (this.IsLocal != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLocal\n" ;
            } else {
                s += ind + "isLocal\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? Capacity
        // GraphQL -> capacity: Long (scalar)
        if (ec.Includes("capacity",true))
        {
            if(this.Capacity == null) {

                this.Capacity = new System.Int64();

            } else {


            }
        }
        else if (this.Capacity != null && ec.Excludes("capacity",true))
        {
            this.Capacity = null;
        }
        //      C# -> System.String? DataCenterName
        // GraphQL -> dataCenterName: String (scalar)
        if (ec.Includes("dataCenterName",true))
        {
            if(this.DataCenterName == null) {

                this.DataCenterName = "FETCH";

            } else {


            }
        }
        else if (this.DataCenterName != null && ec.Excludes("dataCenterName",true))
        {
            this.DataCenterName = null;
        }
        //      C# -> System.String? DataStoreType
        // GraphQL -> dataStoreType: String (scalar)
        if (ec.Includes("dataStoreType",true))
        {
            if(this.DataStoreType == null) {

                this.DataStoreType = "FETCH";

            } else {


            }
        }
        else if (this.DataStoreType != null && ec.Excludes("dataStoreType",true))
        {
            this.DataStoreType = null;
        }
        //      C# -> System.Int64? FreeSpaceInBytes
        // GraphQL -> freeSpaceInBytes: Long (scalar)
        if (ec.Includes("freeSpaceInBytes",true))
        {
            if(this.FreeSpaceInBytes == null) {

                this.FreeSpaceInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.FreeSpaceInBytes != null && ec.Excludes("freeSpaceInBytes",true))
        {
            this.FreeSpaceInBytes = null;
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
        //      C# -> System.Boolean? IsLocal
        // GraphQL -> isLocal: Boolean (scalar)
        if (ec.Includes("isLocal",true))
        {
            if(this.IsLocal == null) {

                this.IsLocal = true;

            } else {


            }
        }
        else if (this.IsLocal != null && ec.Excludes("isLocal",true))
        {
            this.IsLocal = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DataStoreSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<DataStoreSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types