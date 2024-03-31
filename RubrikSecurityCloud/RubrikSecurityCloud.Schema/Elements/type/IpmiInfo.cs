// IpmiInfo.cs
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
    #region IpmiInfo
    public class IpmiInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        [JsonProperty("isAvailable")]
        public System.Boolean? IsAvailable { get; set; }

        //      C# -> System.Boolean? UsesHttps
        // GraphQL -> usesHttps: Boolean! (scalar)
        [JsonProperty("usesHttps")]
        public System.Boolean? UsesHttps { get; set; }

        //      C# -> System.Boolean? UsesIkvm
        // GraphQL -> usesIkvm: Boolean! (scalar)
        [JsonProperty("usesIkvm")]
        public System.Boolean? UsesIkvm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IpmiInfo";
    }

    public IpmiInfo Set(
        System.Boolean? IsAvailable = null,
        System.Boolean? UsesHttps = null,
        System.Boolean? UsesIkvm = null
    ) 
    {
        if ( IsAvailable != null ) {
            this.IsAvailable = IsAvailable;
        }
        if ( UsesHttps != null ) {
            this.UsesHttps = UsesHttps;
        }
        if ( UsesIkvm != null ) {
            this.UsesIkvm = UsesIkvm;
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
        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        if (this.IsAvailable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAvailable\n" ;
            } else {
                s += ind + "isAvailable\n" ;
            }
        }
        //      C# -> System.Boolean? UsesHttps
        // GraphQL -> usesHttps: Boolean! (scalar)
        if (this.UsesHttps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usesHttps\n" ;
            } else {
                s += ind + "usesHttps\n" ;
            }
        }
        //      C# -> System.Boolean? UsesIkvm
        // GraphQL -> usesIkvm: Boolean! (scalar)
        if (this.UsesIkvm != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usesIkvm\n" ;
            } else {
                s += ind + "usesIkvm\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        if (ec.Includes("isAvailable",true))
        {
            if(this.IsAvailable == null) {

                this.IsAvailable = true;

            } else {


            }
        }
        else if (this.IsAvailable != null && ec.Excludes("isAvailable",true))
        {
            this.IsAvailable = null;
        }
        //      C# -> System.Boolean? UsesHttps
        // GraphQL -> usesHttps: Boolean! (scalar)
        if (ec.Includes("usesHttps",true))
        {
            if(this.UsesHttps == null) {

                this.UsesHttps = true;

            } else {


            }
        }
        else if (this.UsesHttps != null && ec.Excludes("usesHttps",true))
        {
            this.UsesHttps = null;
        }
        //      C# -> System.Boolean? UsesIkvm
        // GraphQL -> usesIkvm: Boolean! (scalar)
        if (ec.Includes("usesIkvm",true))
        {
            if(this.UsesIkvm == null) {

                this.UsesIkvm = true;

            } else {


            }
        }
        else if (this.UsesIkvm != null && ec.Excludes("usesIkvm",true))
        {
            this.UsesIkvm = null;
        }
    }


    #endregion

    } // class IpmiInfo
    
    #endregion

    public static class ListIpmiInfoExtensions
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
            this List<IpmiInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IpmiInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IpmiInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IpmiInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IpmiInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types