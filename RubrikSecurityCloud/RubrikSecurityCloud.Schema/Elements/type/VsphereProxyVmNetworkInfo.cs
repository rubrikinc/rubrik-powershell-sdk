// VsphereProxyVmNetworkInfo.cs
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
    #region VsphereProxyVmNetworkInfo
    public class VsphereProxyVmNetworkInfo: BaseType
    {
        #region members

        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String! (scalar)
        [JsonProperty("networkName")]
        public System.String? NetworkName { get; set; }

        //      C# -> VsphereProxyVmStaticIpInfo? StaticIpInfo
        // GraphQL -> staticIpInfo: VsphereProxyVmStaticIpInfo (type)
        [JsonProperty("staticIpInfo")]
        public VsphereProxyVmStaticIpInfo? StaticIpInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereProxyVmNetworkInfo";
    }

    public VsphereProxyVmNetworkInfo Set(
        System.String? NetworkName = null,
        VsphereProxyVmStaticIpInfo? StaticIpInfo = null
    ) 
    {
        if ( NetworkName != null ) {
            this.NetworkName = NetworkName;
        }
        if ( StaticIpInfo != null ) {
            this.StaticIpInfo = StaticIpInfo;
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
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String! (scalar)
        if (this.NetworkName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkName\n" ;
            } else {
                s += ind + "networkName\n" ;
            }
        }
        //      C# -> VsphereProxyVmStaticIpInfo? StaticIpInfo
        // GraphQL -> staticIpInfo: VsphereProxyVmStaticIpInfo (type)
        if (this.StaticIpInfo != null) {
            var fspec = this.StaticIpInfo.AsFieldSpec(conf.Child("staticIpInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "staticIpInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String! (scalar)
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
        //      C# -> VsphereProxyVmStaticIpInfo? StaticIpInfo
        // GraphQL -> staticIpInfo: VsphereProxyVmStaticIpInfo (type)
        if (ec.Includes("staticIpInfo",false))
        {
            if(this.StaticIpInfo == null) {

                this.StaticIpInfo = new VsphereProxyVmStaticIpInfo();
                this.StaticIpInfo.ApplyExploratoryFieldSpec(ec.NewChild("staticIpInfo"));

            } else {

                this.StaticIpInfo.ApplyExploratoryFieldSpec(ec.NewChild("staticIpInfo"));

            }
        }
        else if (this.StaticIpInfo != null && ec.Excludes("staticIpInfo",false))
        {
            this.StaticIpInfo = null;
        }
    }


    #endregion

    } // class VsphereProxyVmNetworkInfo
    
    #endregion

    public static class ListVsphereProxyVmNetworkInfoExtensions
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
            this List<VsphereProxyVmNetworkInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereProxyVmNetworkInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereProxyVmNetworkInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereProxyVmNetworkInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereProxyVmNetworkInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types