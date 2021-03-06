namespace CoditBlog.RoleLinks.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"EDI_DC40", @"EDI_DC40_DIRECT", @"EDI_DC40_OUTMOD", @"EDI_DC40_EXPRSS", @"EDI_DC40_TEST"})]
    public sealed class Common : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns4=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/"" elementFormDefault=""qualified"" targetNamespace=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/"" version=""1.0"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <annotation>
    <appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">IDocSharedTypes</fileNameHint>
    </appinfo>
  </annotation>
  <complexType name=""EDI_DC40"">
    <annotation>
      <documentation>
        <doc:description xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">IDoc Control Record for Interface to External System</doc:description>
      </documentation>
      <appinfo>
        <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        </groupInfo>
      </appinfo>
    </annotation>
    <sequence>
      <element minOccurs=""0"" maxOccurs=""1"" name=""TABNAM"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Name of Table Structure</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""10"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""MANDT"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Client</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""3"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOCNUM"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>IDoc number</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""16"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DOCREL"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>SAP Release for IDoc</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""4"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""STATUS"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Status of IDoc</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""2"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""DIRECT"" nillable=""true"" type=""ns4:EDI_DC40_DIRECT"">
        <annotation>
          <documentation>Direction</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""1"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""OUTMOD"" nillable=""true"" type=""ns4:EDI_DC40_OUTMOD"">
        <annotation>
          <documentation>Output mode</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""1"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""EXPRSS"" nillable=""true"" type=""ns4:EDI_DC40_EXPRSS"">
        <annotation>
          <documentation>Overriding in inbound processing</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""1"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""TEST"" nillable=""true"" type=""ns4:EDI_DC40_TEST"">
        <annotation>
          <documentation>Test flag</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""1"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""IDOCTYP"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Name of basic type</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""30"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""CIMTYP"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Extension (defined by customer)</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""30"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""MESTYP"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Message type</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""30"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""MESCOD"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Message code</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""3"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""MESFCT"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Message Function</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""3"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""STD"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>EDI standard, flag</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""1"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""STDVRS"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>EDI standard, version and release</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""6"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""STDMES"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>EDI message type</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""6"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""SNDPOR"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Sender port (SAP System, external subsystem)</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""10"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""SNDPRT"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Partner type of sender</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""2"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""SNDPFC"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Partner Function of Sender</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""2"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""SNDPRN"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Partner Number of Sender</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""10"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""SNDSAD"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Sender address (SADR)</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""21"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""SNDLAD"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Logical address of sender</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""70"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""RCVPOR"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Receiver port</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""10"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""RCVPRT"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Partner Type of Receiver</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""2"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""RCVPFC"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Partner function of recipient</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""2"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""RCVPRN"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Partner Number of Receiver</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""10"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""RCVSAD"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Recipient address (SADR)</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""21"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""RCVLAD"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Logical address of recipient</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""70"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""CREDAT"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Created on</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""8"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""CRETIM"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Created at</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""6"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""REFINT"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Transmission file (EDI Interchange)</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""14"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""REFGRP"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Message group (EDI Message Group)</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""14"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""REFMES"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Message (EDI Message)</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""14"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""ARCKEY"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Key for external message archive</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""70"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
      <element minOccurs=""0"" maxOccurs=""1"" name=""SERIAL"" nillable=""true"" type=""string"">
        <annotation>
          <documentation>Serialization</documentation>
          <appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""20"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </appinfo>
        </annotation>
      </element>
    </sequence>
  </complexType>
  <element name=""EDI_DC40"" nillable=""true"" type=""ns4:EDI_DC40"" />
  <simpleType name=""EDI_DC40_DIRECT"">
    <restriction base=""string"">
      <enumeration value=""1"">
        <annotation>
          <documentation>Outbound</documentation>
        </annotation>
      </enumeration>
      <enumeration value=""2"">
        <annotation>
          <documentation>Inbound</documentation>
        </annotation>
      </enumeration>
      <enumeration value="""">
        <annotation>
          <documentation>Initial: Accept blanks</documentation>
        </annotation>
      </enumeration>
    </restriction>
  </simpleType>
  <element name=""EDI_DC40_DIRECT"" nillable=""true"" type=""ns4:EDI_DC40_DIRECT"" />
  <simpleType name=""EDI_DC40_OUTMOD"">
    <restriction base=""string"">
      <enumeration value=""1"">
        <annotation>
          <documentation>Transfer IDoc immediately and start external subsystem</documentation>
        </annotation>
      </enumeration>
      <enumeration value=""2"">
        <annotation>
          <documentation>Transfer IDoc immediately</documentation>
        </annotation>
      </enumeration>
      <enumeration value=""3"">
        <annotation>
          <documentation>Collect IDocs, transfer and start external subsystem</documentation>
        </annotation>
      </enumeration>
      <enumeration value=""4"">
        <annotation>
          <documentation>Collect IDocs and transfer</documentation>
        </annotation>
      </enumeration>
      <enumeration value="""">
        <annotation>
          <documentation>Initial: Accept blanks</documentation>
        </annotation>
      </enumeration>
    </restriction>
  </simpleType>
  <element name=""EDI_DC40_OUTMOD"" nillable=""true"" type=""ns4:EDI_DC40_OUTMOD"" />
  <simpleType name=""EDI_DC40_EXPRSS"">
    <restriction base=""string"">
      <enumeration value=""X"">
        <annotation>
          <documentation>Overriding</documentation>
        </annotation>
      </enumeration>
      <enumeration value="""">
        <annotation>
          <documentation>Initial: Accept blanks</documentation>
        </annotation>
      </enumeration>
    </restriction>
  </simpleType>
  <element name=""EDI_DC40_EXPRSS"" nillable=""true"" type=""ns4:EDI_DC40_EXPRSS"" />
  <simpleType name=""EDI_DC40_TEST"">
    <restriction base=""string"">
      <enumeration value=""X"">
        <annotation>
          <documentation>IDoc contains a test message</documentation>
        </annotation>
      </enumeration>
      <enumeration value="""">
        <annotation>
          <documentation>Initial: Accept blanks</documentation>
        </annotation>
      </enumeration>
    </restriction>
  </simpleType>
  <element name=""EDI_DC40_TEST"" nillable=""true"" type=""ns4:EDI_DC40_TEST"" />
