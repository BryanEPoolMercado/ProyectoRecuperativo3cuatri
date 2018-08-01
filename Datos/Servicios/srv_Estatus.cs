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
    public class srv_Estatus
    {
        public List<Estatus> ListarEstatus()
        {
            List<Estatus> objEst = new List<Estatus>();
            using (var db = new PROYECTOVUELO03Entities())
            {
                objEst = db.Estatus.Include("Compra").ToList();
                return objEst;
            }
        }

        public List<Estatus> FiltroEstatus(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = @"SELECT VALUE Estatus FROM PROYECTOVUELO02Entities.Estatus AS Estatus";
                    StringBuilder whereis = new StringBuilder();
                    List<ObjectParameter> parameters = new List<ObjectParameter>();


                    if (datos.Contains("Id_Estatus"))
                    {
                        if (whereis.Length > 0) whereis.Append(" AND ");
                        whereis.Append("Estatus.Id_Estatus=@Id_Estatus");
                        parameters.Add(new ObjectParameter("Id_Estatus", datos["Id_Estatus"]));
                    }

                    if (datos.Contains("Cantidad"))
                    {
                        if (whereis.Length > 0) whereis.Append(" AND ");
                        whereis.Append("Estatus.Cantidad=@Cantidad");
                        parameters.Add(new ObjectParameter("Cantidad", datos["Cantidad"]));
                    }

                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();

                    ObjectContext oc;
                    oc = ((IObjectContextAdapter)db).ObjectContext;

                    var q = new ObjectQuery<Datos.Modelo.Estatus>(query, oc);

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

        public void AgregarEstatus(Estatus item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Estatus.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }

        public void ActualizarEstatus(Estatus item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Estatus objEst = db.Estatus.Where(x => x.Id_pago == item.Id_pago).FirstOrDefault();

                    if (objEst != null)
                    {
                        objEst.Id_Estatus = item.Id_Estatus;
                        objEst.Cantidad = item.Cantidad;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }

        public void EliminarEstatus(Estatus item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Estatus objEst = db.Estatus.Where(x => x.Id_pago == item.Id_pago).FirstOrDefault();

                    if (objEst != null)
                    {
                        db.Estatus.Remove(objEst);
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
