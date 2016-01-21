using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuilaChiles.Business.Catalogos;
using QuilaChiles.Business.General;
using QuilaChiles.Entities.Catalogos;
using QuilaChiles.Entities.DTO;
using QuilaChiles.Entities.General;

namespace SmartQuilaChiles.General
{
    public static class MetodosCatalogos
    {
        private static readonly BusinessNegociosEmpresa NNegocios = new BusinessNegociosEmpresa();
        private static readonly BusinessColonias NColonias = new BusinessColonias();
        private static readonly BusinessUnidadMedida NUnidades = new BusinessUnidadMedida();
        private static readonly BusinessPresentaciones NPresentaciones = new BusinessPresentaciones();
        private static readonly BusinessProductos NProductos = new BusinessPresentaciones();
        
        //TODO: Cambiar ID de Empresa
        public static List<NegociosEmpresa> CargaNegociosComboCatalogos(ComboBox cmbFiltro, ComboBox cmbRegistro)
        {
            List<NegociosEmpresa> result;
            try
            {
                result = NNegocios.ObtenerNegociosSucursales(1);
                if (cmbFiltro != null)
                {
                    cmbFiltro.DataSource = NNegocios.ObtenerNegociosSucursales(1, true);
                    cmbFiltro.DisplayMember = "Nombre";
                    cmbFiltro.ValueMember = "IdNegocio";
                }
                if (cmbRegistro != null)
                {
                    cmbRegistro.DataSource = NNegocios.ObtenerNegociosSucursales(1, true);
                    cmbRegistro.DisplayMember = "Nombre";
                    cmbRegistro.ValueMember = "IdNegocio";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static List<NegociosEmpresa> CargaNegociosCategoriaComboCatalogos(ComboBox cmbFiltro, ComboBox cmbRegistro)
        {
            List<NegociosEmpresa> result;
            try
            {
                result = NNegocios.ObtenerNegociosCategoria(1);
                cmbFiltro.DataSource = NNegocios.ObtenerNegociosCategoria(1, true);
                cmbFiltro.DisplayMember = "Nombre";
                cmbFiltro.ValueMember = "IdNegocio";
                cmbRegistro.DataSource = NNegocios.ObtenerNegociosCategoria(1, true);
                cmbRegistro.DisplayMember = "Nombre";
                cmbRegistro.ValueMember = "IdNegocio";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static List<UnidadMedida> CargaUnidadesCombocatalogos(ComboBox cmbFiltro, ComboBox cmbRegistro)
        {
            List<UnidadMedida> result;
            try
            {
                result = NUnidades.ObtenerUnidades();
                if (cmbFiltro != null)
                {
                    cmbFiltro.DataSource = NUnidades.ObtenerUnidades(true);
                    cmbFiltro.DisplayMember = "Descripcion";
                    cmbFiltro.ValueMember = "IdUnidadMedida";
                }
                if (cmbRegistro != null)
                {
                    cmbRegistro.DataSource = NUnidades.ObtenerUnidades(true);
                    cmbRegistro.DisplayMember = "Descripcion";
                    cmbRegistro.ValueMember = "IdUnidadMedida";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static List<Presentaciones> CargaPresentacionesComboCatalogos(ComboBox cmbFiltro, ComboBox cmbRegistro)
        {
            List<Presentaciones> result;
            try
            {
                result = NPresentaciones.ObtenerPresentaciones();
                if (cmbFiltro != null)
                {
                    cmbFiltro.DataSource = NPresentaciones.ObtenerPresentaciones(true);
                    cmbFiltro.DisplayMember = "Descripcion";
                    cmbFiltro.ValueMember = "IdPresentacion";
                }
                if (cmbRegistro != null)
                {
                    cmbRegistro.DataSource = NPresentaciones.ObtenerPresentaciones(true);
                    cmbRegistro.DisplayMember = "Descripcion";
                    cmbRegistro.ValueMember = "IdPresentacion";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static List<DtoPresentaciones> CargaPresentacionesConcatenadoComboCatalogos(ComboBox cmbFiltro, ComboBox cmbRegistro)
        {
            List<DtoPresentaciones> result;
            try
            {
                result = NPresentaciones.ObtenerPresentaciones().Select(s => new DtoPresentaciones { IdPresentacion = s.IdPresentacion, Descripcion = s.Descripcion + " - " + Convert.ToInt32(s.Cantidad) + " " + s.UnidadMedida.Extracto, IdNegocio = s.IdNegocio }).ToList();
                if (cmbFiltro != null)
                {
                    cmbFiltro.DataSource = NPresentaciones.ObtenerPresentaciones(true).Select(s => new DtoPresentaciones { IdPresentacion = s.IdPresentacion, Descripcion = s.Descripcion + " - " + Convert.ToInt32(s.Cantidad) + " " + s.UnidadMedida.Extracto, IdNegocio = s.IdNegocio }).ToList();
                    cmbFiltro.DisplayMember =  "Descripcion";
                    cmbFiltro.ValueMember = "IdPresentacion";
                }
                if (cmbRegistro != null)
                {
                    cmbRegistro.DataSource = NPresentaciones.ObtenerPresentaciones(true).Select(s => new DtoPresentaciones { IdPresentacion = s.IdPresentacion, Descripcion = s.Descripcion + " - " + Convert.ToInt32(s.Cantidad) + " " + s.UnidadMedida.Extracto, IdNegocio = s.IdNegocio }).ToList();
                    cmbRegistro.DisplayMember = "Descripcion";
                    cmbRegistro.ValueMember = "IdPresentacion";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static void LlenaColonias(ComboBox cmbFill, TextBox txtValidar, ref string cpAnterior)
        {
            try
            {
                if (cpAnterior == txtValidar.Text.Trim()) return;
                cpAnterior = txtValidar.Text.Trim();
                cmbFill.DataSource = NColonias.BuscarColoniaCp(int.Parse(txtValidar.Text.Trim()), true);
                cmbFill.DisplayMember = "Descripcion";
                cmbFill.ValueMember = "IdColonia";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static List<DtoProductos> CargaProductosGrid()
        {
            List<DtoProductos> result;
            try
            {
                result = NProductos.ObtenerProductos().Select(s => new DtoProductos { IdProducto = s.IdProducto, DescripcionProducto = s.Descripcion, IdNegocio = s.Categoria.IdNegocio, DescripcionNegocio = s.Categoria.NegociosEmpresa.Nombre, IdCategoria = s.IdCategoria, DescripcionCategoria = s.Categoria.Descripcion, Precio = s.Precio, Disponible = s.Disponible}).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
