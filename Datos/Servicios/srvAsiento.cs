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
    public class srvAsiento
    {
        private readonly PROYECTOVUELO02Entities1 modelovion;
        public List<Vista_Asiento> getListAsiento(Hashtable datos)
        {
            using (var db = new PROYECTOVUELO02Entities1())
            {
                try
                {
                    string query = "select CL.*,CL.Nombre,AV.Id_Avion Avion from Clase CL inner join Clase ar on CL.Nombre=AV.Id_Avion inner join Avion AV on CL.Id_Avion=AV.Id_Avion";
                    string whereis = "";
                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " CL.Nombre =" + datos["Nombre"].ToString();
                    }
                    if (datos.Contains("Id_Avion"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " CL.Id_Avion =" + datos["Id_Avion"].ToString();
                    }

                    if (whereis.Length > 0)

                        query += "WHERE" + whereis.ToString();
                    IEnumerable<Vista_Asiento> r = db.Database.SqlQuery<Vista_Asiento>(query);
                    return r.ToList();


                }
                catch (Exception)
                {
                    throw new Exception("Verifica los datos a buscar");
                }
            }
        }
        public void addClase(Asiento item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    db.Asiento.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void updateAsiento(Asiento item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Asiento obj = db.Asiento.Where(x => x.Id_Asiento == item.Id_Asiento).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Id_Asiento = item.Id_Asiento;
                        obj.Letra = item.Letra;
                        obj.Fila = item.Fila;
                        obj.Id_Seccion = item.Id_Seccion;
                        obj.id_ = item.id_;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void deleteAsiento(Asiento item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Asiento obj = db.Asiento.Where(x => x.Id_Asiento == item.Id_Asiento).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Asiento.Remove(obj);
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
