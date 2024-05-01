// IntegrationConfig.cs
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
    #region IntegrationConfig
    public class IntegrationConfig: BaseType
    {
        #region members

        //      C# -> DlpConfig? DataLossPrevention
        // GraphQL -> dataLossPrevention: DlpConfig (type)
        [JsonProperty("dataLossPrevention")]
        public DlpConfig? DataLossPrevention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntegrationConfig";
    }

    public IntegrationConfig Set(
        DlpConfig? DataLossPrevention = null
    ) 
    {
        if ( DataLossPrevention != null ) {
            this.DataLossPrevention = DataLossPrevention;
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
        //      C# -> DlpConfig? DataLossPrevention
        // GraphQL -> dataLossPrevention: DlpConfig (type)
        if (this.DataLossPrevention != null) {
            var fspec = this.DataLossPrevention.AsFieldSpec(conf.Child("dataLossPrevention"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataLossPrevention" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DlpConfig? DataLossPrevention
        // GraphQL -> dataLossPrevention: DlpConfig (type)
        if (ec.Includes("dataLossPrevention",false))
        {
            if(this.DataLossPrevention == null) {

                this.DataLossPrevention = new DlpConfig();
                this.DataLossPrevention.ApplyExploratoryFieldSpec(ec.NewChild("dataLossPrevention"));

            } else {

                this.DataLossPrevention.ApplyExploratoryFieldSpec(ec.NewChild("dataLossPrevention"));

            }
        }
        else if (this.DataLossPrevention != null && ec.Excludes("dataLossPrevention",false))
        {
            this.DataLossPrevention = null;
        }
    }


    #endregion

    } // class IntegrationConfig
    
    #endregion

    public static class ListIntegrationConfigExtensions
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
            this List<IntegrationConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntegrationConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntegrationConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntegrationConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntegrationConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types