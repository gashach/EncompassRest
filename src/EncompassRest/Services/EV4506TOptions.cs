using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public sealed class EV4506TOptions : ServiceOptions
    {
        public EV4506TOptions()
        {
            Resources = new List<EV4506TResources>();
        }
        public bool DigiCert { get; set; }
        public string RequestType { get; set; }
        public string RequestOption { get; set; }
        public string TaxReturnFor { get; set; }
        public string BorrowerMonthlyIncome { get; set; }
        public string CoBorrowerMonthlyIncome { get; set; }
        public string CalculateIncomeVariance { get; set; } //make Enum
        public string CalculateIncomeVariancePercentage { get; set; } //make enum ? 
        public string ComparisonMethod { get; set; } //mae enum
        public string AdditionalEmailId { get; set; }
        public string EinNumber { get; set; }
        public string CorporationName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Product_1040 { get; set; } //enum
        public string TranscriptType_1040 { get; set; } //enum
        public string Product_1065 { get; set; } //enum
        public string TranscriptType_1065 { get; set; }//enum
        public string Product_1120 { get; set; } //enum
        public string TranscriptType_1120 { get; set; }//enum
        public string Product_W2 { get; set; } //enum
        public string Product_1099 { get; set; } //enum
        public string TranscriptYear { get; set; }
        public List<EV4506TResources> Resources { get; set; }
    }
}
