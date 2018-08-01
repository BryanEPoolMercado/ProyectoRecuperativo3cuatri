using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using Datos.Entidades;
using System.Collections;


namespace Datos.Servicios
{
    public class srv_Clase
    {
        private PROYECTOVUELO03Entities modeloavion;
        public List<Vista_Clase> ListarClase()
        {
            modeloavion = new PROYECTOVUELO03Entities();
            var selectavion = (from sec in modeloavion.Clase
                               join avi in modeloavion.Avion on sec.Id_Avion equals avi.Id_Avion
                               join mod in modeloavion.Modelo on avi.IdModelo equals mod.IdModelo
                               

                               select new Vista_Clase
                               {
                                   Id_Seccion = sec.Id_Seccion,                                  
                                   Nombre = sec.Nombre,
                                   NombreModelo = mod.NombreModelo,
                               }).ToList();
            return selectavion;
        }
        public List<Vista_Clase> getListClase(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = "select Ae.Id_Aeropuerto,Ae.Nombre,ad.Nombre Ciudad from Aeropuerto Ae inner join Aeropuerto ar on Ae.Nombre=ar.Nombre inner join Ciudad ad on Ae.Id_Ciudad=ad.Id_Ciudad ";
                    string whereis = "";


                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " Ae.Nombre =" + datos["Nombre"].ToString();
                    }
                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + " AND ";
                        whereis = whereis + " ad.Nombre =" + datos["Nombre"].ToString();
                    }

                    if (whereis.Length > 0)

                        query += "WHERE" + whereis.ToString();
                    IEnumerable<Vista_Clase> r = db.Database.SqlQuery<Vista_Clase
                        >(query);
                    return r.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a buscar");
            }
        }
        public void addClase(Clase item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Clase.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void updateClase(Clase item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Clase obj = db.Clase.Where(x => x.Id_Seccion == item.Id_Seccion).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Id_Avion = item.Id_Avion;
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
        public void deleteClase(Clase item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Clase obj = db.Clase.Where(x => x.Id_Seccion == item.Id_Seccion).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Clase.Remove(obj);
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
