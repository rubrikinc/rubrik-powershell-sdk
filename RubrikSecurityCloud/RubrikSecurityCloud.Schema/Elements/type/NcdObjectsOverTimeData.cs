// NcdObjectsOverTimeData.cs
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
    #region NcdObjectsOverTimeData
    public class NcdObjectsOverTimeData: BaseType
    {
        #region members

        //      C# -> System.Int32? Directories
        // GraphQL -> directories: Int! (scalar)
        [JsonProperty("directories")]
        public System.Int32? Directories { get; set; }

        //      C# -> System.Int32? Files
        // GraphQL -> files: Int! (scalar)
        [JsonProperty("files")]
        public System.Int32? Files { get; set; }

        //      C# -> System.Int32? Links
        // GraphQL -> links: Int! (scalar)
        [JsonProperty("links")]
        public System.Int32? Links { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdObjectsOverTimeData";
    }

    public NcdObjectsOverTimeData Set(
        System.Int32? Directories = null,
        System.Int32? Files = null,
        System.Int32? Links = null,
        DateTime? Timestamp = null
    ) 
    {
        if ( Directories != null ) {
            this.Directories = Directories;
        }
        if ( Files != null ) {
            this.Files = Files;
        }
        if ( Links != null ) {
            this.Links = Links;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
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
        //      C# -> System.Int32? Directories
        // GraphQL -> directories: Int! (scalar)
        if (this.Directories != null) {
            if (conf.Flat) {
                s += conf.Prefix + "directories\n" ;
            } else {
                s += ind + "directories\n" ;
            }
        }
        //      C# -> System.Int32? Files
        // GraphQL -> files: Int! (scalar)
        if (this.Files != null) {
            if (conf.Flat) {
                s += conf.Prefix + "files\n" ;
            } else {
                s += ind + "files\n" ;
            }
        }
        //      C# -> System.Int32? Links
        // GraphQL -> links: Int! (scalar)
        if (this.Links != null) {
            if (conf.Flat) {
                s += conf.Prefix + "links\n" ;
            } else {
                s += ind + "links\n" ;
            }
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Directories
        // GraphQL -> directories: Int! (scalar)
        if (ec.Includes("directories",true))
        {
            if(this.Directories == null) {

                this.Directories = Int32.MinValue;

            } else {


            }
        }
        else if (this.Directories != null && ec.Excludes("directories",true))
        {
            this.Directories = null;
        }
        //      C# -> System.Int32? Files
        // GraphQL -> files: Int! (scalar)
        if (ec.Includes("files",true))
        {
            if(this.Files == null) {

                this.Files = Int32.MinValue;

            } else {


            }
        }
        else if (this.Files != null && ec.Excludes("files",true))
        {
            this.Files = null;
        }
        //      C# -> System.Int32? Links
        // GraphQL -> links: Int! (scalar)
        if (ec.Includes("links",true))
        {
            if(this.Links == null) {

                this.Links = Int32.MinValue;

            } else {


            }
        }
        else if (this.Links != null && ec.Excludes("links",true))
        {
            this.Links = null;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (ec.Includes("timestamp",true))
        {
            if(this.Timestamp == null) {

                this.Timestamp = new DateTime();

            } else {


            }
        }
        else if (this.Timestamp != null && ec.Excludes("timestamp",true))
        {
            this.Timestamp = null;
        }
    }


    #endregion

    } // class NcdObjectsOverTimeData
    
    #endregion

    public static class ListNcdObjectsOverTimeDataExtensions
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
            this List<NcdObjectsOverTimeData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NcdObjectsOverTimeData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NcdObjectsOverTimeData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdObjectsOverTimeData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NcdObjectsOverTimeData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types