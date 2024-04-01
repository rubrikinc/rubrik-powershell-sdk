// InterfaceCidr.cs
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
    #region InterfaceCidr
    public class InterfaceCidr: BaseType
    {
        #region members

        //      C# -> InterfaceType? InterfaceType
        // GraphQL -> interfaceType: InterfaceType! (enum)
        [JsonProperty("interfaceType")]
        public InterfaceType? InterfaceType { get; set; }

        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        [JsonProperty("cidr")]
        public System.String? Cidr { get; set; }

        //      C# -> System.Boolean? Selected
        // GraphQL -> selected: Boolean! (scalar)
        [JsonProperty("selected")]
        public System.Boolean? Selected { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "InterfaceCidr";
    }

    public InterfaceCidr Set(
        InterfaceType? InterfaceType = null,
        System.String? Cidr = null,
        System.Boolean? Selected = null
    ) 
    {
        if ( InterfaceType != null ) {
            this.InterfaceType = InterfaceType;
        }
        if ( Cidr != null ) {
            this.Cidr = Cidr;
        }
        if ( Selected != null ) {
            this.Selected = Selected;
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
        //      C# -> InterfaceType? InterfaceType
        // GraphQL -> interfaceType: InterfaceType! (enum)
        if (this.InterfaceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "interfaceType\n" ;
            } else {
                s += ind + "interfaceType\n" ;
            }
        }
        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        if (this.Cidr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cidr\n" ;
            } else {
                s += ind + "cidr\n" ;
            }
        }
        //      C# -> System.Boolean? Selected
        // GraphQL -> selected: Boolean! (scalar)
        if (this.Selected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "selected\n" ;
            } else {
                s += ind + "selected\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> InterfaceType? InterfaceType
        // GraphQL -> interfaceType: InterfaceType! (enum)
        if (ec.Includes("interfaceType",true))
        {
            if(this.InterfaceType == null) {

                this.InterfaceType = new InterfaceType();

            } else {


            }
        }
        else if (this.InterfaceType != null && ec.Excludes("interfaceType",true))
        {
            this.InterfaceType = null;
        }
        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        if (ec.Includes("cidr",true))
        {
            if(this.Cidr == null) {

                this.Cidr = "FETCH";

            } else {


            }
        }
        else if (this.Cidr != null && ec.Excludes("cidr",true))
        {
            this.Cidr = null;
        }
        //      C# -> System.Boolean? Selected
        // GraphQL -> selected: Boolean! (scalar)
        if (ec.Includes("selected",true))
        {
            if(this.Selected == null) {

                this.Selected = true;

            } else {


            }
        }
        else if (this.Selected != null && ec.Excludes("selected",true))
        {
            this.Selected = null;
        }
    }


    #endregion

    } // class InterfaceCidr
    
    #endregion

    public static class ListInterfaceCidrExtensions
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
            this List<InterfaceCidr> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<InterfaceCidr> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<InterfaceCidr> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new InterfaceCidr());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<InterfaceCidr> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types