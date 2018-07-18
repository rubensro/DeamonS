﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DeamonService
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static void Main(string[] args)
        {
            ServiceBase[] ServicesToRun = new ServiceBase[] { new DeamonService(args) };
            ServiceBase.Run(ServicesToRun);

            /* ServiceBase[] ServicesToRun;
             ServicesToRun = new ServiceBase[]
             {
                 new DeamonService()
             };
             ServiceBase.Run(ServicesToRun);*/
        }
    }
}
