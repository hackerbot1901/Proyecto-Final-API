using AGE.Utils.Paginacion;
using Proyecto_Final_Tareas.Entities;
using Proyecto_Final_Tareas.Entities.DAO.Proyecto;

namespace Proyecto_Final_Tareas.Repositories.ProyectoRepositories
{
    public interface IProyectoRepository
    {
        Task<Page<ProyectoDAO>> ConsultarTodos(
            int codigo,
            string descripcion,
            Pageable pageable);

        Task<ProyectoDAO> ConsultarPorId(
            int codigo);

        Task<Proyecto> ConsultarCompletePorId(
            int codigo);

        Task<Page<ProyectoDAO>> ConsultarListaFiltro(
            string filtro,
            Pageable pageable);

        Task<ProyectoDAO> Insertar(
            Proyecto proyecto);

        Task<ProyectoDAO> Actualizar(
            Proyecto proyecto);

        Task<List<ProyectoDAO>> InsertarVarios(
            List<Proyecto> proyectos);

        Task<List<ProyectoDAO>> ActualizarVarios(
            List<Proyecto> proyectos);
    }

}

