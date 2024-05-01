// PvcInformation.cs
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
    #region PvcInformation
    public class PvcInformation: BaseType
    {
        #region members

        //      C# -> System.String? AccessMode
        // GraphQL -> accessMode: String! (scalar)
        [JsonProperty("accessMode")]
        public System.String? AccessMode { get; set; }

        //      C# -> System.String? Capacity
        // GraphQL -> capacity: String! (scalar)
        [JsonProperty("capacity")]
        public System.String? Capacity { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Labels
        // GraphQL -> labels: String! (scalar)
        [JsonProperty("labels")]
        public System.String? Labels { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Phase
        // GraphQL -> phase: String! (scalar)
        [JsonProperty("phase")]
        public System.String? Phase { get; set; }

        //      C# -> System.String? StorageClass
        // GraphQL -> storageClass: String! (scalar)
        [JsonProperty("storageClass")]
        public System.String? StorageClass { get; set; }

        //      C# -> System.String? Volume
        // GraphQL -> volume: String! (scalar)
        [JsonProperty("volume")]
        public System.String? Volume { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PvcInformation";
    }

    public PvcInformation Set(
        System.String? AccessMode = null,
        System.String? Capacity = null,
        System.String? Id = null,
        System.String? Labels = null,
        System.String? Name = null,
        System.String? Phase = null,
        System.String? StorageClass = null,
        System.String? Volume = null
    ) 
    {
        if ( AccessMode != null ) {
            this.AccessMode = AccessMode;
        }
        if ( Capacity != null ) {
            this.Capacity = Capacity;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Labels != null ) {
            this.Labels = Labels;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Phase != null ) {
            this.Phase = Phase;
        }
        if ( StorageClass != null ) {
            this.StorageClass = StorageClass;
        }
        if ( Volume != null ) {
            this.Volume = Volume;
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
        //      C# -> System.String? AccessMode
        // GraphQL -> accessMode: String! (scalar)
        if (this.AccessMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessMode\n" ;
            } else {
                s += ind + "accessMode\n" ;
            }
        }
        //      C# -> System.String? Capacity
        // GraphQL -> capacity: String! (scalar)
        if (this.Capacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capacity\n" ;
            } else {
                s += ind + "capacity\n" ;
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
        //      C# -> System.String? Labels
        // GraphQL -> labels: String! (scalar)
        if (this.Labels != null) {
            if (conf.Flat) {
                s += conf.Prefix + "labels\n" ;
            } else {
                s += ind + "labels\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? Phase
        // GraphQL -> phase: String! (scalar)
        if (this.Phase != null) {
            if (conf.Flat) {
                s += conf.Prefix + "phase\n" ;
            } else {
                s += ind + "phase\n" ;
            }
        }
        //      C# -> System.String? StorageClass
        // GraphQL -> storageClass: String! (scalar)
        if (this.StorageClass != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageClass\n" ;
            } else {
                s += ind + "storageClass\n" ;
            }
        }
        //      C# -> System.String? Volume
        // GraphQL -> volume: String! (scalar)
        if (this.Volume != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volume\n" ;
            } else {
                s += ind + "volume\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AccessMode
        // GraphQL -> accessMode: String! (scalar)
        if (ec.Includes("accessMode",true))
        {
            if(this.AccessMode == null) {

                this.AccessMode = "FETCH";

            } else {


            }
        }
        else if (this.AccessMode != null && ec.Excludes("accessMode",true))
        {
            this.AccessMode = null;
        }
        //      C# -> System.String? Capacity
        // GraphQL -> capacity: String! (scalar)
        if (ec.Includes("capacity",true))
        {
            if(this.Capacity == null) {

                this.Capacity = "FETCH";

            } else {


            }
        }
        else if (this.Capacity != null && ec.Excludes("capacity",true))
        {
            this.Capacity = null;
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
        //      C# -> System.String? Labels
        // GraphQL -> labels: String! (scalar)
        if (ec.Includes("labels",true))
        {
            if(this.Labels == null) {

                this.Labels = "FETCH";

            } else {


            }
        }
        else if (this.Labels != null && ec.Excludes("labels",true))
        {
            this.Labels = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
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
        //      C# -> System.String? Phase
        // GraphQL -> phase: String! (scalar)
        if (ec.Includes("phase",true))
        {
            if(this.Phase == null) {

                this.Phase = "FETCH";

            } else {


            }
        }
        else if (this.Phase != null && ec.Excludes("phase",true))
        {
            this.Phase = null;
        }
        //      C# -> System.String? StorageClass
        // GraphQL -> storageClass: String! (scalar)
        if (ec.Includes("storageClass",true))
        {
            if(this.StorageClass == null) {

                this.StorageClass = "FETCH";

            } else {


            }
        }
        else if (this.StorageClass != null && ec.Excludes("storageClass",true))
        {
            this.StorageClass = null;
        }
        //      C# -> System.String? Volume
        // GraphQL -> volume: String! (scalar)
        if (ec.Includes("volume",true))
        {
            if(this.Volume == null) {

                this.Volume = "FETCH";

            } else {


            }
        }
        else if (this.Volume != null && ec.Excludes("volume",true))
        {
            this.Volume = null;
        }
    }


    #endregion

    } // class PvcInformation
    
    #endregion

    public static class ListPvcInformationExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<PvcInformation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PvcInformation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PvcInformation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PvcInformation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PvcInformation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types