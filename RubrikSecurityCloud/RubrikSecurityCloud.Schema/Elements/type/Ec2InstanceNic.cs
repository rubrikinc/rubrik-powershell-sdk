// Ec2InstanceNic.cs
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
    #region Ec2InstanceNic
    public class Ec2InstanceNic: BaseType
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> SnappableSecurityGroup? SecGroup
        // GraphQL -> secGroup: SnappableSecurityGroup (type)
        [JsonProperty("secGroup")]
        public SnappableSecurityGroup? SecGroup { get; set; }

        //      C# -> SnappableSubnet? Subnet
        // GraphQL -> subnet: SnappableSubnet (type)
        [JsonProperty("subnet")]
        public SnappableSubnet? Subnet { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Ec2InstanceNic";
    }

    public Ec2InstanceNic Set(
        System.String? Key = null,
        SnappableSecurityGroup? SecGroup = null,
        SnappableSubnet? Subnet = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( SecGroup != null ) {
            this.SecGroup = SecGroup;
        }
        if ( Subnet != null ) {
            this.Subnet = Subnet;
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
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> SnappableSecurityGroup? SecGroup
        // GraphQL -> secGroup: SnappableSecurityGroup (type)
        if (this.SecGroup != null) {
            var fspec = this.SecGroup.AsFieldSpec(conf.Child("secGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "secGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnappableSubnet? Subnet
        // GraphQL -> subnet: SnappableSubnet (type)
        if (this.Subnet != null) {
            var fspec = this.Subnet.AsFieldSpec(conf.Child("subnet"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subnet" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = "FETCH";

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> SnappableSecurityGroup? SecGroup
        // GraphQL -> secGroup: SnappableSecurityGroup (type)
        if (ec.Includes("secGroup",false))
        {
            if(this.SecGroup == null) {

                this.SecGroup = new SnappableSecurityGroup();
                this.SecGroup.ApplyExploratoryFieldSpec(ec.NewChild("secGroup"));

            } else {

                this.SecGroup.ApplyExploratoryFieldSpec(ec.NewChild("secGroup"));

            }
        }
        else if (this.SecGroup != null && ec.Excludes("secGroup",false))
        {
            this.SecGroup = null;
        }
        //      C# -> SnappableSubnet? Subnet
        // GraphQL -> subnet: SnappableSubnet (type)
        if (ec.Includes("subnet",false))
        {
            if(this.Subnet == null) {

                this.Subnet = new SnappableSubnet();
                this.Subnet.ApplyExploratoryFieldSpec(ec.NewChild("subnet"));

            } else {

                this.Subnet.ApplyExploratoryFieldSpec(ec.NewChild("subnet"));

            }
        }
        else if (this.Subnet != null && ec.Excludes("subnet",false))
        {
            this.Subnet = null;
        }
    }


    #endregion

    } // class Ec2InstanceNic
    
    #endregion

    public static class ListEc2InstanceNicExtensions
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
            this List<Ec2InstanceNic> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Ec2InstanceNic> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Ec2InstanceNic> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Ec2InstanceNic());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Ec2InstanceNic> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types