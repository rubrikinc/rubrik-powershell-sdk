// M365LicenseParams.cs
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
    #region M365LicenseParams
    public class M365LicenseParams: BaseType
    {
        #region members

        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        [JsonProperty("hostType")]
        public AzureHostType? HostType { get; set; }

        //      C# -> System.Int64? Fetb
        // GraphQL -> fetb: Long! (scalar)
        [JsonProperty("fetb")]
        public System.Int64? Fetb { get; set; }

        //      C# -> System.Int32? UserCount
        // GraphQL -> userCount: Int! (scalar)
        [JsonProperty("userCount")]
        public System.Int32? UserCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365LicenseParams";
    }

    public M365LicenseParams Set(
        AzureHostType? HostType = null,
        System.Int64? Fetb = null,
        System.Int32? UserCount = null
    ) 
    {
        if ( HostType != null ) {
            this.HostType = HostType;
        }
        if ( Fetb != null ) {
            this.Fetb = Fetb;
        }
        if ( UserCount != null ) {
            this.UserCount = UserCount;
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
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (this.HostType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostType\n" ;
            } else {
                s += ind + "hostType\n" ;
            }
        }
        //      C# -> System.Int64? Fetb
        // GraphQL -> fetb: Long! (scalar)
        if (this.Fetb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fetb\n" ;
            } else {
                s += ind + "fetb\n" ;
            }
        }
        //      C# -> System.Int32? UserCount
        // GraphQL -> userCount: Int! (scalar)
        if (this.UserCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userCount\n" ;
            } else {
                s += ind + "userCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        if (ec.Includes("hostType",true))
        {
            if(this.HostType == null) {

                this.HostType = new AzureHostType();

            } else {


            }
        }
        else if (this.HostType != null && ec.Excludes("hostType",true))
        {
            this.HostType = null;
        }
        //      C# -> System.Int64? Fetb
        // GraphQL -> fetb: Long! (scalar)
        if (ec.Includes("fetb",true))
        {
            if(this.Fetb == null) {

                this.Fetb = new System.Int64();

            } else {


            }
        }
        else if (this.Fetb != null && ec.Excludes("fetb",true))
        {
            this.Fetb = null;
        }
        //      C# -> System.Int32? UserCount
        // GraphQL -> userCount: Int! (scalar)
        if (ec.Includes("userCount",true))
        {
            if(this.UserCount == null) {

                this.UserCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.UserCount != null && ec.Excludes("userCount",true))
        {
            this.UserCount = null;
        }
    }


    #endregion

    } // class M365LicenseParams
    
    #endregion

    public static class ListM365LicenseParamsExtensions
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
            this List<M365LicenseParams> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365LicenseParams> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365LicenseParams> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365LicenseParams());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365LicenseParams> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types