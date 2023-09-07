// VsphereVmVolumeSpec.cs
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
    #region VsphereVmVolumeSpec
    public class VsphereVmVolumeSpec: BaseType
    {
        #region members

        //      C# -> System.String? DataStoreCdmId
        // GraphQL -> dataStoreCdmId: String! (scalar)
        [JsonProperty("dataStoreCdmId")]
        public System.String? DataStoreCdmId { get; set; }

        //      C# -> System.String? DataStoreId
        // GraphQL -> dataStoreId: String! (scalar)
        [JsonProperty("dataStoreId")]
        public System.String? DataStoreId { get; set; }

        //      C# -> System.String? DatastoreClusterId
        // GraphQL -> datastoreClusterId: String! (scalar)
        [JsonProperty("datastoreClusterId")]
        public System.String? DatastoreClusterId { get; set; }

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        [JsonProperty("label")]
        public System.String? Label { get; set; }

        //      C# -> System.Single? SizeGbs
        // GraphQL -> sizeGbs: Float! (scalar)
        [JsonProperty("sizeGbs")]
        public System.Single? SizeGbs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VSphereVMVolumeSpec";
    }

    public VsphereVmVolumeSpec Set(
        System.String? DataStoreCdmId = null,
        System.String? DataStoreId = null,
        System.String? DatastoreClusterId = null,
        System.String? Key = null,
        System.String? Label = null,
        System.Single? SizeGbs = null
    ) 
    {
        if ( DataStoreCdmId != null ) {
            this.DataStoreCdmId = DataStoreCdmId;
        }
        if ( DataStoreId != null ) {
            this.DataStoreId = DataStoreId;
        }
        if ( DatastoreClusterId != null ) {
            this.DatastoreClusterId = DatastoreClusterId;
        }
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( Label != null ) {
            this.Label = Label;
        }
        if ( SizeGbs != null ) {
            this.SizeGbs = SizeGbs;
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
        //      C# -> System.String? DataStoreCdmId
        // GraphQL -> dataStoreCdmId: String! (scalar)
        if (this.DataStoreCdmId != null) {
            s += ind + "dataStoreCdmId\n" ;
        }
        //      C# -> System.String? DataStoreId
        // GraphQL -> dataStoreId: String! (scalar)
        if (this.DataStoreId != null) {
            s += ind + "dataStoreId\n" ;
        }
        //      C# -> System.String? DatastoreClusterId
        // GraphQL -> datastoreClusterId: String! (scalar)
        if (this.DatastoreClusterId != null) {
            s += ind + "datastoreClusterId\n" ;
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            s += ind + "key\n" ;
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (this.Label != null) {
            s += ind + "label\n" ;
        }
        //      C# -> System.Single? SizeGbs
        // GraphQL -> sizeGbs: Float! (scalar)
        if (this.SizeGbs != null) {
            s += ind + "sizeGbs\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DataStoreCdmId
        // GraphQL -> dataStoreCdmId: String! (scalar)
        if (this.DataStoreCdmId == null && ec.Includes("dataStoreCdmId",true))
        {
            this.DataStoreCdmId = "FETCH";
        }
        //      C# -> System.String? DataStoreId
        // GraphQL -> dataStoreId: String! (scalar)
        if (this.DataStoreId == null && ec.Includes("dataStoreId",true))
        {
            this.DataStoreId = "FETCH";
        }
        //      C# -> System.String? DatastoreClusterId
        // GraphQL -> datastoreClusterId: String! (scalar)
        if (this.DatastoreClusterId == null && ec.Includes("datastoreClusterId",true))
        {
            this.DatastoreClusterId = "FETCH";
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key == null && ec.Includes("key",true))
        {
            this.Key = "FETCH";
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (this.Label == null && ec.Includes("label",true))
        {
            this.Label = "FETCH";
        }
        //      C# -> System.Single? SizeGbs
        // GraphQL -> sizeGbs: Float! (scalar)
        if (this.SizeGbs == null && ec.Includes("sizeGbs",true))
        {
            this.SizeGbs = new System.Single();
        }
    }


    #endregion

    } // class VsphereVmVolumeSpec
    
    #endregion

    public static class ListVsphereVmVolumeSpecExtensions
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
            this List<VsphereVmVolumeSpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVmVolumeSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVmVolumeSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VsphereVmVolumeSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types