// CloudAccountVpc.cs
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
    #region CloudAccountVpc
    public class CloudAccountVpc: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

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
        return "CloudAccountVpc";
    }

    public CloudAccountVpc Set(
        System.String? Id = null,
        System.String? Name = null,
        System.String? VpcId = null,
        CloudAccountAddressBlockV4? CidrBlock = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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

    } // class CloudAccountVpc
    
    #endregion

    public static class ListCloudAccountVpcExtensions
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
            this List<CloudAccountVpc> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudAccountVpc> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountVpc> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountVpc());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudAccountVpc> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types