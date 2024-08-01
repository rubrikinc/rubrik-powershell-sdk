// SearchIocDetails.cs
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
    #region SearchIocDetails
    public class SearchIocDetails: BaseType
    {
        #region members

        //      C# -> IocSearchStatus? Status
        // GraphQL -> status: IOCSearchStatus! (enum)
        [JsonProperty("status")]
        public IocSearchStatus? Status { get; set; }

        //      C# -> IocFeedEntry? IocInfo
        // GraphQL -> iocInfo: IocFeedEntry (type)
        [JsonProperty("iocInfo")]
        public IocFeedEntry? IocInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SearchIOCDetails";
    }

    public SearchIocDetails Set(
        IocSearchStatus? Status = null,
        IocFeedEntry? IocInfo = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( IocInfo != null ) {
            this.IocInfo = IocInfo;
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
        //      C# -> IocSearchStatus? Status
        // GraphQL -> status: IOCSearchStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> IocFeedEntry? IocInfo
        // GraphQL -> iocInfo: IocFeedEntry (type)
        if (this.IocInfo != null) {
            var fspec = this.IocInfo.AsFieldSpec(conf.Child("iocInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "iocInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> IocSearchStatus? Status
        // GraphQL -> status: IOCSearchStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new IocSearchStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> IocFeedEntry? IocInfo
        // GraphQL -> iocInfo: IocFeedEntry (type)
        if (ec.Includes("iocInfo",false))
        {
            if(this.IocInfo == null) {

                this.IocInfo = new IocFeedEntry();
                this.IocInfo.ApplyExploratoryFieldSpec(ec.NewChild("iocInfo"));

            } else {

                this.IocInfo.ApplyExploratoryFieldSpec(ec.NewChild("iocInfo"));

            }
        }
        else if (this.IocInfo != null && ec.Excludes("iocInfo",false))
        {
            this.IocInfo = null;
        }
    }


    #endregion

    } // class SearchIocDetails
    
    #endregion

    public static class ListSearchIocDetailsExtensions
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
            this List<SearchIocDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SearchIocDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SearchIocDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SearchIocDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SearchIocDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types