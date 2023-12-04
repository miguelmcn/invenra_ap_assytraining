namespace assytraining.infrastructure.Repositories.Context
{
    public interface IContext<TDataModel>
    {
        public IEnumerable<TDataModel> GetAll();

        public TDataModel GetBy<TId>(TId id);

        public TDataModel Save(TDataModel dataModel);

        public void Delete(TDataModel dataModel);
    }
}
