using AGE.Utils.Paginacion;
using AGE.Utils.WebLink;
using Proyecto_Final_Tareas.Entities.DAO.Proyecto;

namespace Proyecto_Final_Tareas.Services.ProyectoService
{
    public interface IProyectoService
    {
        Task<Page<ProyectoDAO>> ConsultarTodos(
            int codigo,
            string descripcion,
            Pageable pageable);

        Task<Page<ProyectoDAO>> ConsultarListaFiltro(
            string filtro,
            Pageable pageable);

        Task<ProyectoDAO> ConsultarPorId(
            int codigo);

        Task<Resource<ProyectoDAO>> Insertar(
            IHttpContextAccessor _httpContextAccessor,
            ProyectoSaveDAO agePaisesSaveDAO);

        Task<ProyectoDAO> Actualizar(
            IHttpContextAccessor _httpContextAccessor,
            ProyectoSaveDAO agePaisesSaveDAO);

        Task<List<Resource<ProyectoDAO>>> InsertarVarios(
            IHttpContextAccessor _httpContextAccessor,
            List<ProyectoSaveDAO> agePaisesSaveDAOList);

        Task<List<ProyectoDAO>> ActualizarVarios(
            IHttpContextAccessor _httpContextAccessor,
            List<ProyectoSaveDAO> agePaisesSaveDAOList);
    }

}
