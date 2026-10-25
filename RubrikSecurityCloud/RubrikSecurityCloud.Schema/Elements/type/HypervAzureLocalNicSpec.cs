// HypervAzureLocalNicSpec.cs
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
    #region HypervAzureLocalNicSpec
    public class HypervAzureLocalNicSpec: BaseType
    {
        #region members

        //      C# -> System.String? LogicalNetworkId
        // GraphQL -> logicalNetworkId: String! (scalar)
        [JsonProperty("logicalNetworkId")]
        public System.String? LogicalNetworkId { get; set; }

        //      C# -> System.String? LogicalNetworkName
        // GraphQL -> logicalNetworkName: String! (scalar)
        [JsonProperty("logicalNetworkName")]
        public System.String? LogicalNetworkName { get; set; }

        //      C# -> System.String? NicInstanceId
        // GraphQL -> nicInstanceId: String! (scalar)
        [JsonProperty("nicInstanceId")]
        public System.String? NicInstanceId { get; set; }

        //      C# -> System.Int32? SourceNicIndex
        // GraphQL -> sourceNicIndex: Int! (scalar)
        [JsonProperty("sourceNicIndex")]
        public System.Int32? SourceNicIndex { get; set; }

        //      C# -> NicIpConfig? IpConfig
        // GraphQL -> ipConfig: NicIpConfig! (type)
        [JsonProperty("ipConfig")]
        public NicIpConfig? IpConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervAzureLocalNicSpec";
    }

    public HypervAzureLocalNicSpec Set(
        System.String? LogicalNetworkId = null,
        System.String? LogicalNetworkName = null,
        System.String? NicInstanceId = null,
        System.Int32? SourceNicIndex = null,
        NicIpConfig? IpConfig = null
    ) 
    {
        if ( LogicalNetworkId != null ) {
            this.LogicalNetworkId = LogicalNetworkId;
        }
        if ( LogicalNetworkName != null ) {
            this.LogicalNetworkName = LogicalNetworkName;
        }
        if ( NicInstanceId != null ) {
            this.NicInstanceId = NicInstanceId;
        }
        if ( SourceNicIndex != null ) {
            this.SourceNicIndex = SourceNicIndex;
        }
        if ( IpConfig != null ) {
            this.IpConfig = IpConfig;
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
        //      C# -> System.String? LogicalNetworkId
        // GraphQL -> logicalNetworkId: String! (scalar)
        if (this.LogicalNetworkId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalNetworkId\n" ;
            } else {
                s += ind + "logicalNetworkId\n" ;
            }
        }
        //      C# -> System.String? LogicalNetworkName
        // GraphQL -> logicalNetworkName: String! (scalar)
        if (this.LogicalNetworkName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalNetworkName\n" ;
            } else {
                s += ind + "logicalNetworkName\n" ;
            }
        }
        //      C# -> System.String? NicInstanceId
        // GraphQL -> nicInstanceId: String! (scalar)
        if (this.NicInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nicInstanceId\n" ;
            } else {
                s += ind + "nicInstanceId\n" ;
            }
        }
        //      C# -> System.Int32? SourceNicIndex
        // GraphQL -> sourceNicIndex: Int! (scalar)
        if (this.SourceNicIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceNicIndex\n" ;
            } else {
                s += ind + "sourceNicIndex\n" ;
            }
        }
        //      C# -> NicIpConfig? IpConfig
        // GraphQL -> ipConfig: NicIpConfig! (type)
        if (this.IpConfig != null) {
            var fspec = this.IpConfig.AsFieldSpec(conf.Child("ipConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ipConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? LogicalNetworkId
        // GraphQL -> logicalNetworkId: String! (scalar)
        if (ec.Includes("logicalNetworkId",true))
        {
            if(this.LogicalNetworkId == null) {

                this.LogicalNetworkId = "FETCH";

            } else {


            }
        }
        else if (this.LogicalNetworkId != null && ec.Excludes("logicalNetworkId",true))
        {
            this.LogicalNetworkId = null;
        }
        //      C# -> System.String? LogicalNetworkName
        // GraphQL -> logicalNetworkName: String! (scalar)
        if (ec.Includes("logicalNetworkName",true))
        {
            if(this.LogicalNetworkName == null) {

                this.LogicalNetworkName = "FETCH";

            } else {


            }
        }
        else if (this.LogicalNetworkName != null && ec.Excludes("logicalNetworkName",true))
        {
            this.LogicalNetworkName = null;
        }
        //      C# -> System.String? NicInstanceId
        // GraphQL -> nicInstanceId: String! (scalar)
        if (ec.Includes("nicInstanceId",true))
        {
            if(this.NicInstanceId == null) {

                this.NicInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.NicInstanceId != null && ec.Excludes("nicInstanceId",true))
        {
            this.NicInstanceId = null;
        }
        //      C# -> System.Int32? SourceNicIndex
        // GraphQL -> sourceNicIndex: Int! (scalar)
        if (ec.Includes("sourceNicIndex",true))
        {
            if(this.SourceNicIndex == null) {

                this.SourceNicIndex = Int32.MinValue;

            } else {


            }
        }
        else if (this.SourceNicIndex != null && ec.Excludes("sourceNicIndex",true))
        {
            this.SourceNicIndex = null;
        }
        //      C# -> NicIpConfig? IpConfig
        // GraphQL -> ipConfig: NicIpConfig! (type)
        if (ec.Includes("ipConfig",false))
        {
            if(this.IpConfig == null) {

                this.IpConfig = new NicIpConfig();
                this.IpConfig.ApplyExploratoryFieldSpec(ec.NewChild("ipConfig"));

            } else {

                this.IpConfig.ApplyExploratoryFieldSpec(ec.NewChild("ipConfig"));

            }
        }
        else if (this.IpConfig != null && ec.Excludes("ipConfig",false))
        {
            this.IpConfig = null;
        }
    }


    #endregion

    } // class HypervAzureLocalNicSpec
    
    #endregion

    public static class ListHypervAzureLocalNicSpecExtensions
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
            this List<HypervAzureLocalNicSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervAzureLocalNicSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervAzureLocalNicSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervAzureLocalNicSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervAzureLocalNicSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types