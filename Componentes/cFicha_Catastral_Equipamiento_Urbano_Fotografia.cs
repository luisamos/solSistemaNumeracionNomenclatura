﻿using System;
using System.Data;

namespace Componentes
{
    /// <summary>
    /// Clase: Ficha Catastral Equipamiento Urbano - Fotografía
    /// Autor                   : Luis Amos
    /// Fecha de Creación       : 01 - 02 - 2011
    /// Fecha de Modificación   : 21 - 02 - 2012
    /// </summary>
    public class cFicha_Catastral_Equipamiento_Urbano_Fotografia : cFicha
    {
        #region Atributos y Propiedades
        cFicha_Catastral_Equipamiento_Urbano ficha_Catastral_Equipamiento_Urbano;

        /// <summary>
        /// Clase: Ficha Catastral de Equipamiento Urbano
        /// </summary>
        public cFicha_Catastral_Equipamiento_Urbano Ficha_Catastral_Equipamiento_Urbano
        {
            get { return ficha_Catastral_Equipamiento_Urbano; }
            set { ficha_Catastral_Equipamiento_Urbano = value; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Ficha Catastral Equipamiento Urbano - Fotografía
        /// </summary>
        public cFicha_Catastral_Equipamiento_Urbano_Fotografia()
        {
            try
            {
                server.agregar_table_mapping("VS_LISTAR_FICHA_CATASTRAL_EQUIPAMIENTO_URBANO_FOTOGRAFIA",
                server.parametro("ID"),
                server.parametro("PLANO DE UBICACION"),
                server.parametro("AÑO PLANO DE UBICACION"),
                server.parametro("FOTOGRAFIA DIGITAL"),
                server.parametro("AÑO FOTOGRAFIA DIGITAL"),
                server.parametro("SECTOR"),
                server.parametro("MANZANA"),
                server.parametro("LOTE"),   
                server.parametro("EDIFICA"),
                server.parametro("ESTADO"),
                server.parametro("USUARIO CREA"),
                server.parametro("FECHA DE CREACION"),
                server.parametro("USUARIO MODIFICA"),
                server.parametro("FECHA DE MODIFICACION"),
                server.parametro("FICHA"));

                server.agregar_sp("GUARDAR_FICHA_CATASTRAL_EQUIPAMIENTO_URBANO_FOTOGRAFIA", 'G',
                server.parametro(),
                server.parametro("@PLANO_UBICACION",SqlDbType.VarBinary,"PLANO DE UBICACION",null),
                server.parametro("@AÑO_PLANO_UBICACION",SqlDbType.VarChar,4,"AÑO PLANO DE UBICACION",null),
                server.parametro("@FOTOGRAFIA_DIGITAL",SqlDbType.VarBinary,"FOTOGRAFIA DIGITAL",null),
                server.parametro("@AÑO_FOTOGRAFIA_DIGITAL",SqlDbType.VarChar,4,"AÑO FOTOGRAFIA DIGITAL",null),
                server.parametro("@SECTOR",SqlDbType.VarChar,2,"SECTOR",null), 
                server.parametro("@MANZANA",SqlDbType.VarChar,3,"MANZANA",null), 
                server.parametro("@LOTE",SqlDbType.VarChar,3,"LOTE",null),
                server.parametro("@EDIFICA", SqlDbType.VarChar, 2, "EDIFICA", null), 
                server.parametro("@FICHA", SqlDbType.VarChar, 10, "FICHA", null),
                server.parametro("@USUARIO", SqlDbType.VarChar, 10,"USUARIO CREA",null));

                server.agregar_sp("MODIFICAR_FICHA_CATASTRAL_EQUIPAMIENTO_URBANO_FOTOGRAFIA", 'M',
                server.parametro(),
                server.parametro("@ID", SqlDbType.BigInt, "ID", null),
                server.parametro("@PLANO_UBICACION", SqlDbType.VarBinary, "PLANO DE UBICACION", null),
                server.parametro("@AÑO_PLANO_UBICACION", SqlDbType.VarChar, 4, "AÑO PLANO DE UBICACION", null),
                server.parametro("@FOTOGRAFIA_DIGITAL", SqlDbType.VarBinary, "FOTOGRAFIA DIGITAL", null),
                server.parametro("@AÑO_FOTOGRAFIA_DIGITAL", SqlDbType.VarChar, 4, "AÑO FOTOGRAFIA DIGITAL", null),
                server.parametro("@SECTOR", SqlDbType.VarChar, 2, "SECTOR", null),
                server.parametro("@MANZANA", SqlDbType.VarChar, 3, "MANZANA", null),
                server.parametro("@LOTE", SqlDbType.VarChar, 3, "LOTE", null),
                server.parametro("@EDIFICA", SqlDbType.VarChar, 2, "EDIFICA", null), 
                server.parametro("@USUARIO", SqlDbType.VarChar, 10,"USUARIO MODIFICA",null));

                server.agregar_sp("ELIMINAR_FICHA_CATASTRAL_EQUIPAMIENTO_URBANO_FOTOGRAFIA", 'E',
                server.parametro(),
                server.parametro("@ID", SqlDbType.BigInt, "ID", null),
                server.parametro("@USUARIO", SqlDbType.VarChar, 10, "USUARIO MODIFICA",null));
            }
            catch (Exception ex)
            {
                throw new sqlServerException("Error Iniciar el Objeto, Ficha Catastral de Equipamiento Urbano - Fotografía. ", ex);
            }
        }

        /// <summary>
        /// Actualiza todos los registros de una tabla especificada
        /// </summary>
        /// <param name="tabla">Tabla a Actualizar en la base de datos</param>
        /// <returns>Retorna el número de filas afectadas</returns>
        public int actualizar(FICHA_ds tabla)
        {
            try
            {
                i=server.actualizar(tabla, "VS_LISTAR_FICHA_CATASTRAL_EQUIPAMIENTO_URBANO_FOTOGRAFIA");
            }
            catch (Exception ex)
            {
                i = -2;
                throw new sqlServerException("Error Actualizar, Ficha Catastral de Equipamiento Urbano - Fotografía. ", ex); 
            }
            return i;
        }
        #endregion
    }
}