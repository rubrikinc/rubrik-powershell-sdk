// ObjectType.cs
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
    #region ObjectType
 
    public class ObjectType: IFragment, SnappableGroupByInfo
    {
        #region members
        //      C# -> ObjectTypeEnum? EnumValue
        // GraphQL -> enumValue: ObjectTypeEnum! (enum)
        [JsonProperty("enumValue")]
        public ObjectTypeEnum? EnumValue { get; set; }

        #endregion

    #region methods

    public ObjectType Set(
        ObjectTypeEnum? EnumValue = null
    ) 
    {
        if ( EnumValue != null ) {
            this.EnumValue = EnumValue;
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
            //      C# -> ObjectTypeEnum? EnumValue
            // GraphQL -> enumValue: ObjectTypeEnum! (enum)
            if (this.EnumValue != null)
            {
                 s += ind + "enumValue\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> ObjectTypeEnum? EnumValue
            // GraphQL -> enumValue: ObjectTypeEnum! (enum)
            if (this.EnumValue == null && Exploration.Includes(parent + ".enumValue$"))
            {
                this.EnumValue = new ObjectTypeEnum();
            }
        }


    #endregion

    } // class ObjectType
    #endregion

    public static class ListObjectTypeExtensions
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
            this List<ObjectType> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ObjectType> list, 
            String parent = "")
        {
            var item = new ObjectType();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types