﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5477
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace JointMilitarySymbologyLibrary {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://esri.com/jmsmlConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://esri.com/jmsmlConfig.xsd", IsNullable=false)]
    public partial class JMSMLConfig {
        
        private JMSMLConfigETLConfig eTLConfigField;
        
        private string libraryPathField;
        
        private string libraryNameField;
        
        /// <remarks/>
        public JMSMLConfigETLConfig ETLConfig {
            get {
                return this.eTLConfigField;
            }
            set {
                this.eTLConfigField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string LibraryPath {
            get {
                return this.libraryPathField;
            }
            set {
                this.libraryPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string LibraryName {
            get {
                return this.libraryNameField;
            }
            set {
                this.libraryNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://esri.com/jmsmlConfig.xsd")]
    public partial class JMSMLConfigETLConfig {
        
        private GraphicFolderType[] graphicFolderField;
        
        private string domainSeparatorField;
        
        private int pointSizeField;
        
        private string sVGHomeField;
        
        private string graphicHomeField;
        
        private string graphicRootField;
        
        private string graphicExtensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GraphicFolder")]
        public GraphicFolderType[] GraphicFolder {
            get {
                return this.graphicFolderField;
            }
            set {
                this.graphicFolderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DomainSeparator {
            get {
                return this.domainSeparatorField;
            }
            set {
                this.domainSeparatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int PointSize {
            get {
                return this.pointSizeField;
            }
            set {
                this.pointSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string SVGHome {
            get {
                return this.sVGHomeField;
            }
            set {
                this.sVGHomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string GraphicHome {
            get {
                return this.graphicHomeField;
            }
            set {
                this.graphicHomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string GraphicRoot {
            get {
                return this.graphicRootField;
            }
            set {
                this.graphicRootField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string GraphicExtension {
            get {
                return this.graphicExtensionField;
            }
            set {
                this.graphicExtensionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://esri.com/jmsmlConfig.xsd")]
    public partial class GraphicFolderType {
        
        private GraphicFolderType[] graphicFolderField;
        
        private string nameField;
        
        private string framesField;
        
        private bool echelonsField;
        
        private bool mobilitiesField;
        
        private bool hQTFDummiesField;
        
        private bool arraysField;
        
        private bool specialsField;
        
        private string entitiesField;
        
        private string modifierOnesField;
        
        private string modifierTwosField;
        
        public GraphicFolderType() {
            this.framesField = "false";
            this.echelonsField = false;
            this.mobilitiesField = false;
            this.hQTFDummiesField = false;
            this.arraysField = false;
            this.specialsField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GraphicFolder")]
        public GraphicFolderType[] GraphicFolder {
            get {
                return this.graphicFolderField;
            }
            set {
                this.graphicFolderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREFS")]
        [System.ComponentModel.DefaultValueAttribute("false")]
        public string Frames {
            get {
                return this.framesField;
            }
            set {
                this.framesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Echelons {
            get {
                return this.echelonsField;
            }
            set {
                this.echelonsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Mobilities {
            get {
                return this.mobilitiesField;
            }
            set {
                this.mobilitiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool HQTFDummies {
            get {
                return this.hQTFDummiesField;
            }
            set {
                this.hQTFDummiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Arrays {
            get {
                return this.arraysField;
            }
            set {
                this.arraysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Specials {
            get {
                return this.specialsField;
            }
            set {
                this.specialsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREFS")]
        public string Entities {
            get {
                return this.entitiesField;
            }
            set {
                this.entitiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREFS")]
        public string ModifierOnes {
            get {
                return this.modifierOnesField;
            }
            set {
                this.modifierOnesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREFS")]
        public string ModifierTwos {
            get {
                return this.modifierTwosField;
            }
            set {
                this.modifierTwosField = value;
            }
        }
    }
}
