// HostDiscoverableInfo.cs
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
    #region HostDiscoverableInfo
    public class HostDiscoverableInfo: BaseType
    {
        #region members

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.Int32? PortNumber
        // GraphQL -> portNumber: Int! (scalar)
        [JsonProperty("portNumber")]
        public System.Int32? PortNumber { get; set; }

        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost (type)
        [JsonProperty("host")]
        public PhysicalHost? Host { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HostDiscoverableInfo";
    }

    public HostDiscoverableInfo Set(
        System.String? HostId = null,
        System.Int32? PortNumber = null,
        PhysicalHost? Host = null
    ) 
    {
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( PortNumber != null ) {
            this.PortNumber = PortNumber;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.Int32? PortNumber
        // GraphQL -> portNumber: Int! (scalar)
        if (this.PortNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "portNumber\n" ;
            } else {
                s += ind + "portNumber\n" ;
            }
        }
        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost (type)
        if (this.Host != null) {
            var fspec = this.Host.AsFieldSpec(conf.Child("host"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> System.Int32? PortNumber
        // GraphQL -> portNumber: Int! (scalar)
        if (ec.Includes("portNumber",true))
        {
            if(this.PortNumber == null) {

                this.PortNumber = Int32.MinValue;

            } else {


            }
        }
        else if (this.PortNumber != null && ec.Excludes("portNumber",true))
        {
            this.PortNumber = null;
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

    } // class HostDiscoverableInfo
    
    #endregion

    public static class ListHostDiscoverableInfoExtensions
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
            this List<HostDiscoverableInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HostDiscoverableInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HostDiscoverableInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HostDiscoverableInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HostDiscoverableInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types