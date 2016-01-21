using System.Configuration;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Security.Cryptography;
using QuilaChiles.Entities;
using QuilaChiles.Entities.Catalogos;
using QuilaChiles.Entities.General;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Data
{
    using System.Text;
    using System;
    public partial class DbContext : ObjectContext
    {
        public const string ConnectionString = "name=QuilaChilesConn";
        public const string ContainerName = "QuilaChilesConn";

        public DbContext()
            : base(ConnectionString, ContainerName)
        {
            _cargo = CreateObjectSet<Cargo>();
            _categoria = CreateObjectSet<Categoria>();
            _colonias = CreateObjectSet<Colonias>();
            _empleado = CreateObjectSet<Empleado>();
            _empleadocargo = CreateObjectSet<EmpleadoCargo>();
            _empresa = CreateObjectSet<Empresa>();
            _estados = CreateObjectSet<Estados>();
            _estatus = CreateObjectSet<Estatus>();
            _insumo = CreateObjectSet<Insumo>();
            _insumopresentacion = CreateObjectSet<InsumoPresentacion>();
            _insumoproducto = CreateObjectSet<InsumoProducto>();
            _mesas = CreateObjectSet<Mesas>();
            _municipios = CreateObjectSet<Municipios>();
            _negociosempresa = CreateObjectSet<NegociosEmpresa>();
            _nivelsucursal = CreateObjectSet<NivelSucursal>();
            _orden = CreateObjectSet<Orden>();
            _ordendetalle = CreateObjectSet<OrdenDetalle>();
            _presentaciones = CreateObjectSet<Presentaciones>();
            _producto = CreateObjectSet<Producto>();
            _sucursalnegocio = CreateObjectSet<SucursalNegocio>();
            _unidadMedida = CreateObjectSet<UnidadMedida>();
        }

        public DbContext(string connectionString)
            : base(ConnectionString, ContainerName)
        {
        }

        public DbContext(EntityConnection connection)
            : base(ConnectionString, ContainerName)
        {
        }

        public static string DecryptedConnectionString
        {
            get
            {
                byte[] ToD, Denc;

                if (string.IsNullOrEmpty(ConfigurationManager.ConnectionStrings["QuilaChilesConn"].ToString()))
                    throw new Exception("No se encuentra cadena de conexion");

                ToD = Convert.FromBase64String(ConfigurationManager.ConnectionStrings["QuilaChilesConn"].ToString());

                Denc = ProtectedData.Unprotect(ToD, null, DataProtectionScope.LocalMachine);
                string cadena = Encoding.ASCII.GetString(Denc).Replace("&quot;", "\"");
                //System.Xml.Linq.XDocument x1 = System.Xml.Linq.XDocument.Parse(x);
                return cadena;
            }
        }

        public ObjectSet<Cargo> Cargo
        {
            get { return _cargo; }

        }
        public ObjectSet<Categoria> Categoria
        {
            get { return _categoria; }

        }
        public ObjectSet<Colonias> Colonias
        {
            get { return _colonias; }

        }
        public ObjectSet<Empleado> Empleado
        {
            get { return _empleado; }

        }
        public ObjectSet<EmpleadoCargo> EmpleadoCargo
        {
            get { return _empleadocargo; }

        }
        public ObjectSet<Empresa> Empresa
        {
            get { return _empresa; }

        }
        public ObjectSet<Estados> Estados
        {
            get { return _estados; }

        }
        public ObjectSet<Estatus> Estatus
        {
            get { return _estatus; }

        }
        public ObjectSet<Insumo> Insumo
        {
            get { return _insumo; }

        }
        public ObjectSet<InsumoPresentacion> InsumoPresentacion
        {
            get { return _insumopresentacion; }

        }
        public ObjectSet<InsumoProducto> InsumoProducto
        {
            get { return _insumoproducto; }

        }
        public ObjectSet<Mesas> Mesas
        {
            get { return _mesas; }

        }
        public ObjectSet<Municipios> Municipios
        {
            get { return _municipios; }

        }
        public ObjectSet<NegociosEmpresa> NegociosEmpresa
        {
            get { return _negociosempresa; }

        }
        public ObjectSet<NivelSucursal> NivelSucursal
        {
            get { return _nivelsucursal; }

        }
        public ObjectSet<Orden> Orden
        {
            get { return _orden; }

        }
        public ObjectSet<OrdenDetalle> OrdenDetalle
        {
            get { return _ordendetalle; }

        }
        public ObjectSet<Presentaciones> Presentaciones
        {
            get { return _presentaciones; }

        }
        public ObjectSet<Producto> Producto
        {
            get { return _producto; }

        }
        public ObjectSet<SucursalNegocio> SucursalNegocio
        {
            get { return _sucursalnegocio; }

        }
        public ObjectSet<UnidadMedida> UnidadMedida
        {
            get { return _unidadMedida; }

        }

        private ObjectSet<Cargo> _cargo;
        private ObjectSet<Categoria> _categoria;
        private ObjectSet<Colonias> _colonias;
        private ObjectSet<Empleado> _empleado;
        private ObjectSet<EmpleadoCargo> _empleadocargo;
        private ObjectSet<Empresa> _empresa;
        private ObjectSet<Estados> _estados;
        private ObjectSet<Estatus> _estatus;
        private ObjectSet<Insumo> _insumo;
        private ObjectSet<InsumoPresentacion> _insumopresentacion;
        private ObjectSet<InsumoProducto> _insumoproducto;
        private ObjectSet<Mesas> _mesas;
        private ObjectSet<Municipios> _municipios;
        private ObjectSet<NegociosEmpresa> _negociosempresa;
        private ObjectSet<NivelSucursal> _nivelsucursal;
        private ObjectSet<Orden> _orden;
        private ObjectSet<OrdenDetalle> _ordendetalle;
        private ObjectSet<Presentaciones> _presentaciones;
        private ObjectSet<Producto> _producto;
        private ObjectSet<SucursalNegocio> _sucursalnegocio;
        private ObjectSet<UnidadMedida> _unidadMedida;
    }
}
