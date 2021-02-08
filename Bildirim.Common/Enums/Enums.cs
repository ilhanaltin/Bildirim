using System.ComponentModel;
namespace Bildirim.Common.Enums
{
    public enum USER_STATUS_TYPE
    {
        [Description("Aktif")]
        Active = 1,
        [Description("Silinmiş")]
        Deleted = 2,
        [Description("Kara Listede")]
        Blocked = 3,
        [Description("AKtivasyon Bekliyor")]
        Waiting_Activation = 3
    }
}
