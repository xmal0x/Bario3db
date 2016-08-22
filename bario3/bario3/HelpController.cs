using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bario3
{
    class HelpController
    {
        //Список для автозамен
        static List<string> lstAuto = new List<string>();

        private static string[] AddToAutoList(string[] dataArray, List<string> lst)
        { 
            //создаем список для автозамен, получаем массив значений и выбираем только уникальные
            foreach (string k in dataArray)
            {
                    
                if (lst.Contains(k.Trim()))
                    break;
                lst.Add(k.Trim());
            }

            return lst.ToArray();
        }

        public static void IniAuto(string[] dataArray, TextBox tbox)
        {
            //инициализация автоКомплита, значения считываются из массива, полученого из БД
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(AddToAutoList(dataArray, lstAuto));
            tbox.AutoCompleteCustomSource = source;
            tbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

    }
}
