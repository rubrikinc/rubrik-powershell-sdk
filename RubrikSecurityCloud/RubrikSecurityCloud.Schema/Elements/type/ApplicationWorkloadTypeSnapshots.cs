// ApplicationWorkloadTypeSnapshots.cs
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
    #region ApplicationWorkloadTypeSnapshots
    public class ApplicationWorkloadTypeSnapshots: BaseType
    {
        #region members

        //      C# -> CloudNativeObjectType? ObjectType
        // GraphQL -> objectType: CloudNativeObjectType! (enum)
        [JsonProperty("objectType")]
        public CloudNativeObjectType? ObjectType { get; set; }

        //      C# -> List<ApplicationWorkloadSnapshot>? Snapshots
        // GraphQL -> snapshots: [ApplicationWorkloadSnapshot!]! (type)
        [JsonProperty("snapshots")]
        public List<ApplicationWorkloadSnapshot>? Snapshots { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ApplicationWorkloadTypeSnapshots";
    }

    public ApplicationWorkloadTypeSnapshots Set(
        CloudNativeObjectType? ObjectType = null,
        List<ApplicationWorkloadSnapshot>? Snapshots = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Snapshots != null ) {
            this.Snapshots = Snapshots;
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
        //      C# -> CloudNativeObjectType? ObjectType
        // GraphQL -> objectType: CloudNativeObjectType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> List<ApplicationWorkloadSnapshot>? Snapshots
        // GraphQL -> snapshots: [ApplicationWorkloadSnapshot!]! (type)
        if (this.Snapshots != null) {
            var fspec = this.Snapshots.AsFieldSpec(conf.Child("snapshots"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshots" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudNativeObjectType? ObjectType
        // GraphQL -> objectType: CloudNativeObjectType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new CloudNativeObjectType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> List<ApplicationWorkloadSnapshot>? Snapshots
        // GraphQL -> snapshots: [ApplicationWorkloadSnapshot!]! (type)
        if (ec.Includes("snapshots",false))
        {
            if(this.Snapshots == null) {

                this.Snapshots = new List<ApplicationWorkloadSnapshot>();
                this.Snapshots.ApplyExploratoryFieldSpec(ec.NewChild("snapshots"));

            } else {

                this.Snapshots.ApplyExploratoryFieldSpec(ec.NewChild("snapshots"));

            }
        }
        else if (this.Snapshots != null && ec.Excludes("snapshots",false))
        {
            this.Snapshots = null;
        }
    }


    #endregion

    } // class ApplicationWorkloadTypeSnapshots
    
    #endregion

    public static class ListApplicationWorkloadTypeSnapshotsExtensions
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
            this List<ApplicationWorkloadTypeSnapshots> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ApplicationWorkloadTypeSnapshots> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ApplicationWorkloadTypeSnapshots> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ApplicationWorkloadTypeSnapshots());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ApplicationWorkloadTypeSnapshots> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types