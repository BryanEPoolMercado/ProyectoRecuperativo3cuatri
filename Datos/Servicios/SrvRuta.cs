using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using System.Collections;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Datos.Servicios;
using Datos.Entidades;

namespace Datos.Servicios
{
    public class SrvRuta
    {

        //private PROYECTOVUELO02Entities1 modeloruta;

        //public List<Vista_Ruta> listaRuta()
        //{

        //}

        private readonly PROYECTOVUELO02Entities1 modelovion;


        public List<Vista_Ruta> getListRutaP(Hashtable datos)
        {
            using (var db = new PROYECTOVUELO02Entities1())
            {
                try
                {
                    string query = "select ru.*,ao.Nombre Origen,ad.Nombre Destino from Ruta ru inner join Aeropuerto ao on ru.Origen_Aeropuerto=ao.Id_Aeropuerto inner join Aeropuerto ad on ru.Destino_Aeropuerto=ad.Id_Aeropuerto ";
                    string whereis = "";
                    if (datos.Contains("Origen_Aeropuerto"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " ru.Origen_Aeropuerto =" + datos["Origen_Aeropuerto"].ToString();
                    }
                    if (datos.Contains("Destino_Aeropuerto"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " ru.Destino_Aeropuerto =" + datos["Destino_Aeropuerto"].ToString();
                    }

                    if (whereis.Length > 0)
                    
                        query += "WHERE" + whereis.ToString();
                        IEnumerable<Vista_Ruta> r=db.Database.SqlQuery<Vista_Ruta>(query);
                        return r.ToList();
                    

                }
                catch (Exception)
                {
                    throw new Exception("Verifica los datos a buscar");
                }
            }
        }
        
        public void addRuta(Ruta item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    db.Ruta.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void updateRuta(Ruta item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Ruta obj = db.Ruta.Where(x => x.Id_Ruta == item.Id_Ruta).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Origen_Aeropuerto = item.Origen_Aeropuerto;
                        obj.Destino_Aeropuerto = item.Destino_Aeropuerto;
                        obj.Distancia = item.Distancia;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void deleteRuta(Ruta item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Ruta obj = db.Ruta.Where(x => x.Id_Ruta == item.Id_Ruta).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Ruta.Remove(obj);
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
