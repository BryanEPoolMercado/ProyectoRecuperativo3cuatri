using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using System.Collections;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Datos.Servicios
{
    public class SrvPrecio
    {
        public List<Precio> getListPrecio()
        {
            List<Precio> obj = new List<Precio>();
            using (var db = new PROYECTOVUELO02Entities1())
            {
                obj = db.Precio.ToList();
                return obj;
            }
        }
        public List<Precio> getListPrecio(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    string query = @"SELECT VALUE Precio FROM PROYECTOVUELO02Entities1.Precio As Precio ";
                    StringBuilder whereis = new StringBuilder();
                    List<ObjectParameter> parameters = new List<ObjectParameter>();


                    if (datos.Contains("Precio"))
                    {
                        if (whereis.Length > 0) whereis.Append("");
                        whereis.Append("Precio.Precio=@Precio");
                        parameters.Add(new ObjectParameter("Precio", datos["Precio"]));
                    }
                    
                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();

                    ObjectContext oc;
                    oc = ((IObjectContextAdapter)db).ObjectContext;

                    var q = new ObjectQuery<Datos.Modelo.Precio>(query, oc);

                    if (whereis.Length > 0)
                    {
                        foreach (ObjectParameter parametro in parameters)
                            q.Parameters.Add(parametro);

                    }
                    return q.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a buscar");
            }
        }
        public void addPrecio(Precio item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    db.Precio.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void updatePrecio(Precio item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Precio obj = db.Precio.Where(x => x.Id_Precio == item.Id_Precio).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Id_Avion = item.Id_Avion;
                        obj.Id_Ruta = item.Id_Ruta;
                        obj.Id_Seccion = item.Id_Seccion;
                        obj.Precio1 = item.Precio1;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void deletePrecio(Precio item)
        {
            try
            {
                using (var db = new PROYECTOVUELO02Entities1())
                {
                    Precio obj = db.Precio.Where(x => x.Id_Precio == item.Id_Precio).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Precio.Remove(obj);
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
