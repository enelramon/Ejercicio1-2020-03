using Ejercicio1_2020_03.Models;
using Ejercicio1_2020_03.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Ejercicio1_2020_03.BLL
{
    public class EstudiantesBLL
    {
        /// <summary>
        /// Permite insertar o modificar una entidad en la base de datos
        /// </summary>
        /// <param name="estudiante">La entidad que se desea guardar</param> 
        public static bool Guardar(Estudiantes estudiante)
        {
            if (!Existe(estudiante.EstudianteId))//si no existe insertamos
                return Insertar(estudiante);
            else
                return Modificar(estudiante);
        }

        /// <summary>
        /// Permite insertar una entidad en la base de datos
        /// </summary>
        /// <param name="estudiante">La entidad que se desea guardar</param>
        private static bool Insertar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //Agregar la entidad que se desea insertar al contexto
                contexto.Estudiantes.Add(estudiante);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        /// <summary>
        /// Permite modificar una entidad en la base de datos
        /// </summary>
        /// <param name="estudiante">La entidad que se desea modificar</param> 
        public static bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                //marcar la entidad como modificada para que el contexto sepa como proceder
                contexto.Entry(estudiante).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

           public static bool Existe(int id)
            {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Estudiantes.Any(e => e.EstudianteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
            }

            public static Estudiantes Buscar(int id)
            {
                Contexto contexto = new Contexto();
                Estudiantes estudiante = new Estudiantes();

                try
                {
                    estudiante = contexto.Estudiantes.Find(id);
                }
                catch
                {
                    throw;
                }   
                finally
                {
                    contexto.Dispose();
                }
                return estudiante; 
            }
    }
}