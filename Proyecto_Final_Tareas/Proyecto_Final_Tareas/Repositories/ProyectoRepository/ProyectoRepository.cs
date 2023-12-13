using AGE.Middleware.Exceptions.NotFound;
using AGE.Utils;
using AGE.Utils.Paginacion;
using Proyecto_Final_Tareas.Entities;
using Proyecto_Final_Tareas.Entities.DAO.Proyecto;
using Proyecto_Final_Tareas.Repositories.ProyectoRepositories;

namespace Proyecto_Final_Tareas.Repositories.ProyectoRepository
{
    public class ProyectoRepository : IProyectoRepository
    {
        private readonly ProyectoTareasContext _dbContext;

        public ProyectoRepository(ProyectoTareasContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<ProyectoDAO> Actualizar(Proyecto proyecto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProyectoDAO>> ActualizarVarios(List<Proyecto> proyectos)
        {
            throw new NotImplementedException();
        }

        public Task<Proyecto> ConsultarCompletePorId(int codigo)
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

        public async Task<Page<ProyectoDAO>> ConsultarTodos(int codigo, string descripcion, Pageable pageable)
        {
            if (_dbContext.Proyectos == null)
            {
                throw new RegisterNotFoundException();
            }
            var Query = _dbContext.Proyectos
                .Where(p => p.Estado != Globales.ESTADO_ANULADO && (codigo == 0 || p.Id == codigo) &&
                            (descripcion.Equals("") || p.Descripcion.ToLower().Contains(descripcion.ToLower())));

            return await Paginator<Proyecto, ProyectoDAO>.Paginar(Query, pageable, FromEntityToDAO);
        }

        private ProyectoDAO FromEntityToDAO(Proyecto entityObject)
        {
            ProyectoDAO DAOobject = null;

            if (entityObject != null)
            {
                DAOobject = new ProyectoDAO
                {
                    Id = entityObject.Id,
                    Nombre = entityObject.Nombre,
                    Descripcion = entityObject.Descripcion,
                    Estado = entityObject.Estado,
                    FechaInicio = entityObject.FechaInicio,
                    FechaFin = entityObject.FechaFin,
                };
            }
            return DAOobject;

        }

        public Task<ProyectoDAO> Insertar(Proyecto proyecto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProyectoDAO>> InsertarVarios(List<Proyecto> proyectos)
        {
            throw new NotImplementedException();
        }
    }
}
