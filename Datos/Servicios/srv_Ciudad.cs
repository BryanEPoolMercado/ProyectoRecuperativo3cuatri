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
    public class srv_Ciudad
    {
        public List<Ciudad> ListaCiudad()
        {
            List<Ciudad> obj = new List<Ciudad>();
            using (var db = new PROYECTOVUELO03Entities())
            {
                obj = db.Ciudad.ToList();
                return obj;
            }
        }
        private PROYECTOVUELO03Entities modeloavion;
        public List<Vista_Ciudad> ListarCiudad()
        {
            modeloavion = new PROYECTOVUELO03Entities();
            var selectavion = (from ciu in modeloavion.Ciudad
                               join pai in modeloavion.Pais on ciu.Id_Pais equals pai.Id_Pais
                               
                               select new Vista_Ciudad
                               {
                                   Id_Ciudad = ciu.Id_Ciudad,
                                   Nombre = ciu.Nombre,
                                   NombrePais = pai.Nombre,
                               }).ToList();
            return selectavion;
        }
        public List<Vista_Ciudad> FiltroCiudad(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = "select ciu.Id_Ciudad,pai.Nombre as NombrePais,ciu.Nombre from Ciudad ciu inner join Pais pai on ciu.Id_Pais = pai.Id_Pais ";
                    string whereis = "";


                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + "";
                        whereis = whereis + " ciu.Nombre = " + "'"+ datos["Nombre"].ToString() + "'";
                    }
                   
                    if (whereis.Length > 0)

                        query += "WHERE" + whereis.ToString();
                    IEnumerable<Vista_Ciudad> r = db.Database.SqlQuery<Vista_Ciudad
                        >(query);
                    return r.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a buscar");
            }
        }
        public void AgregarCiudad(Ciudad item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Ciudad.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void ModificarCiudad(Ciudad item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Ciudad obj = db.Ciudad.Where(x => x.Id_Ciudad == item.Id_Ciudad).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Id_Pais = item.Id_Pais;
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
        public void EliminarCiudad(Ciudad item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Ciudad obj = db.Ciudad.Where(x => x.Id_Ciudad == item.Id_Ciudad).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Ciudad.Remove(obj);
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
