using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Control
{
    class Setting
    {
        public const int ADMIN = 0;
        public const int STAFF = 1;
        public const int CUSTOMER = 2;

        public const int ENGLISH = 0;
        public const int VIETNAMESE = 1;

        public static int Authority;
        public static int Language;
    }
}