</schema>";
        
        public Common() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [5];
                _RootElements[0] = "EDI_DC40";
                _RootElements[1] = "EDI_DC40_DIRECT";
                _RootElements[2] = "EDI_DC40_OUTMOD";
                _RootElements[3] = "EDI_DC40_EXPRSS";
                _RootElements[4] = "EDI_DC40_TEST";
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
        
        [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/",@"EDI_DC40")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EDI_DC40"})]
        public sealed class EDI_DC40 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EDI_DC40() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EDI_DC40";
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
        
        [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/",@"EDI_DC40_DIRECT")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EDI_DC40_DIRECT"})]
        public sealed class EDI_DC40_DIRECT : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EDI_DC40_DIRECT() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EDI_DC40_DIRECT";
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
        
        [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/",@"EDI_DC40_OUTMOD")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EDI_DC40_OUTMOD"})]
        public sealed class EDI_DC40_OUTMOD : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EDI_DC40_OUTMOD() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EDI_DC40_OUTMOD";
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
        
        [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/",@"EDI_DC40_EXPRSS")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EDI_DC40_EXPRSS"})]
        public sealed class EDI_DC40_EXPRSS : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EDI_DC40_EXPRSS() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EDI_DC40_EXPRSS";
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
        
        [Schema(@"http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/",@"EDI_DC40_TEST")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EDI_DC40_TEST"})]
        public sealed class EDI_DC40_TEST : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EDI_DC40_TEST() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EDI_DC40_TEST";
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
}
