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
    public class srv_Perfil
    {
        public List<Perfil> ListarPerfil()
        {
            List<Perfil> obj = new List<Perfil>();
            using (var db = new PROYECTOVUELO03Entities())
            {
                obj = db.Perfil.ToList();
                return obj;
            }
        }
        public List<Perfil> FiltroPerfil(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = @"SELECT VALUE Perfil FROM PROYECTOVUELO03Entities.Perfil As Perfil ";
                    StringBuilder whereis = new StringBuilder();
                    List<ObjectParameter> parameters = new List<ObjectParameter>();

                    if (datos.Contains("Nombre_perfil"))
                    {
                        if (whereis.Length > 0) whereis.Append("AND");
                        whereis.Append("Perfil.Nombre_perfil=@Nombre_perfil");
                        parameters.Add(new ObjectParameter("Nombre_perfil", datos["Nombre_perfil"]));
                    }

                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();

                    ObjectContext oc;
                    oc = ((IObjectContextAdapter)db).ObjectContext;

                    var q = new ObjectQuery<Datos.Modelo.Perfil>(query, oc);

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
        public void AgregarPerfil(Perfil item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Perfil.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void ActualizarPerfil(Perfil item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Perfil obj = db.Perfil.Where(x => x.Id_Perfil == item.Id_Perfil).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Nombre_perfil = item.Nombre_perfil;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void EliminarPerfil(Perfil item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Perfil obj = db.Perfil.Where(x => x.Id_Perfil == item.Id_Perfil).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Perfil.Remove(obj);
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
