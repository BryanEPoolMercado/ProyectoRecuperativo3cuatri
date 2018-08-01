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
    public class SrvUbicacion
    {
        private readonly PROYECTOVUELO02Entities1 modelovion;

        public List<Vista_Ubicacion> getListUbicacion(Hashtable datos)
        {
            using (var db = new PROYECTOVUELO02Entities1())
            {
                try
                {
                    string query = "select UB.*,UB.nombre_ubicacion,ASSS.Id_Asiento Asiento from Ubicacion UB inner join Ubicacion ar on UB.nombre_ubicacion=ASSS.Id_Asiento inner join Asiento ASSS on UB.Id_Asiento=ASSS.Id_Asiento";
                    string whereis = "";
                    if (datos.Contains("nombre_ubicacion"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " UB.nombre_ubicacion =" + datos["nombre_ubicacion"].ToString();
                    }
                    if (datos.Contains("Id_Asiento"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " UB.Id_Asiento =" + datos["Id_Asiento"].ToString();
                    }

                    if (whereis.Length > 0)

                        query += "WHERE" + whereis.ToString();
                    IEnumerable<Vista_Ubicacion> r = db.Database.SqlQuery<Vista_Ubicacion>(query);
                    return r.ToList();


                }
                catch (Exception)
                {
                    throw new Exception("Verifica los datos a buscar");
                }
            }
        }
        public void addUbicacion(Ubicacion item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
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
        public void updateUbicacion(Ubicacion item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Ubicacion obj = db.Ubicacion.Where(x => x.id_ == item.id_).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.id_ = item.id_;
                        obj.id_asiento = item.id_asiento;
                        obj.nombre_ubicacion = item.nombre_ubicacion;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void deleteUbicacion(Ubicacion item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Ubicacion obj = db.Ubicacion.Where(x => x.id_ == item.id_).FirstOrDefault();

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
