// ProxmoxEnvironmentDetails.cs
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
    #region ProxmoxEnvironmentDetails
    public class ProxmoxEnvironmentDetails: BaseType
    {
        #region members

        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        [JsonProperty("ipAddresses")]
        public List<System.String>? IpAddresses { get; set; }

        //      C# -> System.String? ProxmoxClusterId
        // GraphQL -> proxmoxClusterId: UUID (scalar)
        [JsonProperty("proxmoxClusterId")]
        public System.String? ProxmoxClusterId { get; set; }

        //      C# -> System.String? ProxmoxEnvironmentId
        // GraphQL -> proxmoxEnvironmentId: UUID! (scalar)
        [JsonProperty("proxmoxEnvironmentId")]
        public System.String? ProxmoxEnvironmentId { get; set; }

        //      C# -> System.String? ProxmoxNodeId
        // GraphQL -> proxmoxNodeId: UUID! (scalar)
        [JsonProperty("proxmoxNodeId")]
        public System.String? ProxmoxNodeId { get; set; }

        //      C# -> List<System.String>? Versions
        // GraphQL -> versions: [String!]! (scalar)
        [JsonProperty("versions")]
        public List<System.String>? Versions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProxmoxEnvironmentDetails";
    }

    public ProxmoxEnvironmentDetails Set(
        List<System.String>? IpAddresses = null,
        System.String? ProxmoxClusterId = null,
        System.String? ProxmoxEnvironmentId = null,
        System.String? ProxmoxNodeId = null,
        List<System.String>? Versions = null
    ) 
    {
        if ( IpAddresses != null ) {
            this.IpAddresses = IpAddresses;
        }
        if ( ProxmoxClusterId != null ) {
            this.ProxmoxClusterId = ProxmoxClusterId;
        }
        if ( ProxmoxEnvironmentId != null ) {
            this.ProxmoxEnvironmentId = ProxmoxEnvironmentId;
        }
        if ( ProxmoxNodeId != null ) {
            this.ProxmoxNodeId = ProxmoxNodeId;
        }
        if ( Versions != null ) {
            this.Versions = Versions;
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
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (this.IpAddresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddresses\n" ;
            } else {
                s += ind + "ipAddresses\n" ;
            }
        }
        //      C# -> System.String? ProxmoxClusterId
        // GraphQL -> proxmoxClusterId: UUID (scalar)
        if (this.ProxmoxClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "proxmoxClusterId\n" ;
            } else {
                s += ind + "proxmoxClusterId\n" ;
            }
        }
        //      C# -> System.String? ProxmoxEnvironmentId
        // GraphQL -> proxmoxEnvironmentId: UUID! (scalar)
        if (this.ProxmoxEnvironmentId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "proxmoxEnvironmentId\n" ;
            } else {
                s += ind + "proxmoxEnvironmentId\n" ;
            }
        }
        //      C# -> System.String? ProxmoxNodeId
        // GraphQL -> proxmoxNodeId: UUID! (scalar)
        if (this.ProxmoxNodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "proxmoxNodeId\n" ;
            } else {
                s += ind + "proxmoxNodeId\n" ;
            }
        }
        //      C# -> List<System.String>? Versions
        // GraphQL -> versions: [String!]! (scalar)
        if (this.Versions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "versions\n" ;
            } else {
                s += ind + "versions\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (ec.Includes("ipAddresses",true))
        {
            if(this.IpAddresses == null) {

                this.IpAddresses = new List<System.String>();

            } else {


            }
        }
        else if (this.IpAddresses != null && ec.Excludes("ipAddresses",true))
        {
            this.IpAddresses = null;
        }
        //      C# -> System.String? ProxmoxClusterId
        // GraphQL -> proxmoxClusterId: UUID (scalar)
        if (ec.Includes("proxmoxClusterId",true))
        {
            if(this.ProxmoxClusterId == null) {

                this.ProxmoxClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ProxmoxClusterId != null && ec.Excludes("proxmoxClusterId",true))
        {
            this.ProxmoxClusterId = null;
        }
        //      C# -> System.String? ProxmoxEnvironmentId
        // GraphQL -> proxmoxEnvironmentId: UUID! (scalar)
        if (ec.Includes("proxmoxEnvironmentId",true))
        {
            if(this.ProxmoxEnvironmentId == null) {

                this.ProxmoxEnvironmentId = "FETCH";

            } else {


            }
        }
        else if (this.ProxmoxEnvironmentId != null && ec.Excludes("proxmoxEnvironmentId",true))
        {
            this.ProxmoxEnvironmentId = null;
        }
        //      C# -> System.String? ProxmoxNodeId
        // GraphQL -> proxmoxNodeId: UUID! (scalar)
        if (ec.Includes("proxmoxNodeId",true))
        {
            if(this.ProxmoxNodeId == null) {

                this.ProxmoxNodeId = "FETCH";

            } else {


            }
        }
        else if (this.ProxmoxNodeId != null && ec.Excludes("proxmoxNodeId",true))
        {
            this.ProxmoxNodeId = null;
        }
        //      C# -> List<System.String>? Versions
        // GraphQL -> versions: [String!]! (scalar)
        if (ec.Includes("versions",true))
        {
            if(this.Versions == null) {

                this.Versions = new List<System.String>();

            } else {


            }
        }
        else if (this.Versions != null && ec.Excludes("versions",true))
        {
            this.Versions = null;
        }
    }


    #endregion

    } // class ProxmoxEnvironmentDetails
    
    #endregion

    public static class ListProxmoxEnvironmentDetailsExtensions
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
            this List<ProxmoxEnvironmentDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProxmoxEnvironmentDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProxmoxEnvironmentDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProxmoxEnvironmentDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProxmoxEnvironmentDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types