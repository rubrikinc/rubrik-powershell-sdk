// CloudNativeLabel.cs
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
    #region CloudNativeLabel
    public class CloudNativeLabel: BaseType
    {
        #region members

        //      C# -> System.String? LabelKey
        // GraphQL -> labelKey: String! (scalar)
        [JsonProperty("labelKey")]
        public System.String? LabelKey { get; set; }

        //      C# -> System.String? LabelValue
        // GraphQL -> labelValue: String! (scalar)
        [JsonProperty("labelValue")]
        public System.String? LabelValue { get; set; }

        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        [JsonProperty("matchAllValues")]
        public System.Boolean? MatchAllValues { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeLabel";
    }

    public CloudNativeLabel Set(
        System.String? LabelKey = null,
        System.String? LabelValue = null,
        System.Boolean? MatchAllValues = null
    ) 
    {
        if ( LabelKey != null ) {
            this.LabelKey = LabelKey;
        }
        if ( LabelValue != null ) {
            this.LabelValue = LabelValue;
        }
        if ( MatchAllValues != null ) {
            this.MatchAllValues = MatchAllValues;
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
        //      C# -> System.String? LabelKey
        // GraphQL -> labelKey: String! (scalar)
        if (this.LabelKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "labelKey\n" ;
            } else {
                s += ind + "labelKey\n" ;
            }
        }
        //      C# -> System.String? LabelValue
        // GraphQL -> labelValue: String! (scalar)
        if (this.LabelValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "labelValue\n" ;
            } else {
                s += ind + "labelValue\n" ;
            }
        }
        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        if (this.MatchAllValues != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchAllValues\n" ;
            } else {
                s += ind + "matchAllValues\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? LabelKey
        // GraphQL -> labelKey: String! (scalar)
        if (ec.Includes("labelKey",true))
        {
            if(this.LabelKey == null) {

                this.LabelKey = "FETCH";

            } else {


            }
        }
        else if (this.LabelKey != null && ec.Excludes("labelKey",true))
        {
            this.LabelKey = null;
        }
        //      C# -> System.String? LabelValue
        // GraphQL -> labelValue: String! (scalar)
        if (ec.Includes("labelValue",true))
        {
            if(this.LabelValue == null) {

                this.LabelValue = "FETCH";

            } else {


            }
        }
        else if (this.LabelValue != null && ec.Excludes("labelValue",true))
        {
            this.LabelValue = null;
        }
        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        if (ec.Includes("matchAllValues",true))
        {
            if(this.MatchAllValues == null) {

                this.MatchAllValues = true;

            } else {


            }
        }
        else if (this.MatchAllValues != null && ec.Excludes("matchAllValues",true))
        {
            this.MatchAllValues = null;
        }
    }


    #endregion

    } // class CloudNativeLabel
    
    #endregion

    public static class ListCloudNativeLabelExtensions
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
            this List<CloudNativeLabel> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeLabel> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeLabel> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeLabel());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeLabel> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types