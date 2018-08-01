using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Servicios
{
    public class srv_DetalleCompra
    {
        public void AgregarDetalleCompra(Detalle_Compra item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Detalle_Compra.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
 
        public void EliminarDetalleCompra(Detalle_Compra item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Detalle_Compra obj = db.Detalle_Compra.Where(x => x.IdDetalleCompra == item.IdDetalleCompra).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Detalle_Compra.Remove(obj);
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
