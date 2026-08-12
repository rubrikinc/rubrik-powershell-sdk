// AnomalyDetectionConfig.cs
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
    #region AnomalyDetectionConfig
    public class AnomalyDetectionConfig: BaseType
    {
        #region members

        //      C# -> List<System.Int32>? ErrorCodes
        // GraphQL -> errorCodes: [Int!]! (scalar)
        [JsonProperty("errorCodes")]
        public List<System.Int32>? ErrorCodes { get; set; }

        //      C# -> System.Int32? LatenessBufferMinutes
        // GraphQL -> latenessBufferMinutes: Int! (scalar)
        [JsonProperty("latenessBufferMinutes")]
        public System.Int32? LatenessBufferMinutes { get; set; }

        //      C# -> System.Int32? QuietPeriodMinutes
        // GraphQL -> quietPeriodMinutes: Int! (scalar)
        [JsonProperty("quietPeriodMinutes")]
        public System.Int32? QuietPeriodMinutes { get; set; }

        //      C# -> List<System.String>? Results
        // GraphQL -> results: [String!]! (scalar)
        [JsonProperty("results")]
        public List<System.String>? Results { get; set; }

        //      C# -> System.Int64? Threshold
        // GraphQL -> threshold: Long! (scalar)
        [JsonProperty("threshold")]
        public System.Int64? Threshold { get; set; }

        //      C# -> System.Int32? WindowMinutes
        // GraphQL -> windowMinutes: Int! (scalar)
        [JsonProperty("windowMinutes")]
        public System.Int32? WindowMinutes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnomalyDetectionConfig";
    }

    public AnomalyDetectionConfig Set(
        List<System.Int32>? ErrorCodes = null,
        System.Int32? LatenessBufferMinutes = null,
        System.Int32? QuietPeriodMinutes = null,
        List<System.String>? Results = null,
        System.Int64? Threshold = null,
        System.Int32? WindowMinutes = null
    ) 
    {
        if ( ErrorCodes != null ) {
            this.ErrorCodes = ErrorCodes;
        }
        if ( LatenessBufferMinutes != null ) {
            this.LatenessBufferMinutes = LatenessBufferMinutes;
        }
        if ( QuietPeriodMinutes != null ) {
            this.QuietPeriodMinutes = QuietPeriodMinutes;
        }
        if ( Results != null ) {
            this.Results = Results;
        }
        if ( Threshold != null ) {
            this.Threshold = Threshold;
        }
        if ( WindowMinutes != null ) {
            this.WindowMinutes = WindowMinutes;
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
        //      C# -> List<System.Int32>? ErrorCodes
        // GraphQL -> errorCodes: [Int!]! (scalar)
        if (this.ErrorCodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorCodes\n" ;
            } else {
                s += ind + "errorCodes\n" ;
            }
        }
        //      C# -> System.Int32? LatenessBufferMinutes
        // GraphQL -> latenessBufferMinutes: Int! (scalar)
        if (this.LatenessBufferMinutes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latenessBufferMinutes\n" ;
            } else {
                s += ind + "latenessBufferMinutes\n" ;
            }
        }
        //      C# -> System.Int32? QuietPeriodMinutes
        // GraphQL -> quietPeriodMinutes: Int! (scalar)
        if (this.QuietPeriodMinutes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "quietPeriodMinutes\n" ;
            } else {
                s += ind + "quietPeriodMinutes\n" ;
            }
        }
        //      C# -> List<System.String>? Results
        // GraphQL -> results: [String!]! (scalar)
        if (this.Results != null) {
            if (conf.Flat) {
                s += conf.Prefix + "results\n" ;
            } else {
                s += ind + "results\n" ;
            }
        }
        //      C# -> System.Int64? Threshold
        // GraphQL -> threshold: Long! (scalar)
        if (this.Threshold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "threshold\n" ;
            } else {
                s += ind + "threshold\n" ;
            }
        }
        //      C# -> System.Int32? WindowMinutes
        // GraphQL -> windowMinutes: Int! (scalar)
        if (this.WindowMinutes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "windowMinutes\n" ;
            } else {
                s += ind + "windowMinutes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.Int32>? ErrorCodes
        // GraphQL -> errorCodes: [Int!]! (scalar)
        if (ec.Includes("errorCodes",true))
        {
            if(this.ErrorCodes == null) {

                this.ErrorCodes = new List<System.Int32>();

            } else {


            }
        }
        else if (this.ErrorCodes != null && ec.Excludes("errorCodes",true))
        {
            this.ErrorCodes = null;
        }
        //      C# -> System.Int32? LatenessBufferMinutes
        // GraphQL -> latenessBufferMinutes: Int! (scalar)
        if (ec.Includes("latenessBufferMinutes",true))
        {
            if(this.LatenessBufferMinutes == null) {

                this.LatenessBufferMinutes = Int32.MinValue;

            } else {


            }
        }
        else if (this.LatenessBufferMinutes != null && ec.Excludes("latenessBufferMinutes",true))
        {
            this.LatenessBufferMinutes = null;
        }
        //      C# -> System.Int32? QuietPeriodMinutes
        // GraphQL -> quietPeriodMinutes: Int! (scalar)
        if (ec.Includes("quietPeriodMinutes",true))
        {
            if(this.QuietPeriodMinutes == null) {

                this.QuietPeriodMinutes = Int32.MinValue;

            } else {


            }
        }
        else if (this.QuietPeriodMinutes != null && ec.Excludes("quietPeriodMinutes",true))
        {
            this.QuietPeriodMinutes = null;
        }
        //      C# -> List<System.String>? Results
        // GraphQL -> results: [String!]! (scalar)
        if (ec.Includes("results",true))
        {
            if(this.Results == null) {

                this.Results = new List<System.String>();

            } else {


            }
        }
        else if (this.Results != null && ec.Excludes("results",true))
        {
            this.Results = null;
        }
        //      C# -> System.Int64? Threshold
        // GraphQL -> threshold: Long! (scalar)
        if (ec.Includes("threshold",true))
        {
            if(this.Threshold == null) {

                this.Threshold = new System.Int64();

            } else {


            }
        }
        else if (this.Threshold != null && ec.Excludes("threshold",true))
        {
            this.Threshold = null;
        }
        //      C# -> System.Int32? WindowMinutes
        // GraphQL -> windowMinutes: Int! (scalar)
        if (ec.Includes("windowMinutes",true))
        {
            if(this.WindowMinutes == null) {

                this.WindowMinutes = Int32.MinValue;

            } else {


            }
        }
        else if (this.WindowMinutes != null && ec.Excludes("windowMinutes",true))
        {
            this.WindowMinutes = null;
        }
    }


    #endregion

    } // class AnomalyDetectionConfig
    
    #endregion

    public static class ListAnomalyDetectionConfigExtensions
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
            this List<AnomalyDetectionConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnomalyDetectionConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnomalyDetectionConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnomalyDetectionConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnomalyDetectionConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types