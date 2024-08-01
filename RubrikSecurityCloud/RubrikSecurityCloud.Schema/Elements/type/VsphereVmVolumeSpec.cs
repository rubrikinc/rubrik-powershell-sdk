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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? DataStoreCdmId
        // GraphQL -> dataStoreCdmId: String! (scalar)
        if (this.DataStoreCdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataStoreCdmId\n" ;
            } else {
                s += ind + "dataStoreCdmId\n" ;
            }
        }
        //      C# -> System.String? DataStoreId
        // GraphQL -> dataStoreId: String! (scalar)
        if (this.DataStoreId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataStoreId\n" ;
            } else {
                s += ind + "dataStoreId\n" ;
            }
        }
        //      C# -> System.String? DatastoreClusterId
        // GraphQL -> datastoreClusterId: String! (scalar)
        if (this.DatastoreClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datastoreClusterId\n" ;
            } else {
                s += ind + "datastoreClusterId\n" ;
            }
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (this.Label != null) {
            if (conf.Flat) {
                s += conf.Prefix + "label\n" ;
            } else {
                s += ind + "label\n" ;
            }
        }
        //      C# -> System.Single? SizeGbs
        // GraphQL -> sizeGbs: Float! (scalar)
        if (this.SizeGbs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sizeGbs\n" ;
            } else {
                s += ind + "sizeGbs\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DataStoreCdmId
        // GraphQL -> dataStoreCdmId: String! (scalar)
        if (ec.Includes("dataStoreCdmId",true))
        {
            if(this.DataStoreCdmId == null) {

                this.DataStoreCdmId = "FETCH";

            } else {


            }
        }
        else if (this.DataStoreCdmId != null && ec.Excludes("dataStoreCdmId",true))
        {
            this.DataStoreCdmId = null;
        }
        //      C# -> System.String? DataStoreId
        // GraphQL -> dataStoreId: String! (scalar)
        if (ec.Includes("dataStoreId",true))
        {
            if(this.DataStoreId == null) {

                this.DataStoreId = "FETCH";

            } else {


            }
        }
        else if (this.DataStoreId != null && ec.Excludes("dataStoreId",true))
        {
            this.DataStoreId = null;
        }
        //      C# -> System.String? DatastoreClusterId
        // GraphQL -> datastoreClusterId: String! (scalar)
        if (ec.Includes("datastoreClusterId",true))
        {
            if(this.DatastoreClusterId == null) {

                this.DatastoreClusterId = "FETCH";

            } else {


            }
        }
        else if (this.DatastoreClusterId != null && ec.Excludes("datastoreClusterId",true))
        {
            this.DatastoreClusterId = null;
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = "FETCH";

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> System.String? Label
        // GraphQL -> label: String! (scalar)
        if (ec.Includes("label",true))
        {
            if(this.Label == null) {

                this.Label = "FETCH";

            } else {


            }
        }
        else if (this.Label != null && ec.Excludes("label",true))
        {
            this.Label = null;
        }
        //      C# -> System.Single? SizeGbs
        // GraphQL -> sizeGbs: Float! (scalar)
        if (ec.Includes("sizeGbs",true))
        {
            if(this.SizeGbs == null) {

                this.SizeGbs = new System.Single();

            } else {


            }
        }
        else if (this.SizeGbs != null && ec.Excludes("sizeGbs",true))
        {
            this.SizeGbs = null;
        }
    }


    #endregion

    } // class VsphereVmVolumeSpec
    
    #endregion

    public static class ListVsphereVmVolumeSpecExtensions
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
            this List<VsphereVmVolumeSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereVmVolumeSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<VsphereVmVolumeSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types