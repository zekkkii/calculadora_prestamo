using System;
using System.Collections.Generic;
using System.Text;

namespace app_tasa_prestamo.comboBoxItems
{
    class ComboBoxitem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;

        }

    }
}