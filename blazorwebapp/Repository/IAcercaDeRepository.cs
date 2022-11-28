using blazorwebapp.Data;

namespace blazorwebapp.Repository
{
    public interface IAcercaDeRepository
    {
        public Task<IEnumerable<AcercaDeModel>> GetAcerdaDe();
        public Task<AcercaDeModel> GetAcercaDeDetalle(int id);
        public Task<bool> InsertarAcercaDe(AcercaDeModel acercaDe);
        public Task<bool> ActualizarAcercaDe(AcercaDeModel acercaDe);
        public Task<bool> EliminarAcercaDe(AcercaDeModel pacercaDe);
    }
}
