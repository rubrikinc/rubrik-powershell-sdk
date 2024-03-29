// HotAddNetworkConfigWithName.cs
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
    #region HotAddNetworkConfigWithName
    public class HotAddNetworkConfigWithName: BaseType
    {
        #region members

        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String (scalar)
        [JsonProperty("networkName")]
        public System.String? NetworkName { get; set; }

        //      C# -> StaticIpInfo? StaticIpConfig
        // GraphQL -> staticIpConfig: StaticIpInfo (type)
        [JsonProperty("staticIpConfig")]
        public StaticIpInfo? StaticIpConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HotAddNetworkConfigWithName";
    }

    public HotAddNetworkConfigWithName Set(
        System.String? NetworkName = null,
        StaticIpInfo? StaticIpConfig = null
    ) 
    {
        if ( NetworkName != null ) {
            this.NetworkName = NetworkName;
        }
        if ( StaticIpConfig != null ) {
            this.StaticIpConfig = StaticIpConfig;
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
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String (scalar)
        if (this.NetworkName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkName\n" ;
            } else {
                s += ind + "networkName\n" ;
            }
        }
        //      C# -> StaticIpInfo? StaticIpConfig
        // GraphQL -> staticIpConfig: StaticIpInfo (type)
        if (this.StaticIpConfig != null) {
            var fspec = this.StaticIpConfig.AsFieldSpec(conf.Child("staticIpConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "staticIpConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String (scalar)
        if (ec.Includes("networkName",true))
        {
            if(this.NetworkName == null) {

                this.NetworkName = "FETCH";

            } else {


            }
        }
        else if (this.NetworkName != null && ec.Excludes("networkName",true))
        {
            this.NetworkName = null;
        }
        //      C# -> StaticIpInfo? StaticIpConfig
        // GraphQL -> staticIpConfig: StaticIpInfo (type)
        if (ec.Includes("staticIpConfig",false))
        {
            if(this.StaticIpConfig == null) {

                this.StaticIpConfig = new StaticIpInfo();
                this.StaticIpConfig.ApplyExploratoryFieldSpec(ec.NewChild("staticIpConfig"));

            } else {

                this.StaticIpConfig.ApplyExploratoryFieldSpec(ec.NewChild("staticIpConfig"));

            }
        }
        else if (this.StaticIpConfig != null && ec.Excludes("staticIpConfig",false))
        {
            this.StaticIpConfig = null;
        }
    }


    #endregion

    } // class HotAddNetworkConfigWithName
    
    #endregion

    public static class ListHotAddNetworkConfigWithNameExtensions
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
            this List<HotAddNetworkConfigWithName> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<HotAddNetworkConfigWithName> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HotAddNetworkConfigWithName> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HotAddNetworkConfigWithName());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HotAddNetworkConfigWithName> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types