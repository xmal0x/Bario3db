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

        private static string[] AddToAutoList(Dictionary<int, Bottle> dict, List<string> lst, string textBoxName)
        {
            //создаем список для автозамен, значения берем из словаря, выбираем по полю textBoxName
            if (textBoxName == "name")
            {
                //добавляем название
                foreach (int k in dict.Keys)
                {
                    if (lst.Contains(dict[k].name))
                        break;
                    lst.Add(dict[k].name);
                }

            }
            if (textBoxName == "type")
            {
                //добавляем тип позиции
                foreach (int k in dict.Keys)
                {
                    if (lst.Contains(dict[k].type))
                        break;
                    lst.Add(dict[k].type);
                }

            }

            return lst.ToArray();
        }

        public static void IniAuto(Dictionary<int, Bottle> dict, TextBox tbox, string textBoxName)
        {
            //инициализация автоКомплита, значения считываются из словаря, по полю textBoxName
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(AddToAutoList(dict, lstAuto, textBoxName));
            tbox.AutoCompleteCustomSource = source;
            tbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

    }
}
