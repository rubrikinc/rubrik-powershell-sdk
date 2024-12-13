// UpdateNasSystemReply.cs
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
    #region UpdateNasSystemReply
    public class UpdateNasSystemReply: BaseType
    {
        #region members

        //      C# -> HostRbsConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HostRbsConnectionStatus (enum)
        [JsonProperty("connectionStatus")]
        public HostRbsConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> NasVendorType? VendorType
        // GraphQL -> vendorType: NasVendorType! (enum)
        [JsonProperty("vendorType")]
        public NasVendorType? VendorType { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateNasSystemReply";
    }

    public UpdateNasSystemReply Set(
        HostRbsConnectionStatus? ConnectionStatus = null,
        NasVendorType? VendorType = null,
        System.String? Hostname = null,
        System.String? Id = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( VendorType != null ) {
            this.VendorType = VendorType;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
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
        //      C# -> HostRbsConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HostRbsConnectionStatus (enum)
        if (this.ConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectionStatus\n" ;
            } else {
                s += ind + "connectionStatus\n" ;
            }
        }
        //      C# -> NasVendorType? VendorType
        // GraphQL -> vendorType: NasVendorType! (enum)
        if (this.VendorType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vendorType\n" ;
            } else {
                s += ind + "vendorType\n" ;
            }
        }
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HostRbsConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HostRbsConnectionStatus (enum)
        if (ec.Includes("connectionStatus",true))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new HostRbsConnectionStatus();

            } else {


            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",true))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> NasVendorType? VendorType
        // GraphQL -> vendorType: NasVendorType! (enum)
        if (ec.Includes("vendorType",true))
        {
            if(this.VendorType == null) {

                this.VendorType = new NasVendorType();

            } else {


            }
        }
        else if (this.VendorType != null && ec.Excludes("vendorType",true))
        {
            this.VendorType = null;
        }
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
    }


    #endregion

    } // class UpdateNasSystemReply
    
    #endregion

    public static class ListUpdateNasSystemReplyExtensions
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
            this List<UpdateNasSystemReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateNasSystemReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateNasSystemReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateNasSystemReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateNasSystemReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types