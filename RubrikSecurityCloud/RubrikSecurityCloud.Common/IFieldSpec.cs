using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RubrikSecurityCloud.Types
{
    public class FieldSpecConfig
    {
        public bool Flat { get; set; } = false;
        public int Indent { get; set; } = 0;
        public string Prefix { get; set; } = "";

        public string Node { get; set; } = "";

        // IgnoreComposition does not automatically get passed down
        // to child/copy FieldSpecConfigs. It must be set explicitly.
        public bool IgnoreComposition { get; set; } = false;

        public FieldSpecConfig Child(string thisNode = "", string childNode = "",
            bool ignoreComposition = false)
        {
            thisNode = string.IsNullOrEmpty(thisNode) ? this.Node : thisNode;
            return new FieldSpecConfig
            {
                Flat = this.Flat,
                Indent = this.Indent + 1,
                Prefix = this.Prefix +
                    (string.IsNullOrEmpty(thisNode) ? "" : thisNode + "."),
                Node = childNode,
                IgnoreComposition = ignoreComposition
            };
        }

        public FieldSpecConfig Copy(bool ignoreComposition = false)
        {
            return new FieldSpecConfig
            {
                Flat = this.Flat,
                Indent = this.Indent,
                Prefix = this.Prefix,
                Node = this.Node,
                IgnoreComposition = ignoreComposition
            };
        }

        public string IndentStr()
        {
            return new string(' ', this.Indent * 2);
        }
    }
    public interface IFieldSpec
    {
        string AsFieldSpec(FieldSpecConfig? conf=null);
        List<string> SelectedFields();
        void ApplyExploratoryFieldSpec(ExplorationContext ec);
        void SelectForRetrieval();
    }
}
