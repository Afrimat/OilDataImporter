using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilDataImporter.Models
{
    public class OilWatch
    {
        public string REPSTRUCTURE { get; set; }
        public string SITE_NAME { get; set; }
        public string EQUIPMENT_NAME { get; set; }
        public string EQUIPMENT_MAKEMODEL { get; set; }
        public string EQUIP_ALTID { get; set; }
        public string COMPONENT_NAME { get; set; }
        public string COMPONENT_MAKEMODEL { get; set; }
        public int? SAMPLE_NUMBER { get; set; }
        public string SEVERITY { get; set; }
        public string FLUIDMAKE { get; set; }
        public int? SMR { get; set; }
        public string JOBNO { get; set; }
        public DateTime? RECEIVEDON { get; set; }
        public DateTime? SAMPLEDON { get; set; }
        public string PFIU { get; set; }
        public int? CONSUMPTION { get; set; }
        public string FLUIDDRAINED { get; set; }
        public string FILTERCHANGED { get; set; }
        public int? AG { get; set; }
        public int? AL { get; set; }
        public int? B { get; set; }
        public int? BA { get; set; }
        public int? BE { get; set; }
        public int? CA { get; set; }
        public double? CA_GLYCOL { get; set; }
        public double? CA_MOLYBDATE { get; set; }
        public double? CA_TDS { get; set; }
        public int? CR { get; set; }
        public int? CU { get; set; }
        public int? DENSITY { get; set; }
        public double? F_DIESEL { get; set; }
        public int? F_SOOT { get; set; }
        public int? FDFLASH { get; set; }
        public int? FE { get; set; }
        public int? FLASHPOINT { get; set; }
        public double? FS_BACTERIA { get; set; }
        public double? FS_DENSITY { get; set; }
        public int? FS_DIS10 { get; set; }
        public int? FS_DIS20 { get; set; }
        public int? FS_DIS30 { get; set; }
        public int? FS_DIS40 { get; set; }
        public int? FS_DIS50 { get; set; }
        public int? FS_DIS60 { get; set; }
        public int? FS_DIS70 { get; set; }
        public int? FS_DIS80 { get; set; }
        public int? FS_DIS90 { get; set; }
        public int? FS_FBP { get; set; }
        public int? FS_FE { get; set; }
        public int? FS_FLASHPT { get; set; }
        public int? FS_IBP { get; set; }
        public int? FS_IPCONTAMINATION { get; set; }
        public double? FTIR_H2OLUBE { get; set; }
        public double? FUEL { get; set; }
        public string H2O { get; set; }
        public int? ISO14CODE { get; set; }
        public int? ISO4CODE { get; set; }
        public int? ISO515RATIO { get; set; }
        public int? ISO6CODE { get; set; }
        public double? K { get; set; }
        public double? KF { get; set; }
        public double? LI { get; set; }
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
        public double? PH { get; set; }
        public int? PQINDEX { get; set; }
        public int? S { get; set; }
        public int? SI { get; set; }
        public int? SN { get; set; }
        public double? SOOT_PERCENTAGE { get; set; }
        public double? TAN { get; set; }
        public double? TBN { get; set; }
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
        public double? V100 { get; set; }
        public double? V40 { get; set; }
        public int? ZN { get; set; }
        public string DIAGNOSIS { get; set; }
        public string FEEDBACK { get; set; }
        public string EQUIPMENT_MAKEMODELDESC { get; set; }
        public string COMPONENT_NAMEDESC { get; set; }
        public string COMPONENT_MAKEMODELDESC { get; set; }
        public string FLUIDMAKEDESC { get; set; }
        public string REPSTRUCTUREDESCRIPTION { get; set; }
        public string EQUIPMENT_INACTIVEMARK { get; set; }
        public string FEEDBACKREQUESTED { get; set; }
        public string HASREPEATPROBLEM { get; set; }
        public int? PROBLEMCATEGORIES { get; set; }
        public string COMPONENT_TESTCLASS { get; set; }
        public string REPORTGROUP { get; set; }
        public DateTime? COMPLETEONON { get; set; }
        public double? PVI { get; set; }
        public int? SOOT_PPM { get; set; }
        public int? BOTTLE_NO { get; set; }
        public int? FLUID_HRS { get; set; }
    }
    public class OilWatchClassMap : ClassMap<OilWatch>
    {
        public OilWatchClassMap()
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
            Map(m => m.CA_GLYCOL).Name("CA_GLYCOL");
            Map(m => m.CA_MOLYBDATE).Name("CA_MOLYBDATE");
            Map(m => m.CA_TDS).Name("CA_TDS");
            Map(m => m.CR).Name("CR");
            Map(m => m.CU).Name("CU");
            Map(m => m.DENSITY).Name("DENSITY");
            Map(m => m.F_DIESEL).Name("F_DIESEL");
            Map(m => m.F_SOOT).Name("F_SOOT");
            Map(m => m.FDFLASH).Name("FDFLASH");
            Map(m => m.FE).Name("FE");
            Map(m => m.FLASHPOINT).Name("FLASHPOINT");
            Map(m => m.FS_BACTERIA).Name("FS_BACTERIA");
            Map(m => m.FS_DENSITY).Name("FS_DENSITY");
            Map(m => m.FS_DIS10).Name("FS_DIS10");
            Map(m => m.FS_DIS20).Name("FS_DIS20");
            Map(m => m.FS_DIS30).Name("FS_DIS30");
            Map(m => m.FS_DIS40).Name("FS_DIS40");
            Map(m => m.FS_DIS50).Name("FS_DIS50");
            Map(m => m.FS_DIS60).Name("FS_DIS60");
            Map(m => m.FS_DIS70).Name("FS_DIS70");
            Map(m => m.FS_DIS80).Name("FS_DIS80");
            Map(m => m.FS_DIS90).Name("FS_DIS90");
            Map(m => m.FS_FBP).Name("FS_FBP");
            Map(m => m.FS_FE).Name("FS_FE");
            Map(m => m.FS_FLASHPT).Name("FS_FLASHPT");
            Map(m => m.FS_IBP).Name("FS_IBP");
            Map(m => m.FS_IPCONTAMINATION).Name("FS_IPCONTAMINATION");
            Map(m => m.FTIR_H2OLUBE).Name("FTIR_H2OLUBE");
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
            Map(m => m.PQINDEX).Name("PQINDEX");
            Map(m => m.S).Name("S");
            Map(m => m.SI).Name("SI");
            Map(m => m.SN).Name("SN");
            Map(m => m.SOOT_PERCENTAGE).Name("SOOT_PERCENTAGE");
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
            Map(m => m.ZN).Name("ZN");
            Map(m => m.DIAGNOSIS).Name("DIAGNOSIS");
            Map(m => m.FEEDBACK).Name("FEEDBACK");
            Map(m => m.EQUIPMENT_MAKEMODELDESC).Name("EQUIPMENT_MAKEMODELDESC");
            Map(m => m.COMPONENT_NAMEDESC).Name("COMPONENT_NAMEDESC");
            Map(m => m.COMPONENT_MAKEMODELDESC).Name("COMPONENT_MAKEMODELDESC");
            Map(m => m.FLUIDMAKEDESC).Name("FLUIDMAKEDESC");
            Map(m => m.REPSTRUCTUREDESCRIPTION).Name("REPSTRUCTUREDESCRIPTION");
            Map(m => m.EQUIPMENT_INACTIVEMARK).Name("EQUIPMENT_INACTIVEMARK");
            Map(m => m.FEEDBACKREQUESTED).Name("FEEDBACKREQUESTED");
            Map(m => m.HASREPEATPROBLEM).Name("HASREPEATPROBLEM");
            Map(m => m.PROBLEMCATEGORIES).Name("PROBLEMCATEGORIES");
            Map(m => m.COMPONENT_TESTCLASS).Name("COMPONENT_TESTCLASS");
            Map(m => m.REPORTGROUP).Name("REPORTGROUP");
            Map(m => m.COMPLETEONON).Name("COMPLETEONON");
            Map(m => m.PVI).Name("PVI");
            Map(m => m.SOOT_PPM).Name("SOOT_PPM");
            Map(m => m.BOTTLE_NO).Name("BOTTLE_NO");
            Map(m => m.FLUID_HRS).Name("FLUID_HRS");
        }
    }

}
