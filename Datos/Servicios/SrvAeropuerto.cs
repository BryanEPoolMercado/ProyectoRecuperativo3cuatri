using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using System.Collections;
using System.Data.Entity.Core.Objects;
using Datos.Entidades;
using System.Data.Entity.Infrastructure;

namespace Datos.Servicios
{
    public class SrvAeropuerto
    {
        private readonly PROYECTOVUELO02Entities1 modelovion;


        public List<Vista_Aeropuerto> getListAeropuer(Hashtable datos)
        {
            using (var db = new PROYECTOVUELO02Entities1())
            {
                try
                {
                    string query = "select Ae.*,Ae.Nombre,ad.Nombre Ciudad from Aeropuerto Ae inner join Aeropuerto ar on Ae.Nombre=ar.Nombre inner join Ciudad ad on Ae.Id_Ciudad=ad.Id_Ciudad";
                    string whereis = "";
                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " Ae.Nombre =" + datos["Nombre"].ToString();
                    }
                    if (datos.Contains("Id_Ciudad"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " Ae.Id_Ciudad =" + datos["Id_Ciudad"].ToString();
                    }

                    if (whereis.Length > 0)

                        query += "WHERE" + whereis.ToString();
                    IEnumerable<Vista_Aeropuerto> r = db.Database.SqlQuery<Vista_Aeropuerto>(query);
                    return r.ToList();


                }
                catch (Exception)
                {
                    throw new Exception("Verifica los datos a buscar");
                }
            }
        }
        public void addAeropuerto(Aeropuerto item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    db.Aeropuerto.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void updateAeropuerto (Aeropuerto item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Aeropuerto obj = db.Aeropuerto.Where(x => x.Id_Aeropuerto == item.Id_Aeropuerto).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Id_Aeropuerto = item.Id_Aeropuerto;
                        obj.Id_Ciudad = item.Id_Ciudad;
                        obj.Nombre = item.Nombre;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void deleteAeropuerto(Aeropuerto item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Aeropuerto obj = db.Aeropuerto.Where(x => x.Id_Aeropuerto == item.Id_Aeropuerto).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Aeropuerto.Remove(obj);
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
