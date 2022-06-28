using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1_MongoDB_With_On_WinForms
{
    public static class FiltersOnDataGrid
    {
        public static void Filter(this DataGridView dataGrid, int prop, string value, Func<string, string, bool> pred)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                //CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGrid.DataSource];
                dataGrid.CurrentCell = null;
                dataGrid.Rows[i].Visible = pred(dataGrid[prop, i].Value?.ToString(), value);

            }
        }

        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> en, Func<T, bool> pred)
        {
            foreach (var item in en)
            {
                if (pred(item))
                {
                    yield return item;
                }
            }
        }
    }
}
