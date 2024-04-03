// FailoverClusterAppSource.cs
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
    #region FailoverClusterAppSource
    public class FailoverClusterAppSource: BaseType
    {
        #region members

        //      C# -> List<System.String>? Vips
        // GraphQL -> vips: [String!]! (scalar)
        [JsonProperty("vips")]
        public List<System.String>? Vips { get; set; }

        //      C# -> List<System.String>? VirtualIps
        // GraphQL -> virtualIps: [String!]! (scalar)
        [JsonProperty("virtualIps")]
        public List<System.String>? VirtualIps { get; set; }

        //      C# -> List<FailoverClusterNodeOrder>? NodeOrders
        // GraphQL -> nodeOrders: [FailoverClusterNodeOrder!]! (type)
        [JsonProperty("nodeOrders")]
        public List<FailoverClusterNodeOrder>? NodeOrders { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterAppSource";
    }

    public FailoverClusterAppSource Set(
        List<System.String>? Vips = null,
        List<System.String>? VirtualIps = null,
        List<FailoverClusterNodeOrder>? NodeOrders = null
    ) 
    {
        if ( Vips != null ) {
            this.Vips = Vips;
        }
        if ( VirtualIps != null ) {
            this.VirtualIps = VirtualIps;
        }
        if ( NodeOrders != null ) {
            this.NodeOrders = NodeOrders;
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
        //      C# -> List<System.String>? Vips
        // GraphQL -> vips: [String!]! (scalar)
        if (this.Vips != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vips\n" ;
            } else {
                s += ind + "vips\n" ;
            }
        }
        //      C# -> List<System.String>? VirtualIps
        // GraphQL -> virtualIps: [String!]! (scalar)
        if (this.VirtualIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "virtualIps\n" ;
            } else {
                s += ind + "virtualIps\n" ;
            }
        }
        //      C# -> List<FailoverClusterNodeOrder>? NodeOrders
        // GraphQL -> nodeOrders: [FailoverClusterNodeOrder!]! (type)
        if (this.NodeOrders != null) {
            var fspec = this.NodeOrders.AsFieldSpec(conf.Child("nodeOrders"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nodeOrders" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Vips
        // GraphQL -> vips: [String!]! (scalar)
        if (ec.Includes("vips",true))
        {
            if(this.Vips == null) {

                this.Vips = new List<System.String>();

            } else {


            }
        }
        else if (this.Vips != null && ec.Excludes("vips",true))
        {
            this.Vips = null;
        }
        //      C# -> List<System.String>? VirtualIps
        // GraphQL -> virtualIps: [String!]! (scalar)
        if (ec.Includes("virtualIps",true))
        {
            if(this.VirtualIps == null) {

                this.VirtualIps = new List<System.String>();

            } else {


            }
        }
        else if (this.VirtualIps != null && ec.Excludes("virtualIps",true))
        {
            this.VirtualIps = null;
        }
        //      C# -> List<FailoverClusterNodeOrder>? NodeOrders
        // GraphQL -> nodeOrders: [FailoverClusterNodeOrder!]! (type)
        if (ec.Includes("nodeOrders",false))
        {
            if(this.NodeOrders == null) {

                this.NodeOrders = new List<FailoverClusterNodeOrder>();
                this.NodeOrders.ApplyExploratoryFieldSpec(ec.NewChild("nodeOrders"));

            } else {

                this.NodeOrders.ApplyExploratoryFieldSpec(ec.NewChild("nodeOrders"));

            }
        }
        else if (this.NodeOrders != null && ec.Excludes("nodeOrders",false))
        {
            this.NodeOrders = null;
        }
    }


    #endregion

    } // class FailoverClusterAppSource
    
    #endregion

    public static class ListFailoverClusterAppSourceExtensions
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
            this List<FailoverClusterAppSource> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverClusterAppSource> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterAppSource> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterAppSource());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverClusterAppSource> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types