using Autofac;
using MyList.Containers;
using MyList.Interfaces;

namespace MyList.Configs
{
    public class DIConfig
    {
        public IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MyList<string>>().As<IMyList<string>>();
            builder.RegisterType<Starter>();

            var container = builder.Build();

            return container;
        }
    }
}
