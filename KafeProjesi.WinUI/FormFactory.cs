using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeProjesi.WinUI
{
    public class FormFactory
    {
        private static IServiceProvider serviceProvider;

        public static void SetServiceProvider(IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
        }


        public static frmLogin CreatefrmLogin()
        {
            return serviceProvider.GetRequiredService<frmLogin>();



        }

    }
}
