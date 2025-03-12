using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryChecker_v2
{
    public class battery
    {
        public string responses_battery;
        public battery() 
        {
           
        }
        public void events()
        {
            switch (SystemInformation.PowerStatus.PowerLineStatus)
            {
                case PowerLineStatus.Offline:
                    this.responses_battery = "Desconectado";
                    break;
                case PowerLineStatus.Online:
                    this.responses_battery = "Conectado";
                    break;
                case PowerLineStatus.Unknown:
                    this.responses_battery = "Desconocido";
                    break;
                default:
                    this.responses_battery = "Error";
                    break;
            }
        }
    }
}