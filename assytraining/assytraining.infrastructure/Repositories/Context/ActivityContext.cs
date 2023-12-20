using assytraining.infrastructure.Repositories.DataModel;

namespace assytraining.infrastructure.Repositories.Context
{
    internal class ActivityContext : IContext<ActivityDataModel>
    {
        private static ActivityContext? instance;

        private ActivityContext() { }

        public static ActivityContext GetInstance()
        {
            return instance ??= new ActivityContext();
        }

        public Task Delete(ActivityDataModel dataModel)
        {
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<ActivityDataModel>> GetAll()
        {
            return await Task.Run(() =>
               {
                   return new List<ActivityDataModel>()
                   {
                    MockedData(Guid.NewGuid().ToString()),
                    MockedData(Guid.NewGuid().ToString())
                   };
               });
        }

        public Task<ActivityDataModel> GetBy<TId>(TId id)
        {
            return Task.FromResult(MockedData(id));
        }

        public Task<ActivityDataModel> Save(ActivityDataModel dataModel)
        {
            return Task.FromResult(MockedData(Guid.NewGuid().ToString()));
        }

        private static ActivityDataModel MockedData<TId>(TId id)
        {
            return new ActivityDataModel
            {
                ActivityID = id as string,
                IvenIRAStudentID = Guid.NewGuid().ToString(),
                Params = new Dictionary<string, string> {
                    {
                        "Veículo", "X1"
                    },
                    {
                        "Atividade", "Volante"
                    },
                    {
                        "Cíclos por Atividade", "5"
                    }
                }
            };
        }
    }
}
