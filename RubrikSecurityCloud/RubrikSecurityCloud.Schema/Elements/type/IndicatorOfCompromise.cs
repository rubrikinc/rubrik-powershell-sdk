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
            this List<IndicatorOfCompromise> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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