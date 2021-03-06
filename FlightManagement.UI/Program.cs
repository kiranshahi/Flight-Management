﻿using FlightManagement.BLL;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var customerService = kernel.Get<ICustomerService>();
            var planeService = kernel.Get<IPlaneService>();
            var cargoService = kernel.Get<ICargoService>();
            var planeBookService = kernel.Get<IPlaneBookService>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(planeBookService, planeService, cargoService, customerService));
        }
    }
}
