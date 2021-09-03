using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;

namespace SmartPower.Client.Blazor.Test
{
    public abstract class FixtureBase
    {
        private readonly IFixture _fixture;
        
        public IMapper Mapper;

        protected FixtureBase()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization());

            _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                .ForEach(b => _fixture.Behaviors.Remove(b));

            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            Mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile<SmartPower.Client.Blazor.AutoMapper>()));
        }

        protected T Create<T>()
        {
            return _fixture.Create<T>();
        }

        protected List<T> CreateMany<T>(int? count)
        {
            return count == null ? _fixture.CreateMany<T>().ToList() : _fixture.CreateMany<T>(count.Value).ToList();
        }
    }
}
