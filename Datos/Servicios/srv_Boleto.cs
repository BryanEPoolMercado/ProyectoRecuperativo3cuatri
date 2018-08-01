using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Servicios
{
    public class srv_Boleto
    {        
        public int AgregarBoleto(Boleto item)
        {
            try
            {
                int id = 0;
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Boleto.Add(item);
                    db.SaveChanges();
                    id = item.Id_Boleto;
                }
                return id;
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }        
        public void EliminarBoleto(Boleto item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Boleto obj = db.Boleto.Where(x => x.Id_Boleto == item.Id_Boleto).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Boleto.Remove(obj);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a eliminar");
            }
        }
    }
}
