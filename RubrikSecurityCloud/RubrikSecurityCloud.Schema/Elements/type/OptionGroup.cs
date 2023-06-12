// OptionGroup.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region OptionGroup
    public class OptionGroup: BaseType
    {
        #region members

        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        [JsonProperty("arn")]
        public System.String? Arn { get; set; }

        //      C# -> System.String? Engine
        // GraphQL -> engine: String! (scalar)
        [JsonProperty("engine")]
        public System.String? Engine { get; set; }

        //      C# -> System.String? MajorEngineVersion
        // GraphQL -> majorEngineVersion: String! (scalar)
        [JsonProperty("majorEngineVersion")]
        public System.String? MajorEngineVersion { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }


        #endregion

    #region methods

    public OptionGroup Set(
        System.String? Arn = null,
        System.String? Engine = null,
        System.String? MajorEngineVersion = null,
        System.String? Name = null,
        System.String? VpcId = null
    ) 
    {
        if ( Arn != null ) {
            this.Arn = Arn;
        }
        if ( Engine != null ) {
            this.Engine = Engine;
        }
        if ( MajorEngineVersion != null ) {
            this.MajorEngineVersion = MajorEngineVersion;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
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
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn != null) {
            s += ind + "arn\n" ;
        }
        //      C# -> System.String? Engine
        // GraphQL -> engine: String! (scalar)
        if (this.Engine != null) {
            s += ind + "engine\n" ;
        }
        //      C# -> System.String? MajorEngineVersion
        // GraphQL -> majorEngineVersion: String! (scalar)
        if (this.MajorEngineVersion != null) {
            s += ind + "majorEngineVersion\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            s += ind + "vpcId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn == null && Exploration.Includes(parent + ".arn", true))
        {
            this.Arn = "FETCH";
        }
        //      C# -> System.String? Engine
        // GraphQL -> engine: String! (scalar)
        if (this.Engine == null && Exploration.Includes(parent + ".engine", true))
        {
            this.Engine = "FETCH";
        }
        //      C# -> System.String? MajorEngineVersion
        // GraphQL -> majorEngineVersion: String! (scalar)
        if (this.MajorEngineVersion == null && Exploration.Includes(parent + ".majorEngineVersion", true))
        {
            this.MajorEngineVersion = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId == null && Exploration.Includes(parent + ".vpcId", true))
        {
            this.VpcId = "FETCH";
        }
    }


    #endregion

    } // class OptionGroup
    
    #endregion

    public static class ListOptionGroupExtensions
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
            this List<OptionGroup> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OptionGroup> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OptionGroup());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types