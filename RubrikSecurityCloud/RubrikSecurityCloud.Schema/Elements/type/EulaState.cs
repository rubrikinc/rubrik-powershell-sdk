// EulaState.cs
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
    #region EulaState
    public class EulaState: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        [JsonProperty("isAccepted")]
        public System.Boolean? IsAccepted { get; set; }

        //      C# -> System.Boolean? IsPactsafeEnabled
        // GraphQL -> isPactsafeEnabled: Boolean! (scalar)
        [JsonProperty("isPactsafeEnabled")]
        public System.Boolean? IsPactsafeEnabled { get; set; }

        //      C# -> System.Boolean? IsPactsafeV2Enabled
        // GraphQL -> isPactsafeV2Enabled: Boolean! (scalar)
        [JsonProperty("isPactsafeV2Enabled")]
        public System.Boolean? IsPactsafeV2Enabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EulaState";
    }

    public EulaState Set(
        System.Boolean? IsAccepted = null,
        System.Boolean? IsPactsafeEnabled = null,
        System.Boolean? IsPactsafeV2Enabled = null
    ) 
    {
        if ( IsAccepted != null ) {
            this.IsAccepted = IsAccepted;
        }
        if ( IsPactsafeEnabled != null ) {
            this.IsPactsafeEnabled = IsPactsafeEnabled;
        }
        if ( IsPactsafeV2Enabled != null ) {
            this.IsPactsafeV2Enabled = IsPactsafeV2Enabled;
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
        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        if (this.IsAccepted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAccepted\n" ;
            } else {
                s += ind + "isAccepted\n" ;
            }
        }
        //      C# -> System.Boolean? IsPactsafeEnabled
        // GraphQL -> isPactsafeEnabled: Boolean! (scalar)
        if (this.IsPactsafeEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPactsafeEnabled\n" ;
            } else {
                s += ind + "isPactsafeEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsPactsafeV2Enabled
        // GraphQL -> isPactsafeV2Enabled: Boolean! (scalar)
        if (this.IsPactsafeV2Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPactsafeV2Enabled\n" ;
            } else {
                s += ind + "isPactsafeV2Enabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        if (ec.Includes("isAccepted",true))
        {
            if(this.IsAccepted == null) {

                this.IsAccepted = true;

            } else {


            }
        }
        else if (this.IsAccepted != null && ec.Excludes("isAccepted",true))
        {
            this.IsAccepted = null;
        }
        //      C# -> System.Boolean? IsPactsafeEnabled
        // GraphQL -> isPactsafeEnabled: Boolean! (scalar)
        if (ec.Includes("isPactsafeEnabled",true))
        {
            if(this.IsPactsafeEnabled == null) {

                this.IsPactsafeEnabled = true;

            } else {


            }
        }
        else if (this.IsPactsafeEnabled != null && ec.Excludes("isPactsafeEnabled",true))
        {
            this.IsPactsafeEnabled = null;
        }
        //      C# -> System.Boolean? IsPactsafeV2Enabled
        // GraphQL -> isPactsafeV2Enabled: Boolean! (scalar)
        if (ec.Includes("isPactsafeV2Enabled",true))
        {
            if(this.IsPactsafeV2Enabled == null) {

                this.IsPactsafeV2Enabled = true;

            } else {


            }
        }
        else if (this.IsPactsafeV2Enabled != null && ec.Excludes("isPactsafeV2Enabled",true))
        {
            this.IsPactsafeV2Enabled = null;
        }
    }


    #endregion

    } // class EulaState
    
    #endregion

    public static class ListEulaStateExtensions
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
            this List<EulaState> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<EulaState> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EulaState> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EulaState());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EulaState> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types