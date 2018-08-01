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
    public class srv_Moneda
    {
        public List<Tipo_de_Moneda> getListMoneda()
        {
            List<Tipo_de_Moneda> objMone = new List<Tipo_de_Moneda>();
            using (var db = new PROYECTOVUELO03Entities())
            {
                objMone = db.Tipo_de_Moneda.Include("Compra").ToList();
                return objMone;
            }
        }

        public List<Tipo_de_Moneda> getListMoneda(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = @"SELECT VALUE Tipo_de_Moneda FROM PROYECTOVUELO02Entities.Tipo_de_Moneda As Tipo_de_Moneda";
                    StringBuilder whereis = new StringBuilder();
                    List<ObjectParameter> parameters = new List<ObjectParameter>();


                    if (datos.Contains("Nombre_Moneda"))
                    {
                        if (whereis.Length > 0) whereis.Append(" AND ");
                        whereis.Append("Tipo_de_Moneda.Nombre_Moneda=@Nombre_Moneda");
                        parameters.Add(new ObjectParameter("Nombre_Moneda", datos["Nombre_Moneda"]));
                    }

                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();

                    ObjectContext oc;
                    oc = ((IObjectContextAdapter)db).ObjectContext;

                    var q = new ObjectQuery<Datos.Modelo.Tipo_de_Moneda>(query, oc);

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

        public void addMoneda(Tipo_de_Moneda item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Tipo_de_Moneda.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }

        public void updateMoneda(Tipo_de_Moneda item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Tipo_de_Moneda objMone = db.Tipo_de_Moneda.Where(x => x.Id_Moneda == item.Id_Moneda).FirstOrDefault();

                    if (objMone != null)
                    {
                        objMone.Nombre_Moneda = item.Nombre_Moneda;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }

        public void deleteMoneda(Tipo_de_Moneda item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Tipo_de_Moneda objMone = db.Tipo_de_Moneda.Where(x => x.Id_Moneda == item.Id_Moneda).FirstOrDefault();

                    if (objMone != null)
                    {
                        db.Tipo_de_Moneda.Remove(objMone);
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

