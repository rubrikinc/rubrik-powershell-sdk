// MosaicRecoveryRangeObject.cs
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
    #region MosaicRecoveryRangeObject
    public class MosaicRecoveryRangeObject: BaseType
    {
        #region members

        //      C# -> System.String? EarliestTimestamp
        // GraphQL -> earliestTimestamp: String (scalar)
        [JsonProperty("earliestTimestamp")]
        public System.String? EarliestTimestamp { get; set; }

        //      C# -> System.String? LatestTimestamp
        // GraphQL -> latestTimestamp: String (scalar)
        [JsonProperty("latestTimestamp")]
        public System.String? LatestTimestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MosaicRecoveryRangeObject";
    }

    public MosaicRecoveryRangeObject Set(
        System.String? EarliestTimestamp = null,
        System.String? LatestTimestamp = null
    ) 
    {
        if ( EarliestTimestamp != null ) {
            this.EarliestTimestamp = EarliestTimestamp;
        }
        if ( LatestTimestamp != null ) {
            this.LatestTimestamp = LatestTimestamp;
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
        //      C# -> System.String? EarliestTimestamp
        // GraphQL -> earliestTimestamp: String (scalar)
        if (this.EarliestTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "earliestTimestamp\n" ;
            } else {
                s += ind + "earliestTimestamp\n" ;
            }
        }
        //      C# -> System.String? LatestTimestamp
        // GraphQL -> latestTimestamp: String (scalar)
        if (this.LatestTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestTimestamp\n" ;
            } else {
                s += ind + "latestTimestamp\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? EarliestTimestamp
        // GraphQL -> earliestTimestamp: String (scalar)
        if (ec.Includes("earliestTimestamp",true))
        {
            if(this.EarliestTimestamp == null) {

                this.EarliestTimestamp = "FETCH";

            } else {


            }
        }
        else if (this.EarliestTimestamp != null && ec.Excludes("earliestTimestamp",true))
        {
            this.EarliestTimestamp = null;
        }
        //      C# -> System.String? LatestTimestamp
        // GraphQL -> latestTimestamp: String (scalar)
        if (ec.Includes("latestTimestamp",true))
        {
            if(this.LatestTimestamp == null) {

                this.LatestTimestamp = "FETCH";

            } else {


            }
        }
        else if (this.LatestTimestamp != null && ec.Excludes("latestTimestamp",true))
        {
            this.LatestTimestamp = null;
        }
    }


    #endregion

    } // class MosaicRecoveryRangeObject
    
    #endregion

    public static class ListMosaicRecoveryRangeObjectExtensions
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
            this List<MosaicRecoveryRangeObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MosaicRecoveryRangeObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MosaicRecoveryRangeObject> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicRecoveryRangeObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MosaicRecoveryRangeObject> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types