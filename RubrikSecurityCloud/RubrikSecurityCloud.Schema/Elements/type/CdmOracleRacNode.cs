// CdmOracleRacNode.cs
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
    #region CdmOracleRacNode
    public class CdmOracleRacNode: BaseType
    {
        #region members

        //      C# -> HostConnectivityStatusEnum? Status
        // GraphQL -> status: HostConnectivityStatusEnum! (enum)
        [JsonProperty("status")]
        public HostConnectivityStatusEnum? Status { get; set; }

        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String (scalar)
        [JsonProperty("hostFid")]
        public System.String? HostFid { get; set; }

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost (type)
        [JsonProperty("host")]
        public PhysicalHost? Host { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmOracleRacNode";
    }

    public CdmOracleRacNode Set(
        HostConnectivityStatusEnum? Status = null,
        System.String? HostFid = null,
        System.String? NodeName = null,
        PhysicalHost? Host = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( HostFid != null ) {
            this.HostFid = HostFid;
        }
        if ( NodeName != null ) {
            this.NodeName = NodeName;
        }
        if ( Host != null ) {
            this.Host = Host;
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
        //      C# -> HostConnectivityStatusEnum? Status
        // GraphQL -> status: HostConnectivityStatusEnum! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String (scalar)
        if (this.HostFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostFid\n" ;
            } else {
                s += ind + "hostFid\n" ;
            }
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeName\n" ;
            } else {
                s += ind + "nodeName\n" ;
            }
        }
        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost (type)
        if (this.Host != null) {
            var fspec = this.Host.AsFieldSpec(conf.Child("host"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "host" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HostConnectivityStatusEnum? Status
        // GraphQL -> status: HostConnectivityStatusEnum! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new HostConnectivityStatusEnum();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String (scalar)
        if (ec.Includes("hostFid",true))
        {
            if(this.HostFid == null) {

                this.HostFid = "FETCH";

            } else {


            }
        }
        else if (this.HostFid != null && ec.Excludes("hostFid",true))
        {
            this.HostFid = null;
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (ec.Includes("nodeName",true))
        {
            if(this.NodeName == null) {

                this.NodeName = "FETCH";

            } else {


            }
        }
        else if (this.NodeName != null && ec.Excludes("nodeName",true))
        {
            this.NodeName = null;
        }
        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost (type)
        if (ec.Includes("host",false))
        {
            if(this.Host == null) {

                this.Host = new PhysicalHost();
                this.Host.ApplyExploratoryFieldSpec(ec.NewChild("host"));

            } else {

                this.Host.ApplyExploratoryFieldSpec(ec.NewChild("host"));

            }
        }
        else if (this.Host != null && ec.Excludes("host",false))
        {
            this.Host = null;
        }
    }


    #endregion

    } // class CdmOracleRacNode
    
    #endregion

    public static class ListCdmOracleRacNodeExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CdmOracleRacNode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmOracleRacNode> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmOracleRacNode> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmOracleRacNode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmOracleRacNode> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types