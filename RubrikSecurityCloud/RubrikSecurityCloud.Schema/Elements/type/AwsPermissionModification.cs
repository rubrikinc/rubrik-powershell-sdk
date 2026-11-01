// AwsPermissionModification.cs
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
    #region AwsPermissionModification
    public class AwsPermissionModification: BaseType
    {
        #region members

        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        [JsonProperty("action")]
        public System.String? Action { get; set; }

        //      C# -> System.String? Effect
        // GraphQL -> effect: String! (scalar)
        [JsonProperty("effect")]
        public System.String? Effect { get; set; }

        //      C# -> List<AwsPermissionStatement>? Latest
        // GraphQL -> latest: [AwsPermissionStatement!]! (type)
        [JsonProperty("latest")]
        public List<AwsPermissionStatement>? Latest { get; set; }

        //      C# -> List<AwsPermissionStatement>? Previous
        // GraphQL -> previous: [AwsPermissionStatement!]! (type)
        [JsonProperty("previous")]
        public List<AwsPermissionStatement>? Previous { get; set; }

        //      C# -> List<AwsPermissionStatement>? Unchanged
        // GraphQL -> unchanged: [AwsPermissionStatement!]! (type)
        [JsonProperty("unchanged")]
        public List<AwsPermissionStatement>? Unchanged { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsPermissionModification";
    }

    public AwsPermissionModification Set(
        System.String? Action = null,
        System.String? Effect = null,
        List<AwsPermissionStatement>? Latest = null,
        List<AwsPermissionStatement>? Previous = null,
        List<AwsPermissionStatement>? Unchanged = null
    ) 
    {
        if ( Action != null ) {
            this.Action = Action;
        }
        if ( Effect != null ) {
            this.Effect = Effect;
        }
        if ( Latest != null ) {
            this.Latest = Latest;
        }
        if ( Previous != null ) {
            this.Previous = Previous;
        }
        if ( Unchanged != null ) {
            this.Unchanged = Unchanged;
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
        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        if (this.Action != null) {
            if (conf.Flat) {
                s += conf.Prefix + "action\n" ;
            } else {
                s += ind + "action\n" ;
            }
        }
        //      C# -> System.String? Effect
        // GraphQL -> effect: String! (scalar)
        if (this.Effect != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effect\n" ;
            } else {
                s += ind + "effect\n" ;
            }
        }
        //      C# -> List<AwsPermissionStatement>? Latest
        // GraphQL -> latest: [AwsPermissionStatement!]! (type)
        if (this.Latest != null) {
            var fspec = this.Latest.AsFieldSpec(conf.Child("latest"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latest" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsPermissionStatement>? Previous
        // GraphQL -> previous: [AwsPermissionStatement!]! (type)
        if (this.Previous != null) {
            var fspec = this.Previous.AsFieldSpec(conf.Child("previous"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "previous" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsPermissionStatement>? Unchanged
        // GraphQL -> unchanged: [AwsPermissionStatement!]! (type)
        if (this.Unchanged != null) {
            var fspec = this.Unchanged.AsFieldSpec(conf.Child("unchanged"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "unchanged" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Action
        // GraphQL -> action: String! (scalar)
        if (ec.Includes("action",true))
        {
            if(this.Action == null) {

                this.Action = "FETCH";

            } else {


            }
        }
        else if (this.Action != null && ec.Excludes("action",true))
        {
            this.Action = null;
        }
        //      C# -> System.String? Effect
        // GraphQL -> effect: String! (scalar)
        if (ec.Includes("effect",true))
        {
            if(this.Effect == null) {

                this.Effect = "FETCH";

            } else {


            }
        }
        else if (this.Effect != null && ec.Excludes("effect",true))
        {
            this.Effect = null;
        }
        //      C# -> List<AwsPermissionStatement>? Latest
        // GraphQL -> latest: [AwsPermissionStatement!]! (type)
        if (ec.Includes("latest",false))
        {
            if(this.Latest == null) {

                this.Latest = new List<AwsPermissionStatement>();
                this.Latest.ApplyExploratoryFieldSpec(ec.NewChild("latest"));

            } else {

                this.Latest.ApplyExploratoryFieldSpec(ec.NewChild("latest"));

            }
        }
        else if (this.Latest != null && ec.Excludes("latest",false))
        {
            this.Latest = null;
        }
        //      C# -> List<AwsPermissionStatement>? Previous
        // GraphQL -> previous: [AwsPermissionStatement!]! (type)
        if (ec.Includes("previous",false))
        {
            if(this.Previous == null) {

                this.Previous = new List<AwsPermissionStatement>();
                this.Previous.ApplyExploratoryFieldSpec(ec.NewChild("previous"));

            } else {

                this.Previous.ApplyExploratoryFieldSpec(ec.NewChild("previous"));

            }
        }
        else if (this.Previous != null && ec.Excludes("previous",false))
        {
            this.Previous = null;
        }
        //      C# -> List<AwsPermissionStatement>? Unchanged
        // GraphQL -> unchanged: [AwsPermissionStatement!]! (type)
        if (ec.Includes("unchanged",false))
        {
            if(this.Unchanged == null) {

                this.Unchanged = new List<AwsPermissionStatement>();
                this.Unchanged.ApplyExploratoryFieldSpec(ec.NewChild("unchanged"));

            } else {

                this.Unchanged.ApplyExploratoryFieldSpec(ec.NewChild("unchanged"));

            }
        }
        else if (this.Unchanged != null && ec.Excludes("unchanged",false))
        {
            this.Unchanged = null;
        }
    }


    #endregion

    } // class AwsPermissionModification
    
    #endregion

    public static class ListAwsPermissionModificationExtensions
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
            this List<AwsPermissionModification> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsPermissionModification> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsPermissionModification> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsPermissionModification());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsPermissionModification> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types