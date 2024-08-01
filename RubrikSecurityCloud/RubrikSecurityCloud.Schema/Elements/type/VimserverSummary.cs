// VimserverSummary.cs
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
    #region VimserverSummary
    public class VimserverSummary: BaseType
    {
        #region members

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? VcdClusterId
        // GraphQL -> vcdClusterId: String! (scalar)
        [JsonProperty("vcdClusterId")]
        public System.String? VcdClusterId { get; set; }

        //      C# -> System.String? VcdClusterName
        // GraphQL -> vcdClusterName: String! (scalar)
        [JsonProperty("vcdClusterName")]
        public System.String? VcdClusterName { get; set; }

        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        [JsonProperty("vcenterId")]
        public System.String? VcenterId { get; set; }

        //      C# -> VcdConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: VcdConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public VcdConnectionStatus? ConnectionStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VimserverSummary";
    }

    public VimserverSummary Set(
        System.String? Hostname = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? VcdClusterId = null,
        System.String? VcdClusterName = null,
        System.String? VcenterId = null,
        VcdConnectionStatus? ConnectionStatus = null
    ) 
    {
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( VcdClusterId != null ) {
            this.VcdClusterId = VcdClusterId;
        }
        if ( VcdClusterName != null ) {
            this.VcdClusterName = VcdClusterName;
        }
        if ( VcenterId != null ) {
            this.VcenterId = VcenterId;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
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
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? VcdClusterId
        // GraphQL -> vcdClusterId: String! (scalar)
        if (this.VcdClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcdClusterId\n" ;
            } else {
                s += ind + "vcdClusterId\n" ;
            }
        }
        //      C# -> System.String? VcdClusterName
        // GraphQL -> vcdClusterName: String! (scalar)
        if (this.VcdClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcdClusterName\n" ;
            } else {
                s += ind + "vcdClusterName\n" ;
            }
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        if (this.VcenterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcenterId\n" ;
            } else {
                s += ind + "vcenterId\n" ;
            }
        }
        //      C# -> VcdConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: VcdConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(conf.Child("connectionStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? VcdClusterId
        // GraphQL -> vcdClusterId: String! (scalar)
        if (ec.Includes("vcdClusterId",true))
        {
            if(this.VcdClusterId == null) {

                this.VcdClusterId = "FETCH";

            } else {


            }
        }
        else if (this.VcdClusterId != null && ec.Excludes("vcdClusterId",true))
        {
            this.VcdClusterId = null;
        }
        //      C# -> System.String? VcdClusterName
        // GraphQL -> vcdClusterName: String! (scalar)
        if (ec.Includes("vcdClusterName",true))
        {
            if(this.VcdClusterName == null) {

                this.VcdClusterName = "FETCH";

            } else {


            }
        }
        else if (this.VcdClusterName != null && ec.Excludes("vcdClusterName",true))
        {
            this.VcdClusterName = null;
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        if (ec.Includes("vcenterId",true))
        {
            if(this.VcenterId == null) {

                this.VcenterId = "FETCH";

            } else {


            }
        }
        else if (this.VcenterId != null && ec.Excludes("vcenterId",true))
        {
            this.VcenterId = null;
        }
        //      C# -> VcdConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: VcdConnectionStatus (type)
        if (ec.Includes("connectionStatus",false))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new VcdConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            } else {

                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",false))
        {
            this.ConnectionStatus = null;
        }
    }


    #endregion

    } // class VimserverSummary
    
    #endregion

    public static class ListVimserverSummaryExtensions
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
            this List<VimserverSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VimserverSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VimserverSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VimserverSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VimserverSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types