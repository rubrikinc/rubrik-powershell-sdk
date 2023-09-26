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
            this List<LambdaSettings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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