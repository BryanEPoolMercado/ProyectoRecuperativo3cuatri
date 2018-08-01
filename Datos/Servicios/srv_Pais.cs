using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Pais
    {
        public List<Pais> ListarPais()
        {
            List<Pais> obj = new List<Pais>();
            using (var db = new PROYECTOVUELO03Entities())
            {
                obj = db.Pais.ToList();
                return obj;
            }
        }
        public List<Pais> ListarPais(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = @"SELECT VALUE Pais FROM PROYECTOVUELO03Entities.Pais As Pais ";
                    StringBuilder whereis = new StringBuilder();
                    List<ObjectParameter> parameters = new List<ObjectParameter>();

                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0) whereis.Append("AND");
                        whereis.Append("Pais.Nombre=@Nombre");
                        parameters.Add(new ObjectParameter("Nombre", datos["Nombre"]));
                    }

                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();

                    ObjectContext oc;
                    oc = ((IObjectContextAdapter)db).ObjectContext;

                    var q = new ObjectQuery<Datos.Modelo.Pais>(query, oc);

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
        public void AgregarPais(Pais item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Pais.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void ActualizarPais(Pais item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Pais obj = db.Pais.Where(x => x.Id_Pais == item.Id_Pais).FirstOrDefault();

                    if (obj != null)
                    {
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
        public void EliminarPais(Pais item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Pais obj = db.Pais.Where(x => x.Id_Pais == item.Id_Pais).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Pais.Remove(obj);
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
