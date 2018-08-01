using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Avion
    {
        private PROYECTOVUELO03Entities modeloavion;
        public List<Vista_Avion> ListarAvion()
        {
            modeloavion = new PROYECTOVUELO03Entities();
            var selectavion = (from avi in modeloavion.Avion
                               join mod in modeloavion.Modelo on avi.IdModelo equals mod.IdModelo
                               join aer in modeloavion.Aerolinea on avi.Id_Aerolinea equals aer.Id_Aerolinea

                               select new Vista_Avion
                               {
                                   Id_Avion = avi.Id_Avion,
                                   NumeroPasajeros = avi.NumeroPasajeros,
                                   Nombre = aer.Nombre,
                                   NombreModelo = mod.NombreModelo,
                               }).ToList();
            return selectavion;
        }
        public List<Avion> ListarAvion2()
        {
            List<Avion> obj = new List<Avion>();
            using (var db = new PROYECTOVUELO03Entities())
            {
                obj = db.Avion.ToList();
                return obj;
            }
        }
        public List<Vista_Avion> FiltroAvion(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = "select avi.Id_Avion,aero.Nombre,mod.NombreModelo,avi.NumeroPasajeros from Avion avi inner join Aerolinea aero on avi.Id_Aerolinea=aero.Id_Aerolinea inner join Modelo mod on avi.IdModelo = mod.IdModelo ";
                    string whereis = "";


                    if (datos.Contains("NombreModelo"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " mod.NombreModelo = " + "'" + datos["NombreModelo"].ToString() + "'";
                    }

                    if (whereis.Length > 0)

                        query += "WHERE" + whereis.ToString();
                    IEnumerable<Vista_Avion> r = db.Database.SqlQuery<Vista_Avion>(query);
                    return r.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a buscar");
            }
        }
        public void AgregarAvion(Avion item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Avion.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void ActualizarAvion(Avion item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Avion obj = db.Avion.Where(x => x.Id_Avion == item.Id_Avion).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.NumeroPasajeros = item.NumeroPasajeros;
                        obj.Id_Aerolinea = item.Id_Aerolinea;
                        obj.IdModelo = item.IdModelo;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void EliminarAvion(Avion item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Avion obj = db.Avion.Where(x => x.Id_Avion == item.Id_Avion).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Avion.Remove(obj);
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

