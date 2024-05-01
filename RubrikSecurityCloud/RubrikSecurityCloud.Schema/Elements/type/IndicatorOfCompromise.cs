// IndicatorOfCompromise.cs
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
    #region IndicatorOfCompromise
    public class IndicatorOfCompromise: BaseType
    {
        #region members

        //      C# -> IndicatorOfCompromiseKind? IocKind
        // GraphQL -> iocKind: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("iocKind")]
        public IndicatorOfCompromiseKind? IocKind { get; set; }

        //      C# -> System.String? IocValue
        // GraphQL -> iocValue: String! (scalar)
        [JsonProperty("iocValue")]
        public System.String? IocValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IndicatorOfCompromise";
    }

    public IndicatorOfCompromise Set(
        IndicatorOfCompromiseKind? IocKind = null,
        System.String? IocValue = null
    ) 
    {
        if ( IocKind != null ) {
            this.IocKind = IocKind;
        }
        if ( IocValue != null ) {
            this.IocValue = IocValue;
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
        //      C# -> IndicatorOfCompromiseKind? IocKind
        // GraphQL -> iocKind: IndicatorOfCompromiseKind! (enum)
        if (this.IocKind != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iocKind\n" ;
            } else {
                s += ind + "iocKind\n" ;
            }
        }
        //      C# -> System.String? IocValue
        // GraphQL -> iocValue: String! (scalar)
        if (this.IocValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iocValue\n" ;
            } else {
                s += ind + "iocValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> IndicatorOfCompromiseKind? IocKind
        // GraphQL -> iocKind: IndicatorOfCompromiseKind! (enum)
        if (ec.Includes("iocKind",true))
        {
            if(this.IocKind == null) {

                this.IocKind = new IndicatorOfCompromiseKind();

            } else {


            }
        }
        else if (this.IocKind != null && ec.Excludes("iocKind",true))
        {
            this.IocKind = null;
        }
        //      C# -> System.String? IocValue
        // GraphQL -> iocValue: String! (scalar)
        if (ec.Includes("iocValue",true))
        {
            if(this.IocValue == null) {

                this.IocValue = "FETCH";

            } else {


            }
        }
        else if (this.IocValue != null && ec.Excludes("iocValue",true))
        {
            this.IocValue = null;
        }
    }


    #endregion

    } // class IndicatorOfCompromise
    
    #endregion

    public static class ListIndicatorOfCompromiseExtensions
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
            this List<IndicatorOfCompromise> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IndicatorOfCompromise> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IndicatorOfCompromise> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IndicatorOfCompromise());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IndicatorOfCompromise> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types