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

        public const int NOTIFICATION_STATUS_TYPE_PASSIVE = 1;
        public const int NOTIFICATION_STATUS_TYPE_WAITING_APPROVE = 2;
        public const int NOTIFICATION_STATUS_TYPE_APPROVED = 3;
        public const int NOTIFICATION_STATUS_TYPE_ERROR = 4;

        public static string getNotificationStatusString(long status)
        {
            switch (status)
            {
                case Constants.NOTIFICATION_STATUS_TYPE_PASSIVE:
                    return "Pasif";

                case Constants.NOTIFICATION_STATUS_TYPE_WAITING_APPROVE:
                    return "Onay Bekliyor";

                case Constants.NOTIFICATION_STATUS_TYPE_APPROVED:
                    return "Onaylandı";

                case Constants.NOTIFICATION_STATUS_TYPE_ERROR:
                    return "Hata Oluştu";
            }
            return "-";
        }

        public const int NOTIFICATION_TYPE_COMPAIGN = 1;

        public static string getNotificationTypeString(long status)
        {
            switch (status)
            {
                case Constants.NOTIFICATION_TYPE_COMPAIGN:
                    return "Kampanya";

            }
            return "-";
        }

        public const int COUNTRY_TURKEY = 1;
        public const int COUNTRY_USA = 2;
        public const int COUNTRY_GERMANY = 3;

        public static string getCountryString(long status)
        {
            switch (status)
            {
                case Constants.COUNTRY_TURKEY:
                    return "Türkiye";

                case Constants.COUNTRY_USA:
                    return "Amerika";

                case Constants.COUNTRY_GERMANY:
                    return "Almanya";

            }
            return "-";
        }

        public const int CAMPAIGN_TYPE_PERSONAL = 1;
        public const int CAMPAIGN_TYPE_COMMERICAL = 2;

        public static string getCampaignTypeString(long status)
        {
            switch (status)
            {
                case Constants.CAMPAIGN_TYPE_PERSONAL:
                    return "Bireysel";

                case Constants.CAMPAIGN_TYPE_COMMERICAL:
                    return "Ticari";
            }
            return "-";
        }

        public static string[] monthNames = { "ocak", "şubat", "mart", "nisan", "mayıs", "haziran", "temmuz", "ağustos", "eylül", "ekim", "kasım", "aralık" };

        public const int FILE_TYPE_IMAGE = 1;
        public const int FILE_TYPE_VIDEO = 2;
        public static string getFileTypeString(long fileType)
        {
            switch (fileType)
            {
                case Constants.FILE_TYPE_IMAGE:
                    return "Resim";

                case Constants.FILE_TYPE_VIDEO:
                    return "Video";
            }
            return "-";
        }

        public const string ApiUrlAddress = "https://api.bildirmatik.com/";
    }
}
