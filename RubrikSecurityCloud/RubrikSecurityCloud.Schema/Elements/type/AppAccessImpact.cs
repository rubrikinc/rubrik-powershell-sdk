// AppAccessImpact.cs
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
    #region AppAccessImpact
    public class AppAccessImpact: BaseType
    {
        #region members

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        [JsonProperty("principalName")]
        public System.String? PrincipalName { get; set; }

        //      C# -> AppAccessPath? ChangedPath
        // GraphQL -> changedPath: AppAccessPath (type)
        [JsonProperty("changedPath")]
        public AppAccessPath? ChangedPath { get; set; }

        //      C# -> List<AppAccessImpactEntry>? Impacts
        // GraphQL -> impacts: [AppAccessImpactEntry!]! (type)
        [JsonProperty("impacts")]
        public List<AppAccessImpactEntry>? Impacts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppAccessImpact";
    }

    public AppAccessImpact Set(
        System.String? PrincipalId = null,
        System.String? PrincipalName = null,
        AppAccessPath? ChangedPath = null,
        List<AppAccessImpactEntry>? Impacts = null
    ) 
    {
        if ( PrincipalId != null ) {
            this.PrincipalId = PrincipalId;
        }
        if ( PrincipalName != null ) {
            this.PrincipalName = PrincipalName;
        }
        if ( ChangedPath != null ) {
            this.ChangedPath = ChangedPath;
        }
        if ( Impacts != null ) {
            this.Impacts = Impacts;
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
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalId\n" ;
            } else {
                s += ind + "principalId\n" ;
            }
        }
        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        if (this.PrincipalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalName\n" ;
            } else {
                s += ind + "principalName\n" ;
            }
        }
        //      C# -> AppAccessPath? ChangedPath
        // GraphQL -> changedPath: AppAccessPath (type)
        if (this.ChangedPath != null) {
            var fspec = this.ChangedPath.AsFieldSpec(conf.Child("changedPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "changedPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AppAccessImpactEntry>? Impacts
        // GraphQL -> impacts: [AppAccessImpactEntry!]! (type)
        if (this.Impacts != null) {
            var fspec = this.Impacts.AsFieldSpec(conf.Child("impacts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "impacts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (ec.Includes("principalId",true))
        {
            if(this.PrincipalId == null) {

                this.PrincipalId = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalId != null && ec.Excludes("principalId",true))
        {
            this.PrincipalId = null;
        }
        //      C# -> System.String? PrincipalName
        // GraphQL -> principalName: String! (scalar)
        if (ec.Includes("principalName",true))
        {
            if(this.PrincipalName == null) {

                this.PrincipalName = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalName != null && ec.Excludes("principalName",true))
        {
            this.PrincipalName = null;
        }
        //      C# -> AppAccessPath? ChangedPath
        // GraphQL -> changedPath: AppAccessPath (type)
        if (ec.Includes("changedPath",false))
        {
            if(this.ChangedPath == null) {

                this.ChangedPath = new AppAccessPath();
                this.ChangedPath.ApplyExploratoryFieldSpec(ec.NewChild("changedPath"));

            } else {

                this.ChangedPath.ApplyExploratoryFieldSpec(ec.NewChild("changedPath"));

            }
        }
        else if (this.ChangedPath != null && ec.Excludes("changedPath",false))
        {
            this.ChangedPath = null;
        }
        //      C# -> List<AppAccessImpactEntry>? Impacts
        // GraphQL -> impacts: [AppAccessImpactEntry!]! (type)
        if (ec.Includes("impacts",false))
        {
            if(this.Impacts == null) {

                this.Impacts = new List<AppAccessImpactEntry>();
                this.Impacts.ApplyExploratoryFieldSpec(ec.NewChild("impacts"));

            } else {

                this.Impacts.ApplyExploratoryFieldSpec(ec.NewChild("impacts"));

            }
        }
        else if (this.Impacts != null && ec.Excludes("impacts",false))
        {
            this.Impacts = null;
        }
    }


    #endregion

    } // class AppAccessImpact
    
    #endregion

    public static class ListAppAccessImpactExtensions
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
            this List<AppAccessImpact> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AppAccessImpact> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AppAccessImpact> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AppAccessImpact());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AppAccessImpact> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types