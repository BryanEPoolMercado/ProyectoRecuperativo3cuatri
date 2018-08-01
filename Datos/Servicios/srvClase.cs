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
    public class srvClase
    {
        private PROYECTOVUELO02Entities1 modelovion;


        public List<Vista_clase> ListarClase()
        {
            modelovion = new PROYECTOVUELO02Entities1();
            var selectus = (from cl in modelovion.Clase
                            join avi in modelovion.Avion on cl.Id_Avion equals avi.Id_Avion
                            join mo in modelovion.Modelo on avi.IdModelo equals mo.IdModelo


                            select new Vista_clase
                            {
                                Id_Seccion = cl.Id_Seccion,
                                Nombre = cl.Nombre,
                                NombreModelo = mo.NombreModelo,
                                
                               

                            }).ToList();
            return selectus;
        }
        public List<Vista_clase> getListClase(Hashtable datos)
        {
            using (var db = new PROYECTOVUELO02Entities1())
            {
                try
                {
                    string query = "select av.Id_Avion,mo.NombreModelo,cl.Nombre as Clase from Clase cl inner join Avion av on cl.Id_Avion = av.Id_Avion inner join Modelo mo on av.IdModelo = mo.IdModelo";
                    string whereis = "";
                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " cl.Nombre =" + datos["Nombre"].ToString();
                    }

                    if (datos.Contains("Id_Avion"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " cl.Id_Avion=" + datos["Id_Avion"].ToString();
                    }

                    if (whereis.Length > 0)

                        query += "WHERE" + whereis.ToString();
                    IEnumerable<Vista_clase> r = db.Database.SqlQuery<Vista_clase>(query);
                    return r.ToList();


                }
                catch (Exception e)
                {
                    throw new Exception("Verifica los datos a buscar");
                }
            }
        }
        public void addClase(Clase item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    db.Clase.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void updateClase(Clase item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Clase obj = db.Clase.Where(x => x.Id_Seccion == item.Id_Seccion).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Nombre = item.Nombre;
                        obj.Id_Seccion = item.Id_Seccion;
                        obj.Id_Avion = item.Id_Avion;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void deleteClase(Clase item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Clase obj = db.Clase.Where(x => x.Id_Seccion == item.Id_Seccion).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Clase.Remove(obj);
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
