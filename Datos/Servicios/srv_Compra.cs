using Datos.Entidades;
using Datos.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Servicios
{

    public class srv_Compra
    {
        public List<Vista_DetalleCompra> FiltroCompras(Hashtable datos)
        {
            using (var db = new PROYECTOVUELO03Entities())
            {
                try
                {
                    string query = "select bol.Id_Boleto,NombreUsuario=(us.Nombre+ ' ' +us.Apellido_pat+' ' + us.Apellido_mat),ao.Nombre AS Origen,ad.Nombre AS Destino,com.Fecha_compra,asi.numero,asi.letra,asi.posicion,asi.precio from Detalle_Compra dc " +
                        "inner join Compra com on dc.Id_Compra = com.Id_Compra " +
                        "inner join Estatus est on com.Id_pago = est.Id_pago " +
                        "inner join Usuario us on com.Id_Usuario = us.Id_Usuario " +
                        "inner join Boleto bol on dc.Id_Boleto = bol.Id_Boleto " +
                        "inner join Asiento asi on bol.Id_Asiento = asi.Id_Asiento " +
                        "inner join Vuelos vu on bol.Id_Vuelo = vu.Id_Vuelo " +
                        "inner join Ruta r on vu.Id_Ruta = r.Id_Ruta " +
                        "inner join Aeropuerto ao on r.Origen_Aeropuerto = ao.Id_Aeropuerto " +
                        "inner join Aeropuerto ad on r.Destino_Aeropuerto = ad.Id_Aeropuerto ";

                    string whereis = " and ";
                    if (datos.Contains("Id_Usuario"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + "";
                        whereis = whereis + " us.Id_Usuario = " + datos["Id_Usuario"].ToString();
                    }

                    if (whereis.Length > 0)
                        query += " WHERE est.Id_pago = 1" + whereis.ToString();
                    IEnumerable<Vista_DetalleCompra> r = db.Database.SqlQuery<Vista_DetalleCompra>(query);
                    return r.ToList();
                }
                catch (Exception)
                {
                    throw new Exception("Verifica los datos a buscar");
                }
            }
        }
        public List<Vista_DetalleCompra> FiltroReservaciones(Hashtable datos)
        {
            using (var db = new PROYECTOVUELO03Entities())
            {
                try
                {
                    string query = "select bol.Id_Boleto,NombreUsuario=(us.Nombre+ ' ' +us.Apellido_pat+' ' + us.Apellido_mat),ao.Nombre AS Origen,ad.Nombre AS Destino,com.Fecha_compra,asi.numero,asi.letra,asi.posicion,asi.precio from Detalle_Compra dc " +
                        "inner join Compra com on dc.Id_Compra = com.Id_Compra " +
                        "inner join Estatus est on com.Id_pago = est.Id_pago " +
                        "inner join Usuario us on com.Id_Usuario = us.Id_Usuario " +
                        "inner join Boleto bol on dc.Id_Boleto = bol.Id_Boleto " +
                        "inner join Asiento asi on bol.Id_Asiento = asi.Id_Asiento " +
                        "inner join Vuelos vu on bol.Id_Vuelo = vu.Id_Vuelo " +
                        "inner join Ruta r on vu.Id_Ruta = r.Id_Ruta " +
                        "inner join Aeropuerto ao on r.Origen_Aeropuerto = ao.Id_Aeropuerto " +
                        "inner join Aeropuerto ad on r.Destino_Aeropuerto = ad.Id_Aeropuerto ";                       

                    string whereis = " and ";                   
                    if (datos.Contains("Id_Usuario"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + "";
                        whereis = whereis + " us.Id_Usuario = " + datos["Id_Usuario"].ToString();
                    }
                    
                    if (whereis.Length > 0)
                        query += " WHERE est.Id_pago = 2" + whereis.ToString();
                    IEnumerable<Vista_DetalleCompra> r = db.Database.SqlQuery<Vista_DetalleCompra>(query);
                    return r.ToList();
                }
                catch (Exception)
                {
                    throw new Exception("Verifica los datos a buscar");
                }
            }
        }
        public int AgregarCompra(Compra item)
        {
            try
            {
                int id = 0;
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Compra.Add(item);
                    db.SaveChanges();
                    id = item.Id_Compra;
                }
                return id;
            }
            catch (Exception e)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        
        public void EliminarCompra(Compra item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Compra obj = db.Compra.Where(x => x.Id_Compra == item.Id_Compra).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Compra.Remove(obj);
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
