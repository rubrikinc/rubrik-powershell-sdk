// ArchivalLocationForecastRefreshStatus.cs
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
    #region ArchivalLocationForecastRefreshStatus
    public class ArchivalLocationForecastRefreshStatus: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsRefreshInProgress
        // GraphQL -> isRefreshInProgress: Boolean! (scalar)
        [JsonProperty("isRefreshInProgress")]
        public System.Boolean? IsRefreshInProgress { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalLocationForecastRefreshStatus";
    }

    public ArchivalLocationForecastRefreshStatus Set(
        System.Boolean? IsRefreshInProgress = null
    ) 
    {
        if ( IsRefreshInProgress != null ) {
            this.IsRefreshInProgress = IsRefreshInProgress;
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
        //      C# -> System.Boolean? IsRefreshInProgress
        // GraphQL -> isRefreshInProgress: Boolean! (scalar)
        if (this.IsRefreshInProgress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRefreshInProgress\n" ;
            } else {
                s += ind + "isRefreshInProgress\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsRefreshInProgress
        // GraphQL -> isRefreshInProgress: Boolean! (scalar)
        if (ec.Includes("isRefreshInProgress",true))
        {
            if(this.IsRefreshInProgress == null) {

                this.IsRefreshInProgress = true;

            } else {


            }
        }
        else if (this.IsRefreshInProgress != null && ec.Excludes("isRefreshInProgress",true))
        {
            this.IsRefreshInProgress = null;
        }
    }


    #endregion

    } // class ArchivalLocationForecastRefreshStatus
    
    #endregion

    public static class ListArchivalLocationForecastRefreshStatusExtensions
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
            this List<ArchivalLocationForecastRefreshStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalLocationForecastRefreshStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationForecastRefreshStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationForecastRefreshStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalLocationForecastRefreshStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types