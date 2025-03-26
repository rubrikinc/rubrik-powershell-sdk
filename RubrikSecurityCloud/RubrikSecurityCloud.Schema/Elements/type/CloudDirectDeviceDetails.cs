// CloudDirectDeviceDetails.cs
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
    #region CloudDirectDeviceDetails
    public class CloudDirectDeviceDetails: BaseType
    {
        #region members

        //      C# -> DeviceState? LastState
        // GraphQL -> lastState: DeviceState! (enum)
        [JsonProperty("lastState")]
        public DeviceState? LastState { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> DateTime? LastConnectedAt
        // GraphQL -> lastConnectedAt: DateTime (scalar)
        [JsonProperty("lastConnectedAt")]
        public DateTime? LastConnectedAt { get; set; }

        //      C# -> DateTime? RemovedAt
        // GraphQL -> removedAt: DateTime (scalar)
        [JsonProperty("removedAt")]
        public DateTime? RemovedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectDeviceDetails";
    }

    public CloudDirectDeviceDetails Set(
        DeviceState? LastState = null,
        System.String? IpAddress = null,
        DateTime? LastConnectedAt = null,
        DateTime? RemovedAt = null
    ) 
    {
        if ( LastState != null ) {
            this.LastState = LastState;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( LastConnectedAt != null ) {
            this.LastConnectedAt = LastConnectedAt;
        }
        if ( RemovedAt != null ) {
            this.RemovedAt = RemovedAt;
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
        //      C# -> DeviceState? LastState
        // GraphQL -> lastState: DeviceState! (enum)
        if (this.LastState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastState\n" ;
            } else {
                s += ind + "lastState\n" ;
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
        //      C# -> DateTime? LastConnectedAt
        // GraphQL -> lastConnectedAt: DateTime (scalar)
        if (this.LastConnectedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastConnectedAt\n" ;
            } else {
                s += ind + "lastConnectedAt\n" ;
            }
        }
        //      C# -> DateTime? RemovedAt
        // GraphQL -> removedAt: DateTime (scalar)
        if (this.RemovedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "removedAt\n" ;
            } else {
                s += ind + "removedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DeviceState? LastState
        // GraphQL -> lastState: DeviceState! (enum)
        if (ec.Includes("lastState",true))
        {
            if(this.LastState == null) {

                this.LastState = new DeviceState();

            } else {


            }
        }
        else if (this.LastState != null && ec.Excludes("lastState",true))
        {
            this.LastState = null;
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
        //      C# -> DateTime? LastConnectedAt
        // GraphQL -> lastConnectedAt: DateTime (scalar)
        if (ec.Includes("lastConnectedAt",true))
        {
            if(this.LastConnectedAt == null) {

                this.LastConnectedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastConnectedAt != null && ec.Excludes("lastConnectedAt",true))
        {
            this.LastConnectedAt = null;
        }
        //      C# -> DateTime? RemovedAt
        // GraphQL -> removedAt: DateTime (scalar)
        if (ec.Includes("removedAt",true))
        {
            if(this.RemovedAt == null) {

                this.RemovedAt = new DateTime();

            } else {


            }
        }
        else if (this.RemovedAt != null && ec.Excludes("removedAt",true))
        {
            this.RemovedAt = null;
        }
    }


    #endregion

    } // class CloudDirectDeviceDetails
    
    #endregion

    public static class ListCloudDirectDeviceDetailsExtensions
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
            this List<CloudDirectDeviceDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectDeviceDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectDeviceDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectDeviceDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectDeviceDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types