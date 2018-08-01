using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Datos.Modelo;
using System.Collections;

namespace Datos.Servicios
{
    public class srv_Precio
    {      

        public List<Vista_Precio> getListPrecio(Hashtable datos)
        {
            using (var db = new PROYECTOVUELO03Entities())
            {
                try
                {
                    string query = " select pr.*, p.Precio,av.Id_Avion Avion,ru.Origen_Aeropuerto Origen, rui.Destino_Aeropuerto Destino,cl.Nombre Clase from Precio pr inner join Precio p on pr.Precio=p.Precio inner join Avion av on av.Id_Avion= av.Id_Avion inner join Ruta ru on pr.Id_Ruta=ru.Origen_Aeropuerto  inner join Ruta rui on pr.Id_Ruta=ru.Destino_Aeropuerto inner join Clase cl on pr.Id_Seccion=cl.Nombre";
                    string whereis = "";
                    if (datos.Contains("Id_Avion"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " pr.Id_Avion =" + datos["Id_Avion"].ToString();
                    }
                    if (datos.Contains("Origen_Aeropuerto"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " pr.Origen_Aeropuerto =" + datos["Origen_Aeropuerto"].ToString();
                    }
                    if (datos.Contains("Destino_Aeropuerto"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " pr.Destino_Aeropuerto =" + datos["Destino_Aeropuerto"].ToString();
                    }

                    if (whereis.Length > 0)

                        query += "WHERE" + whereis.ToString();
                    IEnumerable<Vista_Precio> r = db.Database.SqlQuery<Vista_Precio>(query);
                    return r.ToList();


                }
                catch (Exception)
                {
                    throw new Exception("Verifica los datos a buscar");
                }
            }
        }
        public void addPrecio(Precio item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
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
                using (var db = new PROYECTOVUELO03Entities())
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
                using (var db = new PROYECTOVUELO03Entities())
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
