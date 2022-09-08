using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string Added = "Eklendi";
        public static string Deleted = "Silindi";
        public static string Updated = "Güncellendi";
        public static string CarAddedError = "Araba en az 2 karakter olmalı ve günlük fiyat 0'dan fazla olmalıdır.";
        public static string MaintenanceTime= "Sistem Bakımda";
        public static string Failed = "Araba teslim edilmemiş";
    }
}
