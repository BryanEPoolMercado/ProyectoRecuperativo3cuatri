using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;

namespace Datos.Servicios
{
    public class srv_Aerolinea
    {
        public List<Aerolinea> ListarAerolinea()
        {
            List<Aerolinea> obj = new List<Aerolinea>();
            using (var db = new PROYECTOVUELO03Entities())
            {
                obj = db.Aerolinea.ToList();
                return obj;
            }
        }
        public List<Aerolinea> FiltroAerolinea(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = @"SELECT VALUE Aerolinea FROM PROYECTOVUELO03Entities.Aerolinea As Aerolinea ";
                    StringBuilder whereis = new StringBuilder();
                    List<ObjectParameter> parameters = new List<ObjectParameter>();

                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0) whereis.Append("AND");
                        whereis.Append("Aerolinea.Nombre=@Nombre");
                        parameters.Add(new ObjectParameter("Nombre", datos["Nombre"]));
                    }

                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();

                    ObjectContext oc;
                    oc = ((IObjectContextAdapter)db).ObjectContext;

                    var q = new ObjectQuery<Datos.Modelo.Aerolinea>(query, oc);

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
        public void AgregarAerolinea(Aerolinea item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Aerolinea.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void ActualizarAerolinea(Aerolinea item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Aerolinea obj = db.Aerolinea.Where(x => x.Id_Aerolinea == item.Id_Aerolinea).FirstOrDefault();

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
        public void EliminarAerolinea(Aerolinea item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Aerolinea obj = db.Aerolinea.Where(x => x.Id_Aerolinea == item.Id_Aerolinea).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Aerolinea.Remove(obj);
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

