using System;

class ReadNumberToText
{
    static void Main(string[] args)
    {
        // Bước 1: Hỏi số cần đọc
        Console.Write("Nhập số cần đọc: ");
        int number = int.Parse(Console.ReadLine());

        // Xử lý số có một chữ số
        if (number >= 0 && number <= 9)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("Số không");
                    break;
                case 1:
                    Console.WriteLine("Số một");
                    break;
                case 2:
                    Console.WriteLine("Số hai");
                    break;
                case 3:
                    Console.WriteLine("Số ba");
                    break;
                case 4:
                    Console.WriteLine("Số bốn");
                    break;
                case 5:
                    Console.WriteLine("Số năm");
                    break;
                case 6:
                    Console.WriteLine("Số sáu");
                    break;
                case 7:
                    Console.WriteLine("Số bảy");
                    break;
                case 8:
                    Console.WriteLine("Số tám");
                    break;
                case 9:
                    Console.WriteLine("Số chín");
                    break;
            }
        }


        // Xử lý số có hai chữ số
        else if (number >= 10 && number < 100)
        {
            int tens = number / 10;
            int ones = number % 10;

            // Đọc phần số hàng chục
            switch (tens)
            {
                case 2:
                    Console.Write("hai mươi ");
                    break;
                case 3:
                    Console.Write("ba mươi ");
                    break;
                case 4:
                    Console.Write("bốn mươi ");
                    break;
                case 5:
                    Console.Write("năm mươi ");
                    break;
                case 6:
                    Console.Write("sáu mươi ");
                    break;
                case 7:
                    Console.Write("bảy mươi ");
                    break;
                case 8:
                    Console.Write("tám mươi ");
                    break;
                case 9:
                    Console.Write("chín mươi ");
                    break;

                default:
                    Console.Write(GetTensName(tens) + " ");
                    break;
            }

            // Đọc phần số hàng đơn vị
            switch (ones)
            {
                case 0:
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine("một");
                    break;
                case 2:
                    Console.WriteLine("hai");
                    break;
                case 3:
                    Console.WriteLine("ba");
                    break;
                case 4:
                    Console.WriteLine(" bốn");
                    break;
                case 5:
                    Console.WriteLine("năm");
                    break;
                case 6:
                    Console.WriteLine("sáu");
                    break;
                case 7:
                    Console.WriteLine("bảy");
                    break;
                case 8:
                    Console.WriteLine("tám");
                    break;
                case 9:
                    Console.WriteLine("chín");
                    break;
                default:
                    Console.WriteLine(GetOnesName(ones));
                    break;
            }
        }
        else if (number >= 100 && number < 1000)
        {
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int ones = number % 10;

            // Đọc phần số hàng trăm
            switch (hundreds)
            {
                case 1:
                    Console.Write("một trăm ");
                    break;
                case 2:
                    Console.Write("hai trăm ");
                    break;
                case 3:
                    Console.Write("ba trăm ");
                    break;
                case 4:
                    Console.Write("bốn trăm ");
                    break;
                case 5:
                    Console.Write("năm trăm ");
                    break;
                case 6:
                    Console.Write("sáu trăm ");
                    break;
                case 7:
                    Console.Write("bảy trăm ");
                    break;
                case 8:
                    Console.Write("tám trăm ");
                    break;
                case 9:
                    Console.Write("chín trăm ");
                    break;
                default:
                    Console.Write(GetHundredsName(hundreds) + " ");
                    break;
            }

            // Đọc phần số hàng chục và hàng đơn vị (tương tự như phần xử lý số có hai chữ số)
            if (tens > 0)
            {
                Console.Write(GetTensName(tens) + " ");
            }

            Console.WriteLine(GetOnesName(ones));
        }
        else
        {
            Console.WriteLine("Số vượt quá khả năng đọc");
        }

        // Hàm hỗ trợ đọc tên hàng trăm
        static string GetHundredsName(int hundreds)
        {
            switch (hundreds)
            {
                case 1:
                    return "một";
                case 2:
                    return "hai";
                case 3:
                    return "ba";
                case 4:
                    return "bốn";
                case 5:
                    return "năm";
                case 6:
                    return "sáu";
                case 7:
                    return "bảy";
                case 8:
                    return "tám";
                case 9:
                    return "chín";
                default:
                    return "";
            }
        }


        static string GetTensName(int tens)
        {
            switch (tens)
            {
                case 1:
                    return "mười";
                case 2:
                    return "hai mươi";
                case 3:
                    return "ba mươi";
                case 4:
                    return "bốn mươi";
                case 5:
                    return "năm mươi";
                case 6:
                    return "sáu mươi";
                case 7:
                    return "bảy mươi";
                case 8:
                    return "tám mươi";
                case 9:
                    return "chín mươi";
                default:
                    return "";
            }
        }

        static string GetOnesName(int ones)
        {
            switch (ones)
            {
                case 1:
                    return "lẻ mốt";
                case 2:
                    return "lẻ hai";
                case 3:
                    return "lẻ ba";
                case 4:
                    return "lẻ bốn";
                case 5:
                    return "lẻ năm";
                case 6:
                    return "lẻ sáu";
                case 7:
                    return "lẻ bảy";
                case 8:
                    return "lẻ tám";
                case 9:
                    return "lẻ chín";
                default:
                    return ones.ToString();
            }
        }
    }
}
