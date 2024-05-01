// CloudAccountSubnet.cs
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
    #region CloudAccountSubnet
    public class CloudAccountSubnet: BaseType
    {
        #region members

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> CloudAccountAddressBlockV4? CidrBlock
        // GraphQL -> cidrBlock: CloudAccountAddressBlockV4 (type)
        [JsonProperty("cidrBlock")]
        public CloudAccountAddressBlockV4? CidrBlock { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudAccountSubnet";
    }

    public CloudAccountSubnet Set(
        System.String? AvailabilityZone = null,
        System.String? Name = null,
        System.String? SubnetId = null,
        System.String? VpcId = null,
        CloudAccountAddressBlockV4? CidrBlock = null
    ) 
    {
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SubnetId != null ) {
            this.SubnetId = SubnetId;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( CidrBlock != null ) {
            this.CidrBlock = CidrBlock;
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
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "availabilityZone\n" ;
            } else {
                s += ind + "availabilityZone\n" ;
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
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (this.SubnetId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetId\n" ;
            } else {
                s += ind + "subnetId\n" ;
            }
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vpcId\n" ;
            } else {
                s += ind + "vpcId\n" ;
            }
        }
        //      C# -> CloudAccountAddressBlockV4? CidrBlock
        // GraphQL -> cidrBlock: CloudAccountAddressBlockV4 (type)
        if (this.CidrBlock != null) {
            var fspec = this.CidrBlock.AsFieldSpec(conf.Child("cidrBlock"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cidrBlock" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (ec.Includes("availabilityZone",true))
        {
            if(this.AvailabilityZone == null) {

                this.AvailabilityZone = "FETCH";

            } else {


            }
        }
        else if (this.AvailabilityZone != null && ec.Excludes("availabilityZone",true))
        {
            this.AvailabilityZone = null;
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
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (ec.Includes("subnetId",true))
        {
            if(this.SubnetId == null) {

                this.SubnetId = "FETCH";

            } else {


            }
        }
        else if (this.SubnetId != null && ec.Excludes("subnetId",true))
        {
            this.SubnetId = null;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (ec.Includes("vpcId",true))
        {
            if(this.VpcId == null) {

                this.VpcId = "FETCH";

            } else {


            }
        }
        else if (this.VpcId != null && ec.Excludes("vpcId",true))
        {
            this.VpcId = null;
        }
        //      C# -> CloudAccountAddressBlockV4? CidrBlock
        // GraphQL -> cidrBlock: CloudAccountAddressBlockV4 (type)
        if (ec.Includes("cidrBlock",false))
        {
            if(this.CidrBlock == null) {

                this.CidrBlock = new CloudAccountAddressBlockV4();
                this.CidrBlock.ApplyExploratoryFieldSpec(ec.NewChild("cidrBlock"));

            } else {

                this.CidrBlock.ApplyExploratoryFieldSpec(ec.NewChild("cidrBlock"));

            }
        }
        else if (this.CidrBlock != null && ec.Excludes("cidrBlock",false))
        {
            this.CidrBlock = null;
        }
    }


    #endregion

    } // class CloudAccountSubnet
    
    #endregion

    public static class ListCloudAccountSubnetExtensions
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
            this List<CloudAccountSubnet> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudAccountSubnet> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountSubnet> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountSubnet());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudAccountSubnet> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types