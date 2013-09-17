namespace CoditBlog.RoleLinks.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Idoc/3/INVOIC02/ZINVOIC02/731/Receive",@"Receive")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Receive"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CoditBlog.RoleLinks.Schemas.ZINVOIC02", typeof(global::CoditBlog.RoleLinks.Schemas.ZINVOIC02))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CoditBlog.RoleLinks.Schemas.Common", typeof(global::CoditBlog.RoleLinks.Schemas.Common))]
    public sealed class ZINVOIC02_Receive : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://Microsoft.LobServices.Sap/2007/03/Idoc/3/INVOIC02/ZINVOIC02/731/Receive"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/3/INVOIC02/ZINVOIC02/731"" xmlns:ns1=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/"" elementFormDefault=""qualified"" targetNamespace=""http://Microsoft.LobServices.Sap/2007/03/Idoc/3/INVOIC02/ZINVOIC02/731/Receive"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""CoditBlog.RoleLinks.Schemas.ZINVOIC02"" namespace=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/3/INVOIC02/ZINVOIC02/731"" />
  <xs:import schemaLocation=""CoditBlog.RoleLinks.Schemas.Common"" namespace=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/"" />
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">IDocOperation.INVOIC02.ZINVOIC02.731.3.Receive</fileNameHint>
      <b:references>
        <b:reference targetNamespace=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/"" />
        <b:reference targetNamespace=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/3/INVOIC02/ZINVOIC02/731"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Receive"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">http://Microsoft.LobServices.Sap/2007/03/Idoc/3/INVOIC02/ZINVOIC02/731/Receive</doc:action>
      </xs:documentation>
      <xs:appinfo>
        <recordInfo structure=""delimited"" child_delimiter_type=""hex"" child_delimiter=""0xd 0xa"" child_order=""infix"" preserve_delimiter_for_empty_data=""True"" suppress_trailing_delimiters=""False"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        </recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/3/INVOIC02/ZINVOIC02/731"" minOccurs=""1"" maxOccurs=""2147483647"" name=""idocData"" nillable=""true"" type=""q2:INVOIC02"">
          <xs:annotation>
            <xs:appinfo>
              <recordInfo structure=""delimited"" child_delimiter_type=""hex"" child_delimiter=""0xd 0xa"" child_order=""postfix"" preserve_delimiter_for_empty_data=""True"" suppress_trailing_delimiters=""False"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
              </recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:annotation>
    <xs:appinfo>
      <schemaEditorExtension:schemaInfo extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"">
      </schemaEditorExtension:schemaInfo>
      <schemaInfo root_reference=""Receive"" standard=""Flat File"" count_positions_by_byte=""false"" parser_optimization=""complexity"" allow_early_termination=""true"" default_pad_char="" "" pad_char_type=""char"" allow_message_breakup_of_infix_root=""false"" compile_parse_tables=""false"" suppress_empty_nodes=""true"" generate_empty_nodes=""false"" early_terminate_optional_fields=""true"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
      </schemaInfo>
    </xs:appinfo>
  </xs:annotation>
</xs:schema>";
        
        public ZINVOIC02_Receive() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Receive";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
