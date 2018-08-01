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
    public class srv_Modelo
    {
        public List<Modelo.Modelo> ListarModelo()
        {
            List<Modelo.Modelo> obj = new List<Modelo.Modelo>();
            using (var db = new PROYECTOVUELO03Entities())
            {
                obj = db.Modelo.ToList();
                return obj;
            }
        }
        public List<Modelo.Modelo> FiltroModelo(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = @"SELECT VALUE Modelo FROM PROYECTOVUELO03Entities.Modelo As Modelo ";
                    StringBuilder whereis = new StringBuilder();
                    List<ObjectParameter> parameters = new List<ObjectParameter>();

                    if (datos.Contains("NombreModelo"))
                    {
                        if (whereis.Length > 0) whereis.Append("AND");
                        whereis.Append("Modelo.NombreModelo=@NombreModelo");
                        parameters.Add(new ObjectParameter("NombreModelo", datos["NombreModelo"]));
                    }

                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();

                    ObjectContext oc;
                    oc = ((IObjectContextAdapter)db).ObjectContext;

                    var q = new ObjectQuery<Datos.Modelo.Modelo>(query, oc);

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
        public void AgregarModelo(Modelo.Modelo item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Modelo.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void ActualizarModelo(Modelo.Modelo item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Modelo.Modelo obj = db.Modelo.Where(x => x.IdModelo == item.IdModelo).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.NombreModelo = item.NombreModelo;
                        obj.NumeroFilas = item.NumeroFilas;
                        obj.NumeroColumnas = item.NumeroColumnas;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void EliminarModelo(Modelo.Modelo item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Modelo.Modelo obj = db.Modelo.Where(x => x.IdModelo == item.IdModelo).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Modelo.Remove(obj);
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

