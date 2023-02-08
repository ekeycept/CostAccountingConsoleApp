using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main()
        {
            float thisCost;
            float overallCost = 0;
            bool repeat = true;
            float productCost = 0, internetCost = 0, clothesCost = 0, giftCost = 0, transportCost = 0;
            string[] costList = new string[6];
            StreamReader sr = new("CostAccounting.txt");
            for (int i = 0; i < costList.Length; i++)
            {
                costList[i] = sr.ReadLine();
            }

            if (costList[5] != null)
            {
                sr.Close();
                productCost =float.Parse(costList[0]);
                internetCost =float.Parse(costList[1]);
                clothesCost =float.Parse(costList[2]);
                giftCost =float.Parse(costList[3]);
                transportCost =float.Parse(costList[4]);
                overallCost =float.Parse(costList[5]);
            }


            Console.WriteLine("******* Подсчёт расходов *******");
            sr.Close();
            while (repeat == true)
            {

            Console.WriteLine("Для добавления выберите категорию расходов:");
            Console.WriteLine("Продукты / Интернет / Одежда / Подарки / Транспорт");
            string CostCatеgory = Console.ReadLine();

            switch (CostCatеgory)
            {
                case "Продукты":
                    Console.WriteLine("Вы выбрали 'Продукты'. Какая сумма была потрачена?");
                    thisCost = float.Parse(Console.ReadLine());
                    productCost += thisCost;
                    overallCost += thisCost;
                    break; ;
                case "Интернет":
                    Console.WriteLine("Вы выбрали 'Интернет'. Какая сумма была потрачена?");
                    thisCost = float.Parse(Console.ReadLine());
                    internetCost += thisCost;
                    overallCost +=  thisCost;
                    break;
                case "Одежда":
                    Console.WriteLine("Вы выбрали 'Одежду'. Какая сумма была потрачена?");
                    thisCost = float.Parse(Console.ReadLine());
                    clothesCost += thisCost;
                    overallCost += thisCost;
                    break;
                case "Подарки":
                    Console.WriteLine("Вы выбрали 'Подарки'. Какая сумма была потрачена?");
                    thisCost = float.Parse(Console.ReadLine());
                    giftCost += thisCost;
                    overallCost += thisCost;
                    break;
                case "Транспорт":
                    Console.WriteLine("Вы выбрали 'Транспорт'. Какая сумма была потрачена?");
                    thisCost = float.Parse(Console.ReadLine());
                    transportCost += thisCost;
                    overallCost += thisCost;
                    break;
                default:
                    Console.Error.WriteLine("Такой категории нет. Повторите ввод");
                    break;
            }
            Console.WriteLine("Были ли ещё расходы? Да / Нет");
            string answer = Console.ReadLine();
            if (answer == "Да")
                repeat = true;
            else
                repeat = false;
            }
            Console.Clear();
            Console.WriteLine("Расчёт расходов закончен");
            Console.WriteLine("Траты на продуткы: {0}", productCost);
            Console.WriteLine("Траты на интернет: {0}", internetCost);
            Console.WriteLine("Траты на одежду: {0}", clothesCost);
            Console.WriteLine("Траты на подарки: {0}", giftCost);
            Console.WriteLine("Траты на транспорт: {0}", transportCost);
            Console.WriteLine("Общая сумма трат: {0}", overallCost);

            StreamWriter sw = new("C:\\Users\\gorbo\\Desktop\\CostAccounting.txt", false, ASCIIEncoding.ASCII);
            sw.WriteLine(productCost);
            sw.WriteLine(internetCost);
            sw.WriteLine(clothesCost);
            sw.WriteLine(giftCost);
            sw.WriteLine(transportCost);
            sw.WriteLine(overallCost);
            sw.Close();

        }

    }
}