using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bario3
{
    internal class mathBario
    {
        internal static float Calculate(Bottle bottle, int weightScan)
        {
            float result = (bottle.capacityFull * (weightScan - bottle.weightEmpty)) / (bottle.weightFull - bottle.weightEmpty);
            return result;
        }

        internal static float FullPriceCalculate(Bottle bottle)
        {
            //Считаем стоимость остатка в бутылке
            float fullPrice = (bottle.capacityNow / bottle.portion) * bottle.price;
            return fullPrice;
            
        }

        internal static int CalculateMoneyForDay(DateTime date, Dictionary<DateTime, Bottle> dict)
        {
            //расчет стоимости всех позиций за определенную дату date
            int fullMoneyDate = 0;

            try
            {
                foreach(DateTime k in dict.Keys)
                {
                    if (k.Date == date.Date)
                    {
                        fullMoneyDate += (int)FullPriceCalculate(dict[k]);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка, возможно нет подключения к БД\n" + ex.Message);
            }

            return fullMoneyDate;

        } 
    }
}