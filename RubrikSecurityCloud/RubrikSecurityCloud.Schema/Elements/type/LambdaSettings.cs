// LambdaSettings.cs
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
    #region LambdaSettings
    public class LambdaSettings: BaseType
    {
        #region members

        //      C# -> System.Single? AnomalyThreshold
        // GraphQL -> anomalyThreshold: Float (scalar)
        [JsonProperty("anomalyThreshold")]
        public System.Single? AnomalyThreshold { get; set; }

        //      C# -> System.Boolean? IsAnomalyAlertEnabled
        // GraphQL -> isAnomalyAlertEnabled: Boolean (scalar)
        [JsonProperty("isAnomalyAlertEnabled")]
        public System.Boolean? IsAnomalyAlertEnabled { get; set; }

        //      C# -> System.Single? RansomwareThreshold
        // GraphQL -> ransomwareThreshold: Float (scalar)
        [JsonProperty("ransomwareThreshold")]
        public System.Single? RansomwareThreshold { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LambdaSettings";
    }

    public LambdaSettings Set(
        System.Single? AnomalyThreshold = null,
        System.Boolean? IsAnomalyAlertEnabled = null,
        System.Single? RansomwareThreshold = null
    ) 
    {
        if ( AnomalyThreshold != null ) {
            this.AnomalyThreshold = AnomalyThreshold;
        }
        if ( IsAnomalyAlertEnabled != null ) {
            this.IsAnomalyAlertEnabled = IsAnomalyAlertEnabled;
        }
        if ( RansomwareThreshold != null ) {
            this.RansomwareThreshold = RansomwareThreshold;
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
        //      C# -> System.Single? AnomalyThreshold
        // GraphQL -> anomalyThreshold: Float (scalar)
        if (this.AnomalyThreshold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomalyThreshold\n" ;
            } else {
                s += ind + "anomalyThreshold\n" ;
            }
        }
        //      C# -> System.Boolean? IsAnomalyAlertEnabled
        // GraphQL -> isAnomalyAlertEnabled: Boolean (scalar)
        if (this.IsAnomalyAlertEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAnomalyAlertEnabled\n" ;
            } else {
                s += ind + "isAnomalyAlertEnabled\n" ;
            }
        }
        //      C# -> System.Single? RansomwareThreshold
        // GraphQL -> ransomwareThreshold: Float (scalar)
        if (this.RansomwareThreshold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ransomwareThreshold\n" ;
            } else {
                s += ind + "ransomwareThreshold\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Single? AnomalyThreshold
        // GraphQL -> anomalyThreshold: Float (scalar)
        if (ec.Includes("anomalyThreshold",true))
        {
            if(this.AnomalyThreshold == null) {

                this.AnomalyThreshold = new System.Single();

            } else {


            }
        }
        else if (this.AnomalyThreshold != null && ec.Excludes("anomalyThreshold",true))
        {
            this.AnomalyThreshold = null;
        }
        //      C# -> System.Boolean? IsAnomalyAlertEnabled
        // GraphQL -> isAnomalyAlertEnabled: Boolean (scalar)
        if (ec.Includes("isAnomalyAlertEnabled",true))
        {
            if(this.IsAnomalyAlertEnabled == null) {

                this.IsAnomalyAlertEnabled = true;

            } else {


            }
        }
        else if (this.IsAnomalyAlertEnabled != null && ec.Excludes("isAnomalyAlertEnabled",true))
        {
            this.IsAnomalyAlertEnabled = null;
        }
        //      C# -> System.Single? RansomwareThreshold
        // GraphQL -> ransomwareThreshold: Float (scalar)
        if (ec.Includes("ransomwareThreshold",true))
        {
            if(this.RansomwareThreshold == null) {

                this.RansomwareThreshold = new System.Single();

            } else {


            }
        }
        else if (this.RansomwareThreshold != null && ec.Excludes("ransomwareThreshold",true))
        {
            this.RansomwareThreshold = null;
        }
    }


    #endregion

    } // class LambdaSettings
    
    #endregion

    public static class ListLambdaSettingsExtensions
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
            this List<LambdaSettings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LambdaSettings> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LambdaSettings> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LambdaSettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LambdaSettings> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types