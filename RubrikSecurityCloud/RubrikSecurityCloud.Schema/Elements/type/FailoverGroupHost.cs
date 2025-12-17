// FailoverGroupHost.cs
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
    #region FailoverGroupHost
    public class FailoverGroupHost: BaseType
    {
        #region members

        //      C# -> FailoverGroupStatus? HostStatus
        // GraphQL -> hostStatus: FailoverGroupStatus! (enum)
        [JsonProperty("hostStatus")]
        public FailoverGroupStatus? HostStatus { get; set; }

        //      C# -> HostRegisterOsType? HostType
        // GraphQL -> hostType: HostRegisterOsType! (enum)
        [JsonProperty("hostType")]
        public HostRegisterOsType? HostType { get; set; }

        //      C# -> System.String? ActiveClusterUuid
        // GraphQL -> activeClusterUuid: UUID! (scalar)
        [JsonProperty("activeClusterUuid")]
        public System.String? ActiveClusterUuid { get; set; }

        //      C# -> List<System.String>? CounterpartIds
        // GraphQL -> counterpartIds: [UUID!]! (scalar)
        [JsonProperty("counterpartIds")]
        public List<System.String>? CounterpartIds { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: UUID! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.Int32? NumberOfObjects
        // GraphQL -> numberOfObjects: Int! (scalar)
        [JsonProperty("numberOfObjects")]
        public System.Int32? NumberOfObjects { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverGroupHost";
    }

    public FailoverGroupHost Set(
        FailoverGroupStatus? HostStatus = null,
        HostRegisterOsType? HostType = null,
        System.String? ActiveClusterUuid = null,
        List<System.String>? CounterpartIds = null,
        System.String? HostId = null,
        System.String? HostName = null,
        System.Int32? NumberOfObjects = null
    ) 
    {
        if ( HostStatus != null ) {
            this.HostStatus = HostStatus;
        }
        if ( HostType != null ) {
            this.HostType = HostType;
        }
        if ( ActiveClusterUuid != null ) {
            this.ActiveClusterUuid = ActiveClusterUuid;
        }
        if ( CounterpartIds != null ) {
            this.CounterpartIds = CounterpartIds;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( NumberOfObjects != null ) {
            this.NumberOfObjects = NumberOfObjects;
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
        //      C# -> FailoverGroupStatus? HostStatus
        // GraphQL -> hostStatus: FailoverGroupStatus! (enum)
        if (this.HostStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostStatus\n" ;
            } else {
                s += ind + "hostStatus\n" ;
            }
        }
        //      C# -> HostRegisterOsType? HostType
        // GraphQL -> hostType: HostRegisterOsType! (enum)
        if (this.HostType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostType\n" ;
            } else {
                s += ind + "hostType\n" ;
            }
        }
        //      C# -> System.String? ActiveClusterUuid
        // GraphQL -> activeClusterUuid: UUID! (scalar)
        if (this.ActiveClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeClusterUuid\n" ;
            } else {
                s += ind + "activeClusterUuid\n" ;
            }
        }
        //      C# -> List<System.String>? CounterpartIds
        // GraphQL -> counterpartIds: [UUID!]! (scalar)
        if (this.CounterpartIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "counterpartIds\n" ;
            } else {
                s += ind + "counterpartIds\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: UUID! (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
            }
        }
        //      C# -> System.Int32? NumberOfObjects
        // GraphQL -> numberOfObjects: Int! (scalar)
        if (this.NumberOfObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numberOfObjects\n" ;
            } else {
                s += ind + "numberOfObjects\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> FailoverGroupStatus? HostStatus
        // GraphQL -> hostStatus: FailoverGroupStatus! (enum)
        if (ec.Includes("hostStatus",true))
        {
            if(this.HostStatus == null) {

                this.HostStatus = new FailoverGroupStatus();

            } else {


            }
        }
        else if (this.HostStatus != null && ec.Excludes("hostStatus",true))
        {
            this.HostStatus = null;
        }
        //      C# -> HostRegisterOsType? HostType
        // GraphQL -> hostType: HostRegisterOsType! (enum)
        if (ec.Includes("hostType",true))
        {
            if(this.HostType == null) {

                this.HostType = new HostRegisterOsType();

            } else {


            }
        }
        else if (this.HostType != null && ec.Excludes("hostType",true))
        {
            this.HostType = null;
        }
        //      C# -> System.String? ActiveClusterUuid
        // GraphQL -> activeClusterUuid: UUID! (scalar)
        if (ec.Includes("activeClusterUuid",true))
        {
            if(this.ActiveClusterUuid == null) {

                this.ActiveClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ActiveClusterUuid != null && ec.Excludes("activeClusterUuid",true))
        {
            this.ActiveClusterUuid = null;
        }
        //      C# -> List<System.String>? CounterpartIds
        // GraphQL -> counterpartIds: [UUID!]! (scalar)
        if (ec.Includes("counterpartIds",true))
        {
            if(this.CounterpartIds == null) {

                this.CounterpartIds = new List<System.String>();

            } else {


            }
        }
        else if (this.CounterpartIds != null && ec.Excludes("counterpartIds",true))
        {
            this.CounterpartIds = null;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: UUID! (scalar)
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
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
        }
        //      C# -> System.Int32? NumberOfObjects
        // GraphQL -> numberOfObjects: Int! (scalar)
        if (ec.Includes("numberOfObjects",true))
        {
            if(this.NumberOfObjects == null) {

                this.NumberOfObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumberOfObjects != null && ec.Excludes("numberOfObjects",true))
        {
            this.NumberOfObjects = null;
        }
    }


    #endregion

    } // class FailoverGroupHost
    
    #endregion

    public static class ListFailoverGroupHostExtensions
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
            this List<FailoverGroupHost> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverGroupHost> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverGroupHost> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverGroupHost());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverGroupHost> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types