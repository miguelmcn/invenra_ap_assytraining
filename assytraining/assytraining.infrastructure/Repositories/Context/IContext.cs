namespace assytraining.infrastructure.Repositories.Context
{
    internal interface IContext<TDataModel>
    {
        public Task<IEnumerable<TDataModel>> GetAll();

        public Task<TDataModel> GetBy<TId>(TId id);

        public Task<TDataModel> Save(TDataModel dataModel);

        public Task Delete(TDataModel dataModel);
    }
}
