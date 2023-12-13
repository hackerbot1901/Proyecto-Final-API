namespace AGE.Utils
{
    public class Globales
    {
        internal const String ESTADO_ACTIVO = "A";
		internal const String ESTADO_INACTIVO = "I";
		internal const String ESTADO_ANULADO = "N";
	
		internal const String SI = "S";
		internal const String NO = "N";

        internal const String GENERO_MASCULINO = "M";
        internal const String GENERO_FEMENINO = "F";

        internal const String SOLTERO = "S";
        internal const String CASADO = "C";

        internal const int CANTIDAD_ELEMENTOS_PAGINA = 30;

        internal const int CODIGO_APLICACION_AGE = 1;
	
		internal const int NIVEL_1 = 1;
	
		internal const String USUARIO_TIPO_REGISTRO_GMAIL="G";
		internal const String USUARIO_TIPO_REGISTRO_FACEBOOK="F";
		internal const String USUARIO_TIPO_REGISTRO_NORMAL="R";
		internal const String USUARIO_TIPO_REGISTRO_A="A";
	
		internal const String NTF_FRECUENCIA_ENVIO_DIARIA= "D";
		internal const String NTF_FRECUENCIA_ENVIO_SEMANAL= "S";
		internal const String NTF_FRECUENCIA_ENVIO_MENSUAL= "A";
		internal const String NTF_FRECUENCIA_ENVIO_ANUAL= "A";
	
		internal const String NTF_PERIODO_ENVIO_INMEDIATO = "IN";
		internal const String NTF_PERIODO_ENVIO_FECHA_HORA = "FH";
		internal const String NTF_PERIODO_ENVIO_PERSONALIZADO = "PE";
	
		internal const String TIPO_PAQUETE_I = "I";
		internal const String TIPO_PAQUETE_V = "V";
	
		internal const String TIPO_EXCEPCION_F = "F";
		internal const String TIPO_EXCEPCION_N = "N";
	
		internal const String ACCION_MENSAJE_D = "D";
		internal const String ACCION_MENSAJE_C = "C";
	
		internal const String PRINCIPAL = "P";
		internal const String SECUNDARIO = "S";
	
		internal const String TIPO_DATO_VARCHAR = "V";
		internal const String TIPO_DATO_INT = "I";
		internal const String TIPO_DATO_N = "N";
		internal const String TIPO_DATO_DATE = "D";
	
		internal const String TIPO_I = "I";
		internal const String TIPO_E = "E";
	
		internal const String TIPO_TRANSACCION_D = "D";
		internal const String TIPO_TRANSACCION_C = "C";
		internal const String TIPO_TRANSACCION_O = "O";
	
		internal const String TIPO_FIRMA_A = "A";
		internal const String TIPO_FIRMA_T = "T";
	
		internal const String NTF_TIPO_DE_NOTIFICACION_MANUAL = "M";
		internal const String NTF_TIPO_DE_NOTIFICACION_AUTOMATICA = "A";
	
		internal const String NTF_ASUNTO_RESET_CORREO = "Recuperación de contraseña";
		internal const String MENSAJE_RESET_EXITOSO= "Se ha enviado una contraseña temporal al correo";
		internal const String MENSAJE_OMNI= "En Omni Hospital continuamos, ¡Honrando la Vida!";
		
		//Secuencia primaria
		internal const int CODIGO_SECUENCIA_LICENCIATARIO = 1;
		internal const int CODIGO_SECUENCIA_APLICACION = 2;
		internal const int CODIGO_SECUENCIA_TRANSACCION = 3;
		internal const int CODIGO_SECUENCIA_CLASE_CONTRIBUYENTE = 4;
		internal const int CODIGO_SECUENCIA_DIA_FERIADO = 5;
		internal const int CODIGO_SECUENCIA_IDIOMA = 6;
		internal const int CODIGO_SECUENCIA_FRANQUICIA = 7;
		internal const int CODIGO_SECUENCIA_MENSAJE = 8;
		internal const int CODIGO_SECUENCIA_MONEDA = 9;
		internal const int CODIGO_SECUENCIA_LOCALIDAD = 10;
		internal const int CODIGO_SECUENCIA_PAIS = 11;
		internal const int CODIGO_SECUENCIA_PARAMETRO_VIGENCIA = 12;
		internal const int CODIGO_SECUENCIA_SISTEMA = 13;
		internal const int CODIGO_SECUENCIA_TIPO_IDENTIFICACION = 14;
		internal const int CODIGO_SECUENCIA_TIPO_DIRECCION = 15;
		internal const int CODIGO_SECUENCIA_TIPO_LOCALIDAD = 16;
		internal const int CODIGO_SECUENCIA_PARAMETRO_GENERAL = 17;
	
		//Secuencias por licenciatario
		internal const int CODIGO_SECUENCIA_PERFIL = 1;
		internal const int CODIGO_SECUENCIA_USUARIO = 2;
		internal const int CODIGO_SECUENCIA_DEPARTAMENTO = 3;
		internal const int CODIGO_SECUENCIA_DIRECCION = 4;
		internal const int CODIGO_SECUENCIA_FERIADO_EXCEPCION = 5;
		internal const int CODIGO_SECUENCIA_FAVORITO = 6;
		internal const int CODIGO_SECUENCIA_FIRMA_DIGITAL = 7;
		internal const int CODIGO_SECUENCIA_FORMA_PAGO = 8;
		internal const int CODIGO_SECUENCIA_FORMA_PAGO_INST_FINAN = 9;
		internal const int CODIGO_SECUENCIA_INSTITUCION_FINANCIERA = 10;
		internal const int CODIGO_SECUENCIA_LICEN_PARAM_VIGENCIA = 11;
		internal const int CODIGO_SECUENCIA_MONEDA_COTIZACION = 12;
		internal const int CODIGO_SECUENCIA_PERFIL_TRX = 13;
		internal const int CODIGO_SECUENCIA_PERSONA = 14;
		internal const int CODIGO_SECUENCIA_RUTA = 15;
		internal const int CODIGO_SECUENCIA_PUNTO_EMISION = 16;
		internal const int CODIGO_SECUENCIA_SUB_APLICACION = 17;
		internal const int CODIGO_SECUENCIA_SUCURSAL = 18;
		internal const int CODIGO_SECUENCIA_TIPO_SUCURSAL = 19;
		internal const int CODIGO_SECUENCIA_USUARIO_PARAM_VIGENCIA = 20;
		internal const int CODIGO_SECUENCIA_USUARIO_PERFIL = 21;
		internal const int CODIGO_SECUENCIA_ARCHIVOS_MULTIMEDIA = 22;
		internal const int CODIGO_SECUENCIA_NOTIFICACIONES_PUSH = 23;
		internal const int CODIGO_SECUENCIA_UNIDAD_TIEMPO = 24;
		internal const int CODIGO_SECUENCIA_TIPO_PERSONA = 25;
		internal const int CODIGO_SECUENCIA_LOG_ERROR = 26;
		internal const int CODIGO_SECUENCIA_LOG_USUARIO = 27;
		internal const int CODIGO_SECUENCIA_MODALIDAD = 28;
    }
}
