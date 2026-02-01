// ObjectTypeUsage.cs
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
    #region ObjectTypeUsage
    public class ObjectTypeUsage: BaseType
    {
        #region members

        //      C# -> O365SnappableType? ObjectType
        // GraphQL -> objectType: O365SnappableType! (enum)
        [JsonProperty("objectType")]
        public O365SnappableType? ObjectType { get; set; }

        //      C# -> System.Int32? ResourceMailboxCount
        // GraphQL -> resourceMailboxCount: Int (scalar)
        [JsonProperty("resourceMailboxCount")]
        public System.Int32? ResourceMailboxCount { get; set; }

        //      C# -> System.Int32? SharedMailboxCount
        // GraphQL -> sharedMailboxCount: Int (scalar)
        [JsonProperty("sharedMailboxCount")]
        public System.Int32? SharedMailboxCount { get; set; }

        //      C# -> System.Int64? TotalConsumption
        // GraphQL -> totalConsumption: Long (scalar)
        [JsonProperty("totalConsumption")]
        public System.Int64? TotalConsumption { get; set; }

        //      C# -> System.Int32? TotalProtectedUsers
        // GraphQL -> totalProtectedUsers: Int (scalar)
        [JsonProperty("totalProtectedUsers")]
        public System.Int32? TotalProtectedUsers { get; set; }

        //      C# -> System.Int32? UserMailboxCount
        // GraphQL -> userMailboxCount: Int (scalar)
        [JsonProperty("userMailboxCount")]
        public System.Int32? UserMailboxCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectTypeUsage";
    }

    public ObjectTypeUsage Set(
        O365SnappableType? ObjectType = null,
        System.Int32? ResourceMailboxCount = null,
        System.Int32? SharedMailboxCount = null,
        System.Int64? TotalConsumption = null,
        System.Int32? TotalProtectedUsers = null,
        System.Int32? UserMailboxCount = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( ResourceMailboxCount != null ) {
            this.ResourceMailboxCount = ResourceMailboxCount;
        }
        if ( SharedMailboxCount != null ) {
            this.SharedMailboxCount = SharedMailboxCount;
        }
        if ( TotalConsumption != null ) {
            this.TotalConsumption = TotalConsumption;
        }
        if ( TotalProtectedUsers != null ) {
            this.TotalProtectedUsers = TotalProtectedUsers;
        }
        if ( UserMailboxCount != null ) {
            this.UserMailboxCount = UserMailboxCount;
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
        //      C# -> O365SnappableType? ObjectType
        // GraphQL -> objectType: O365SnappableType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.Int32? ResourceMailboxCount
        // GraphQL -> resourceMailboxCount: Int (scalar)
        if (this.ResourceMailboxCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceMailboxCount\n" ;
            } else {
                s += ind + "resourceMailboxCount\n" ;
            }
        }
        //      C# -> System.Int32? SharedMailboxCount
        // GraphQL -> sharedMailboxCount: Int (scalar)
        if (this.SharedMailboxCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sharedMailboxCount\n" ;
            } else {
                s += ind + "sharedMailboxCount\n" ;
            }
        }
        //      C# -> System.Int64? TotalConsumption
        // GraphQL -> totalConsumption: Long (scalar)
        if (this.TotalConsumption != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalConsumption\n" ;
            } else {
                s += ind + "totalConsumption\n" ;
            }
        }
        //      C# -> System.Int32? TotalProtectedUsers
        // GraphQL -> totalProtectedUsers: Int (scalar)
        if (this.TotalProtectedUsers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalProtectedUsers\n" ;
            } else {
                s += ind + "totalProtectedUsers\n" ;
            }
        }
        //      C# -> System.Int32? UserMailboxCount
        // GraphQL -> userMailboxCount: Int (scalar)
        if (this.UserMailboxCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userMailboxCount\n" ;
            } else {
                s += ind + "userMailboxCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> O365SnappableType? ObjectType
        // GraphQL -> objectType: O365SnappableType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new O365SnappableType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> System.Int32? ResourceMailboxCount
        // GraphQL -> resourceMailboxCount: Int (scalar)
        if (ec.Includes("resourceMailboxCount",true))
        {
            if(this.ResourceMailboxCount == null) {

                this.ResourceMailboxCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ResourceMailboxCount != null && ec.Excludes("resourceMailboxCount",true))
        {
            this.ResourceMailboxCount = null;
        }
        //      C# -> System.Int32? SharedMailboxCount
        // GraphQL -> sharedMailboxCount: Int (scalar)
        if (ec.Includes("sharedMailboxCount",true))
        {
            if(this.SharedMailboxCount == null) {

                this.SharedMailboxCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.SharedMailboxCount != null && ec.Excludes("sharedMailboxCount",true))
        {
            this.SharedMailboxCount = null;
        }
        //      C# -> System.Int64? TotalConsumption
        // GraphQL -> totalConsumption: Long (scalar)
        if (ec.Includes("totalConsumption",true))
        {
            if(this.TotalConsumption == null) {

                this.TotalConsumption = new System.Int64();

            } else {


            }
        }
        else if (this.TotalConsumption != null && ec.Excludes("totalConsumption",true))
        {
            this.TotalConsumption = null;
        }
        //      C# -> System.Int32? TotalProtectedUsers
        // GraphQL -> totalProtectedUsers: Int (scalar)
        if (ec.Includes("totalProtectedUsers",true))
        {
            if(this.TotalProtectedUsers == null) {

                this.TotalProtectedUsers = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalProtectedUsers != null && ec.Excludes("totalProtectedUsers",true))
        {
            this.TotalProtectedUsers = null;
        }
        //      C# -> System.Int32? UserMailboxCount
        // GraphQL -> userMailboxCount: Int (scalar)
        if (ec.Includes("userMailboxCount",true))
        {
            if(this.UserMailboxCount == null) {

                this.UserMailboxCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.UserMailboxCount != null && ec.Excludes("userMailboxCount",true))
        {
            this.UserMailboxCount = null;
        }
    }


    #endregion

    } // class ObjectTypeUsage
    
    #endregion

    public static class ListObjectTypeUsageExtensions
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
            this List<ObjectTypeUsage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectTypeUsage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectTypeUsage> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectTypeUsage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectTypeUsage> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types