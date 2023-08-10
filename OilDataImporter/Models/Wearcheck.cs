using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilDataImporter.Models
{
    public class Wearcheck
    {
        public string REPSTRUCTURE { get; set; }
        public string SITE_NAME { get; set; }
        public string EQUIPMENT_NAME { get; set; }
        public string EQUIPMENT_MAKEMODEL { get; set; }
        public string EQUIP_ALTID { get; set; }
        public string COMPONENT_NAME { get; set; }
        public string COMPONENT_MAKEMODEL { get; set; }
        public string SAMPLE_NUMBER { get; set; }
        public string SEVERITY { get; set; }
        public string FLUIDMAKE { get; set; }
        public int? SMR { get; set; }
        public string JOBNO { get; set; }
        public DateTime? RECEIVEDON { get; set; }
        public DateTime? SAMPLEDON { get; set; }
        public int? PFIU { get; set; }
        public int? CONSUMPTION { get; set; }
        public string FLUIDDRAINED { get; set; }
        public string FILTERCHANGED { get; set; }
        public int? AG { get; set; }
        public int? AL { get; set; }
        public int? B { get; set; }
        public int? BA { get; set; }
        public int? BE { get; set; }
        public int? CA { get; set; }
        public string CA_APPEARANCE { get; set; }
        public string CA_BOIL { get; set; }
        public string CA_COLOUR { get; set; }
        public string CA_COLOURINT { get; set; }
        public string CA_FOAM { get; set; }
        public string CA_FREEZE { get; set; }
        public string CA_GLYCOL { get; set; }
        public string CA_MOLYBDATE { get; set; }
        public string CA_NO2 { get; set; }
        public string CA_ODOUR { get; set; }
        public string CA_OIL { get; set; }
        public string CA_PPT { get; set; }
        public string CA_SEDAPPEAR { get; set; }
        public string CA_SEDCOLOUR { get; set; }
        public string CA_SEDMAGN { get; set; }
        public string CA_TDS { get; set; }
        public int? CD { get; set; }
        public int? CO { get; set; }
        public int? CR { get; set; }
        public string CRACKLE { get; set; }
        public int? CU { get; set; }
        public string DENSITY { get; set; }
        public string FANTIWEAR { get; set; }
        public int? FDIESEL { get; set; }
        public int? FGLY { get; set; }
        public int? FH2O { get; set; }
        public int? FNOX { get; set; }
        public int? FOPTIMETHGLY { get; set; }
        public int? FOXID { get; set; }
        public int? FSO4 { get; set; }
        public int? FSOOT { get; set; }
        public double? FTBN { get; set; }
        public string FAAGWET { get; set; }
        public string FAALWET { get; set; }
        public string FAAS43 { get; set; }
        public string FAAS93 { get; set; }
        public string FABLACK_OXIDE { get; set; }
        public string FACWET { get; set; }
        public string FACDIRT { get; set; }
        public string FACHUNKY_BEARING { get; set; }
        public string FACHUNKY_GEAR { get; set; }
        public string FACUWET { get; set; }
        public string FACUPRIC { get; set; }
        public string FADILUTION { get; set; }
        public string FAFIBRE { get; set; }
        public string FAGRIT { get; set; }
        public string FALAMINAR { get; set; }
        public string FAM50 { get; set; }
        public string FAMASS { get; set; }
        public string FAMGWET { get; set; }
        public string FAOTH { get; set; }
        public string FAPBWET { get; set; }
        public string FAPCS { get; set; }
        public string FAPHS { get; set; }
        public string FAPOLYMER { get; set; }
        public string FAPQ_OIL { get; set; }
        public string FAPQ_PAD { get; set; }
        public string FAPQ_RPD { get; set; }
        public string FARED_OXIDE { get; set; }
        public string FARUST { get; set; }
        public string FASEAL { get; set; }
        public string FASS { get; set; }
        public string FASS3 { get; set; }
        public string FASS4 { get; set; }
        public string FAWM { get; set; }
        public string FDFLASH { get; set; }
        public int FE { get; set; }
        public string FLASHPOINT { get; set; }
        public string FSAL { get; set; }
        public string FSAPPEARANCE { get; set; }
        public string FSBACTCONT { get; set; }
        public string FSBACTERIA { get; set; }
        public string FSCOLOR { get; set; }
        public string FSCONTAMINATION { get; set; }
        public string FSDENSITY { get; set; }
        public string FSDIS10 { get; set; }
        public string FSDIS20 { get; set; }
        public string FSDIS30 { get; set; }
        public string FSDIS40 { get; set; }
        public string FSDIS50 { get; set; }
        public string FSDIS60 { get; set; }
        public string FSDIS70 { get; set; }
        public string FSDIS80 { get; set; }
        public string FSDIS90 { get; set; }
        public string FSFBP { get; set; }
        public string FSFE { get; set; }
        public string FSFLASHPT { get; set; }
        public string FSIBP { get; set; }
        public string FSIPCONTAMINATION { get; set; }
        public string FSLUBRICITY { get; set; }
        public string FSMG { get; set; }
        public string FSMICROFUNGI { get; set; }
        public string FSMN { get; set; }
        public string FSNA { get; set; }
        public string FSPB { get; set; }
        public string FSSI { get; set; }
        public string FSSMOKE { get; set; }
        public string FSSULPHUR { get; set; }
        public string FSTAN { get; set; }
        public string FSV { get; set; }
        public string FSVIS { get; set; }
        public string FSWATER { get; set; }
        public string FSZN { get; set; }
        public string FTIRH2OLUBE { get; set; }
        public string FTIRJP8DIESEL { get; set; }
        public string FTIRTANREP { get; set; }
        public string FTIRTBNREP { get; set; }
        public int? FUEL { get; set; }
        public string H2O { get; set; }
        public int? ISO14CODE { get; set; }
        public int? ISO4CODE { get; set; }
        public string ISO515RATIO { get; set; }
        public int? ISO6CODE { get; set; }
        public int? K { get; set; }
        public string KF { get; set; }
        public int? LI { get; set; }
        public int? MG { get; set; }
        public int? MN { get; set; }
        public int? MO { get; set; }
        public int? MPE { get; set; }
        public int? MPEC { get; set; }
        public int? MPECLR { get; set; }
        public int? NA { get; set; }
        public int? NI { get; set; }
        public int? P { get; set; }
        public int? PB { get; set; }
        public string PH { get; set; }
        public string POTTAN { get; set; }
        public int? PQINDEX { get; set; }
        public string RPDCHUNK { get; set; }
        public string RPDCUT { get; set; }
        public string RPDNF { get; set; }
        public string RPDOX { get; set; }
        public string RPDPOLY { get; set; }
        public string RPDRUB { get; set; }
        public string RPDSLIDE { get; set; }
        public string RPDSPH { get; set; }
        public int? S { get; set; }
        public int? SB { get; set; }
        public int? SI { get; set; }
        public int? SN { get; set; }
        public string SOOTPERCENTAGE { get; set; }
        public string TAN { get; set; }
        public string TBN { get; set; }
        public int? TI { get; set; }
        public int? U100 { get; set; }
        public int? U14 { get; set; }
        public int? U20 { get; set; }
        public int? U25 { get; set; }
        public int? U4 { get; set; }
        public int? U50 { get; set; }
        public int? U6 { get; set; }
        public int? U75 { get; set; }
        public int? V { get; set; }
        public string V100 { get; set; }
        public double V40 { get; set; }
        public int? VI { get; set; }
        public string VISO { get; set; }
        public int? ZN { get; set; }
        public int? ZR { get; set; }
        public string DIAGNOSIS { get; set; }
        public string FEEDBACK { get; set; }
        public string EQUIPMENT_MAKEMODELDESC { get; set; }
        public string COMPONENT_NAMEDESC { get; set; }
        public string COMPONENT_MAKEMODELDESC { get; set; }
        public string FLUIDMAKEDESC { get; set; }
        public string REPSTRUCTUREDESCRIPTION { get; set; }
        public int EQUIPMENT_INACTIVEMARK { get; set; }
        public string FEEDBACKREQUESTED { get; set; }
        public string HASFEEDBACK { get; set; }
        public string HASREPEATPROBLEM { get; set; }
        public string PROBLEMCATEGORIES { get; set; }
        public int? RRI { get; set; }
        public string RULER_TOT { get; set; }
        public string RULER_PHENOL { get; set; }
        public string RULER_AMINE { get; set; }
        public string FOAMING { get; set; }
        public string H2OSEP { get; set; }
        public string AIRREL { get; set; }
        public string VPR { get; set; }
        public string RPVOT { get; set; }
        public string COLOUR { get; set; }
        public string CLARITY { get; set; }
        public string DGAH2 { get; set; }
        public string DGAO2 { get; set; }
        public string DGAN2 { get; set; }
        public string DGACH4 { get; set; }
        public string DGACO { get; set; }
        public string DGACO2 { get; set; }
        public string DGAC2H2 { get; set; }
        public string DGAC2H4 { get; set; }
        public string DGAC2H6 { get; set; }
        public string DGAPERCGAS { get; set; }
        public string DGACO2_CO_RATIO { get; set; }
        public string DGATCG { get; set; }
        public string TSFURANICS { get; set; }
        public string TSKVACTUAL { get; set; }
        public string TSPCBTOT { get; set; }
        public string TSTANDELTA { get; set; }
        public string FSBIODIESEL { get; set; }
        public string FSCETANEINDEX { get; set; }
        public string FSDENSITY15 { get; set; }
        public string FSDENSITY20 { get; set; }
        public string FSFREEH2O { get; set; }
        public string FSRESIDUE { get; set; }
        public string FSRECOVERY { get; set; }
        public string COMPONENT_TESTCLASS { get; set; }
        public string REPORTGROUP { get; set; }
        public string TSCORROS { get; set; }
        public string TSIFT { get; set; }
        public string TBND2896 { get; set; }
        public int? FBKDELTADAYS { get; set; }
        public int? BI { get; set; }
        public string FUELTYPE { get; set; }
        public string I_PH { get; set; }
        public DateTime? COMPLETEDON { get; set; }
        public string PVI { get; set; }
        public int? SOOTPPM { get; set; }
        public string CUSTOMER_COMMENTS { get; set; }
        public string EQUIPMENT_SERIALNUMBER { get; set; }
        public string COMPONENT_ALTID { get; set; }
        public string COMPONENT_SERIALNUMBER { get; set; }
    }
    public class WearcheckClassMap : ClassMap<Wearcheck>
    {
        public WearcheckClassMap()
        {
            Map(m => m.REPSTRUCTURE).Name("REPSTRUCTURE");
            Map(m => m.SITE_NAME).Name("SITE_NAME");
            Map(m => m.EQUIPMENT_NAME).Name("EQUIPMENT_NAME");
            Map(m => m.EQUIPMENT_MAKEMODEL).Name("EQUIPMENT_MAKEMODEL");
            Map(m => m.EQUIP_ALTID).Name("EQUIP_ALTID");
            Map(m => m.COMPONENT_NAME).Name("COMPONENT_NAME");
            Map(m => m.COMPONENT_MAKEMODEL).Name("COMPONENT_MAKEMODEL");
            Map(m => m.SAMPLE_NUMBER).Name("SAMPLE_NUMBER");
            Map(m => m.SEVERITY).Name("SEVERITY");
            Map(m => m.FLUIDMAKE).Name("FLUIDMAKE");
            Map(m => m.SMR).Name("SMR");
            Map(m => m.JOBNO).Name("JOBNO");
            Map(m => m.RECEIVEDON).Name("RECEIVEDON");
            Map(m => m.SAMPLEDON).Name("SAMPLEDON");
            Map(m => m.PFIU).Name("PFIU");
            Map(m => m.CONSUMPTION).Name("CONSUMPTION");
            Map(m => m.FLUIDDRAINED).Name("FLUIDDRAINED");
            Map(m => m.FILTERCHANGED).Name("FILTERCHANGED");
            Map(m => m.AG).Name("AG");
            Map(m => m.AL).Name("AL");
            Map(m => m.B).Name("B");
            Map(m => m.BA).Name("BA");
            Map(m => m.BE).Name("BE");
            Map(m => m.CA).Name("CA");
            Map(m => m.CA_APPEARANCE).Name("CA_APPEARANCE");
            Map(m => m.CA_BOIL).Name("CA_BOIL");
            Map(m => m.CA_COLOUR).Name("CA_COLOUR");
            Map(m => m.CA_COLOURINT).Name("CA_COLOURINT");
            Map(m => m.CA_FOAM).Name("CA_FOAM");
            Map(m => m.CA_FREEZE).Name("CA_FREEZE");
            Map(m => m.CA_GLYCOL).Name("CA_GLYCOL");
            Map(m => m.CA_MOLYBDATE).Name("CA_MOLYBDATE");
            Map(m => m.CA_NO2).Name("CA_NO2");
            Map(m => m.CA_ODOUR).Name("CA_ODOUR");
            Map(m => m.CA_OIL).Name("CA_OIL");
            Map(m => m.CA_PPT).Name("CA_PPT");
            Map(m => m.CA_SEDAPPEAR).Name("CA_SEDAPPEAR");
            Map(m => m.CA_SEDCOLOUR).Name("CA_SEDCOLOUR");
            Map(m => m.CA_SEDMAGN).Name("CA_SEDMAGN");
            Map(m => m.CA_TDS).Name("CA_TDS");
            Map(m => m.CD).Name("CD");
            Map(m => m.CO).Name("CO");
            Map(m => m.CR).Name("CR");
            Map(m => m.CRACKLE).Name("CRACKLE");
            Map(m => m.CU).Name("CU");
            Map(m => m.DENSITY).Name("DENSITY");
            Map(m => m.FANTIWEAR).Name("F.ANTIWEAR");
            Map(m => m.FDIESEL).Name("F.DIESEL");
            Map(m => m.FGLY).Name("F.GLY");
            Map(m => m.FH2O).Name("F.H2O");
            Map(m => m.FNOX).Name("F.NOX");
            Map(m => m.FOPTIMETHGLY).Name("F.OPTIMETHGLY");
            Map(m => m.FOXID).Name("F.OXID");
            Map(m => m.FSO4).Name("F.SO4");
            Map(m => m.FSOOT).Name("F.SOOT");
            Map(m => m.FTBN).Name("F.TBN");
            Map(m => m.FAAGWET).Name("FA.AG.WET");
            Map(m => m.FAALWET).Name("FA.AL.WET");
            Map(m => m.FAAS43).Name("FA.AS43");
            Map(m => m.FAAS93).Name("FA.AS93");
            Map(m => m.FABLACK_OXIDE).Name("FA.BLACK_OXIDE");
            Map(m => m.FACWET).Name("FA.C.WET");
            Map(m => m.FACDIRT).Name("FA.CDIRT");
            Map(m => m.FACHUNKY_BEARING).Name("FA.CHUNKY_BEARING");
            Map(m => m.FACHUNKY_GEAR).Name("FA.CHUNKY_GEAR");
            Map(m => m.FACUWET).Name("FA.CU.WET");
            Map(m => m.FACUPRIC).Name("FA.CUPRIC");
            Map(m => m.FADILUTION).Name("FA.DILUTION");
            Map(m => m.FAFIBRE).Name("FA.FIBRE");
            Map(m => m.FAGRIT).Name("FA.GRIT");
            Map(m => m.FALAMINAR).Name("FA.LAMINAR");
            Map(m => m.FAM50).Name("FA.M50");
            Map(m => m.FAMASS).Name("FA.MASS");
            Map(m => m.FAMGWET).Name("FA.MG.WET");
            Map(m => m.FAOTH).Name("FA.OTH");
            Map(m => m.FAPBWET).Name("FA.PB.WET");
            Map(m => m.FAPCS).Name("FA.PCS");
            Map(m => m.FAPHS).Name("FA.PHS");
            Map(m => m.FAPOLYMER).Name("FA.POLYMER");
            Map(m => m.FAPQ_OIL).Name("FA.PQ_OIL");
            Map(m => m.FAPQ_PAD).Name("FA.PQ_PAD");
            Map(m => m.FAPQ_RPD).Name("FA.PQ_RPD");
            Map(m => m.FARED_OXIDE).Name("FA.RED_OXIDE");
            Map(m => m.FARUST).Name("FA.RUST");
            Map(m => m.FASEAL).Name("FA.SEAL");
            Map(m => m.FASS).Name("FA.SS");
            Map(m => m.FASS3).Name("FA.SS3");
            Map(m => m.FASS4).Name("FA.SS4");
            Map(m => m.FAWM).Name("FA.WM");
            Map(m => m.FDFLASH).Name("FDFLASH");
            Map(m => m.FE).Name("FE");
            Map(m => m.FLASHPOINT).Name("FLASHPOINT");
            Map(m => m.FSAL).Name("FS.AL");
            Map(m => m.FSAPPEARANCE).Name("FS.APPEARANCE");
            Map(m => m.FSBACTCONT).Name("FS.BACTCONT");
            Map(m => m.FSBACTERIA).Name("FS.BACTERIA");
            Map(m => m.FSCOLOR).Name("FS.COLOR");
            Map(m => m.FSCONTAMINATION).Name("FS.CONTAMINATION");
            Map(m => m.FSDENSITY).Name("FS.DENSITY");
            Map(m => m.FSDIS10).Name("FS.DIS10");
            Map(m => m.FSDIS20).Name("FS.DIS20");
            Map(m => m.FSDIS30).Name("FS.DIS30");
            Map(m => m.FSDIS40).Name("FS.DIS40");
            Map(m => m.FSDIS50).Name("FS.DIS50");
            Map(m => m.FSDIS60).Name("FS.DIS60");
            Map(m => m.FSDIS70).Name("FS.DIS70");
            Map(m => m.FSDIS80).Name("FS.DIS80");
            Map(m => m.FSDIS90).Name("FS.DIS90");
            Map(m => m.FSFBP).Name("FS.FBP");
            Map(m => m.FSFE).Name("FS.FE");
            Map(m => m.FSFLASHPT).Name("FS.FLASHPT");
            Map(m => m.FSIBP).Name("FS.IBP");
            Map(m => m.FSIPCONTAMINATION).Name("FS.IPCONTAMINATION");
            Map(m => m.FSLUBRICITY).Name("FS.LUBRICITY");
            Map(m => m.FSMG).Name("FS.MG");
            Map(m => m.FSMICROFUNGI).Name("FS.MICRO.FUNGI");
            Map(m => m.FSMN).Name("FS.MN");
            Map(m => m.FSNA).Name("FS.NA");
            Map(m => m.FSPB).Name("FS.PB");
            Map(m => m.FSSI).Name("FS.SI");
            Map(m => m.FSSMOKE).Name("FS.SMOKE");
            Map(m => m.FSSULPHUR).Name("FS.SULPHUR");
            Map(m => m.FSTAN).Name("FS.TAN");
            Map(m => m.FSV).Name("FS.V");
            Map(m => m.FSVIS).Name("FS.VIS");
            Map(m => m.FSWATER).Name("FS.WATER");
            Map(m => m.FSZN).Name("FS.ZN");
            Map(m => m.FTIRH2OLUBE).Name("FTIR.H2OLUBE");
            Map(m => m.FTIRJP8DIESEL).Name("FTIR.JP8DIESEL");
            Map(m => m.FTIRTANREP).Name("FTIR.TANREP");
            Map(m => m.FTIRTBNREP).Name("FTIR.TBNREP");
            Map(m => m.FUEL).Name("FUEL");
            Map(m => m.H2O).Name("H2O");
            Map(m => m.ISO14CODE).Name("ISO14CODE");
            Map(m => m.ISO4CODE).Name("ISO4CODE");
            Map(m => m.ISO515RATIO).Name("ISO515RATIO");
            Map(m => m.ISO6CODE).Name("ISO6CODE");
            Map(m => m.K).Name("K");
            Map(m => m.KF).Name("KF");
            Map(m => m.LI).Name("LI");
            Map(m => m.MG).Name("MG");
            Map(m => m.MN).Name("MN");
            Map(m => m.MO).Name("MO");
            Map(m => m.MPE).Name("MPE");
            Map(m => m.MPEC).Name("MPEC");
            Map(m => m.MPECLR).Name("MPECLR");
            Map(m => m.NA).Name("NA");
            Map(m => m.NI).Name("NI");
            Map(m => m.P).Name("P");
            Map(m => m.PB).Name("PB");
            Map(m => m.PH).Name("PH");
            Map(m => m.POTTAN).Name("POTTAN");
            Map(m => m.PQINDEX).Name("PQINDEX");
            Map(m => m.RPDCHUNK).Name("RPD.CHUNK");
            Map(m => m.RPDCUT).Name("RPD.CUT");
            Map(m => m.RPDNF).Name("RPD.NF");
            Map(m => m.RPDOX).Name("RPD.OX");
            Map(m => m.RPDPOLY).Name("RPD.POLY");
            Map(m => m.RPDRUB).Name("RPD.RUB");
            Map(m => m.RPDSLIDE).Name("RPD.SLIDE");
            Map(m => m.RPDSPH).Name("RPD.SPH");
            Map(m => m.S).Name("S");
            Map(m => m.SB).Name("SB");
            Map(m => m.SI).Name("SI");
            Map(m => m.SN).Name("SN");
            Map(m => m.SOOTPERCENTAGE).Name("SOOT.PERCENTAGE");
            Map(m => m.TAN).Name("TAN");
            Map(m => m.TBN).Name("TBN");
            Map(m => m.TI).Name("TI");
            Map(m => m.U100).Name("U100");
            Map(m => m.U14).Name("U14");
            Map(m => m.U20).Name("U20");
            Map(m => m.U25).Name("U25");
            Map(m => m.U4).Name("U4");
            Map(m => m.U50).Name("U50");
            Map(m => m.U6).Name("U6");
            Map(m => m.U75).Name("U75");
            Map(m => m.V).Name("V");
            Map(m => m.V100).Name("V100");
            Map(m => m.V40).Name("V40");
            Map(m => m.VI).Name("VI");
            Map(m => m.VISO).Name("VISO");
            Map(m => m.ZN).Name("ZN");
            Map(m => m.ZR).Name("ZR");
            Map(m => m.DIAGNOSIS).Name("DIAGNOSIS");
            Map(m => m.FEEDBACK).Name("FEEDBACK");
            Map(m => m.EQUIPMENT_MAKEMODELDESC).Name("EQUIPMENT_MAKEMODELDESC");
            Map(m => m.COMPONENT_NAMEDESC).Name("COMPONENT_NAMEDESC");
            Map(m => m.COMPONENT_MAKEMODELDESC).Name("COMPONENT_MAKEMODELDESC");
            Map(m => m.FLUIDMAKEDESC).Name("FLUIDMAKEDESC");
            Map(m => m.REPSTRUCTUREDESCRIPTION).Name("REPSTRUCTUREDESCRIPTION");
            Map(m => m.EQUIPMENT_INACTIVEMARK).Name("EQUIPMENT_INACTIVEMARK");
            Map(m => m.FEEDBACKREQUESTED).Name("FEEDBACKREQUESTED");
            Map(m => m.HASFEEDBACK).Name("HASFEEDBACK");
            Map(m => m.HASREPEATPROBLEM).Name("HASREPEATPROBLEM");
            Map(m => m.PROBLEMCATEGORIES).Name("PROBLEMCATEGORIES");
            Map(m => m.RRI).Name("RRI");
            Map(m => m.RULER_TOT).Name("RULER_TOT");
            Map(m => m.RULER_PHENOL).Name("RULER_PHENOL");
            Map(m => m.RULER_AMINE).Name("RULER_AMINE");
            Map(m => m.FOAMING).Name("FOAMING");
            Map(m => m.H2OSEP).Name("H2OSEP");
            Map(m => m.AIRREL).Name("AIRREL");
            Map(m => m.VPR).Name("VPR");
            Map(m => m.RPVOT).Name("RPVOT");
            Map(m => m.COLOUR).Name("COLOUR");
            Map(m => m.CLARITY).Name("CLARITY");
            Map(m => m.DGAH2).Name("DGA.H2");
            Map(m => m.DGAO2).Name("DGA.O2");
            Map(m => m.DGAN2).Name("DGA.N2");
            Map(m => m.DGACH4).Name("DGA.CH4");
            Map(m => m.DGACO).Name("DGA.CO");
            Map(m => m.DGACO2).Name("DGA.CO2");
            Map(m => m.DGAC2H2).Name("DGA.C2H2");
            Map(m => m.DGAC2H4).Name("DGA.C2H4");
            Map(m => m.DGAC2H6).Name("DGA.C2H6");
            Map(m => m.DGAPERCGAS).Name("DGA.PERCGAS");
            Map(m => m.DGACO2_CO_RATIO).Name("DGA.CO2_CO_RATIO");
            Map(m => m.DGATCG).Name("DGA.TCG");
            Map(m => m.TSFURANICS).Name("TS.FURANICS");
            Map(m => m.TSKVACTUAL).Name("TS.KV.ACTUAL");
            Map(m => m.TSPCBTOT).Name("TS.PCB.TOT");
            Map(m => m.TSTANDELTA).Name("TS.TANDELTA");
            Map(m => m.FSBIODIESEL).Name("FS.BIODIESEL");
            Map(m => m.FSCETANEINDEX).Name("FS.CETANEINDEX");
            Map(m => m.FSDENSITY15).Name("FS.DENSITY15");
            Map(m => m.FSDENSITY20).Name("FS.DENSITY20");
            Map(m => m.FSFREEH2O).Name("FS.FREEH2O");
            Map(m => m.FSRESIDUE).Name("FS.RESIDUE");
            Map(m => m.FSRECOVERY).Name("FS.RECOVERY");
            Map(m => m.COMPONENT_TESTCLASS).Name("COMPONENT_TESTCLASS");
            Map(m => m.REPORTGROUP).Name("REPORTGROUP");
            Map(m => m.TSCORROS).Name("TS.CORRO.S");
            Map(m => m.TSIFT).Name("TS.IFT");
            Map(m => m.TBND2896).Name("TBN(D2896)");
            Map(m => m.FBKDELTADAYS).Name("FBKDELTADAYS");
            Map(m => m.BI).Name("BI");
            Map(m => m.FUELTYPE).Name("FUELTYPE");
            Map(m => m.I_PH).Name("I-PH");
            Map(m => m.COMPLETEDON).Name("COMPLETEDON");
            Map(m => m.PVI).Name("PVI");
            Map(m => m.SOOTPPM).Name("SOOT.PPM");
            Map(m => m.CUSTOMER_COMMENTS).Name("CUSTOMER_COMMENTS");
            Map(m => m.EQUIPMENT_SERIALNUMBER).Name("EQUIPMENT_SERIALNUMBER").Optional();
            Map(m => m.COMPONENT_ALTID).Name("COMPONENT_ALTID").Optional();
            Map(m => m.COMPONENT_SERIALNUMBER).Name("COMPONENT_SERIALNUMBER").Optional();
        }
    }
}
