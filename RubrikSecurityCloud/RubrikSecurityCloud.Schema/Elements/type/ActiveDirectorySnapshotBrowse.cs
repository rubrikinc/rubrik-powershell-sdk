// ActiveDirectorySnapshotBrowse.cs
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
    #region ActiveDirectorySnapshotBrowse
    public class ActiveDirectorySnapshotBrowse: BaseType
    {
        #region members

        //      C# -> ActiveDirectoryObjectType? ActiveDirectoryObjectType
        // GraphQL -> activeDirectoryObjectType: ActiveDirectoryObjectType! (enum)
        [JsonProperty("activeDirectoryObjectType")]
        public ActiveDirectoryObjectType? ActiveDirectoryObjectType { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Dn
        // GraphQL -> dn: String (scalar)
        [JsonProperty("dn")]
        public System.String? Dn { get; set; }

        //      C# -> System.Int32? Dnt
        // GraphQL -> dnt: Int! (scalar)
        [JsonProperty("dnt")]
        public System.Int32? Dnt { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectorySnapshotBrowse";
    }

    public ActiveDirectorySnapshotBrowse Set(
        ActiveDirectoryObjectType? ActiveDirectoryObjectType = null,
        System.String? Description = null,
        System.String? Dn = null,
        System.Int32? Dnt = null,
        System.String? Name = null
    ) 
    {
        if ( ActiveDirectoryObjectType != null ) {
            this.ActiveDirectoryObjectType = ActiveDirectoryObjectType;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Dn != null ) {
            this.Dn = Dn;
        }
        if ( Dnt != null ) {
            this.Dnt = Dnt;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> ActiveDirectoryObjectType? ActiveDirectoryObjectType
        // GraphQL -> activeDirectoryObjectType: ActiveDirectoryObjectType! (enum)
        if (this.ActiveDirectoryObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeDirectoryObjectType\n" ;
            } else {
                s += ind + "activeDirectoryObjectType\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.String? Dn
        // GraphQL -> dn: String (scalar)
        if (this.Dn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dn\n" ;
            } else {
                s += ind + "dn\n" ;
            }
        }
        //      C# -> System.Int32? Dnt
        // GraphQL -> dnt: Int! (scalar)
        if (this.Dnt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dnt\n" ;
            } else {
                s += ind + "dnt\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ActiveDirectoryObjectType? ActiveDirectoryObjectType
        // GraphQL -> activeDirectoryObjectType: ActiveDirectoryObjectType! (enum)
        if (ec.Includes("activeDirectoryObjectType",true))
        {
            if(this.ActiveDirectoryObjectType == null) {

                this.ActiveDirectoryObjectType = new ActiveDirectoryObjectType();

            } else {


            }
        }
        else if (this.ActiveDirectoryObjectType != null && ec.Excludes("activeDirectoryObjectType",true))
        {
            this.ActiveDirectoryObjectType = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.String? Dn
        // GraphQL -> dn: String (scalar)
        if (ec.Includes("dn",true))
        {
            if(this.Dn == null) {

                this.Dn = "FETCH";

            } else {


            }
        }
        else if (this.Dn != null && ec.Excludes("dn",true))
        {
            this.Dn = null;
        }
        //      C# -> System.Int32? Dnt
        // GraphQL -> dnt: Int! (scalar)
        if (ec.Includes("dnt",true))
        {
            if(this.Dnt == null) {

                this.Dnt = Int32.MinValue;

            } else {


            }
        }
        else if (this.Dnt != null && ec.Excludes("dnt",true))
        {
            this.Dnt = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
    }


    #endregion

    } // class ActiveDirectorySnapshotBrowse
    
    #endregion

    public static class ListActiveDirectorySnapshotBrowseExtensions
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
            this List<ActiveDirectorySnapshotBrowse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectorySnapshotBrowse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectorySnapshotBrowse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectorySnapshotBrowse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectorySnapshotBrowse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types