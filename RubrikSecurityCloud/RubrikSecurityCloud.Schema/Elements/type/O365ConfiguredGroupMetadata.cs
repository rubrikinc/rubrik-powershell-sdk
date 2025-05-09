// O365ConfiguredGroupMetadata.cs
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
    #region O365ConfiguredGroupMetadata
    public class O365ConfiguredGroupMetadata: BaseType
    {
        #region members

        //      C# -> System.Int32? SharepointObjects
        // GraphQL -> sharepointObjects: Int (scalar)
        [JsonProperty("sharepointObjects")]
        public System.Int32? SharepointObjects { get; set; }

        //      C# -> System.Int32? TeamsObjects
        // GraphQL -> teamsObjects: Int (scalar)
        [JsonProperty("teamsObjects")]
        public System.Int32? TeamsObjects { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365ConfiguredGroupMetadata";
    }

    public O365ConfiguredGroupMetadata Set(
        System.Int32? SharepointObjects = null,
        System.Int32? TeamsObjects = null
    ) 
    {
        if ( SharepointObjects != null ) {
            this.SharepointObjects = SharepointObjects;
        }
        if ( TeamsObjects != null ) {
            this.TeamsObjects = TeamsObjects;
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
        //      C# -> System.Int32? SharepointObjects
        // GraphQL -> sharepointObjects: Int (scalar)
        if (this.SharepointObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sharepointObjects\n" ;
            } else {
                s += ind + "sharepointObjects\n" ;
            }
        }
        //      C# -> System.Int32? TeamsObjects
        // GraphQL -> teamsObjects: Int (scalar)
        if (this.TeamsObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "teamsObjects\n" ;
            } else {
                s += ind + "teamsObjects\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? SharepointObjects
        // GraphQL -> sharepointObjects: Int (scalar)
        if (ec.Includes("sharepointObjects",true))
        {
            if(this.SharepointObjects == null) {

                this.SharepointObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.SharepointObjects != null && ec.Excludes("sharepointObjects",true))
        {
            this.SharepointObjects = null;
        }
        //      C# -> System.Int32? TeamsObjects
        // GraphQL -> teamsObjects: Int (scalar)
        if (ec.Includes("teamsObjects",true))
        {
            if(this.TeamsObjects == null) {

                this.TeamsObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.TeamsObjects != null && ec.Excludes("teamsObjects",true))
        {
            this.TeamsObjects = null;
        }
    }


    #endregion

    } // class O365ConfiguredGroupMetadata
    
    #endregion

    public static class ListO365ConfiguredGroupMetadataExtensions
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
            this List<O365ConfiguredGroupMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365ConfiguredGroupMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365ConfiguredGroupMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365ConfiguredGroupMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365ConfiguredGroupMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types