using AGE.Utils.Paginacion;
using AGE.Utils.WebLink;
using Proyecto_Final_Tareas.Entities.DAO.Proyecto;
using Proyecto_Final_Tareas.Repositories.ProyectoRepositories;
using Proyecto_Final_Tareas.Repositories.ProyectoRepository;

namespace Proyecto_Final_Tareas.Services.ProyectoService
{
    public class ProyectoService : IProyectoService
    {
        private readonly IProyectoRepository _repository;

        public ProyectoService(IProyectoRepository Repository)
        {
           _repository = Repository;
        }

        public Task<ProyectoDAO> Actualizar(IHttpContextAccessor _httpContextAccessor, ProyectoSaveDAO agePaisesSaveDAO)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProyectoDAO>> ActualizarVarios(IHttpContextAccessor _httpContextAccessor, List<ProyectoSaveDAO> agePaisesSaveDAOList)
        {
            throw new NotImplementedException();
        }

        public Task<Page<ProyectoDAO>> ConsultarListaFiltro(string filtro, Pageable pageable)
        {
            throw new NotImplementedException();
        }

        public Task<ProyectoDAO> ConsultarPorId(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<Page<ProyectoDAO>> ConsultarTodos(
            int codigo,
            string descripcion,
            Pageable pageable)
        {
            pageable.Validar<ProyectoDAO>();

            return _repository.ConsultarTodos(codigo, descripcion, pageable);
        }

        public Task<Resource<ProyectoDAO>> Insertar(IHttpContextAccessor _httpContextAccessor, ProyectoSaveDAO agePaisesSaveDAO)
        {
            throw new NotImplementedException();
        }

        public Task<List<Resource<ProyectoDAO>>> InsertarVarios(IHttpContextAccessor _httpContextAccessor, List<ProyectoSaveDAO> agePaisesSaveDAOList)
        {
            throw new NotImplementedException();
        }
    }
}
