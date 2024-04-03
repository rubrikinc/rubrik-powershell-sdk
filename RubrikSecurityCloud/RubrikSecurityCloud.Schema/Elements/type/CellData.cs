// CellData.cs
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
    #region CellData
    public class CellData: BaseType
    {
        #region members

        //      C# -> DisplayableValue? DisplayableValue
        // GraphQL -> displayableValue: DisplayableValue (interface)
        [JsonProperty("displayableValue")]
        public DisplayableValue? DisplayableValue { get; set; }

        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        [JsonProperty("metadata")]
        public List<Metadata>? Metadata { get; set; }

        //      C# -> List<MetadataV2>? MetadataV2
        // GraphQL -> metadataV2: [MetadataV2!]! (type)
        [JsonProperty("metadataV2")]
        public List<MetadataV2>? MetadataV2 { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CellData";
    }

    public CellData Set(
        DisplayableValue? DisplayableValue = null,
        List<Metadata>? Metadata = null,
        List<MetadataV2>? MetadataV2 = null
    ) 
    {
        if ( DisplayableValue != null ) {
            this.DisplayableValue = DisplayableValue;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
        }
        if ( MetadataV2 != null ) {
            this.MetadataV2 = MetadataV2;
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
        //      C# -> DisplayableValue? DisplayableValue
        // GraphQL -> displayableValue: DisplayableValue (interface)
        if (this.DisplayableValue != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.DisplayableValue, conf.Child("displayableValue"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "displayableValue" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (this.Metadata != null) {
            var fspec = this.Metadata.AsFieldSpec(conf.Child("metadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<MetadataV2>? MetadataV2
        // GraphQL -> metadataV2: [MetadataV2!]! (type)
        if (this.MetadataV2 != null) {
            var fspec = this.MetadataV2.AsFieldSpec(conf.Child("metadataV2"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metadataV2" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DisplayableValue? DisplayableValue
        // GraphQL -> displayableValue: DisplayableValue (interface)
        if (ec.Includes("displayableValue",false))
        {
            if(this.DisplayableValue == null) {

                var impls = new List<DisplayableValue>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("displayableValue"));
                this.DisplayableValue = (DisplayableValue)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<DisplayableValue>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("displayableValue"));
                this.DisplayableValue = (DisplayableValue)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.DisplayableValue != null && ec.Excludes("displayableValue",false))
        {
            this.DisplayableValue = null;
        }
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (ec.Includes("metadata",false))
        {
            if(this.Metadata == null) {

                this.Metadata = new List<Metadata>();
                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            } else {

                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            }
        }
        else if (this.Metadata != null && ec.Excludes("metadata",false))
        {
            this.Metadata = null;
        }
        //      C# -> List<MetadataV2>? MetadataV2
        // GraphQL -> metadataV2: [MetadataV2!]! (type)
        if (ec.Includes("metadataV2",false))
        {
            if(this.MetadataV2 == null) {

                this.MetadataV2 = new List<MetadataV2>();
                this.MetadataV2.ApplyExploratoryFieldSpec(ec.NewChild("metadataV2"));

            } else {

                this.MetadataV2.ApplyExploratoryFieldSpec(ec.NewChild("metadataV2"));

            }
        }
        else if (this.MetadataV2 != null && ec.Excludes("metadataV2",false))
        {
            this.MetadataV2 = null;
        }
    }


    #endregion

    } // class CellData
    
    #endregion

    public static class ListCellDataExtensions
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
            this List<CellData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CellData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CellData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CellData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CellData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types