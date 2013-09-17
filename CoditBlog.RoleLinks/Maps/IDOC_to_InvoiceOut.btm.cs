namespace CoditBlog.RoleLinks.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CoditBlog.RoleLinks.Schemas.ZINVOIC02_Receive", typeof(global::CoditBlog.RoleLinks.Schemas.ZINVOIC02_Receive))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CoditBlog.RoleLinks.Schemas.InvoiceOut", typeof(global::CoditBlog.RoleLinks.Schemas.InvoiceOut))]
    public sealed class IDOC_to_InvoiceOut : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s2 s0 s1"" version=""1.0"" xmlns:s2=""http://Microsoft.LobServices.Sap/2007/03/Idoc/3/INVOIC02/ZINVOIC02/731/Receive"" xmlns:s0=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/3/INVOIC02/ZINVOIC02/731"" xmlns:ns0=""http://CoditBlog.RoleLinks.InvoiceOut"" xmlns:s1=""http://Microsoft.LobServices.Sap/2007/03/Types/Idoc/Common/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Receive"" />
  </xsl:template>
  <xsl:template match=""/s2:Receive"">
    <ns0:InvoiceOut>
      <xsl:if test=""s2:idocData/s0:EDI_DC40/s1:DOCNUM"">
        <InvoiceNumber>
          <xsl:value-of select=""s2:idocData/s0:EDI_DC40/s1:DOCNUM/text()"" />
        </InvoiceNumber>
      </xsl:if>
      <xsl:if test=""s2:idocData/s0:E2EDK01005/s0:CURCY"">
        <Currency>
          <xsl:value-of select=""s2:idocData/s0:E2EDK01005/s0:CURCY/text()"" />
        </Currency>
      </xsl:if>
      <xsl:if test=""s2:idocData/s0:E2EDK01005/s0:RECIPNT_NO"">
        <DestinationNumber>
          <xsl:value-of select=""s2:idocData/s0:E2EDK01005/s0:RECIPNT_NO/text()"" />
        </DestinationNumber>
      </xsl:if>
      <xsl:if test=""s2:idocData/s0:E2EDK01005/s0:NTGEW"">
        <NumberOfItems>
          <xsl:value-of select=""s2:idocData/s0:E2EDK01005/s0:NTGEW/text()"" />
        </NumberOfItems>
      </xsl:if>
      <xsl:if test=""s2:idocData/s0:E2EDK01005/s0:BRGEW"">
        <Weight>
          <xsl:value-of select=""s2:idocData/s0:E2EDK01005/s0:BRGEW/text()"" />
        </Weight>
      </xsl:if>
      <xsl:if test=""s2:idocData/s0:E2EDK01005/s0:GEWEI"">
        <UnitOfMeasure>
          <xsl:value-of select=""s2:idocData/s0:E2EDK01005/s0:GEWEI/text()"" />
        </UnitOfMeasure>
      </xsl:if>
    </ns0:InvoiceOut>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CoditBlog.RoleLinks.Schemas.ZINVOIC02_Receive";
        
        private const global::CoditBlog.RoleLinks.Schemas.ZINVOIC02_Receive _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CoditBlog.RoleLinks.Schemas.InvoiceOut";
        
        private const global::CoditBlog.RoleLinks.Schemas.InvoiceOut _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"CoditBlog.RoleLinks.Schemas.ZINVOIC02_Receive";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CoditBlog.RoleLinks.Schemas.InvoiceOut";
                return _TrgSchemas;
            }
        }
    }
}
