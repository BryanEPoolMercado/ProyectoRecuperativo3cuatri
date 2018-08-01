using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using Datos.Entidades;
using System.Collections;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Datos.Servicios
{
    public class srv_Asiento
    {
       
        public List<Asiento> ListarAsiento()
        {
            List<Asiento> obj = new List<Asiento>();
            using (var db = new PROYECTOVUELO03Entities())
            {
                obj = db.Asiento.ToList();
                return obj;
            }
        }
        public List<Asiento> FiltroAsiento(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = @"SELECT VALUE Asiento FROM PROYECTOVUELO03Entities.Asiento As Asiento";
                    
                    StringBuilder whereis = new StringBuilder();
                    List<ObjectParameter> parameters = new List<ObjectParameter>();

                    if (datos.Contains("Id_Vuelo"))
                    {
                        if (whereis.Length > 0) whereis.Append(" ");
                        whereis.Append("Asiento.Id_Vuelo=@Id_Vuelo");
                        parameters.Add(new ObjectParameter("Id_Vuelo", datos["Id_Vuelo"]));
                    }
                    
                    whereis.Append(" and Asiento.estado=@estado");
                    parameters.Add(new ObjectParameter("estado", false));

                    if (whereis.Length > 0)
                        query += " WHERE " + whereis.ToString();

                    ObjectContext oc;
                    oc = ((IObjectContextAdapter)db).ObjectContext;

                    var q = new ObjectQuery<Datos.Modelo.Asiento>(query, oc);

                    if (whereis.Length > 0)
                    {
                        foreach (ObjectParameter parametro in parameters)
                            q.Parameters.Add(parametro);
                    }
                    return q.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Verifica los datos a buscar");
            }
        }

        public void addAsiento(Asiento item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
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
        public Asiento updateAsiento(Asiento item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Asiento obj = db.Asiento.Where(x => x.Id_Asiento == item.Id_Asiento).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Id_Asiento = item.Id_Asiento;
                        obj.Id_Seccion = item.Id_Seccion;
                        obj.Id_Vuelo = item.Id_Vuelo;
                        obj.letra = item.letra;
                        obj.numero = item.numero;
                        obj.posicion=item.posicion;
                        obj.estado = true;                       
                        db.SaveChanges();
                    }
                    return obj;
                }                
            }

            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public Asiento updateAsientoDisponible(Asiento item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Asiento obj = db.Asiento.Where(x => x.Id_Asiento == item.Id_Asiento).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Id_Asiento = item.Id_Asiento;                       
                        obj.letra = item.letra;
                        obj.numero = item.numero; 
                        obj.precio=item.precio;
                        obj.estado = false;
                        db.SaveChanges();
                    }
                    return obj;
                }
            }

            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void ModificarAsiento(Asiento item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Asiento obj = db.Asiento.Where(x => x.Id_Asiento == item.Id_Asiento).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.posicion = item.posicion;
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
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Asiento obj = db.Asiento.Where(x => x.posicion == item.posicion).FirstOrDefault();

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
