using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum OpenBankruptcy
    {
        None = 0,
        [EnumMember(Value = "7")]
        n7 = 7,
        [EnumMember(Value = "11")]
        n11 = 11,
        [EnumMember(Value = "13")]
        n13 = 13
    }
}