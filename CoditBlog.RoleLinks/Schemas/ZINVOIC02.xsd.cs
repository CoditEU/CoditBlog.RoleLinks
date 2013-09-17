namespace CoditBlog.RoleLinks.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CoditBlog.RoleLinks.Schemas.Common", typeof(global::CoditBlog.RoleLinks.Schemas.Common))]
    public sealed class ZINVOIC02 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/"" xmlns:ns3=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/3/INVOIC02/ZINVOIC02/731"" elementFormDefault=""qualified"" targetNamespace=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/3/INVOIC02/ZINVOIC02/731"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""CoditBlog.RoleLinks.Schemas.Common"" namespace=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/"" />
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">IDoc.INVOIC02.ZINVOIC02.731.3</fileNameHint>
      <b:references>
        <b:reference targetNamespace=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""E1EDK01"">
    <xs:annotation>
      <xs:appinfo>
        <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        </groupInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" default=""E2EDK01005"" name=""DATAHEADERCOLUMN_SEGNAM"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""30"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DATAHEADERCOLUMN_MANDT"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""3"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DATAHEADERCOLUMN_DOCNUM"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""16"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DATAHEADERCOLUMN_SEGNUM"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""6"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DATAHEADERCOLUMN_PSGNUM"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""6"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DATAHEADERCOLUMN_HLEVEL"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""2"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CURCY"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Currency</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""3"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""HWAER"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>EDI local currency</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""3"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WKURS"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Exchange rate</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""12"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ZTERM"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Terms of payment key</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""17"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""KUNDEUINR"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>VAT Registration Number</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""20"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""EIGENUINR"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>VAT Registration Number</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""20"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BSART"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Document type</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""4"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BELNR"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>IDOC document number</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""35"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""NTGEW"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Net weight</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""18"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BRGEW"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Net weight</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""18"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""GEWEI"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Weight unit</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""3"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""FKART_RL"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Invoice list type</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""4"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ABLAD"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Unloading Point</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""25"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BSTZD"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Purchase order number supplement</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""4"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""VSART"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Shipping Conditions</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""2"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""VSART_BEZ"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Description of the Shipping Type</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""20"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""RECIPNT_NO"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Number of recipient (for control via the ALE model)</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""10"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AUGRU"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Order reason (reason for the business transaction)</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""3"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AUGRU_BEZ"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Description</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""40"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ABRVW"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Usage Indicator</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""3"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ABRVW_BEZ"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Description</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""20"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LIFSK"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Delivery block (document header)</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""2"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LIFSK_BEZ"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Description</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""20"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""EMPST"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Receiving point</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""25"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ABTNR"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Department number</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""4"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DELCO"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Agreed delivery time</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""3"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WKURS_M"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Indirectly quoted exchange rate in an IDoc segment</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""12"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SEGMENTPAD"" nillable=""true"" type=""xs:string"">
        <xs:annotation>
          <xs:documentation>Padding White Spaces against the Total Segment Length</xs:documentation>
          <xs:appinfo>
            <fieldInfo pad_char=""0x20"" pad_char_type=""hex"" justification=""left"" pos_offset=""0"" pos_length=""643"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""INVOIC02"">
    <xs:annotation>
      <xs:appinfo>
        <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        </groupInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element xmlns:q1=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/"" minOccurs=""1"" maxOccurs=""1"" name=""EDI_DC40"" type=""q1:EDI_DC40"">
        <xs:annotation>
          <xs:appinfo>
            <recordInfo structure=""positional"" sequence_number=""1"" tag_name=""ZINVOIC02"" tag_offset=""69"" preserve_delimiter_for_empty_data=""True"" suppress_trailing_delimiters=""False"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </recordInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""E2EDK01005"" type=""ns3:E1EDK01"">
        <xs:annotation>
          <xs:documentation>IDoc: Document header general data</xs:documentation>
          <xs:appinfo>
            <recordInfo structure=""positional"" sequence_number=""2"" tag_name=""E2EDK01005"" tag_offset=""0"" preserve_delimiter_for_empty_data=""True"" suppress_trailing_delimiters=""False"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
            </recordInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public ZINVOIC02() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [0];
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
