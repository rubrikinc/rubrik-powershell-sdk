// NodeStatus.cs
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
    #region NodeStatus
    public class NodeStatus: BaseType
    {
        #region members

        //      C# -> System.String? BrikId
        // GraphQL -> brikId: String! (scalar)
        [JsonProperty("brikId")]
        public System.String? BrikId { get; set; }

        //      C# -> System.Boolean? HasUnavailableDisks
        // GraphQL -> hasUnavailableDisks: Boolean (scalar)
        [JsonProperty("hasUnavailableDisks")]
        public System.Boolean? HasUnavailableDisks { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> SupportTunnelInfo? SupportTunnel
        // GraphQL -> supportTunnel: SupportTunnelInfo (type)
        [JsonProperty("supportTunnel")]
        public SupportTunnelInfo? SupportTunnel { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NodeStatus";
    }

    public NodeStatus Set(
        System.String? BrikId = null,
        System.Boolean? HasUnavailableDisks = null,
        System.String? Hostname = null,
        System.String? Id = null,
        System.String? IpAddress = null,
        System.String? Status = null,
        SupportTunnelInfo? SupportTunnel = null
    ) 
    {
        if ( BrikId != null ) {
            this.BrikId = BrikId;
        }
        if ( HasUnavailableDisks != null ) {
            this.HasUnavailableDisks = HasUnavailableDisks;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( SupportTunnel != null ) {
            this.SupportTunnel = SupportTunnel;
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
        //      C# -> System.String? BrikId
        // GraphQL -> brikId: String! (scalar)
        if (this.BrikId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "brikId\n" ;
            } else {
                s += ind + "brikId\n" ;
            }
        }
        //      C# -> System.Boolean? HasUnavailableDisks
        // GraphQL -> hasUnavailableDisks: Boolean (scalar)
        if (this.HasUnavailableDisks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasUnavailableDisks\n" ;
            } else {
                s += ind + "hasUnavailableDisks\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (this.IpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddress\n" ;
            } else {
                s += ind + "ipAddress\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> SupportTunnelInfo? SupportTunnel
        // GraphQL -> supportTunnel: SupportTunnelInfo (type)
        if (this.SupportTunnel != null) {
            var fspec = this.SupportTunnel.AsFieldSpec(conf.Child("supportTunnel"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "supportTunnel" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? BrikId
        // GraphQL -> brikId: String! (scalar)
        if (ec.Includes("brikId",true))
        {
            if(this.BrikId == null) {

                this.BrikId = "FETCH";

            } else {


            }
        }
        else if (this.BrikId != null && ec.Excludes("brikId",true))
        {
            this.BrikId = null;
        }
        //      C# -> System.Boolean? HasUnavailableDisks
        // GraphQL -> hasUnavailableDisks: Boolean (scalar)
        if (ec.Includes("hasUnavailableDisks",true))
        {
            if(this.HasUnavailableDisks == null) {

                this.HasUnavailableDisks = true;

            } else {


            }
        }
        else if (this.HasUnavailableDisks != null && ec.Excludes("hasUnavailableDisks",true))
        {
            this.HasUnavailableDisks = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (ec.Includes("ipAddress",true))
        {
            if(this.IpAddress == null) {

                this.IpAddress = "FETCH";

            } else {


            }
        }
        else if (this.IpAddress != null && ec.Excludes("ipAddress",true))
        {
            this.IpAddress = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> SupportTunnelInfo? SupportTunnel
        // GraphQL -> supportTunnel: SupportTunnelInfo (type)
        if (ec.Includes("supportTunnel",false))
        {
            if(this.SupportTunnel == null) {

                this.SupportTunnel = new SupportTunnelInfo();
                this.SupportTunnel.ApplyExploratoryFieldSpec(ec.NewChild("supportTunnel"));

            } else {

                this.SupportTunnel.ApplyExploratoryFieldSpec(ec.NewChild("supportTunnel"));

            }
        }
        else if (this.SupportTunnel != null && ec.Excludes("supportTunnel",false))
        {
            this.SupportTunnel = null;
        }
    }


    #endregion

    } // class NodeStatus
    
    #endregion

    public static class ListNodeStatusExtensions
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
            this List<NodeStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NodeStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NodeStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NodeStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NodeStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types