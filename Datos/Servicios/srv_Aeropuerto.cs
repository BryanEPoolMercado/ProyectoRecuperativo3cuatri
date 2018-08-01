using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using Datos.Entidades;
using System.Collections;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Datos.Servicios
{
    public class srv_Aeropuerto
    {
        public List<Aeropuerto> ListarAeropuerto()
        {
            List<Aeropuerto> obj = new List<Aeropuerto>();
            using (var db = new PROYECTOVUELO03Entities())
            {
                obj = db.Aeropuerto.ToList();
                return obj;
            }
        }
        private PROYECTOVUELO03Entities modeloavion;
        public List<Vista_Aeropuerto> getListAeropuerto()
        {
            modeloavion = new PROYECTOVUELO03Entities();
            var selectavion = (from aero in modeloavion.Aeropuerto
                               join ciu in modeloavion.Ciudad on aero.Id_Ciudad equals ciu.Id_Ciudad

                               select new Vista_Aeropuerto
                               {
                                   Id_Aeropuerto = aero.Id_Aeropuerto,
                                   Nombre = aero.Nombre,
                                   Ciudad = ciu.Nombre,
                               }).ToList();
            return selectavion;
        }
        public List<Vista_Aeropuerto> getListAeropuerto(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = "select Ae.Id_Aeropuerto,Ae.Nombre,ciu.Nombre as Ciudad from Aeropuerto Ae inner join Ciudad ciu on Ae.Id_Ciudad=ciu.Id_Ciudad ";
                    string whereis = "";


                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " Ae.Nombre = " + "'" + datos["Nombre"].ToString() + "'";
                    }                   

                    if (whereis.Length > 0)

                        query += "WHERE" + whereis.ToString();
                    IEnumerable<Vista_Aeropuerto> r = db.Database.SqlQuery<Vista_Aeropuerto>(query);
                    return r.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a buscar");
            }
        }
        public void addAeropuerto(Aeropuerto item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
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
        public void updateAeropuerto(Aeropuerto item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
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
                using (var db = new PROYECTOVUELO03Entities())
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
