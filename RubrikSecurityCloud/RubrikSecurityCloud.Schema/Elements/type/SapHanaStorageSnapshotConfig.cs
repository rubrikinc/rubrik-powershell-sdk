// SapHanaStorageSnapshotConfig.cs
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
    #region SapHanaStorageSnapshotConfig
    public class SapHanaStorageSnapshotConfig: BaseType
    {
        #region members

        //      C# -> Duration? Frequency
        // GraphQL -> frequency: Duration (type)
        [JsonProperty("frequency")]
        public Duration? Frequency { get; set; }

        //      C# -> Duration? Retention
        // GraphQL -> retention: Duration (type)
        [JsonProperty("retention")]
        public Duration? Retention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaStorageSnapshotConfig";
    }

    public SapHanaStorageSnapshotConfig Set(
        Duration? Frequency = null,
        Duration? Retention = null
    ) 
    {
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( Retention != null ) {
            this.Retention = Retention;
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
        //      C# -> Duration? Frequency
        // GraphQL -> frequency: Duration (type)
        if (this.Frequency != null) {
            var fspec = this.Frequency.AsFieldSpec(conf.Child("frequency"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "frequency {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Duration? Retention
        // GraphQL -> retention: Duration (type)
        if (this.Retention != null) {
            var fspec = this.Retention.AsFieldSpec(conf.Child("retention"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "retention {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Duration? Frequency
        // GraphQL -> frequency: Duration (type)
        if (ec.Includes("frequency",false))
        {
            if(this.Frequency == null) {

                this.Frequency = new Duration();
                this.Frequency.ApplyExploratoryFieldSpec(ec.NewChild("frequency"));

            } else {

                this.Frequency.ApplyExploratoryFieldSpec(ec.NewChild("frequency"));

            }
        }
        else if (this.Frequency != null && ec.Excludes("frequency",false))
        {
            this.Frequency = null;
        }
        //      C# -> Duration? Retention
        // GraphQL -> retention: Duration (type)
        if (ec.Includes("retention",false))
        {
            if(this.Retention == null) {

                this.Retention = new Duration();
                this.Retention.ApplyExploratoryFieldSpec(ec.NewChild("retention"));

            } else {

                this.Retention.ApplyExploratoryFieldSpec(ec.NewChild("retention"));

            }
        }
        else if (this.Retention != null && ec.Excludes("retention",false))
        {
            this.Retention = null;
        }
    }


    #endregion

    } // class SapHanaStorageSnapshotConfig
    
    #endregion

    public static class ListSapHanaStorageSnapshotConfigExtensions
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
            this List<SapHanaStorageSnapshotConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SapHanaStorageSnapshotConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaStorageSnapshotConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaStorageSnapshotConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaStorageSnapshotConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types