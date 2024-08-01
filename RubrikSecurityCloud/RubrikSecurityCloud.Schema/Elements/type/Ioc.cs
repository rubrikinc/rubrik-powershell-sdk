// Ioc.cs
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
    #region Ioc
    public class Ioc: BaseType
    {
        #region members

        //      C# -> System.String? FeedProviderId
        // GraphQL -> feedProviderId: String! (scalar)
        [JsonProperty("feedProviderId")]
        public System.String? FeedProviderId { get; set; }

        //      C# -> List<IndicatorOfCompromise>? IocList
        // GraphQL -> iocList: [IndicatorOfCompromise!]! (type)
        [JsonProperty("iocList")]
        public List<IndicatorOfCompromise>? IocList { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Ioc";
    }

    public Ioc Set(
        System.String? FeedProviderId = null,
        List<IndicatorOfCompromise>? IocList = null
    ) 
    {
        if ( FeedProviderId != null ) {
            this.FeedProviderId = FeedProviderId;
        }
        if ( IocList != null ) {
            this.IocList = IocList;
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
        //      C# -> System.String? FeedProviderId
        // GraphQL -> feedProviderId: String! (scalar)
        if (this.FeedProviderId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feedProviderId\n" ;
            } else {
                s += ind + "feedProviderId\n" ;
            }
        }
        //      C# -> List<IndicatorOfCompromise>? IocList
        // GraphQL -> iocList: [IndicatorOfCompromise!]! (type)
        if (this.IocList != null) {
            var fspec = this.IocList.AsFieldSpec(conf.Child("iocList"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "iocList" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FeedProviderId
        // GraphQL -> feedProviderId: String! (scalar)
        if (ec.Includes("feedProviderId",true))
        {
            if(this.FeedProviderId == null) {

                this.FeedProviderId = "FETCH";

            } else {


            }
        }
        else if (this.FeedProviderId != null && ec.Excludes("feedProviderId",true))
        {
            this.FeedProviderId = null;
        }
        //      C# -> List<IndicatorOfCompromise>? IocList
        // GraphQL -> iocList: [IndicatorOfCompromise!]! (type)
        if (ec.Includes("iocList",false))
        {
            if(this.IocList == null) {

                this.IocList = new List<IndicatorOfCompromise>();
                this.IocList.ApplyExploratoryFieldSpec(ec.NewChild("iocList"));

            } else {

                this.IocList.ApplyExploratoryFieldSpec(ec.NewChild("iocList"));

            }
        }
        else if (this.IocList != null && ec.Excludes("iocList",false))
        {
            this.IocList = null;
        }
    }


    #endregion

    } // class Ioc
    
    #endregion

    public static class ListIocExtensions
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
            this List<Ioc> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Ioc> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Ioc> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Ioc());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Ioc> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types