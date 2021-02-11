using System;

namespace Bildirim.Common
{
    public class Constants
    {
        public const int USER_STATUS_ACTIVE = 1;
        public const int USER_STATUS_DELETED = 2;
        public const int USER_STATUS_BLACKLIST = 3;
        public const int USER_STATUS_WAITING_ACTIVATION = 4;
        public static string getUserStatusString(long status)
        {
            switch (status)
            {
                case Constants.USER_STATUS_ACTIVE:
                    return "Aktif";

                case Constants.USER_STATUS_DELETED:
                    return "Silinmiş";

                case Constants.USER_STATUS_BLACKLIST:
                    return "Kara Listede";

                case Constants.USER_STATUS_WAITING_ACTIVATION:
                    return "Aktivasyon Bekliyor";
            }
            return "-";
        }

        public const int USER_ROLE_ADMIN = 1;
        public const int USER_ROLE_NORMALUSER = 2;
        public static string getUserRoleString(long role)
        {
            switch (role)
            {
                case Constants.USER_ROLE_ADMIN:
                    return "Yönetici";

                case Constants.USER_ROLE_NORMALUSER:
                    return "Üye";
            }
            return "-";
        }

        public const int USER_LOGIN_NORMAL = 1;
        public const int USER_LOGIN_GOOGLE = 2;
        public const int USER_LOGIN_FACEBOOK = 3;
        public static string getUserLoginString(long status)
        {
            switch (status)
            {
                case Constants.USER_LOGIN_NORMAL:
                    return "Normal";

                case Constants.USER_LOGIN_GOOGLE:
                    return "Google";

                case Constants.USER_LOGIN_FACEBOOK:
                    return "Facebook";
            }
            return "-";
        }

        public const int COMPANY_GARANTI_BANKASI = 1;
        public const int COMPANY_IS_BANKASI = 2;
        public const int COMPANY_MEDIA_MARKT = 3;
        public static string getCompanyString(long status)
        {
            switch (status)
            {
                case Constants.COMPANY_GARANTI_BANKASI:
                    return "Garanti Bankası";

                case Constants.COMPANY_IS_BANKASI:
                    return "İş Bankası";

                case Constants.COMPANY_MEDIA_MARKT:
                    return "Media Markt";
            }
            return "-";
        }

        public const int NOTIFICATION_STATUS_TYPE_DELETED = 1;
        public const int NOTIFICATION_STATUS_TYPE_WAITING_APPROVE = 2;
        public const int NOTIFICATION_STATUS_TYPE_APPROVED = 3;

        public static string getNotificationStatusString(long status)
        {
            switch (status)
            {
                case Constants.NOTIFICATION_STATUS_TYPE_DELETED:
                    return "Silinmiş";

                case Constants.NOTIFICATION_STATUS_TYPE_WAITING_APPROVE:
                    return "Onay Bekliyor";

                case Constants.NOTIFICATION_STATUS_TYPE_APPROVED:
                    return "Onaylandı";
            }
            return "-";
        }

        public const int NOTIFICATION_TYPE_COMPAIGN_PERSONAL = 2;
        public const int NOTIFICATION_TYPE_COMPAIGN_COMMERCIAL = 3;

        public static string getNotificationTypeString(long status)
        {
            switch (status)
            {
                case Constants.NOTIFICATION_TYPE_COMPAIGN_PERSONAL:
                    return "Kampanya/Bireysel";

                case Constants.NOTIFICATION_TYPE_COMPAIGN_COMMERCIAL:
                    return "Kampanya/Ticari";
            }
            return "-";
        }

        public static string[] monthNames = { "ocak", "şubat", "mart", "nisan", "mayıs", "haziran", "temmuz", "ağustos", "eylül", "ekim", "kasım", "aralık" };

    }
}
