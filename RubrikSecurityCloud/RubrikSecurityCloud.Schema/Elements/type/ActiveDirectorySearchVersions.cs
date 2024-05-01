// ActiveDirectorySearchVersions.cs
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
    #region ActiveDirectorySearchVersions
    public class ActiveDirectorySearchVersions: BaseType
    {
        #region members

        //      C# -> ActiveDirectoryObjectType? ActiveDirectoryObjectType
        // GraphQL -> activeDirectoryObjectType: ActiveDirectoryObjectType! (enum)
        [JsonProperty("activeDirectoryObjectType")]
        public ActiveDirectoryObjectType? ActiveDirectoryObjectType { get; set; }

        //      C# -> System.String? Dn
        // GraphQL -> dn: String! (scalar)
        [JsonProperty("dn")]
        public System.String? Dn { get; set; }

        //      C# -> System.Int32? Dnt
        // GraphQL -> dnt: Int! (scalar)
        [JsonProperty("dnt")]
        public System.Int32? Dnt { get; set; }

        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot! (type)
        [JsonProperty("snapshot")]
        public CdmSnapshot? Snapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectorySearchVersions";
    }

    public ActiveDirectorySearchVersions Set(
        ActiveDirectoryObjectType? ActiveDirectoryObjectType = null,
        System.String? Dn = null,
        System.Int32? Dnt = null,
        CdmSnapshot? Snapshot = null
    ) 
    {
        if ( ActiveDirectoryObjectType != null ) {
            this.ActiveDirectoryObjectType = ActiveDirectoryObjectType;
        }
        if ( Dn != null ) {
            this.Dn = Dn;
        }
        if ( Dnt != null ) {
            this.Dnt = Dnt;
        }
        if ( Snapshot != null ) {
            this.Snapshot = Snapshot;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
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
        //      C# -> System.String? Dn
        // GraphQL -> dn: String! (scalar)
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
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot! (type)
        if (this.Snapshot != null) {
            var fspec = this.Snapshot.AsFieldSpec(conf.Child("snapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> System.String? Dn
        // GraphQL -> dn: String! (scalar)
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
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot! (type)
        if (ec.Includes("snapshot",false))
        {
            if(this.Snapshot == null) {

                this.Snapshot = new CdmSnapshot();
                this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));

            } else {

                this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));

            }
        }
        else if (this.Snapshot != null && ec.Excludes("snapshot",false))
        {
            this.Snapshot = null;
        }
    }


    #endregion

    } // class ActiveDirectorySearchVersions
    
    #endregion

    public static class ListActiveDirectorySearchVersionsExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ActiveDirectorySearchVersions> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectorySearchVersions> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectorySearchVersions> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectorySearchVersions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectorySearchVersions> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types