using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Datos.Modelo;
using Datos.Entidades;

namespace Datos.Servicios
{
    public class srv_Ubicacion
    {
        private PROYECTOVUELO03Entities modeloavion;
        public List<Vista_Ubicaciones> ListarUbicacion()
        {
            modeloavion = new PROYECTOVUELO03Entities();
            var selectavion = (from ubi in modeloavion.Ubicacion
                               join avi in modeloavion.Avion on ubi.id_avion equals avi.Id_Avion
                               join mod in modeloavion.Modelo on avi.IdModelo equals mod.IdModelo


                               select new Vista_Ubicaciones
                               {
                                   Id_Ubicacion = ubi.Id_Ubicacion,
                                   nombre_ubicacion = ubi.nombre_ubicacion,
                                   NombreModelo = mod.NombreModelo,
                               }).ToList();
            return selectavion;
        }
        public List<Vista_Clase> ListarUbicacion(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = "select ubi.Id_Ubicacion,ubi.nombre_ubicacion,mode.NombreModelo from Ubicacion ubi inner join Avion av on ubi.id_avion=avi.Id_Avion inner join Modelo mode on avi.IdModelo=mode.IdModelo ";
                    string whereis = "";


                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " ";
                        whereis = whereis + " nombre_ubicacion =" + datos["Nombre"].ToString();
                    }
                    
                    if (whereis.Length > 0)

                        query += "WHERE" + whereis.ToString();
                    IEnumerable<Vista_Clase> r = db.Database.SqlQuery<Vista_Clase
                        >(query);
                    return r.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a buscar");
            }
        }
        public void AgregarUbicacion(Ubicacion item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Ubicacion.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void ActualizarUbicacion(Ubicacion item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Ubicacion obj = db.Ubicacion.Where(x => x.Id_Ubicacion == item.Id_Ubicacion).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.nombre_ubicacion = item.nombre_ubicacion;
                        obj.id_avion = item.id_avion;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void EliminarUbicacion(Ubicacion item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Ubicacion obj = db.Ubicacion.Where(x => x.Id_Ubicacion == item.Id_Ubicacion).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Ubicacion.Remove(obj);
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
