// GcpExocomputeConfig.cs
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
    #region GcpExocomputeConfig
    public class GcpExocomputeConfig: BaseType
    {
        #region members

        //      C# -> System.String? ConfigId
        // GraphQL -> configId: UUID! (scalar)
        [JsonProperty("configId")]
        public System.String? ConfigId { get; set; }

        //      C# -> RegionalExocomputeConfig? RegionalExocomputeConfig
        // GraphQL -> regionalExocomputeConfig: RegionalExocomputeConfig (type)
        [JsonProperty("regionalExocomputeConfig")]
        public RegionalExocomputeConfig? RegionalExocomputeConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpExocomputeConfig";
    }

    public GcpExocomputeConfig Set(
        System.String? ConfigId = null,
        RegionalExocomputeConfig? RegionalExocomputeConfig = null
    ) 
    {
        if ( ConfigId != null ) {
            this.ConfigId = ConfigId;
        }
        if ( RegionalExocomputeConfig != null ) {
            this.RegionalExocomputeConfig = RegionalExocomputeConfig;
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
        //      C# -> System.String? ConfigId
        // GraphQL -> configId: UUID! (scalar)
        if (this.ConfigId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configId\n" ;
            } else {
                s += ind + "configId\n" ;
            }
        }
        //      C# -> RegionalExocomputeConfig? RegionalExocomputeConfig
        // GraphQL -> regionalExocomputeConfig: RegionalExocomputeConfig (type)
        if (this.RegionalExocomputeConfig != null) {
            var fspec = this.RegionalExocomputeConfig.AsFieldSpec(conf.Child("regionalExocomputeConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "regionalExocomputeConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ConfigId
        // GraphQL -> configId: UUID! (scalar)
        if (ec.Includes("configId",true))
        {
            if(this.ConfigId == null) {

                this.ConfigId = "FETCH";

            } else {


            }
        }
        else if (this.ConfigId != null && ec.Excludes("configId",true))
        {
            this.ConfigId = null;
        }
        //      C# -> RegionalExocomputeConfig? RegionalExocomputeConfig
        // GraphQL -> regionalExocomputeConfig: RegionalExocomputeConfig (type)
        if (ec.Includes("regionalExocomputeConfig",false))
        {
            if(this.RegionalExocomputeConfig == null) {

                this.RegionalExocomputeConfig = new RegionalExocomputeConfig();
                this.RegionalExocomputeConfig.ApplyExploratoryFieldSpec(ec.NewChild("regionalExocomputeConfig"));

            } else {

                this.RegionalExocomputeConfig.ApplyExploratoryFieldSpec(ec.NewChild("regionalExocomputeConfig"));

            }
        }
        else if (this.RegionalExocomputeConfig != null && ec.Excludes("regionalExocomputeConfig",false))
        {
            this.RegionalExocomputeConfig = null;
        }
    }


    #endregion

    } // class GcpExocomputeConfig
    
    #endregion

    public static class ListGcpExocomputeConfigExtensions
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
            this List<GcpExocomputeConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpExocomputeConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpExocomputeConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpExocomputeConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpExocomputeConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types