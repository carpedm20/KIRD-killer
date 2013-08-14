using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace KIRD_Killer
{
    class AutoLogin
    {
        public AutoLogin()
        {

        }

        public bool ReadRegistry(ref string id, ref string pw)
        {
            RegistryKey reg = Registry.LocalMachine.CreateSubKey("SoftWare").CreateSubKey("mozo_killer_carpedm20");
            id = reg.GetValue("ID", "").ToString();
            pw = reg.GetValue("PW", "").ToString();
            if (id == "" || id == "" && pw == "")
                return false;
            return true;
        }

        public void WriteRegistry(string id, string pw)
        {
            RegistryKey reg = Registry.LocalMachine.CreateSubKey("SoftWare").CreateSubKey("mozo_killer_carpedm20");
            reg.SetValue("ID", id);
            reg.SetValue("PW", pw);
        }
    }
}
