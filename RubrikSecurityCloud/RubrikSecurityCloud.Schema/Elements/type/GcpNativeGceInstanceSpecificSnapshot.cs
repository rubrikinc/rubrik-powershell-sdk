// GcpNativeGceInstanceSpecificSnapshot.cs
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
    #region GcpNativeGceInstanceSpecificSnapshot
 
    public class GcpNativeGceInstanceSpecificSnapshot: BaseType, PolarisSpecificSnapshot
    {
        #region members

        //      C# -> System.String? MachineType
        // GraphQL -> machineType: String! (scalar)
        [JsonProperty("machineType")]
        public System.String? MachineType { get; set; }

        //      C# -> System.String? NetworkHostProjectNativeId
        // GraphQL -> networkHostProjectNativeId: String! (scalar)
        [JsonProperty("networkHostProjectNativeId")]
        public System.String? NetworkHostProjectNativeId { get; set; }

        //      C# -> List<System.String>? NetworkTags
        // GraphQL -> networkTags: [String!]! (scalar)
        [JsonProperty("networkTags")]
        public List<System.String>? NetworkTags { get; set; }

        //      C# -> System.String? ServiceAccountEmail
        // GraphQL -> serviceAccountEmail: String! (scalar)
        [JsonProperty("serviceAccountEmail")]
        public System.String? ServiceAccountEmail { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        [JsonProperty("subnetName")]
        public System.String? SubnetName { get; set; }

        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        [JsonProperty("vpcName")]
        public System.String? VpcName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeGceInstanceSpecificSnapshot";
    }

    public GcpNativeGceInstanceSpecificSnapshot Set(
        System.String? MachineType = null,
        System.String? NetworkHostProjectNativeId = null,
        List<System.String>? NetworkTags = null,
        System.String? ServiceAccountEmail = null,
        System.String? SnapshotId = null,
        System.String? SubnetName = null,
        System.String? VpcName = null
    ) 
    {
        if ( MachineType != null ) {
            this.MachineType = MachineType;
        }
        if ( NetworkHostProjectNativeId != null ) {
            this.NetworkHostProjectNativeId = NetworkHostProjectNativeId;
        }
        if ( NetworkTags != null ) {
            this.NetworkTags = NetworkTags;
        }
        if ( ServiceAccountEmail != null ) {
            this.ServiceAccountEmail = ServiceAccountEmail;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( SubnetName != null ) {
            this.SubnetName = SubnetName;
        }
        if ( VpcName != null ) {
            this.VpcName = VpcName;
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
        //      C# -> System.String? MachineType
        // GraphQL -> machineType: String! (scalar)
        if (this.MachineType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "machineType\n" ;
            } else {
                s += ind + "machineType\n" ;
            }
        }
        //      C# -> System.String? NetworkHostProjectNativeId
        // GraphQL -> networkHostProjectNativeId: String! (scalar)
        if (this.NetworkHostProjectNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkHostProjectNativeId\n" ;
            } else {
                s += ind + "networkHostProjectNativeId\n" ;
            }
        }
        //      C# -> List<System.String>? NetworkTags
        // GraphQL -> networkTags: [String!]! (scalar)
        if (this.NetworkTags != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkTags\n" ;
            } else {
                s += ind + "networkTags\n" ;
            }
        }
        //      C# -> System.String? ServiceAccountEmail
        // GraphQL -> serviceAccountEmail: String! (scalar)
        if (this.ServiceAccountEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serviceAccountEmail\n" ;
            } else {
                s += ind + "serviceAccountEmail\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        if (this.SubnetName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetName\n" ;
            } else {
                s += ind + "subnetName\n" ;
            }
        }
        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        if (this.VpcName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vpcName\n" ;
            } else {
                s += ind + "vpcName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? MachineType
        // GraphQL -> machineType: String! (scalar)
        if (ec.Includes("machineType",true))
        {
            if(this.MachineType == null) {

                this.MachineType = "FETCH";

            } else {


            }
        }
        else if (this.MachineType != null && ec.Excludes("machineType",true))
        {
            this.MachineType = null;
        }
        //      C# -> System.String? NetworkHostProjectNativeId
        // GraphQL -> networkHostProjectNativeId: String! (scalar)
        if (ec.Includes("networkHostProjectNativeId",true))
        {
            if(this.NetworkHostProjectNativeId == null) {

                this.NetworkHostProjectNativeId = "FETCH";

            } else {


            }
        }
        else if (this.NetworkHostProjectNativeId != null && ec.Excludes("networkHostProjectNativeId",true))
        {
            this.NetworkHostProjectNativeId = null;
        }
        //      C# -> List<System.String>? NetworkTags
        // GraphQL -> networkTags: [String!]! (scalar)
        if (ec.Includes("networkTags",true))
        {
            if(this.NetworkTags == null) {

                this.NetworkTags = new List<System.String>();

            } else {


            }
        }
        else if (this.NetworkTags != null && ec.Excludes("networkTags",true))
        {
            this.NetworkTags = null;
        }
        //      C# -> System.String? ServiceAccountEmail
        // GraphQL -> serviceAccountEmail: String! (scalar)
        if (ec.Includes("serviceAccountEmail",true))
        {
            if(this.ServiceAccountEmail == null) {

                this.ServiceAccountEmail = "FETCH";

            } else {


            }
        }
        else if (this.ServiceAccountEmail != null && ec.Excludes("serviceAccountEmail",true))
        {
            this.ServiceAccountEmail = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        if (ec.Includes("subnetName",true))
        {
            if(this.SubnetName == null) {

                this.SubnetName = "FETCH";

            } else {


            }
        }
        else if (this.SubnetName != null && ec.Excludes("subnetName",true))
        {
            this.SubnetName = null;
        }
        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        if (ec.Includes("vpcName",true))
        {
            if(this.VpcName == null) {

                this.VpcName = "FETCH";

            } else {


            }
        }
        else if (this.VpcName != null && ec.Excludes("vpcName",true))
        {
            this.VpcName = null;
        }
    }


    #endregion

    } // class GcpNativeGceInstanceSpecificSnapshot
    
    #endregion

    public static class ListGcpNativeGceInstanceSpecificSnapshotExtensions
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
            this List<GcpNativeGceInstanceSpecificSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpNativeGceInstanceSpecificSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeGceInstanceSpecificSnapshot> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeGceInstanceSpecificSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpNativeGceInstanceSpecificSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types