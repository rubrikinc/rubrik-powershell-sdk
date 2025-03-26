// BackupWindow.cs
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
    #region BackupWindow
    public class BackupWindow: BaseType
    {
        #region members

        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        [JsonProperty("durationInHours")]
        public System.Int32? DurationInHours { get; set; }

        //      C# -> StartTimeAttributes? StartTimeAttributes
        // GraphQL -> startTimeAttributes: StartTimeAttributes (type)
        [JsonProperty("startTimeAttributes")]
        public StartTimeAttributes? StartTimeAttributes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BackupWindow";
    }

    public BackupWindow Set(
        System.Int32? DurationInHours = null,
        StartTimeAttributes? StartTimeAttributes = null
    ) 
    {
        if ( DurationInHours != null ) {
            this.DurationInHours = DurationInHours;
        }
        if ( StartTimeAttributes != null ) {
            this.StartTimeAttributes = StartTimeAttributes;
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
        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        if (this.DurationInHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "durationInHours\n" ;
            } else {
                s += ind + "durationInHours\n" ;
            }
        }
        //      C# -> StartTimeAttributes? StartTimeAttributes
        // GraphQL -> startTimeAttributes: StartTimeAttributes (type)
        if (this.StartTimeAttributes != null) {
            var fspec = this.StartTimeAttributes.AsFieldSpec(conf.Child("startTimeAttributes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "startTimeAttributes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? DurationInHours
        // GraphQL -> durationInHours: Int! (scalar)
        if (ec.Includes("durationInHours",true))
        {
            if(this.DurationInHours == null) {

                this.DurationInHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.DurationInHours != null && ec.Excludes("durationInHours",true))
        {
            this.DurationInHours = null;
        }
        //      C# -> StartTimeAttributes? StartTimeAttributes
        // GraphQL -> startTimeAttributes: StartTimeAttributes (type)
        if (ec.Includes("startTimeAttributes",false))
        {
            if(this.StartTimeAttributes == null) {

                this.StartTimeAttributes = new StartTimeAttributes();
                this.StartTimeAttributes.ApplyExploratoryFieldSpec(ec.NewChild("startTimeAttributes"));

            } else {

                this.StartTimeAttributes.ApplyExploratoryFieldSpec(ec.NewChild("startTimeAttributes"));

            }
        }
        else if (this.StartTimeAttributes != null && ec.Excludes("startTimeAttributes",false))
        {
            this.StartTimeAttributes = null;
        }
    }


    #endregion

    } // class BackupWindow
    
    #endregion

    public static class ListBackupWindowExtensions
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
            this List<BackupWindow> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BackupWindow> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BackupWindow> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupWindow());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BackupWindow> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types