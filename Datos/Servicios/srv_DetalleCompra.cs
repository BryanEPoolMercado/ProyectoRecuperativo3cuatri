using Datos.Entidades;
using Datos.Modelo;
using System;
using System.Collections;
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
        public List<Vista_DetalleCompra> MostrarTicket(Hashtable datos)
        {
            using (var db = new PROYECTOVUELO03Entities())
            {
                try
                {
                    string query = "select bol.Id_Boleto, NombrePasajero as NombreUsuario,ao.Nombre as Origen,ad.Nombre as Destino,Fecha_compra,letra,numero,posicion,precio,estado from Detalle_Compra dc " +
                                   "inner join Boleto bol on dc.Id_Boleto = bol.Id_Boleto " +
                                   "inner join Vuelos vue on bol.Id_Vuelo = vue.Id_Vuelo " +
                                   "inner join Ruta rut on vue.Id_Ruta = rut.Id_Ruta " +
                                   "inner join Aeropuerto ao on rut.Origen_Aeropuerto = ao.Id_Aeropuerto " +
                                   "inner join Aeropuerto ad on rut.Destino_Aeropuerto = ad.Id_Aeropuerto " +
                                   "inner join Asiento asi on bol.Id_Asiento = asi.Id_Asiento " +
                                   "inner join Compra com on dc.Id_Compra = com.Id_Compra ";

                    string whereis = "";
                    if (datos.Contains("Id_Compra"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + "";
                        whereis = whereis + " dc.Id_Compra= " + datos["Id_Compra"].ToString();
                    }

                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();
                    IEnumerable<Vista_DetalleCompra> r = db.Database.SqlQuery<Vista_DetalleCompra>(query);
                    return r.ToList();
                }
                catch (Exception)
                {
                    throw new Exception("Verifica los datos a buscar");
                }
            }
        }
    }
}
