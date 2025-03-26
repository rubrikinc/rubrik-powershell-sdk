// MultiTenantHostSpec.cs
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
    #region MultiTenantHostSpec
    public class MultiTenantHostSpec: BaseType
    {
        #region members

        //      C# -> System.String? MultiTenantHostAzureAppId
        // GraphQL -> multiTenantHostAzureAppId: String! (scalar)
        [JsonProperty("multiTenantHostAzureAppId")]
        public System.String? MultiTenantHostAzureAppId { get; set; }

        //      C# -> NetworkConfig? MultiTenantHostNetworkConfig
        // GraphQL -> multiTenantHostNetworkConfig: NetworkConfig (type)
        [JsonProperty("multiTenantHostNetworkConfig")]
        public NetworkConfig? MultiTenantHostNetworkConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MultiTenantHostSpec";
    }

    public MultiTenantHostSpec Set(
        System.String? MultiTenantHostAzureAppId = null,
        NetworkConfig? MultiTenantHostNetworkConfig = null
    ) 
    {
        if ( MultiTenantHostAzureAppId != null ) {
            this.MultiTenantHostAzureAppId = MultiTenantHostAzureAppId;
        }
        if ( MultiTenantHostNetworkConfig != null ) {
            this.MultiTenantHostNetworkConfig = MultiTenantHostNetworkConfig;
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
        //      C# -> System.String? MultiTenantHostAzureAppId
        // GraphQL -> multiTenantHostAzureAppId: String! (scalar)
        if (this.MultiTenantHostAzureAppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "multiTenantHostAzureAppId\n" ;
            } else {
                s += ind + "multiTenantHostAzureAppId\n" ;
            }
        }
        //      C# -> NetworkConfig? MultiTenantHostNetworkConfig
        // GraphQL -> multiTenantHostNetworkConfig: NetworkConfig (type)
        if (this.MultiTenantHostNetworkConfig != null) {
            var fspec = this.MultiTenantHostNetworkConfig.AsFieldSpec(conf.Child("multiTenantHostNetworkConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "multiTenantHostNetworkConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? MultiTenantHostAzureAppId
        // GraphQL -> multiTenantHostAzureAppId: String! (scalar)
        if (ec.Includes("multiTenantHostAzureAppId",true))
        {
            if(this.MultiTenantHostAzureAppId == null) {

                this.MultiTenantHostAzureAppId = "FETCH";

            } else {


            }
        }
        else if (this.MultiTenantHostAzureAppId != null && ec.Excludes("multiTenantHostAzureAppId",true))
        {
            this.MultiTenantHostAzureAppId = null;
        }
        //      C# -> NetworkConfig? MultiTenantHostNetworkConfig
        // GraphQL -> multiTenantHostNetworkConfig: NetworkConfig (type)
        if (ec.Includes("multiTenantHostNetworkConfig",false))
        {
            if(this.MultiTenantHostNetworkConfig == null) {

                this.MultiTenantHostNetworkConfig = new NetworkConfig();
                this.MultiTenantHostNetworkConfig.ApplyExploratoryFieldSpec(ec.NewChild("multiTenantHostNetworkConfig"));

            } else {

                this.MultiTenantHostNetworkConfig.ApplyExploratoryFieldSpec(ec.NewChild("multiTenantHostNetworkConfig"));

            }
        }
        else if (this.MultiTenantHostNetworkConfig != null && ec.Excludes("multiTenantHostNetworkConfig",false))
        {
            this.MultiTenantHostNetworkConfig = null;
        }
    }


    #endregion

    } // class MultiTenantHostSpec
    
    #endregion

    public static class ListMultiTenantHostSpecExtensions
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
            this List<MultiTenantHostSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MultiTenantHostSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MultiTenantHostSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MultiTenantHostSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MultiTenantHostSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types