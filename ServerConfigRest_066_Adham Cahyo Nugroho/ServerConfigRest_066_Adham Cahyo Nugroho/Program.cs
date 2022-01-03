using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceRest_20190140066_AdhamCahyoNugroho;

namespace ServerConfigRest_066_Adham_Cahyo_Nugroho
{
    static void Main(string[] args)
    {
        ServiceHost hostObjek = null;
        try
        {
            hostObjek = new ServiceHost(typeof(TI_UMY));
            hostObjek.Open();
            Console.WriteLine("HHHH");
            Console.ReadLine();
            hostObjek.Close();
        }
        catch (Exception ex)
        {
            hostObjek = null;
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
    }

    internal class TI_UMY
    {
    }

    internal class ServiceHost
    {
        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}