// ReplicationPairConfigDetails.cs
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
    #region ReplicationPairConfigDetails
    public class ReplicationPairConfigDetails: BaseType
    {
        #region members

        //      C# -> System.String? SetupType
        // GraphQL -> setupType: String! (scalar)
        [JsonProperty("setupType")]
        public System.String? SetupType { get; set; }

        //      C# -> NetworkInterfaceSelectionType? NetworkInterface
        // GraphQL -> networkInterface: NetworkInterfaceSelectionType (type)
        [JsonProperty("networkInterface")]
        public NetworkInterfaceSelectionType? NetworkInterface { get; set; }

        //      C# -> GatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: GatewayInfo (type)
        [JsonProperty("sourceGateway")]
        public GatewayInfo? SourceGateway { get; set; }

        //      C# -> GatewayInfo? TargetGateway
        // GraphQL -> targetGateway: GatewayInfo (type)
        [JsonProperty("targetGateway")]
        public GatewayInfo? TargetGateway { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicationPairConfigDetails";
    }

    public ReplicationPairConfigDetails Set(
        System.String? SetupType = null,
        NetworkInterfaceSelectionType? NetworkInterface = null,
        GatewayInfo? SourceGateway = null,
        GatewayInfo? TargetGateway = null
    ) 
    {
        if ( SetupType != null ) {
            this.SetupType = SetupType;
        }
        if ( NetworkInterface != null ) {
            this.NetworkInterface = NetworkInterface;
        }
        if ( SourceGateway != null ) {
            this.SourceGateway = SourceGateway;
        }
        if ( TargetGateway != null ) {
            this.TargetGateway = TargetGateway;
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
        //      C# -> System.String? SetupType
        // GraphQL -> setupType: String! (scalar)
        if (this.SetupType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "setupType\n" ;
            } else {
                s += ind + "setupType\n" ;
            }
        }
        //      C# -> NetworkInterfaceSelectionType? NetworkInterface
        // GraphQL -> networkInterface: NetworkInterfaceSelectionType (type)
        if (this.NetworkInterface != null) {
            var fspec = this.NetworkInterface.AsFieldSpec(conf.Child("networkInterface"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "networkInterface" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: GatewayInfo (type)
        if (this.SourceGateway != null) {
            var fspec = this.SourceGateway.AsFieldSpec(conf.Child("sourceGateway"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceGateway" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GatewayInfo? TargetGateway
        // GraphQL -> targetGateway: GatewayInfo (type)
        if (this.TargetGateway != null) {
            var fspec = this.TargetGateway.AsFieldSpec(conf.Child("targetGateway"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetGateway" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SetupType
        // GraphQL -> setupType: String! (scalar)
        if (ec.Includes("setupType",true))
        {
            if(this.SetupType == null) {

                this.SetupType = "FETCH";

            } else {


            }
        }
        else if (this.SetupType != null && ec.Excludes("setupType",true))
        {
            this.SetupType = null;
        }
        //      C# -> NetworkInterfaceSelectionType? NetworkInterface
        // GraphQL -> networkInterface: NetworkInterfaceSelectionType (type)
        if (ec.Includes("networkInterface",false))
        {
            if(this.NetworkInterface == null) {

                this.NetworkInterface = new NetworkInterfaceSelectionType();
                this.NetworkInterface.ApplyExploratoryFieldSpec(ec.NewChild("networkInterface"));

            } else {

                this.NetworkInterface.ApplyExploratoryFieldSpec(ec.NewChild("networkInterface"));

            }
        }
        else if (this.NetworkInterface != null && ec.Excludes("networkInterface",false))
        {
            this.NetworkInterface = null;
        }
        //      C# -> GatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: GatewayInfo (type)
        if (ec.Includes("sourceGateway",false))
        {
            if(this.SourceGateway == null) {

                this.SourceGateway = new GatewayInfo();
                this.SourceGateway.ApplyExploratoryFieldSpec(ec.NewChild("sourceGateway"));

            } else {

                this.SourceGateway.ApplyExploratoryFieldSpec(ec.NewChild("sourceGateway"));

            }
        }
        else if (this.SourceGateway != null && ec.Excludes("sourceGateway",false))
        {
            this.SourceGateway = null;
        }
        //      C# -> GatewayInfo? TargetGateway
        // GraphQL -> targetGateway: GatewayInfo (type)
        if (ec.Includes("targetGateway",false))
        {
            if(this.TargetGateway == null) {

                this.TargetGateway = new GatewayInfo();
                this.TargetGateway.ApplyExploratoryFieldSpec(ec.NewChild("targetGateway"));

            } else {

                this.TargetGateway.ApplyExploratoryFieldSpec(ec.NewChild("targetGateway"));

            }
        }
        else if (this.TargetGateway != null && ec.Excludes("targetGateway",false))
        {
            this.TargetGateway = null;
        }
    }


    #endregion

    } // class ReplicationPairConfigDetails
    
    #endregion

    public static class ListReplicationPairConfigDetailsExtensions
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
            this List<ReplicationPairConfigDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReplicationPairConfigDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationPairConfigDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationPairConfigDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationPairConfigDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types