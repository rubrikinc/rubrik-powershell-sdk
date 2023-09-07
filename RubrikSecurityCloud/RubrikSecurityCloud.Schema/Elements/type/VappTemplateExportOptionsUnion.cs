// VappTemplateExportOptionsUnion.cs
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
    #region VappTemplateExportOptionsUnion
    public class VappTemplateExportOptionsUnion: BaseType
    {
        #region members

        //      C# -> VappTemplateExportOptions? AdvancedExportOptions
        // GraphQL -> advancedExportOptions: VappTemplateExportOptions (type)
        [JsonProperty("advancedExportOptions")]
        public VappTemplateExportOptions? AdvancedExportOptions { get; set; }

        //      C# -> VappTemplateExportOptions? DefaultCatalogExportOptions
        // GraphQL -> defaultCatalogExportOptions: VappTemplateExportOptions (type)
        [JsonProperty("defaultCatalogExportOptions")]
        public VappTemplateExportOptions? DefaultCatalogExportOptions { get; set; }

        //      C# -> VappTemplateExportOptions? OriginalVdcExportOptions
        // GraphQL -> originalVdcExportOptions: VappTemplateExportOptions (type)
        [JsonProperty("originalVdcExportOptions")]
        public VappTemplateExportOptions? OriginalVdcExportOptions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappTemplateExportOptionsUnion";
    }

    public VappTemplateExportOptionsUnion Set(
        VappTemplateExportOptions? AdvancedExportOptions = null,
        VappTemplateExportOptions? DefaultCatalogExportOptions = null,
        VappTemplateExportOptions? OriginalVdcExportOptions = null
    ) 
    {
        if ( AdvancedExportOptions != null ) {
            this.AdvancedExportOptions = AdvancedExportOptions;
        }
        if ( DefaultCatalogExportOptions != null ) {
            this.DefaultCatalogExportOptions = DefaultCatalogExportOptions;
        }
        if ( OriginalVdcExportOptions != null ) {
            this.OriginalVdcExportOptions = OriginalVdcExportOptions;
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
        //      C# -> VappTemplateExportOptions? AdvancedExportOptions
        // GraphQL -> advancedExportOptions: VappTemplateExportOptions (type)
        if (this.AdvancedExportOptions != null) {
            var fspec = this.AdvancedExportOptions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "advancedExportOptions {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VappTemplateExportOptions? DefaultCatalogExportOptions
        // GraphQL -> defaultCatalogExportOptions: VappTemplateExportOptions (type)
        if (this.DefaultCatalogExportOptions != null) {
            var fspec = this.DefaultCatalogExportOptions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "defaultCatalogExportOptions {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VappTemplateExportOptions? OriginalVdcExportOptions
        // GraphQL -> originalVdcExportOptions: VappTemplateExportOptions (type)
        if (this.OriginalVdcExportOptions != null) {
            var fspec = this.OriginalVdcExportOptions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "originalVdcExportOptions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VappTemplateExportOptions? AdvancedExportOptions
        // GraphQL -> advancedExportOptions: VappTemplateExportOptions (type)
        if (this.AdvancedExportOptions == null && ec.Includes("advancedExportOptions",false))
        {
            this.AdvancedExportOptions = new VappTemplateExportOptions();
            this.AdvancedExportOptions.ApplyExploratoryFieldSpec(ec.NewChild("advancedExportOptions"));
        }
        //      C# -> VappTemplateExportOptions? DefaultCatalogExportOptions
        // GraphQL -> defaultCatalogExportOptions: VappTemplateExportOptions (type)
        if (this.DefaultCatalogExportOptions == null && ec.Includes("defaultCatalogExportOptions",false))
        {
            this.DefaultCatalogExportOptions = new VappTemplateExportOptions();
            this.DefaultCatalogExportOptions.ApplyExploratoryFieldSpec(ec.NewChild("defaultCatalogExportOptions"));
        }
        //      C# -> VappTemplateExportOptions? OriginalVdcExportOptions
        // GraphQL -> originalVdcExportOptions: VappTemplateExportOptions (type)
        if (this.OriginalVdcExportOptions == null && ec.Includes("originalVdcExportOptions",false))
        {
            this.OriginalVdcExportOptions = new VappTemplateExportOptions();
            this.OriginalVdcExportOptions.ApplyExploratoryFieldSpec(ec.NewChild("originalVdcExportOptions"));
        }
    }


    #endregion

    } // class VappTemplateExportOptionsUnion
    
    #endregion

    public static class ListVappTemplateExportOptionsUnionExtensions
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
            this List<VappTemplateExportOptionsUnion> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VappTemplateExportOptionsUnion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VappTemplateExportOptionsUnion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VappTemplateExportOptionsUnion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types