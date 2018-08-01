using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelo;
using Datos.Entidades;
using System.Data.SqlClient;

namespace Datos.Servicios
{
    public class srv_Usuario
    {
        private PROYECTOVUELO03Entities ModeloUsuario;

        public List<Vista_Usuario> ListarUsuario()
        {
            ModeloUsuario = new PROYECTOVUELO03Entities();
            var selectus = (from usu in ModeloUsuario.Usuario
                            join per in ModeloUsuario.Perfil on usu.Id_Perfil equals per.Id_Perfil

                            select new Vista_Usuario
                            {
                                Id_Usuario = usu.Id_Usuario,
                                Nombre = usu.Nombre,
                                Apellido_pat = usu.Apellido_pat,
                                Apellido_mat = usu.Apellido_mat,
                                Direccion = usu.Direccion,
                                Fecha = usu.Fecha,
                                Telefono_us = usu.Telefono_us,
                                CodigoPos_Usuario = usu.Codigo_p,
                                Correo = usu.Correo,
                                Contrasenia = usu.Contrasenia,
                                Nombre_perfil = per.Nombre_perfil,

                            }).ToList();
            return selectus;
        }
        public List<Vista_Usuario> FiltroUsuario(Hashtable datos)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    string query = "select us.Id_Usuario,per.Nombre_perfil,us.Nombre,us.Apellido_pat,us.Apellido_mat,us.Fecha,us.Direccion,us.Codigo_p as CodigoPos_Usuario,us.Telefono_us,us.Correo,us.Contrasenia from Usuario us inner join Perfil per on us.Id_Perfil=per.Id_Perfil ";
                    string whereis = "";

                    if (datos.Contains("Nombre"))
                    {
                        if (whereis.Length > 0)
                            whereis = whereis + "";
                        whereis = whereis + " us.Nombre = " + "'" + datos["Nombre"].ToString() + "'";
                    }

                    if (whereis.Length > 0)

                        query += "WHERE" + whereis.ToString();
                    IEnumerable<Vista_Usuario> r = db.Database.SqlQuery<Vista_Usuario
                        >(query);
                    return r.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a buscar");
            }
        }
        public void AgregarUsuario(Usuario item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    db.Usuario.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a insertar");
            }
        }
        public void ActualizarUsuario(Usuario item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Usuario obj = db.Usuario.Where(x => x.Id_Usuario == item.Id_Usuario).FirstOrDefault();

                    if (obj != null)
                    {
                        obj.Nombre = item.Nombre;
                        obj.Apellido_pat = item.Apellido_pat;
                        obj.Apellido_mat = item.Apellido_mat;
                        obj.Direccion = item.Direccion;
                        obj.Fecha = item.Fecha;
                        obj.Codigo_p = item.Codigo_p;
                        obj.Id_Perfil = item.Id_Perfil;
                        obj.Telefono_us = item.Telefono_us;
                        obj.Correo = item.Correo;
                        obj.Contrasenia = item.Contrasenia;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Verifica los datos a actualizar");
            }
        }
        public void EliminarUsuario(Usuario item)
        {
            try
            {
                using (var db = new PROYECTOVUELO03Entities())
                {
                    Usuario obj = db.Usuario.Where(x => x.Id_Usuario == item.Id_Usuario).FirstOrDefault();

                    if (obj != null)
                    {
                        db.Usuario.Remove(obj);
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
