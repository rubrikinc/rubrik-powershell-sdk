// IpmiAccess.cs
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
    #region IpmiAccess
    public class IpmiAccess: BaseType
    {
        #region members

        //      C# -> System.Boolean? Https
        // GraphQL -> https: Boolean! (scalar)
        [JsonProperty("https")]
        public System.Boolean? Https { get; set; }

        //      C# -> System.Boolean? Ikvm
        // GraphQL -> iKvm: Boolean! (scalar)
        [JsonProperty("iKvm")]
        public System.Boolean? Ikvm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IpmiAccess";
    }

    public IpmiAccess Set(
        System.Boolean? Https = null,
        System.Boolean? Ikvm = null
    ) 
    {
        if ( Https != null ) {
            this.Https = Https;
        }
        if ( Ikvm != null ) {
            this.Ikvm = Ikvm;
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
        //      C# -> System.Boolean? Https
        // GraphQL -> https: Boolean! (scalar)
        if (this.Https != null) {
            if (conf.Flat) {
                s += conf.Prefix + "https\n" ;
            } else {
                s += ind + "https\n" ;
            }
        }
        //      C# -> System.Boolean? Ikvm
        // GraphQL -> iKvm: Boolean! (scalar)
        if (this.Ikvm != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iKvm\n" ;
            } else {
                s += ind + "iKvm\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? Https
        // GraphQL -> https: Boolean! (scalar)
        if (ec.Includes("https",true))
        {
            if(this.Https == null) {

                this.Https = true;

            } else {


            }
        }
        else if (this.Https != null && ec.Excludes("https",true))
        {
            this.Https = null;
        }
        //      C# -> System.Boolean? Ikvm
        // GraphQL -> iKvm: Boolean! (scalar)
        if (ec.Includes("iKvm",true))
        {
            if(this.Ikvm == null) {

                this.Ikvm = true;

            } else {


            }
        }
        else if (this.Ikvm != null && ec.Excludes("iKvm",true))
        {
            this.Ikvm = null;
        }
    }


    #endregion

    } // class IpmiAccess
    
    #endregion

    public static class ListIpmiAccessExtensions
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
            this List<IpmiAccess> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IpmiAccess> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IpmiAccess> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IpmiAccess());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IpmiAccess> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types