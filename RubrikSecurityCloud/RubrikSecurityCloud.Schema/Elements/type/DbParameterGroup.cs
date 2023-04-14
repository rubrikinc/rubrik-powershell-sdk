// DbParameterGroup.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region DbParameterGroup
    public class DbParameterGroup: IFragment
    {
        #region members
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        [JsonProperty("arn")]
        public System.String? Arn { get; set; }

        //      C# -> System.String? Family
        // GraphQL -> family: String! (scalar)
        [JsonProperty("family")]
        public System.String? Family { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> AwsNativeRdsType? RdsType
        // GraphQL -> rdsType: AwsNativeRdsType! (enum)
        [JsonProperty("rdsType")]
        public AwsNativeRdsType? RdsType { get; set; }

        #endregion

    #region methods

    public DbParameterGroup Set(
        System.String? Arn = null,
        System.String? Family = null,
        System.String? Name = null,
        AwsNativeRdsType? RdsType = null
    ) 
    {
        if ( Arn != null ) {
            this.Arn = Arn;
        }
        if ( Family != null ) {
            this.Family = Family;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RdsType != null ) {
            this.RdsType = RdsType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Arn
            // GraphQL -> arn: String! (scalar)
            if (this.Arn != null)
            {
                 s += ind + "arn\n";

            }
            //      C# -> System.String? Family
            // GraphQL -> family: String! (scalar)
            if (this.Family != null)
            {
                 s += ind + "family\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> AwsNativeRdsType? RdsType
            // GraphQL -> rdsType: AwsNativeRdsType! (enum)
            if (this.RdsType != null)
            {
                 s += ind + "rdsType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Arn
            // GraphQL -> arn: String! (scalar)
            if (this.Arn == null && Exploration.Includes(parent + ".arn$"))
            {
                this.Arn = new System.String("FETCH");
            }
            //      C# -> System.String? Family
            // GraphQL -> family: String! (scalar)
            if (this.Family == null && Exploration.Includes(parent + ".family$"))
            {
                this.Family = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> AwsNativeRdsType? RdsType
            // GraphQL -> rdsType: AwsNativeRdsType! (enum)
            if (this.RdsType == null && Exploration.Includes(parent + ".rdsType$"))
            {
                this.RdsType = new AwsNativeRdsType();
            }
        }


    #endregion

    } // class DbParameterGroup
    #endregion

    public static class ListDbParameterGroupExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<DbParameterGroup> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DbParameterGroup> list, 
            String parent = "")
        {
            var item = new DbParameterGroup();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types