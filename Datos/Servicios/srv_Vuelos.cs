using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Vuelos
    {
        private PROYECTOVUELO03Entities modeloavion;
        public List<Vista_Vuelos> MostrarVuelos()
        {
            modeloavion = new PROYECTOVUELO03Entities();
            var selectavion = (from vue in modeloavion.Vuelos
                               join avi in modeloavion.Avion on vue.Id_Avion equals avi.Id_Avion
                               join mod in modeloavion.Modelo on avi.IdModelo equals mod.IdModelo
                               join rut in modeloavion.Ruta on vue.Id_Ruta equals rut.Id_Ruta

                               select new Vista_Vuelos
                               {
                                   Id_Vuelo = vue.Id_Vuelo,
                                   Hora_Inicio = vue.Hora_Inicio,
                                   Hora_Fin=vue.Hora_Fin, 
                                   Fecha=vue.Fecha,
                                   NombreModelo = mod.NombreModelo,
                                   Id_Ruta = rut.Id_Ruta,
                               }).ToList();
            return selectavion;
        }
        public List<Vista_Vuelos> FilterFly(Hashtable datos)
        {
            using (var db = new PROYECTOVUELO03Entities())
            {
                try
                {
                    string query = "select v.Id_Vuelo,Id_Ruta,ao.Nombre AS Origen,ad.Nombre AS Destino,v.Hora_Inicio,v.Hora_Fin,v.Fecha,mod.NombreModelo from Vuelos v " +
                        "inner join Ruta r on v.Id_Ruta = r.Id_Ruta " +
                        "inner join Aeropuerto ao on r.Origen_Aeropuerto = ao.Id_Aeropuerto " +
                        "inner join Aeropuerto ad on r.Destino_Aeropuerto = ad.Id_Aeropuerto " +
                        "inner join Avion av on v.Id_Avion = av.Id_Avion " +
                        "inner join Modelo mod on av.IdModelo = mod.IdModelo";                      

                    string whereis = "";
                    if (datos.Contains("Id_Ruta"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + "";
                        whereis = whereis + " r.Origen_Aeropuerto = " + datos["Id_Ruta"].ToString();
                    }
                    if (datos.Contains("Id_RutaD"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " r.Destino_Aeropuerto = " + datos["Id_RutaD"].ToString();
                    }
                    if(datos.Contains("Fecha"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + "";
                        whereis = whereis + " v.Fecha >= " + datos["Fecha"].ToString();
                    }
                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();
                    IEnumerable<Vista_Vuelos> r = db.Database.SqlQuery<Vista_Vuelos>(query);
                    return r.ToList();
                }
                catch (Exception)
                {
                    throw new Exception("Verifica los datos a buscar");
                }
            }
        }
        //list               
        public List<Vista_Vuelos> FiltrarListaVuelo(Hashtable datos)
        {
            using (var db = new PROYECTOVUELO03Entities())
            {
                try
                {
                    string query = "select v.Id_Vuelo,ao.Nombre AS Origen,ad.Nombre AS Destino,v.Hora_Inicio,v.Hora_Fin,v.Fecha,ae.Nombre,mod.NombreModelo,mod.NumeroFilas,mod.NumeroColumnas from Vuelos v " +
                        "inner join Ruta r on v.Id_Ruta = r.Id_Ruta " +
                        "inner join Aeropuerto ao on r.Origen_Aeropuerto = ao.Id_Aeropuerto " +
                        "inner join Aeropuerto ad on r.Destino_Aeropuerto = ad.Id_Aeropuerto " +
                        "inner join Avion av on v.Id_Avion = av.Id_Avion " +
                        "inner join Modelo mod on av.IdModelo = mod.IdModelo " +
                        "inner join Aerolinea ae on av.id_aerolinea = ae.id_aerolinea ";

                    string whereis = "";
                    string orderby = " Group by v.Id_Vuelo,ao.Nombre,ad.Nombre,v.Hora_Inicio,v.Hora_Fin,v.Fecha,ae.Nombre,mod.NombreModelo,mod.NumeroFilas,mod.NumeroColumnas";
                    if (datos.Contains("Id_Ruta"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + "";
                        whereis = whereis + " r.Origen_Aeropuerto = " + datos["Id_Ruta"].ToString();
                    }
                    if (datos.Contains("Id_RutaD"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " r.Destino_Aeropuerto = " + datos["Id_RutaD"].ToString();
                    }
                    if (datos.Contains("Fecha"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " v.Fecha >= " + "'" + datos["Fecha"].ToString() + "'";
                    }
                    if (whereis.Length > 0)
                        query += " WHERE " + whereis + orderby.ToString();
                    IEnumerable<Vista_Vuelos> r = db.Database.SqlQuery<Vista_Vuelos>(query);
                    return r.ToList();
                }
                catch (Exception)
                {
                    throw new Exception("Verifica los datos a buscar");
                }
            }
        }

        //add
        public void AgregarVuelos(Vuelos item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Vuelos.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //delete
        public void EliminarVuelos(Vuelos item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Vuelos obj = db.Vuelos.Where(x => x.Id_Vuelo == item.Id_Vuelo).FirstOrDefault();
                    if (obj != null)
                    {
                        db.Vuelos.Remove(obj);
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
        //update
        public void ActualizarVuelos(Vuelos item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Vuelos obj = db.Vuelos.Where(x => x.Id_Vuelo == item.Id_Vuelo).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Hora_Inicio = item.Hora_Inicio;
                        obj.Hora_Fin = item.Hora_Fin;
                        obj.Id_Ruta = item.Id_Ruta;
                        obj.Id_Avion = item.Id_Avion;
                        obj.Fecha = item.Fecha;
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                throw new Exception("Verifique que los datos sean correctos");
            }
        }
    }
}
