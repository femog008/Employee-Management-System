﻿using EMS.WinForm.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.WinForm.Views.Interfaces
{
    public interface IShiftView
    {
        ShiftPresenter Presenter { set; }
    }
}