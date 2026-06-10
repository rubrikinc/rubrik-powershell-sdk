// AzureAdEmIncompatibilities.cs
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
    #region AzureAdEmIncompatibilities
    public class AzureAdEmIncompatibilities: BaseType
    {
        #region members

        //      C# -> EmIncompatibleObjectType? ObjectType
        // GraphQL -> objectType: EmIncompatibleObjectType! (enum)
        [JsonProperty("objectType")]
        public EmIncompatibleObjectType? ObjectType { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        [JsonProperty("targetId")]
        public System.String? TargetId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdEmIncompatibilities";
    }

    public AzureAdEmIncompatibilities Set(
        EmIncompatibleObjectType? ObjectType = null,
        System.String? DisplayName = null,
        System.String? TargetId = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( TargetId != null ) {
            this.TargetId = TargetId;
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
        //      C# -> EmIncompatibleObjectType? ObjectType
        // GraphQL -> objectType: EmIncompatibleObjectType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        if (this.TargetId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetId\n" ;
            } else {
                s += ind + "targetId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> EmIncompatibleObjectType? ObjectType
        // GraphQL -> objectType: EmIncompatibleObjectType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new EmIncompatibleObjectType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.String? TargetId
        // GraphQL -> targetId: String! (scalar)
        if (ec.Includes("targetId",true))
        {
            if(this.TargetId == null) {

                this.TargetId = "FETCH";

            } else {


            }
        }
        else if (this.TargetId != null && ec.Excludes("targetId",true))
        {
            this.TargetId = null;
        }
    }


    #endregion

    } // class AzureAdEmIncompatibilities
    
    #endregion

    public static class ListAzureAdEmIncompatibilitiesExtensions
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
            this List<AzureAdEmIncompatibilities> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdEmIncompatibilities> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdEmIncompatibilities> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdEmIncompatibilities());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdEmIncompatibilities> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types