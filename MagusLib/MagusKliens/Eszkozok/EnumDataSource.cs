using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagusKliens.Eszkozok
{
    public static class EnumDataSource
    {
        public static void SetDataSource<TEnum>(ComboBox box) //where TEnum : Type
        {

            /*
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (int item in Enum.GetValues(typeof(TEnum)))
            {
                dictionary.Add(Enum.GetName(typeof(TEnum), item), item);
            }

            box.DisplayMember = "Key";
            box.ValueMember = "Value";
            box.DataSource = new BindingSource(dictionary, null);
            */
            box.DataSource = Enum.GetValues(typeof(TEnum));
        }
    }
}
