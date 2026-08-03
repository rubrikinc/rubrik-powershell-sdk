// MariadbSlaConfig.cs
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
    #region MariadbSlaConfig
    public class MariadbSlaConfig: BaseType
    {
        #region members

        //      C# -> Duration? DifferentialFrequency
        // GraphQL -> differentialFrequency: Duration (type)
        [JsonProperty("differentialFrequency")]
        public Duration? DifferentialFrequency { get; set; }

        //      C# -> Duration? DifferentialRetention
        // GraphQL -> differentialRetention: Duration (type)
        [JsonProperty("differentialRetention")]
        public Duration? DifferentialRetention { get; set; }

        //      C# -> Duration? LogFrequency
        // GraphQL -> logFrequency: Duration (type)
        [JsonProperty("logFrequency")]
        public Duration? LogFrequency { get; set; }

        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        [JsonProperty("logRetention")]
        public Duration? LogRetention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MariadbSlaConfig";
    }

    public MariadbSlaConfig Set(
        Duration? DifferentialFrequency = null,
        Duration? DifferentialRetention = null,
        Duration? LogFrequency = null,
        Duration? LogRetention = null
    ) 
    {
        if ( DifferentialFrequency != null ) {
            this.DifferentialFrequency = DifferentialFrequency;
        }
        if ( DifferentialRetention != null ) {
            this.DifferentialRetention = DifferentialRetention;
        }
        if ( LogFrequency != null ) {
            this.LogFrequency = LogFrequency;
        }
        if ( LogRetention != null ) {
            this.LogRetention = LogRetention;
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
        //      C# -> Duration? DifferentialFrequency
        // GraphQL -> differentialFrequency: Duration (type)
        if (this.DifferentialFrequency != null) {
            var fspec = this.DifferentialFrequency.AsFieldSpec(conf.Child("differentialFrequency"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "differentialFrequency" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Duration? DifferentialRetention
        // GraphQL -> differentialRetention: Duration (type)
        if (this.DifferentialRetention != null) {
            var fspec = this.DifferentialRetention.AsFieldSpec(conf.Child("differentialRetention"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "differentialRetention" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Duration? LogFrequency
        // GraphQL -> logFrequency: Duration (type)
        if (this.LogFrequency != null) {
            var fspec = this.LogFrequency.AsFieldSpec(conf.Child("logFrequency"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logFrequency" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        if (this.LogRetention != null) {
            var fspec = this.LogRetention.AsFieldSpec(conf.Child("logRetention"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logRetention" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> Duration? DifferentialFrequency
        // GraphQL -> differentialFrequency: Duration (type)
        if (ec.Includes("differentialFrequency",false))
        {
            if(this.DifferentialFrequency == null) {

                this.DifferentialFrequency = new Duration();
                this.DifferentialFrequency.ApplyExploratoryFieldSpec(ec.NewChild("differentialFrequency"));

            } else {

                this.DifferentialFrequency.ApplyExploratoryFieldSpec(ec.NewChild("differentialFrequency"));

            }
        }
        else if (this.DifferentialFrequency != null && ec.Excludes("differentialFrequency",false))
        {
            this.DifferentialFrequency = null;
        }
        //      C# -> Duration? DifferentialRetention
        // GraphQL -> differentialRetention: Duration (type)
        if (ec.Includes("differentialRetention",false))
        {
            if(this.DifferentialRetention == null) {

                this.DifferentialRetention = new Duration();
                this.DifferentialRetention.ApplyExploratoryFieldSpec(ec.NewChild("differentialRetention"));

            } else {

                this.DifferentialRetention.ApplyExploratoryFieldSpec(ec.NewChild("differentialRetention"));

            }
        }
        else if (this.DifferentialRetention != null && ec.Excludes("differentialRetention",false))
        {
            this.DifferentialRetention = null;
        }
        //      C# -> Duration? LogFrequency
        // GraphQL -> logFrequency: Duration (type)
        if (ec.Includes("logFrequency",false))
        {
            if(this.LogFrequency == null) {

                this.LogFrequency = new Duration();
                this.LogFrequency.ApplyExploratoryFieldSpec(ec.NewChild("logFrequency"));

            } else {

                this.LogFrequency.ApplyExploratoryFieldSpec(ec.NewChild("logFrequency"));

            }
        }
        else if (this.LogFrequency != null && ec.Excludes("logFrequency",false))
        {
            this.LogFrequency = null;
        }
        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        if (ec.Includes("logRetention",false))
        {
            if(this.LogRetention == null) {

                this.LogRetention = new Duration();
                this.LogRetention.ApplyExploratoryFieldSpec(ec.NewChild("logRetention"));

            } else {

                this.LogRetention.ApplyExploratoryFieldSpec(ec.NewChild("logRetention"));

            }
        }
        else if (this.LogRetention != null && ec.Excludes("logRetention",false))
        {
            this.LogRetention = null;
        }
    }


    #endregion

    } // class MariadbSlaConfig
    
    #endregion

    public static class ListMariadbSlaConfigExtensions
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
            this List<MariadbSlaConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MariadbSlaConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MariadbSlaConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MariadbSlaConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MariadbSlaConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types