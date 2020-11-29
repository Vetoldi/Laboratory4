using System;
using System.Collections.Generic;
using System.Text;

namespace Part4
{
    class ApplicationLicense
    {
        private const string proCutted = "KLT7-12Rt";
        private const string proKey = "Rts-18KP";
        private string userInput;
        private string userStatus = "undefined";
        public void AllowTrial()
        {
            Console.WriteLine($"Ваш статус {userStatus}");
            if (userStatus == "undefined" || userStatus == "common")
            {
                Console.WriteLine("Введите ключ для Триального режима");
                userInput = Console.ReadLine();
                if (userInput == proCutted)
                {
                    userStatus = "cutted";
                    Console.WriteLine($"Ваш статус {userStatus}");
                    Console.WriteLine("Триальный режим");
                }
            }
        }

        public void AllowCommon()
        {
            Console.WriteLine($"Ваш статус {userStatus}");
            if (userStatus == "undefined")
            {
                userStatus = "common";
                Console.WriteLine($"Теперь ваш статус {userStatus}");
                Console.WriteLine("Бесплатная версия");
            }

        }

        public void AllowPro()
        {
            Console.WriteLine($"Ваш статус {userStatus}");
            if (userStatus == "trial" || userStatus == "common" || userStatus == "undefined")
            {
                Console.WriteLine("Введите ключ для Про режима");
                userInput = Console.ReadLine();
                if (userInput == proKey)
                {
                    userStatus = "pro";
                    Console.WriteLine($"Ваш статус {userStatus}");
                    Console.WriteLine("Платная версия");
                }
            }
        }
    }


}