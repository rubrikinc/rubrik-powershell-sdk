// ActivityObjectType.cs
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
    #region ActivityObjectType
 
    public class ActivityObjectType: BaseType, ActivitySeriesGroupByInfo
    {
        #region members

        //      C# -> ActivityObjectTypeEnum? EnumValue
        // GraphQL -> enumValue: ActivityObjectTypeEnum! (enum)
        [JsonProperty("enumValue")]
        public ActivityObjectTypeEnum? EnumValue { get; set; }


        #endregion

    #region methods

    public ActivityObjectType Set(
        ActivityObjectTypeEnum? EnumValue = null
    ) 
    {
        if ( EnumValue != null ) {
            this.EnumValue = EnumValue;
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
        //      C# -> ActivityObjectTypeEnum? EnumValue
        // GraphQL -> enumValue: ActivityObjectTypeEnum! (enum)
        if (this.EnumValue != null) {
            s += ind + "enumValue\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ActivityObjectTypeEnum? EnumValue
        // GraphQL -> enumValue: ActivityObjectTypeEnum! (enum)
        if (this.EnumValue == null && Exploration.Includes(parent + ".enumValue", true))
        {
            this.EnumValue = new ActivityObjectTypeEnum();
        }
    }


    #endregion

    } // class ActivityObjectType
    
    #endregion

    public static class ListActivityObjectTypeExtensions
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
            this List<ActivityObjectType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ActivityObjectType> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivityObjectType());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types