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

        //      C# -> System.Int64? TotalConsumption
        // GraphQL -> totalConsumption: Long (scalar)
        [JsonProperty("totalConsumption")]
        public System.Int64? TotalConsumption { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectTypeUsage";
    }

    public ObjectTypeUsage Set(
        O365SnappableType? ObjectType = null,
        System.Int64? TotalConsumption = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( TotalConsumption != null ) {
            this.TotalConsumption = TotalConsumption;
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
        //      C# -> System.Int64? TotalConsumption
        // GraphQL -> totalConsumption: Long (scalar)
        if (this.TotalConsumption != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalConsumption\n" ;
            } else {
                s += ind + "totalConsumption\n" ;
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