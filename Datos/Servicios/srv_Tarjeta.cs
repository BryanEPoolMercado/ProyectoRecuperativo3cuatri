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
    public class srv_Tarjeta
    {
        public List<Tarjeta> getListTarjeta()
        {
            List<Tarjeta> objTar = new List<Tarjeta>();
            using (var db = new PROYECTOVUELO03Entities())
            {
                objTar = db.Tarjeta.ToList();
                return objTar;
            }
        }

        public List<Tarjeta> getListTarjeta(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = @"SELECT VALUE Tarjeta  FROM PROYECTOVUELO02Entities.Tarjeta As Tarjeta ";
                    StringBuilder whereis = new StringBuilder();
                    List<ObjectParameter> parameters = new List<ObjectParameter>();


                    if (datos.Contains("Num_Cuenta"))
                    {
                        if (whereis.Length > 0) whereis.Append(" AND ");
                        whereis.Append("Tarjeta.Num_Cuenta=@Num_Cuenta");
                        parameters.Add(new ObjectParameter("Num_Cuenta", datos["Num_Cuenta"]));
                    }

                    if (datos.Contains("Tipo_Tarjeta"))
                    {
                        if (whereis.Length > 0) whereis.Append(" AND ");
                        whereis.Append("Tarjeta.Tipo_Tarjeta=@Tipo_Tarjeta");
                        parameters.Add(new ObjectParameter("Tipo_Tarjeta", datos["Tipo_Tarjeta"]));
                    }

                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0) whereis.Append(" AND ");
                        whereis.Append("Tarjeta.Nombre=@Nombre");
                        parameters.Add(new ObjectParameter("Nombre", datos["Nombre"]));
                    }

                    if (datos.Contains("Apellido_Pat"))
                    {
                        if (whereis.Length > 0) whereis.Append(" AND ");
                        whereis.Append("Tarjeta.Apellido_Pat=@Apellido_Pat");
                        parameters.Add(new ObjectParameter("Apellido_Pat", datos["Apellido_Pat"]));
                    }
                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();

                    ObjectContext oc;
                    oc = ((IObjectContextAdapter)db).ObjectContext;

                    var q = new ObjectQuery<Datos.Modelo.Tarjeta>(query, oc);

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

        public void addTarjeta(Tarjeta item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Tarjeta.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }

        public void updateTarjeta(Tarjeta item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Tarjeta objTar = db.Tarjeta.Where(x => x.Id_Tarjeta == item.Id_Tarjeta).FirstOrDefault();

                    if (objTar != null)
                    {
                        objTar.Num_Cuenta = item.Num_Cuenta;
                        objTar.Tipo_Tarjeta = item.Tipo_Tarjeta;
                        objTar.Fecha_Venc = item.Fecha_Venc;
                        objTar.CVC = item.CVC;
                        objTar.Apellido_Pat = item.Apellido_Pat;
                        objTar.Apellido_Mat = item.Apellido_Mat;
                        objTar.Nombre = item.Nombre;

                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }

        public void deleteTarjeta(Tarjeta item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Tarjeta objTar = db.Tarjeta.Where(x => x.Id_Tarjeta == item.Id_Tarjeta).FirstOrDefault();

                    if (objTar != null)
                    {
                        db.Tarjeta.Remove(objTar);
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

