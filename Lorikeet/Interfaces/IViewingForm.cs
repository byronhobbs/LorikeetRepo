using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lorikeet.Interfaces
{
    interface IViewingForm
    {
        void CloseForm();

        bool SaveForm();
    }
}
