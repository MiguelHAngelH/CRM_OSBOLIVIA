namespace CRM_OS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actividads",
                c => new
                    {
                        idActividad = c.Int(nullable: false, identity: true),
                        fechaRegistro = c.DateTime(nullable: false),
                        idCuenta = c.Int(nullable: false),
                        asunto = c.String(),
                        idObjetivo = c.Int(nullable: false),
                        idPrioridad = c.Int(nullable: false),
                        idTipoActividad = c.Int(nullable: false),
                        descripcion = c.String(),
                        idResponsable = c.Int(nullable: false),
                        fechaInicio = c.DateTime(nullable: false),
                        fechaFinal = c.DateTime(nullable: false),
                        horaInicio = c.Time(nullable: false, precision: 7),
                        horaFin = c.Time(nullable: false, precision: 7),
                        tiempoReal = c.Time(nullable: false, precision: 7),
                        alerta = c.String(),
                        estado = c.String(),
                        resultado = c.String(),
                        direccion = c.String(),
                        Colaborador_idColaborador = c.Int(),
                        TipoActividad_idTipo = c.Int(),
                    })
                .PrimaryKey(t => t.idActividad)
                .ForeignKey("dbo.Colaboradors", t => t.Colaborador_idColaborador)
                .ForeignKey("dbo.Cuentas", t => t.idCuenta, cascadeDelete: true)
                .ForeignKey("dbo.Objetivoes", t => t.idObjetivo, cascadeDelete: true)
                .ForeignKey("dbo.Prioridads", t => t.idPrioridad, cascadeDelete: true)
                .ForeignKey("dbo.TipoActividads", t => t.TipoActividad_idTipo)
                .Index(t => t.idCuenta)
                .Index(t => t.idObjetivo)
                .Index(t => t.idPrioridad)
                .Index(t => t.Colaborador_idColaborador)
                .Index(t => t.TipoActividad_idTipo);
            
            CreateTable(
                "dbo.Colaboradors",
                c => new
                    {
                        idColaborador = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellidos = c.String(),
                        telefono = c.String(),
                        idCargo = c.Int(nullable: false),
                        fechaNacimiento = c.DateTime(nullable: false),
                        correo = c.String(),
                        nroDocumento = c.String(),
                        area = c.String(),
                        estado = c.String(),
                        Usuario_idUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.idColaborador)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_idUsuario)
                .Index(t => t.Usuario_idUsuario);
            
            CreateTable(
                "dbo.Cuentas",
                c => new
                    {
                        idCuenta = c.Int(nullable: false, identity: true),
                        tipoCuenta = c.String(),
                        tipoDocumento = c.String(),
                        nroDocumento = c.String(),
                        nombre = c.String(),
                        telefono = c.String(),
                        sitioWeb = c.String(),
                        rubro = c.String(),
                        idCiudad = c.Int(nullable: false),
                        idColaboradorAsignado = c.Int(nullable: false),
                        estado = c.String(),
                        Colaborador_idColaborador = c.Int(),
                    })
                .PrimaryKey(t => t.idCuenta)
                .ForeignKey("dbo.Colaboradors", t => t.Colaborador_idColaborador)
                .Index(t => t.Colaborador_idColaborador);
            
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        idContacto = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellidos = c.String(),
                        fechaNacimiento = c.DateTime(nullable: false),
                        estadoCivil = c.String(),
                        idCargo = c.Int(nullable: false),
                        telefono = c.String(),
                        correo = c.String(),
                    })
                .PrimaryKey(t => t.idContacto)
                .ForeignKey("dbo.Cargoes", t => t.idCargo, cascadeDelete: true)
                .Index(t => t.idCargo);
            
            CreateTable(
                "dbo.Cargoes",
                c => new
                    {
                        idCargo = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.idCargo);
            
            CreateTable(
                "dbo.OportunidadNegocios",
                c => new
                    {
                        idOportunidad = c.Int(nullable: false, identity: true),
                        necesidadCuenta = c.String(),
                        presupuesto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TiempoTomaDecision = c.Time(nullable: false, precision: 7),
                        idEncargadoTomaDecision = c.Int(nullable: false),
                        idCuenta = c.Int(nullable: false),
                        idProducto = c.Int(nullable: false),
                        estado = c.String(),
                        Colaborador_idColaborador = c.Int(),
                    })
                .PrimaryKey(t => t.idOportunidad)
                .ForeignKey("dbo.Colaboradors", t => t.Colaborador_idColaborador)
                .ForeignKey("dbo.Cuentas", t => t.idCuenta, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.idProducto, cascadeDelete: true)
                .Index(t => t.idCuenta)
                .Index(t => t.idProducto)
                .Index(t => t.Colaborador_idColaborador);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        idProducto = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        descripcion = c.String(),
                        idTipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idProducto)
                .ForeignKey("dbo.TipoProductoes", t => t.idTipo, cascadeDelete: true)
                .Index(t => t.idTipo);
            
            CreateTable(
                "dbo.TipoProductoes",
                c => new
                    {
                        idTipo = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.idTipo);
            
            CreateTable(
                "dbo.Propuestas",
                c => new
                    {
                        idPropuesta = c.Int(nullable: false, identity: true),
                        idOpurtunidadNegocio = c.Int(nullable: false),
                        fecha = c.DateTime(nullable: false),
                        nroPropuesta = c.String(),
                        alcancePropuesta = c.String(),
                        incluyeCapacitacion = c.String(),
                        incluyeInstalacion = c.String(),
                        incluyeSoporte = c.String(),
                        conFactura = c.String(),
                        tiempoImplementacion = c.Time(nullable: false, precision: 7),
                        CostoImplementacion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FormaPago = c.String(),
                        Ganancia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        estado = c.String(),
                        OportunidadNegocio_idOportunidad = c.Int(),
                    })
                .PrimaryKey(t => t.idPropuesta)
                .ForeignKey("dbo.OportunidadNegocios", t => t.OportunidadNegocio_idOportunidad)
                .Index(t => t.OportunidadNegocio_idOportunidad);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        idUsuario = c.Int(nullable: false, identity: true),
                        login = c.String(),
                        contraseña = c.String(),
                        idPerfil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idUsuario)
                .ForeignKey("dbo.Perfils", t => t.idPerfil, cascadeDelete: true)
                .Index(t => t.idPerfil);
            
            CreateTable(
                "dbo.Perfils",
                c => new
                    {
                        idPerfil = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.idPerfil);
            
            CreateTable(
                "dbo.Aplicacions",
                c => new
                    {
                        idAplicacion = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        idModulo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idAplicacion)
                .ForeignKey("dbo.Moduloes", t => t.idModulo, cascadeDelete: true)
                .Index(t => t.idModulo);
            
            CreateTable(
                "dbo.Moduloes",
                c => new
                    {
                        idModulo = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.idModulo);
            
            CreateTable(
                "dbo.Objetivoes",
                c => new
                    {
                        idObjetivo = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.idObjetivo);
            
            CreateTable(
                "dbo.Prioridads",
                c => new
                    {
                        idPrioridad = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        color = c.String(),
                        imagen = c.String(),
                    })
                .PrimaryKey(t => t.idPrioridad);
            
            CreateTable(
                "dbo.TipoActividads",
                c => new
                    {
                        idTipo = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        color = c.String(),
                        imagen = c.String(),
                    })
                .PrimaryKey(t => t.idTipo);
            
            CreateTable(
                "dbo.Ciudads",
                c => new
                    {
                        idCiudad = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        idPais = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idCiudad)
                .ForeignKey("dbo.Pais", t => t.idPais, cascadeDelete: true)
                .Index(t => t.idPais);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        idPais = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.idPais);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Codigo = c.String(nullable: false, maxLength: 128),
                        nombre = c.Int(nullable: false),
                        logo = c.String(),
                        direccion = c.String(),
                        web = c.String(),
                        resumenEjectutivo = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.ColaboradorColaboradors",
                c => new
                    {
                        Colaborador_idColaborador = c.Int(nullable: false),
                        Colaborador_idColaborador1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Colaborador_idColaborador, t.Colaborador_idColaborador1 })
                .ForeignKey("dbo.Colaboradors", t => t.Colaborador_idColaborador)
                .ForeignKey("dbo.Colaboradors", t => t.Colaborador_idColaborador1)
                .Index(t => t.Colaborador_idColaborador)
                .Index(t => t.Colaborador_idColaborador1);
            
            CreateTable(
                "dbo.ContactoCuentas",
                c => new
                    {
                        Contacto_idContacto = c.Int(nullable: false),
                        Cuenta_idCuenta = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Contacto_idContacto, t.Cuenta_idCuenta })
                .ForeignKey("dbo.Contactoes", t => t.Contacto_idContacto, cascadeDelete: true)
                .ForeignKey("dbo.Cuentas", t => t.Cuenta_idCuenta, cascadeDelete: true)
                .Index(t => t.Contacto_idContacto)
                .Index(t => t.Cuenta_idCuenta);
            
            CreateTable(
                "dbo.AplicacionPerfils",
                c => new
                    {
                        Aplicacion_idAplicacion = c.Int(nullable: false),
                        Perfil_idPerfil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Aplicacion_idAplicacion, t.Perfil_idPerfil })
                .ForeignKey("dbo.Aplicacions", t => t.Aplicacion_idAplicacion, cascadeDelete: true)
                .ForeignKey("dbo.Perfils", t => t.Perfil_idPerfil, cascadeDelete: true)
                .Index(t => t.Aplicacion_idAplicacion)
                .Index(t => t.Perfil_idPerfil);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ciudads", "idPais", "dbo.Pais");
            DropForeignKey("dbo.Actividads", "TipoActividad_idTipo", "dbo.TipoActividads");
            DropForeignKey("dbo.Actividads", "idPrioridad", "dbo.Prioridads");
            DropForeignKey("dbo.Actividads", "idObjetivo", "dbo.Objetivoes");
            DropForeignKey("dbo.Usuarios", "idPerfil", "dbo.Perfils");
            DropForeignKey("dbo.AplicacionPerfils", "Perfil_idPerfil", "dbo.Perfils");
            DropForeignKey("dbo.AplicacionPerfils", "Aplicacion_idAplicacion", "dbo.Aplicacions");
            DropForeignKey("dbo.Aplicacions", "idModulo", "dbo.Moduloes");
            DropForeignKey("dbo.Colaboradors", "Usuario_idUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Propuestas", "OportunidadNegocio_idOportunidad", "dbo.OportunidadNegocios");
            DropForeignKey("dbo.Productoes", "idTipo", "dbo.TipoProductoes");
            DropForeignKey("dbo.OportunidadNegocios", "idProducto", "dbo.Productoes");
            DropForeignKey("dbo.OportunidadNegocios", "idCuenta", "dbo.Cuentas");
            DropForeignKey("dbo.OportunidadNegocios", "Colaborador_idColaborador", "dbo.Colaboradors");
            DropForeignKey("dbo.ContactoCuentas", "Cuenta_idCuenta", "dbo.Cuentas");
            DropForeignKey("dbo.ContactoCuentas", "Contacto_idContacto", "dbo.Contactoes");
            DropForeignKey("dbo.Contactoes", "idCargo", "dbo.Cargoes");
            DropForeignKey("dbo.Cuentas", "Colaborador_idColaborador", "dbo.Colaboradors");
            DropForeignKey("dbo.Actividads", "idCuenta", "dbo.Cuentas");
            DropForeignKey("dbo.ColaboradorColaboradors", "Colaborador_idColaborador1", "dbo.Colaboradors");
            DropForeignKey("dbo.ColaboradorColaboradors", "Colaborador_idColaborador", "dbo.Colaboradors");
            DropForeignKey("dbo.Actividads", "Colaborador_idColaborador", "dbo.Colaboradors");
            DropIndex("dbo.AplicacionPerfils", new[] { "Perfil_idPerfil" });
            DropIndex("dbo.AplicacionPerfils", new[] { "Aplicacion_idAplicacion" });
            DropIndex("dbo.ContactoCuentas", new[] { "Cuenta_idCuenta" });
            DropIndex("dbo.ContactoCuentas", new[] { "Contacto_idContacto" });
            DropIndex("dbo.ColaboradorColaboradors", new[] { "Colaborador_idColaborador1" });
            DropIndex("dbo.ColaboradorColaboradors", new[] { "Colaborador_idColaborador" });
            DropIndex("dbo.Ciudads", new[] { "idPais" });
            DropIndex("dbo.Aplicacions", new[] { "idModulo" });
            DropIndex("dbo.Usuarios", new[] { "idPerfil" });
            DropIndex("dbo.Propuestas", new[] { "OportunidadNegocio_idOportunidad" });
            DropIndex("dbo.Productoes", new[] { "idTipo" });
            DropIndex("dbo.OportunidadNegocios", new[] { "Colaborador_idColaborador" });
            DropIndex("dbo.OportunidadNegocios", new[] { "idProducto" });
            DropIndex("dbo.OportunidadNegocios", new[] { "idCuenta" });
            DropIndex("dbo.Contactoes", new[] { "idCargo" });
            DropIndex("dbo.Cuentas", new[] { "Colaborador_idColaborador" });
            DropIndex("dbo.Colaboradors", new[] { "Usuario_idUsuario" });
            DropIndex("dbo.Actividads", new[] { "TipoActividad_idTipo" });
            DropIndex("dbo.Actividads", new[] { "Colaborador_idColaborador" });
            DropIndex("dbo.Actividads", new[] { "idPrioridad" });
            DropIndex("dbo.Actividads", new[] { "idObjetivo" });
            DropIndex("dbo.Actividads", new[] { "idCuenta" });
            DropTable("dbo.AplicacionPerfils");
            DropTable("dbo.ContactoCuentas");
            DropTable("dbo.ColaboradorColaboradors");
            DropTable("dbo.Empresas");
            DropTable("dbo.Pais");
            DropTable("dbo.Ciudads");
            DropTable("dbo.TipoActividads");
            DropTable("dbo.Prioridads");
            DropTable("dbo.Objetivoes");
            DropTable("dbo.Moduloes");
            DropTable("dbo.Aplicacions");
            DropTable("dbo.Perfils");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Propuestas");
            DropTable("dbo.TipoProductoes");
            DropTable("dbo.Productoes");
            DropTable("dbo.OportunidadNegocios");
            DropTable("dbo.Cargoes");
            DropTable("dbo.Contactoes");
            DropTable("dbo.Cuentas");
            DropTable("dbo.Colaboradors");
            DropTable("dbo.Actividads");
        }
    }
}
