// Ec2InstanceVolume.cs
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
    #region Ec2InstanceVolume
    public class Ec2InstanceVolume: BaseType
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.Int32? SizeGbs
        // GraphQL -> sizeGbs: Int! (scalar)
        [JsonProperty("sizeGbs")]
        public System.Int32? SizeGbs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Ec2InstanceVolume";
    }

    public Ec2InstanceVolume Set(
        System.String? Key = null,
        System.Int32? SizeGbs = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( SizeGbs != null ) {
            this.SizeGbs = SizeGbs;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            s += ind + "key\n" ;
        }
        //      C# -> System.Int32? SizeGbs
        // GraphQL -> sizeGbs: Int! (scalar)
        if (this.SizeGbs != null) {
            s += ind + "sizeGbs\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key == null && Exploration.Includes(parent + ".key", true))
        {
            this.Key = "FETCH";
        }
        //      C# -> System.Int32? SizeGbs
        // GraphQL -> sizeGbs: Int! (scalar)
        if (this.SizeGbs == null && Exploration.Includes(parent + ".sizeGbs", true))
        {
            this.SizeGbs = Int32.MinValue;
        }
    }


    #endregion

    } // class Ec2InstanceVolume
    
    #endregion

    public static class ListEc2InstanceVolumeExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<Ec2InstanceVolume> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Ec2InstanceVolume> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Ec2InstanceVolume());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types