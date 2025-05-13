// ScanLimit.cs
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
    #region ScanLimit
    public class ScanLimit: BaseType
    {
        #region members

        //      C# -> List<ObjectSnapshotMapping>? ObjectSnapshotConfig
        // GraphQL -> objectSnapshotConfig: [ObjectSnapshotMapping!] (type)
        [JsonProperty("objectSnapshotConfig")]
        public List<ObjectSnapshotMapping>? ObjectSnapshotConfig { get; set; }

        //      C# -> SnapshotScanConfig? ScanConfig
        // GraphQL -> scanConfig: SnapshotScanConfig (type)
        [JsonProperty("scanConfig")]
        public SnapshotScanConfig? ScanConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ScanLimit";
    }

    public ScanLimit Set(
        List<ObjectSnapshotMapping>? ObjectSnapshotConfig = null,
        SnapshotScanConfig? ScanConfig = null
    ) 
    {
        if ( ObjectSnapshotConfig != null ) {
            this.ObjectSnapshotConfig = ObjectSnapshotConfig;
        }
        if ( ScanConfig != null ) {
            this.ScanConfig = ScanConfig;
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
        //      C# -> List<ObjectSnapshotMapping>? ObjectSnapshotConfig
        // GraphQL -> objectSnapshotConfig: [ObjectSnapshotMapping!] (type)
        if (this.ObjectSnapshotConfig != null) {
            var fspec = this.ObjectSnapshotConfig.AsFieldSpec(conf.Child("objectSnapshotConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectSnapshotConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotScanConfig? ScanConfig
        // GraphQL -> scanConfig: SnapshotScanConfig (type)
        if (this.ScanConfig != null) {
            var fspec = this.ScanConfig.AsFieldSpec(conf.Child("scanConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "scanConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<ObjectSnapshotMapping>? ObjectSnapshotConfig
        // GraphQL -> objectSnapshotConfig: [ObjectSnapshotMapping!] (type)
        if (ec.Includes("objectSnapshotConfig",false))
        {
            if(this.ObjectSnapshotConfig == null) {

                this.ObjectSnapshotConfig = new List<ObjectSnapshotMapping>();
                this.ObjectSnapshotConfig.ApplyExploratoryFieldSpec(ec.NewChild("objectSnapshotConfig"));

            } else {

                this.ObjectSnapshotConfig.ApplyExploratoryFieldSpec(ec.NewChild("objectSnapshotConfig"));

            }
        }
        else if (this.ObjectSnapshotConfig != null && ec.Excludes("objectSnapshotConfig",false))
        {
            this.ObjectSnapshotConfig = null;
        }
        //      C# -> SnapshotScanConfig? ScanConfig
        // GraphQL -> scanConfig: SnapshotScanConfig (type)
        if (ec.Includes("scanConfig",false))
        {
            if(this.ScanConfig == null) {

                this.ScanConfig = new SnapshotScanConfig();
                this.ScanConfig.ApplyExploratoryFieldSpec(ec.NewChild("scanConfig"));

            } else {

                this.ScanConfig.ApplyExploratoryFieldSpec(ec.NewChild("scanConfig"));

            }
        }
        else if (this.ScanConfig != null && ec.Excludes("scanConfig",false))
        {
            this.ScanConfig = null;
        }
    }


    #endregion

    } // class ScanLimit
    
    #endregion

    public static class ListScanLimitExtensions
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
            this List<ScanLimit> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ScanLimit> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ScanLimit> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ScanLimit());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ScanLimit> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types