﻿using System;
using System.Data;
using System.Linq;

namespace Componentes
{
    /// <summary>
    /// Clase: Tipo de Mobiliario Urbano
    /// Autor                   : Luis Amos
    /// Fecha de Creación       : 01 - 02 - 2011
    /// Fecha de Modificación   : 21 - 02 - 2012
    /// </summary>
    public class cTipo_Mobiliario_Urbano : cSubFicha
    {        
        #region Metodos
        /// <summary>
        /// Lista todos los registros
        /// </summary>
        /// <returns>Un conjunto de datos</returns>
        public FICHA_ds listar()
        {
            try
            {
                tabla = server.ejecutar_vs("VS_LISTAR_TIPO_MOBILIARIO_URBANO", tabla, "CODIGO", true);
            }
            catch (Exception ex)
            {
                throw new sqlServerException("Error Listar, Tipo de Mobiliario Urbano. " , ex);
            }
            return tabla;
        }

        /// <summary>
        /// Guardar un Registro
        /// </summary>
        /// <returns>El número de filas Afectadas</returns>
        public int guardar()
        {
            try
            {
                i = server.ejecutar("GUARDAR_TIPO_MOBILIARIO_URBANO",
                    server.parametro("@CODIGO", SqlDbType.VarChar, 2, Codigo),
                    server.parametro("@DESCRIPCION", SqlDbType.VarChar, 50, Descripcion),
                    server.parametro("@USUARIO", SqlDbType.VarChar, 10, Usuario));
            }
            catch (Exception ex)
            {
                i = -1;
                throw new sqlServerException("Error Guardar, Tipo de Mobiliario Urbano. ", ex);
            }
            return i;
        }

        /// <summary>
        /// Modifica un Registro
        /// </summary>
        /// <returns>El número de filas Afectadas</returns>
        public int modificar()
        {
            try
            {
                i = server.ejecutar("MODIFICAR_TIPO_MOBILIARIO_URBANO",
                    server.parametro("@CODIGO", SqlDbType.VarChar, 2, Codigo),
                    server.parametro("@DESCRIPCION", SqlDbType.VarChar, 50, Descripcion),
                    server.parametro("@USUARIO", SqlDbType.VarChar, 10, Usuario));
            }
            catch (Exception ex)
            {
                i = -1;
                throw new sqlServerException("Error Modificar, Tipo de Mobiliario Urbano. ", ex);
            }
            return i;
        }

        /// <summary>
        /// Elimina un Registro
        /// </summary>
        /// <returns>El número de filas Afectadas</returns>
        public int eliminar()
        {
            try
            {
                i = server.ejecutar("ELIMINAR_TIPO_MOBILIARIO_URBANO",
                    server.parametro("@CODIGO", SqlDbType.VarChar, 2, Codigo),
                    server.parametro("@USUARIO", SqlDbType.VarChar, 10, Usuario));
            }
            catch (Exception ex)
            {
                i = -1;
                throw new sqlServerException("Error Eliminar, Tipo de Mobiliario Urbano. ", ex);
            }
            return i;
       }

        /// <summary>
        /// Lista todos los datos en formato de arreglo unidimencional 
        /// </summary>        
        /// <returns>Un arreglo de datos</returns>
        public string[] listar_arreglo()
        {
            string[] arreglo = null;
            try
            {
                if (tabla.VS_LISTAR_TIPO_MOBILIARIO_URBANO.Rows.Count == 0) listar();
                arreglo = tabla.VS_LISTAR_TIPO_MOBILIARIO_URBANO.Select(a => a.LISTA).ToArray();                
            }
            catch (Exception ex)
            {
                throw new sqlServerException("Error Listar Arreglo, Tipo de Mobiliario Urbano. ", ex);
            }
            return arreglo;
        }

        /// <summary>
        /// Busca un registro especificado
        /// </summary>
        /// <param name="elemento">El código del elemento a buscar</param>
        /// <returns>Si existe en la tabla</returns>
        public bool buscar(string elemento)
        {
            bool valor = false;
            try
            {
                if (tabla.VS_LISTAR_TIPO_MOBILIARIO_URBANO.Rows.Count == 0) listar();
                valor = (tabla.VS_LISTAR_TIPO_MOBILIARIO_URBANO.FindByCODIGO(elemento) != null) ? true : false;                
            }
            catch (Exception ex)
            {
                throw new sqlServerException("Error Buscar, Tipo de Mobiliario Urbano. ", ex);
            }
            return valor;
        }
        #endregion
    }
}
