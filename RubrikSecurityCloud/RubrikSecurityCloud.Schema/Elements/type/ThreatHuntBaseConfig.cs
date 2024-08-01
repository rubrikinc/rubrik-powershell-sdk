// ThreatHuntBaseConfig.cs
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
    #region ThreatHuntBaseConfig
    public class ThreatHuntBaseConfig: BaseType
    {
        #region members

        //      C# -> ThreatHuntType? ThreatHuntType
        // GraphQL -> threatHuntType: ThreatHuntType! (enum)
        [JsonProperty("threatHuntType")]
        public ThreatHuntType? ThreatHuntType { get; set; }

        //      C# -> System.Int32? MaxMatchesPerSnapshot
        // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
        [JsonProperty("maxMatchesPerSnapshot")]
        public System.Int32? MaxMatchesPerSnapshot { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Notes
        // GraphQL -> notes: String! (scalar)
        [JsonProperty("notes")]
        public System.String? Notes { get; set; }

        //      C# -> HuntScanFileCriteria? FileScanCriteria
        // GraphQL -> fileScanCriteria: HuntScanFileCriteria! (type)
        [JsonProperty("fileScanCriteria")]
        public HuntScanFileCriteria? FileScanCriteria { get; set; }

        //      C# -> ThreatHuntIocInput? Ioc
        // GraphQL -> ioc: ThreatHuntIocInput! (type)
        [JsonProperty("ioc")]
        public ThreatHuntIocInput? Ioc { get; set; }

        //      C# -> HuntScanSnapshotLimit? SnapshotScanLimit
        // GraphQL -> snapshotScanLimit: HuntScanSnapshotLimit! (type)
        [JsonProperty("snapshotScanLimit")]
        public HuntScanSnapshotLimit? SnapshotScanLimit { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntBaseConfig";
    }

    public ThreatHuntBaseConfig Set(
        ThreatHuntType? ThreatHuntType = null,
        System.Int32? MaxMatchesPerSnapshot = null,
        System.String? Name = null,
        System.String? Notes = null,
        HuntScanFileCriteria? FileScanCriteria = null,
        ThreatHuntIocInput? Ioc = null,
        HuntScanSnapshotLimit? SnapshotScanLimit = null
    ) 
    {
        if ( ThreatHuntType != null ) {
            this.ThreatHuntType = ThreatHuntType;
        }
        if ( MaxMatchesPerSnapshot != null ) {
            this.MaxMatchesPerSnapshot = MaxMatchesPerSnapshot;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Notes != null ) {
            this.Notes = Notes;
        }
        if ( FileScanCriteria != null ) {
            this.FileScanCriteria = FileScanCriteria;
        }
        if ( Ioc != null ) {
            this.Ioc = Ioc;
        }
        if ( SnapshotScanLimit != null ) {
            this.SnapshotScanLimit = SnapshotScanLimit;
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
        //      C# -> ThreatHuntType? ThreatHuntType
        // GraphQL -> threatHuntType: ThreatHuntType! (enum)
        if (this.ThreatHuntType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "threatHuntType\n" ;
            } else {
                s += ind + "threatHuntType\n" ;
            }
        }
        //      C# -> System.Int32? MaxMatchesPerSnapshot
        // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
        if (this.MaxMatchesPerSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxMatchesPerSnapshot\n" ;
            } else {
                s += ind + "maxMatchesPerSnapshot\n" ;
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
        //      C# -> System.String? Notes
        // GraphQL -> notes: String! (scalar)
        if (this.Notes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "notes\n" ;
            } else {
                s += ind + "notes\n" ;
            }
        }
        //      C# -> HuntScanFileCriteria? FileScanCriteria
        // GraphQL -> fileScanCriteria: HuntScanFileCriteria! (type)
        if (this.FileScanCriteria != null) {
            var fspec = this.FileScanCriteria.AsFieldSpec(conf.Child("fileScanCriteria"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileScanCriteria" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ThreatHuntIocInput? Ioc
        // GraphQL -> ioc: ThreatHuntIocInput! (type)
        if (this.Ioc != null) {
            var fspec = this.Ioc.AsFieldSpec(conf.Child("ioc"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ioc" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> HuntScanSnapshotLimit? SnapshotScanLimit
        // GraphQL -> snapshotScanLimit: HuntScanSnapshotLimit! (type)
        if (this.SnapshotScanLimit != null) {
            var fspec = this.SnapshotScanLimit.AsFieldSpec(conf.Child("snapshotScanLimit"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotScanLimit" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ThreatHuntType? ThreatHuntType
        // GraphQL -> threatHuntType: ThreatHuntType! (enum)
        if (ec.Includes("threatHuntType",true))
        {
            if(this.ThreatHuntType == null) {

                this.ThreatHuntType = new ThreatHuntType();

            } else {


            }
        }
        else if (this.ThreatHuntType != null && ec.Excludes("threatHuntType",true))
        {
            this.ThreatHuntType = null;
        }
        //      C# -> System.Int32? MaxMatchesPerSnapshot
        // GraphQL -> maxMatchesPerSnapshot: Int (scalar)
        if (ec.Includes("maxMatchesPerSnapshot",true))
        {
            if(this.MaxMatchesPerSnapshot == null) {

                this.MaxMatchesPerSnapshot = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxMatchesPerSnapshot != null && ec.Excludes("maxMatchesPerSnapshot",true))
        {
            this.MaxMatchesPerSnapshot = null;
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
        //      C# -> System.String? Notes
        // GraphQL -> notes: String! (scalar)
        if (ec.Includes("notes",true))
        {
            if(this.Notes == null) {

                this.Notes = "FETCH";

            } else {


            }
        }
        else if (this.Notes != null && ec.Excludes("notes",true))
        {
            this.Notes = null;
        }
        //      C# -> HuntScanFileCriteria? FileScanCriteria
        // GraphQL -> fileScanCriteria: HuntScanFileCriteria! (type)
        if (ec.Includes("fileScanCriteria",false))
        {
            if(this.FileScanCriteria == null) {

                this.FileScanCriteria = new HuntScanFileCriteria();
                this.FileScanCriteria.ApplyExploratoryFieldSpec(ec.NewChild("fileScanCriteria"));

            } else {

                this.FileScanCriteria.ApplyExploratoryFieldSpec(ec.NewChild("fileScanCriteria"));

            }
        }
        else if (this.FileScanCriteria != null && ec.Excludes("fileScanCriteria",false))
        {
            this.FileScanCriteria = null;
        }
        //      C# -> ThreatHuntIocInput? Ioc
        // GraphQL -> ioc: ThreatHuntIocInput! (type)
        if (ec.Includes("ioc",false))
        {
            if(this.Ioc == null) {

                this.Ioc = new ThreatHuntIocInput();
                this.Ioc.ApplyExploratoryFieldSpec(ec.NewChild("ioc"));

            } else {

                this.Ioc.ApplyExploratoryFieldSpec(ec.NewChild("ioc"));

            }
        }
        else if (this.Ioc != null && ec.Excludes("ioc",false))
        {
            this.Ioc = null;
        }
        //      C# -> HuntScanSnapshotLimit? SnapshotScanLimit
        // GraphQL -> snapshotScanLimit: HuntScanSnapshotLimit! (type)
        if (ec.Includes("snapshotScanLimit",false))
        {
            if(this.SnapshotScanLimit == null) {

                this.SnapshotScanLimit = new HuntScanSnapshotLimit();
                this.SnapshotScanLimit.ApplyExploratoryFieldSpec(ec.NewChild("snapshotScanLimit"));

            } else {

                this.SnapshotScanLimit.ApplyExploratoryFieldSpec(ec.NewChild("snapshotScanLimit"));

            }
        }
        else if (this.SnapshotScanLimit != null && ec.Excludes("snapshotScanLimit",false))
        {
            this.SnapshotScanLimit = null;
        }
    }


    #endregion

    } // class ThreatHuntBaseConfig
    
    #endregion

    public static class ListThreatHuntBaseConfigExtensions
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
            this List<ThreatHuntBaseConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntBaseConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntBaseConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntBaseConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntBaseConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types