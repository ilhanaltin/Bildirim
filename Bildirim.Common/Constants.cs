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
    }
}
