﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zentrix.Models.BD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SAINTPALLEntities1 : DbContext
    {
        public SAINTPALLEntities1()
            : base("name=SAINTPALLEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ataCompCXP> ataCompCXP { get; set; }
        public virtual DbSet<ataFactCXC> ataFactCXC { get; set; }
        public virtual DbSet<AtaSucu> AtaSucu { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CompaniyType> CompaniyType { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyJoin> CompanyJoin { get; set; }
        public virtual DbSet<Connections> Connections { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CPSistema> CPSistema { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<DBTHIRD> DBTHIRD { get; set; }
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<EntityPrefix> EntityPrefix { get; set; }
        public virtual DbSet<Indicador> Indicador { get; set; }
        public virtual DbSet<LogLockReg> LogLockReg { get; set; }
        public virtual DbSet<LogStation> LogStation { get; set; }
        public virtual DbSet<MasterPerspectivaIndicador> MasterPerspectivaIndicador { get; set; }
        public virtual DbSet<ModelAccount> ModelAccount { get; set; }
        public virtual DbSet<Municipality> Municipality { get; set; }
        public virtual DbSet<Perspectiva> Perspectiva { get; set; }
        public virtual DbSet<PriceIdx> PriceIdx { get; set; }
        public virtual DbSet<Rates> Rates { get; set; }
        public virtual DbSet<SAACAMPOS> SAACAMPOS { get; set; }
        public virtual DbSet<SAACXC> SAACXC { get; set; }
        public virtual DbSet<SAACXCHist> SAACXCHist { get; set; }
        public virtual DbSet<SAACXP> SAACXP { get; set; }
        public virtual DbSet<SAACXPHist> SAACXPHist { get; set; }
        public virtual DbSet<SAAGRUPOS> SAAGRUPOS { get; set; }
        public virtual DbSet<SAAOPER> SAAOPER { get; set; }
        public virtual DbSet<SAATACONF> SAATACONF { get; set; }
        public virtual DbSet<SAATACXCISLR> SAATACXCISLR { get; set; }
        public virtual DbSet<SAATACXCRET> SAATACXCRET { get; set; }
        public virtual DbSet<SAATACXCRETMAN> SAATACXCRETMAN { get; set; }
        public virtual DbSet<SAATAUSER> SAATAUSER { get; set; }
        public virtual DbSet<SACLICNV> SACLICNV { get; set; }
        public virtual DbSet<SACLIE> SACLIE { get; set; }
        public virtual DbSet<SACLIE_01> SACLIE_01 { get; set; }
        public virtual DbSet<SACLIE_02> SACLIE_02 { get; set; }
        public virtual DbSet<SACLIE_05> SACLIE_05 { get; set; }
        public virtual DbSet<SACLILOT> SACLILOT { get; set; }
        public virtual DbSet<SACLIOFE> SACLIOFE { get; set; }
        public virtual DbSet<SACLPR> SACLPR { get; set; }
        public virtual DbSet<SACMEC> SACMEC { get; set; }
        public virtual DbSet<SACOMP> SACOMP { get; set; }
        public virtual DbSet<SACOMPHist> SACOMPHist { get; set; }
        public virtual DbSet<SACONF> SACONF { get; set; }
        public virtual DbSet<SACONV> SACONV { get; set; }
        public virtual DbSet<SACVEN> SACVEN { get; set; }
        public virtual DbSet<SADEPO> SADEPO { get; set; }
        public virtual DbSet<SADEPO_01> SADEPO_01 { get; set; }
        public virtual DbSet<SAECLI> SAECLI { get; set; }
        public virtual DbSet<SAECOM> SAECOM { get; set; }
        public virtual DbSet<SAEMEC> SAEMEC { get; set; }
        public virtual DbSet<SAEOPI> SAEOPI { get; set; }
        public virtual DbSet<SAEPRD> SAEPRD { get; set; }
        public virtual DbSet<SAEPRV> SAEPRV { get; set; }
        public virtual DbSet<SAEQUI> SAEQUI { get; set; }
        public virtual DbSet<SAESRV> SAESRV { get; set; }
        public virtual DbSet<SAESTA> SAESTA { get; set; }
        public virtual DbSet<SAETAR> SAETAR { get; set; }
        public virtual DbSet<SAEVEN> SAEVEN { get; set; }
        public virtual DbSet<SAEVTA> SAEVTA { get; set; }
        public virtual DbSet<SAEXIS> SAEXIS { get; set; }
        public virtual DbSet<SAEXISCON> SAEXISCON { get; set; }
        public virtual DbSet<SAFACT> SAFACT { get; set; }
        public virtual DbSet<SAFACTHist> SAFACTHist { get; set; }
        public virtual DbSet<SAFALO> SAFALO { get; set; }
        public virtual DbSet<SAFIEL> SAFIEL { get; set; }
        public virtual DbSet<SAFLDREF> SAFLDREF { get; set; }
        public virtual DbSet<SAICLI> SAICLI { get; set; }
        public virtual DbSet<SAIMEC> SAIMEC { get; set; }
        public virtual DbSet<SAINITI> SAINITI { get; set; }
        public virtual DbSet<SAINSTA> SAINSTA { get; set; }
        public virtual DbSet<SAIPACXC> SAIPACXC { get; set; }
        public virtual DbSet<SAIPAVTA> SAIPAVTA { get; set; }
        public virtual DbSet<SAIPRD> SAIPRD { get; set; }
        public virtual DbSet<SAIPRV> SAIPRV { get; set; }
        public virtual DbSet<SAITCV> SAITCV { get; set; }
        public virtual DbSet<SAITEMCOM> SAITEMCOM { get; set; }
        public virtual DbSet<SAITEMCOMHist> SAITEMCOMHist { get; set; }
        public virtual DbSet<SAITEMFAC> SAITEMFAC { get; set; }
        public virtual DbSet<SAITEMFACHist> SAITEMFACHist { get; set; }
        public virtual DbSet<SAITEMOPI> SAITEMOPI { get; set; }
        public virtual DbSet<SAITEMPLANI> SAITEMPLANI { get; set; }
        public virtual DbSet<SAITEO> SAITEO { get; set; }
        public virtual DbSet<SAITFL> SAITFL { get; set; }
        public virtual DbSet<SAITOR> SAITOR { get; set; }
        public virtual DbSet<SAITRE> SAITRE { get; set; }
        public virtual DbSet<SAIVEN> SAIVEN { get; set; }
        public virtual DbSet<SAJOIN> SAJOIN { get; set; }
        public virtual DbSet<SALOTE> SALOTE { get; set; }
        public virtual DbSet<SAMECA> SAMECA { get; set; }
        public virtual DbSet<SAMUNICIPIO> SAMUNICIPIO { get; set; }
        public virtual DbSet<SAOFER> SAOFER { get; set; }
        public virtual DbSet<SAOPEI> SAOPEI { get; set; }
        public virtual DbSet<SAOPER> SAOPER { get; set; }
        public virtual DbSet<SAORDT> SAORDT { get; set; }
        public virtual DbSet<SAPAGCXC> SAPAGCXC { get; set; }
        public virtual DbSet<SAPAGCXCHist> SAPAGCXCHist { get; set; }
        public virtual DbSet<SAPAGCXP> SAPAGCXP { get; set; }
        public virtual DbSet<SAPAGCXPHist> SAPAGCXPHist { get; set; }
        public virtual DbSet<SAPART> SAPART { get; set; }
        public virtual DbSet<SAPLANI> SAPLANI { get; set; }
        public virtual DbSet<SAPRIM> SAPRIM { get; set; }
        public virtual DbSet<SAPRIMCOM> SAPRIMCOM { get; set; }
        public virtual DbSet<SAPROD> SAPROD { get; set; }
        public virtual DbSet<SAPROD_01> SAPROD_01 { get; set; }
        public virtual DbSet<SAPROD_02> SAPROD_02 { get; set; }
        public virtual DbSet<SAPROD_03> SAPROD_03 { get; set; }
        public virtual DbSet<SAPROV> SAPROV { get; set; }
        public virtual DbSet<SAPROV_01> SAPROV_01 { get; set; }
        public virtual DbSet<SAPROV_02> SAPROV_02 { get; set; }
        public virtual DbSet<SAPROV_03> SAPROV_03 { get; set; }
        public virtual DbSet<SAPROV_04> SAPROV_04 { get; set; }
        public virtual DbSet<SAPROV_05> SAPROV_05 { get; set; }
        public virtual DbSet<SAPRSRI> SAPRSRI { get; set; }
        public virtual DbSet<SAPTOSCLIENTE> SAPTOSCLIENTE { get; set; }
        public virtual DbSet<SAPVPR> SAPVPR { get; set; }
        public virtual DbSet<SAREPO> SAREPO { get; set; }
        public virtual DbSet<SARGOCAT> SARGOCAT { get; set; }
        public virtual DbSet<SARGORET> SARGORET { get; set; }
        public virtual DbSet<SARGOTJT> SARGOTJT { get; set; }
        public virtual DbSet<SASEPRCOM> SASEPRCOM { get; set; }
        public virtual DbSet<SASEPRFAC> SASEPRFAC { get; set; }
        public virtual DbSet<SASEPROPI> SASEPROPI { get; set; }
        public virtual DbSet<SASERI> SASERI { get; set; }
        public virtual DbSet<SASERICON> SASERICON { get; set; }
        public virtual DbSet<SASERV> SASERV { get; set; }
        public virtual DbSet<SASUCU> SASUCU { get; set; }
        public virtual DbSet<SASUCURSAL> SASUCURSAL { get; set; }
        public virtual DbSet<SATABL> SATABL { get; set; }
        public virtual DbSet<SATARJ> SATARJ { get; set; }
        public virtual DbSet<SATAXCOM> SATAXCOM { get; set; }
        public virtual DbSet<SATAXCOMHist> SATAXCOMHist { get; set; }
        public virtual DbSet<SATAXCXC> SATAXCXC { get; set; }
        public virtual DbSet<SATAXCXCHist> SATAXCXCHist { get; set; }
        public virtual DbSet<SATAXCXP> SATAXCXP { get; set; }
        public virtual DbSet<SATAXCXPHist> SATAXCXPHist { get; set; }
        public virtual DbSet<SATAXES> SATAXES { get; set; }
        public virtual DbSet<SATAXITC> SATAXITC { get; set; }
        public virtual DbSet<SATAXITCHist> SATAXITCHist { get; set; }
        public virtual DbSet<SATAXITF> SATAXITF { get; set; }
        public virtual DbSet<SATAXITFHist> SATAXITFHist { get; set; }
        public virtual DbSet<SATAXPRD> SATAXPRD { get; set; }
        public virtual DbSet<SATAXSRV> SATAXSRV { get; set; }
        public virtual DbSet<SATAXVTA> SATAXVTA { get; set; }
        public virtual DbSet<SATAXVTAHist> SATAXVTAHist { get; set; }
        public virtual DbSet<SAUSRREP> SAUSRREP { get; set; }
        public virtual DbSet<SAVEND> SAVEND { get; set; }
        public virtual DbSet<SAVEND_01> SAVEND_01 { get; set; }
        public virtual DbSet<SAVEND_02> SAVEND_02 { get; set; }
        public virtual DbSet<SAZONA> SAZONA { get; set; }
        public virtual DbSet<SAZRP> SAZRP { get; set; }
        public virtual DbSet<SBACUM> SBACUM { get; set; }
        public virtual DbSet<SBAPPD> SBAPPD { get; set; }
        public virtual DbSet<SBAPPM> SBAPPM { get; set; }
        public virtual DbSet<SBBANC> SBBANC { get; set; }
        public virtual DbSet<SBBENE> SBBENE { get; set; }
        public virtual DbSet<SBCOBA> SBCOBA { get; set; }
        public virtual DbSet<SBConc> SBConc { get; set; }
        public virtual DbSet<SBCTAP> SBCTAP { get; set; }
        public virtual DbSet<SBCTAS> SBCTAS { get; set; }
        public virtual DbSet<SBDEFPD> SBDEFPD { get; set; }
        public virtual DbSet<SBDEFPM> SBDEFPM { get; set; }
        public virtual DbSet<SBDesA> SBDesA { get; set; }
        public virtual DbSet<SBDIFE> SBDIFE { get; set; }
        public virtual DbSet<SBDOpF> SBDOpF { get; set; }
        public virtual DbSet<SBDTRN> SBDTRN { get; set; }
        public virtual DbSet<SBEsti> SBEsti { get; set; }
        public virtual DbSet<SBFDCCONS> SBFDCCONS { get; set; }
        public virtual DbSet<SBFDCPER> SBFDCPER { get; set; }
        public virtual DbSet<SBFMTS> SBFMTS { get; set; }
        public virtual DbSet<SBMONE> SBMONE { get; set; }
        public virtual DbSet<SBOPCTAS> SBOPCTAS { get; set; }
        public virtual DbSet<SBOPCXPP> SBOPCXPP { get; set; }
        public virtual DbSet<SBOpFr> SBOpFr { get; set; }
        public virtual DbSet<SBOPMSTR> SBOPMSTR { get; set; }
        public virtual DbSet<SBOPPGOS> SBOPPGOS { get; set; }
        public virtual DbSet<SBPres> SBPres { get; set; }
        public virtual DbSet<SBPrxC> SBPrxC { get; set; }
        public virtual DbSet<SBRptD> SBRptD { get; set; }
        public virtual DbSet<SBTRAN> SBTRAN { get; set; }
        public virtual DbSet<SBTrTr> SBTrTr { get; set; }
        public virtual DbSet<SCProperty> SCProperty { get; set; }
        public virtual DbSet<SFTFLD> SFTFLD { get; set; }
        public virtual DbSet<SFTITM> SFTITM { get; set; }
        public virtual DbSet<SMENTRADA> SMENTRADA { get; set; }
        public virtual DbSet<SMENVIOHDR> SMENVIOHDR { get; set; }
        public virtual DbSet<SMENVIOMOV> SMENVIOMOV { get; set; }
        public virtual DbSet<SSAUTR> SSAUTR { get; set; }
        public virtual DbSet<SSDTAA> SSDTAA { get; set; }
        public virtual DbSet<SSFLDS> SSFLDS { get; set; }
        public virtual DbSet<SSFMTS> SSFMTS { get; set; }
        public virtual DbSet<SSNIVL> SSNIVL { get; set; }
        public virtual DbSet<SSOPMN> SSOPMN { get; set; }
        public virtual DbSet<SSPARD> SSPARD { get; set; }
        public virtual DbSet<SSPARM> SSPARM { get; set; }
        public virtual DbSet<SSTRACE> SSTRACE { get; set; }
        public virtual DbSet<SSUSRS> SSUSRS { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<UserMsg> UserMsg { get; set; }
        public virtual DbSet<ATAProdPall> ATAProdPall { get; set; }
        public virtual DbSet<PreciosDom> PreciosDom { get; set; }
        public virtual DbSet<PreciosJue> PreciosJue { get; set; }
        public virtual DbSet<PreciosMier> PreciosMier { get; set; }
        public virtual DbSet<PreciosMr> PreciosMr { get; set; }
        public virtual DbSet<PreciosSab> PreciosSab { get; set; }
        public virtual DbSet<PreciosVier> PreciosVier { get; set; }
        public virtual DbSet<SAACXC2> SAACXC2 { get; set; }
        public virtual DbSet<SAANULAC> SAANULAC { get; set; }
        public virtual DbSet<SAATAVERS> SAATAVERS { get; set; }
        public virtual DbSet<SAAUTORIZ> SAAUTORIZ { get; set; }
        public virtual DbSet<SACFAC> SACFAC { get; set; }
        public virtual DbSet<SACIUDAD> SACIUDAD { get; set; }
        public virtual DbSet<SACODBAR> SACODBAR { get; set; }
        public virtual DbSet<SACOMP2> SACOMP2 { get; set; }
        public virtual DbSet<SACONPRECIO> SACONPRECIO { get; set; }
        public virtual DbSet<SACORRELSIS> SACORRELSIS { get; set; }
        public virtual DbSet<SACORTEZ> SACORTEZ { get; set; }
        public virtual DbSet<SAESTADO> SAESTADO { get; set; }
        public virtual DbSet<SAEX> SAEX { get; set; }
        public virtual DbSet<SAFACT2> SAFACT2 { get; set; }
        public virtual DbSet<SAITEMCOM2> SAITEMCOM2 { get; set; }
        public virtual DbSet<SAITEMFAC2> SAITEMFAC2 { get; set; }
        public virtual DbSet<SAPAIS> SAPAIS { get; set; }
        public virtual DbSet<SAPRNGIROS> SAPRNGIROS { get; set; }
        public virtual DbSet<SATAXCOM2> SATAXCOM2 { get; set; }
        public virtual DbSet<SATAXITC2> SATAXITC2 { get; set; }
        public virtual DbSet<SATAXITF2> SATAXITF2 { get; set; }
        public virtual DbSet<SATAXVTA2> SATAXVTA2 { get; set; }
        public virtual DbSet<SATMPCHQ> SATMPCHQ { get; set; }
        public virtual DbSet<SATRADEDOCS> SATRADEDOCS { get; set; }
        public virtual DbSet<SBCONF> SBCONF { get; set; }
        public virtual DbSet<SRCCP> SRCCP { get; set; }
        public virtual DbSet<STIB01> STIB01 { get; set; }
        public virtual DbSet<STIB02> STIB02 { get; set; }
        public virtual DbSet<SXAuditProd> SXAuditProd { get; set; }
        public virtual DbSet<TMP_CXP_PC_STIB01> TMP_CXP_PC_STIB01 { get; set; }
        public virtual DbSet<TMP_CXP_STIB01> TMP_CXP_STIB01 { get; set; }
        public virtual DbSet<TMP_GERENCIA_STIB01> TMP_GERENCIA_STIB01 { get; set; }
        public virtual DbSet<TMP_KARLA_PC_STIB01> TMP_KARLA_PC_STIB01 { get; set; }
        public virtual DbSet<TMP_SIETEMASI5_PC_STIB01> TMP_SIETEMASI5_PC_STIB01 { get; set; }
        public virtual DbSet<TMP_TRANRESPROD> TMP_TRANRESPROD { get; set; }
        public virtual DbSet<X1ADMINISTACION4_STIB01> X1ADMINISTACION4_STIB01 { get; set; }
        public virtual DbSet<X1ADMINISTRACION_STIB01> X1ADMINISTRACION_STIB01 { get; set; }
        public virtual DbSet<X1ADMINISTRACION1_STIB01> X1ADMINISTRACION1_STIB01 { get; set; }
        public virtual DbSet<X1ADMINISTRACION2_STIB01> X1ADMINISTRACION2_STIB01 { get; set; }
        public virtual DbSet<X1ADMINISTRACION3_STIB01> X1ADMINISTRACION3_STIB01 { get; set; }
        public virtual DbSet<X1ENCARGADO1_STIB01> X1ENCARGADO1_STIB01 { get; set; }
        public virtual DbSet<X1SISTEMA2_STIB01> X1SISTEMA2_STIB01 { get; set; }
        public virtual DbSet<X1SISTEMAS2_STIB01> X1SISTEMAS2_STIB01 { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
    }
}
