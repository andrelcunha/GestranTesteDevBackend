using Swashbuckle.AspNetCore.Annotations;

namespace Gestran.Forncecedor.API.Models
{
    public abstract class Entity
    {
        [SwaggerSchema(ReadOnly = true)]
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
