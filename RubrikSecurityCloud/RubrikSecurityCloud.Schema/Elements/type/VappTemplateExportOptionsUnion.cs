// VappTemplateExportOptionsUnion.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:04.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region VappTemplateExportOptionsUnion
    public class VappTemplateExportOptionsUnion: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> VappTemplateExportOptions? AdvancedExportOptions
            // GraphQL -> advancedExportOptions: VappTemplateExportOptions (type)
            if (this.AdvancedExportOptions != null)
            {
                 s += ind + "advancedExportOptions\n";

                 s += ind + "{\n" + 
                 this.AdvancedExportOptions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VappTemplateExportOptions? DefaultCatalogExportOptions
            // GraphQL -> defaultCatalogExportOptions: VappTemplateExportOptions (type)
            if (this.DefaultCatalogExportOptions != null)
            {
                 s += ind + "defaultCatalogExportOptions\n";

                 s += ind + "{\n" + 
                 this.DefaultCatalogExportOptions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VappTemplateExportOptions? OriginalVdcExportOptions
            // GraphQL -> originalVdcExportOptions: VappTemplateExportOptions (type)
            if (this.OriginalVdcExportOptions != null)
            {
                 s += ind + "originalVdcExportOptions\n";

                 s += ind + "{\n" + 
                 this.OriginalVdcExportOptions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> VappTemplateExportOptions? AdvancedExportOptions
            // GraphQL -> advancedExportOptions: VappTemplateExportOptions (type)
            if (this.AdvancedExportOptions == null && Exploration.Includes(parent + ".advancedExportOptions"))
            {
                this.AdvancedExportOptions = new VappTemplateExportOptions();
                this.AdvancedExportOptions.ApplyExploratoryFragment(parent + ".advancedExportOptions");
            }
            //      C# -> VappTemplateExportOptions? DefaultCatalogExportOptions
            // GraphQL -> defaultCatalogExportOptions: VappTemplateExportOptions (type)
            if (this.DefaultCatalogExportOptions == null && Exploration.Includes(parent + ".defaultCatalogExportOptions"))
            {
                this.DefaultCatalogExportOptions = new VappTemplateExportOptions();
                this.DefaultCatalogExportOptions.ApplyExploratoryFragment(parent + ".defaultCatalogExportOptions");
            }
            //      C# -> VappTemplateExportOptions? OriginalVdcExportOptions
            // GraphQL -> originalVdcExportOptions: VappTemplateExportOptions (type)
            if (this.OriginalVdcExportOptions == null && Exploration.Includes(parent + ".originalVdcExportOptions"))
            {
                this.OriginalVdcExportOptions = new VappTemplateExportOptions();
                this.OriginalVdcExportOptions.ApplyExploratoryFragment(parent + ".originalVdcExportOptions");
            }
        }


    #endregion

    } // class VappTemplateExportOptionsUnion
    #endregion

    public static class ListVappTemplateExportOptionsUnionExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<VappTemplateExportOptionsUnion> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VappTemplateExportOptionsUnion> list, 
            String parent = "")
        {
            var item = new VappTemplateExportOptionsUnion();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types